using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using MySql.Data.MySqlClient;

using iTextSharp.text.api;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace Telas
{
    public partial class frmRelatorio : Form
    {
        Cliente cl = new Cliente();
        ArrayList arr = new ArrayList();
        Classe_relatorio cr = new Classe_relatorio();
        Usuario us = new Usuario();

        static string data = null;
        public int ultimo = 0; //servirá para identificar qual foi o último para o PDF
        static string primeiradata = null, segundadata = null;
        static string pdf = null;

        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBuscapordata.Enabled == true)
            {
                //Data
                lblData.Visible = true;
                dateTimePicker1.Visible = true;
                btnBuscardata.Visible = true;

                Desabilitar_Cliente();
                Desabilitar_Funcionario();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBuscaporcliente.Enabled == true)
            {
                //Cliente
                lblCliente.Visible = true;
                btnBuscarcliente.Visible = true;
                cbxNomedocliente.Visible = true;

                Desabilitar_Data();
                Desabilitar_Funcionario();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBuscaporfuncionario.Enabled == true)
            {
                dateTimePicker1.Visible = false;

                //Funcionário
                lblFuncionario.Visible = true;
                cbxNomedofuncionario.Visible = true;
                btnBuscarfuncionario.Visible = true;

                Desabilitar_Data();
                Desabilitar_Cliente();
            }
        }

        public void Desabilitar_Data() //desabilitar tudo com relação à data
        {
            lblData.Visible = false;
            btnBuscardata.Visible = false;
            dateTimePicker1.Visible = false;
        }
        public void Desabilitar_Cliente() //desabilitar tudo com relação à cliente
        {
            lblCliente.Visible = false;
            cbxNomedocliente.Visible = false;
            btnBuscarcliente.Visible = false;
        }

        public void Desabilitar_Funcionario() //desabilitar tudo com relação à funcionário
        {
            lblFuncionario.Visible = false;
            btnBuscarfuncionario.Visible = false;
            cbxNomedofuncionario.Visible = false;
        }
        
        private void btnBuscarfuncionario_Click(object sender, EventArgs e)  //buscar por funcionário
        {
            Cursor = Cursors.WaitCursor;
            Limpargrid();
            Buscarfuncionario(cbxNomedofuncionario.Text);
            Cursor = Cursors.Default;
        }

        public void Buscarfuncionario(string func)
        {
            try
            {
                if (func == "")
                {
                    MessageBox.Show("É necessário preencher o campo \"Nome do Funcionário\"", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ultimo = 2;
                    arr = cr.Listar("funcionario", func);
                    PreencherGrid();                    //esse preencher só serve para as buscas simples
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Não foi possível realizar a busca!\nMotivo: " + s.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //esse aqui cria automaticamente não sei pra que, mas cria
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            int y = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[1, i].Value != null)
                {
                    y++;
                }
            }

            if (y > 0)
            {
                DialogResult dialogo = MessageBox.Show("Todos os dados serão perdidos.\nDeseja fechar assim mesmo?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogo == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        public void SalvarClick(/*object sender, EventArgs e*/)
        {                           //esse é só um teste
            try
            {
                // Obtem o nome do arquivo para salvar
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //abre o stream para escrever e cria um StreamWriter para usar na implementacao do stream
                    FileStream fs = new FileStream(@saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter m_streamWriter = new StreamWriter(fs);
                    m_streamWriter.Flush();

                    // Escreve o artigo usando a classe StreamWriter
                    m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);

                    // Escrever no controle rich edit control
                    //m_streamWriter.Write(this.richTextBox1.Text);  //AQUI TEM QUE COLOCAR O CONTEÚDO DO DATAGRIDVIEW

                    // fecha o arquivo
                    m_streamWriter.Flush();
                    m_streamWriter.Close();
                }
            }
            catch (Exception em)
            {
                MessageBox.Show(" Erro : " + em.Message.ToString());
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e) //menu IMPRIMIR
        {


            ////Cria um arquivo PDF
            //Report relatorioPdf = new Report(new PdfFormatter());

            //// Define a fonte que sera usada no relatório PDF
            //FontDef tipoFont = new FontDef(relatorioPdf, FontDef.StandardFont.TimesRoman);
            //FontProp tamanhoFont = new FontProp(tipoFont, 10);

            //// Cria uma Nova Pagina
            //Root.Reports.Page PDFpagina = new Root.Reports.Page(relatorioPdf);
            ////Page PDFpagina = new Page(relatorioPdf);
            ////Adiciona algumas linhas de texto
            //// Escreve no Arquivo
            //PDFpagina.AddCB_MM(60, new RepString(tamanhoFont, "Gerando PDF"));
            //PDFpagina.AddCB_MM(80, new RepString(tamanhoFont, "Asp Net + C#"));
            //PDFpagina.AddCB_MM(100, new RepString(tamanhoFont, "POR LEONE COSTA ROCHA™ © 2010 LCR® "));
            //try
            //{
            //    //visualiza o PDF
            //    RT.ViewPDF(relatorioPdf, "relatorio.pdf");
            //    //Salvando o documento na pasta bin do projeto
            //    relatorioPdf.Save("relatorio.pdf");
            //    //LblError.Text = "GEROU RELATORIO EM PDF";
            //}
            //catch (Exception ex)
            //{
            //    //LblError.Text = "ERRO CRITICO EXPORTAR RELATORIo :" + ex.Message.ToString();
            //    //MessageBox.Show("Erro ao Gerar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //Impressao.Print_DataGridView(dataGridView1);
            //this.printDocument1.Print();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            arr = cl.Clientess();
            for (int i = 0; i < arr.Count; i++) //lista os clientes cadastrados no comboBox
            {
                cbxNomedoclienteAV.Items.Add(((Cliente)arr[i]).Clientes);
                cbxNomedocliente.Items.Add(((Cliente)arr[i]).Clientes);
            }
            arr = us.Usuarios();
            for (int i = 0; i < arr.Count; i++) //lista os funcionários no comboBox
            {
                cbxNomedofuncionarioAV.Items.Add(((Usuario)arr[i]).Nomecompleto);
                cbxNomedofuncionario.Items.Add(((Usuario)arr[i]).Nomecompleto);
            }
        }

        private void btnBuscarcliente_Click(object sender, EventArgs e)  //buscar por cliente
        {
            Cursor = Cursors.WaitCursor;
            Limpargrid();
            Buscarcliente(cbxNomedocliente.Text);
            Cursor = Cursors.Default;
        }

        public void Buscarcliente(string clie)
        {
            try
            {
                if (clie == "")
                {
                    MessageBox.Show("É necessário preencher o campo \"Nome do Cliente\"", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ultimo = 1;
                    arr = cr.Listar("cliente", clie);
                    PreencherGrid();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Não foi possível realizar a busca!\nMotivo: " + s.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscardata_Click(object sender, EventArgs e)  //buscar por data
        {
            Cursor = Cursors.WaitCursor;
            Limpargrid();
            Buscardata(dateTimePicker1.Text);
            Cursor = Cursors.Default;
        }

        public void TirarBarrasUmaData(string luga)    //tira as barras da data
        {
            for (int i = 0; i < luga.Length; i++)
            {
                if (luga[i] != '/')
                {
                    data += luga[i];
                }
            }
        }

        public void Buscardata(string lugar) //busca somente por uma data
        {            
            try
            {
                TirarBarrasUmaData(lugar);
                ultimo = 3;
                arr = cr.listar_data(data);
                data = string.Empty;
                PreencherGrid();
            }
            catch (Exception s)
            {
                MessageBox.Show("Não foi possível realizar a busca!\nMotivo: " + s.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PreencherGrid() //esse preencher só serve para as buscas SIMPLES
        {
            for (int i = 0; i < arr.Count; i++)
            {
                dataGridView1.Rows.Add(); //adiciona linha no Grid
                dataGridView1[0, i].Value = (((Classe_relatorio)arr[i]).Clientes);
                dataGridView1[1, i].Value = (((Classe_relatorio)arr[i]).Funcionario);
                dataGridView1[2, i].Value = (((Classe_relatorio)arr[i]).Produtos);

                int numero = 0;                             //essa parte é para deixar o valor num aspecto bom
                string valor = (((Classe_relatorio)arr[i]).Valortotal);
                for (int e = 0; e < valor.Length; e++)
                {
                    if (valor[e] == ',')
                    {
                        numero++;
                    }
                }
                if (numero > 0) //se tiver normal (se tiver a vírgula)
                {
                    dataGridView1[3, i].Value = "R$ " + (((Classe_relatorio)arr[i]).Valortotal);
                }
                else
                {
                    dataGridView1[3, i].Value = "R$ " + (((Classe_relatorio)arr[i]).Valortotal) + ",00";
                }

                ColocarBarras((((Classe_relatorio)arr[i]).Data).ToString()); //passa a data sem as barras
                dataGridView1[4, i].Value = datadata.ToString();
                datadata = string.Empty;
                
                dataGridView1[5, i].Value = (((Classe_relatorio)arr[i]).Bairro);
            }
            arr = null;
        }

        static string datadata = null;
        public void ColocarBarras(string numeros) //coloca as barras
        {
            int r = 0;
            for (int y = 0; y < numeros.Length; y++)
            {
                if (r == 2 || r == 4)
                {
                    datadata += '/' + numeros[y].ToString();
                }
                else
                {
                    datadata += numeros[y].ToString();
                }
                r++;
            }
        }

        public void Limpargrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        public void TirarBarrasDatas()
        {
            for (int i = 0; i < dateTimePicker2.Text.Length; i++)  //tira as barras das datas
            {
                if (dateTimePicker2.Text[i] != '/')
                {
                    primeiradata += dateTimePicker2.Text[i];
                }
            }
            for (int i = 0; i < dateTimePicker3.Text.Length; i++)
            {
                if (dateTimePicker3.Text[i] != '/')
                {
                    segundadata += dateTimePicker3.Text[i];
                }
            }
        }

        public void BotaoBuscar()
        {
            Limpargrid();
            TirarBarrasDatas();
            arr = null;

            //"troca a cada de posição. Se for 08/12/2011 vai ficar 20111208"
            int data1_contrario = 0, data2_contrario = 0;
            string dia = string.Empty, mes = string.Empty, ano = string.Empty, dia2 = string.Empty, mes2 = string.Empty, ano2 = string.Empty;
            for (int t = 0; t < primeiradata.Length; t++)
            {
                if(dia.Length <= 1) { dia += primeiradata[t].ToString(); }
                else if(mes.Length <= 1) { mes += primeiradata[t].ToString(); }
                else if (ano.Length != primeiradata.Length) { ano += primeiradata[t].ToString(); }
            }
            ano = ano + mes + dia;
            data1_contrario = int.Parse(ano);
            for (int r = 0; r < segundadata.Length; r++)
            {
                if (dia2.Length <= 1) { dia2 += segundadata[r].ToString(); }
                else if (mes2.Length <= 1) { mes2 += segundadata[r].ToString(); }
                else if (ano2.Length != segundadata.Length) { ano2 += segundadata[r].ToString(); }
            }
            ano2 = ano2 + mes2 + dia2;  //faz a concatenação
            data2_contrario = int.Parse(ano2);
            //MessageBox.Show(data1_contrario.ToString() + " e " + data2_contrario.ToString());
            

            //se não tiver selecionado nada
            if (cbxNomedoclienteAV.Text == string.Empty && cbxNomedofuncionarioAV.Text == string.Empty && checkBox1.Checked == false)//tratamento de excessão
            {
                MessageBox.Show("Nenhuma opção foi selecionada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //se tiver selecionado somente o cliente
            else if (cbxNomedoclienteAV.Text != null && cbxNomedofuncionarioAV.Text == string.Empty && checkBox1.Checked == false)
            {
                //MessageBox.Show("Só cliente!", "Atenção!");
                Buscarcliente(cbxNomedoclienteAV.Text);
                ultimo = 4;
            }

            //se tiver selecionado somente o funcionário
            else if (cbxNomedofuncionarioAV.Text != null && cbxNomedoclienteAV.Text == string.Empty && checkBox1.Checked == false)
            {
                //MessageBox.Show("Só funcionário!", "Atenção!");
                Buscarfuncionario(cbxNomedofuncionarioAV.Text);
                ultimo = 5;
            }

            //se tiver selecionado somente uma data
            else if (checkBox1.Checked == true && checkBox2.Checked == false && cbxNomedoclienteAV.Text == string.Empty && cbxNomedofuncionarioAV.Text == string.Empty)
            {
                //MessageBox.Show("Só uma data!", "Atenção!");
                Buscardata(dateTimePicker2.Text);
                ultimo = 6;
            }

            //se tiver selecionado datas iguais
            else if (checkBox2.Checked == true && primeiradata == segundadata || data1_contrario > data2_contrario )
            {
                MessageBox.Show("As datas selecionadas de forma incorreta!\nEscolha datas diferentes de modo que a segunda data seja \"maior que a primeira\" ou selecione somente uma data para buscar somente por um dia.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //se tiver selecionado somente as datas
            else if (checkBox2.Checked == true && cbxNomedoclienteAV.Text == string.Empty && cbxNomedofuncionarioAV.Text == string.Empty)
            {
                //MessageBox.Show("As duas datas!", "Atenção!");
                arr = cr.Buscarpordatas(1, "", "", primeiradata, segundadata);
                PreencherGrid();
                ultimo = 7;
            }

            //somente cliente e a uma data
            else if (cbxNomedoclienteAV.Text != null && cbxNomedofuncionarioAV.Text == string.Empty && checkBox1.Checked == true && checkBox2.Checked == false)
            {
                //MessageBox.Show("Cliente e uma data!", "Atenção!");
                arr = cr.Buscarpordatas(2, cbxNomedoclienteAV.Text, "", primeiradata, "");
                PreencherGrid();
                ultimo = 8;
            }

            //selecionado cliente e as datas
            else if (checkBox2.Checked == true && cbxNomedoclienteAV.Text != string.Empty && cbxNomedofuncionarioAV.Text == string.Empty)
            {
                //MessageBox.Show("Cliente e as datas!", "Atenção!");
                arr = cr.Buscarpordatas(3, cbxNomedoclienteAV.Text, "", primeiradata, segundadata);
                PreencherGrid();
                ultimo = 9;
            }

            //funcionário e uma data
            else if (cbxNomedoclienteAV.Text == string.Empty && cbxNomedofuncionarioAV.Text != null && checkBox1.Checked == true && checkBox2.Checked == false)
            {
                //MessageBox.Show("Funcionário e uma data!", "Atenção!");
                arr = cr.Buscarpordatas(4, "", cbxNomedofuncionarioAV.Text, primeiradata, "");
                PreencherGrid();
                ultimo = 10;
            }

            //funcionário e as datas
            else if (cbxNomedoclienteAV.Text == string.Empty && cbxNomedofuncionarioAV.Text != null && checkBox2.Checked == true)
            {
                //MessageBox.Show("Funcionário e as datas!", "Atenção!");
                arr = cr.Buscarpordatas(5, "", cbxNomedofuncionarioAV.Text, primeiradata, segundadata);
                PreencherGrid();
                ultimo = 11;
            }

                //cliente e funcionário
            else if (cbxNomedoclienteAV.Text != string.Empty && cbxNomedofuncionarioAV.Text != string.Empty && checkBox1.Checked == false)
            {
                //MessageBox.Show("Cliente e funcionário");
                arr = cr.Buscarpordatas(6, cbxNomedoclienteAV.Text, cbxNomedofuncionarioAV.Text, "", "");
                PreencherGrid();
                ultimo = 12;
            }

            //cliente, funcionário e data
            else if (cbxNomedoclienteAV.Text != null && cbxNomedofuncionarioAV.Text != null && checkBox1.Checked == true && checkBox2.Checked == false)
            {
                //MessageBox.Show("Cliente, funcionário e uma data");
                arr = cr.Buscarpordatas(7, cbxNomedoclienteAV.Text, cbxNomedofuncionarioAV.Text, primeiradata, "");
                PreencherGrid();
                ultimo = 13;
            }

            else //se TUDO estiver preenchido corretamente
            {
                //MessageBox.Show("COMPLETO!", "Atenção!");
                arr = cr.Buscarpordatas(8, cbxNomedoclienteAV.Text, cbxNomedofuncionarioAV.Text, primeiradata, segundadata);
                PreencherGrid();
                ultimo = 14;
            }
            primeiradata = string.Empty;
            segundadata = string.Empty;
        }

        private void btnBusca_Click(object sender, EventArgs e) //botão de busca AVANÇADA
        {
            Cursor = Cursors.WaitCursor;
            BotaoBuscar();
            Cursor = Cursors.Default;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                dateTimePicker2.Enabled = true;
                checkBox2.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                dateTimePicker2.Enabled = false;
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
                dateTimePicker3.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                dateTimePicker3.Enabled = true;
            }
            else if (checkBox2.Checked == false)
            {
                dateTimePicker3.Enabled = false;
            }
        }
        
        private void tsmSalvarImprimir_Click(object sender, EventArgs e)
        {
            //pictureBox2.Visible = true;

            for (int t = 0; t <= 1000000; t++)
            {
                Opacity -= 0.00001;
            }

            //FormatTextExport export;
            //String currentDirectory = System.IO.Directory.GetCurrentDirectory();
            //saveFileDialog1.Filter = "*.html|";
            //export = new HTMLExport();
            //this.saveFileDialog1.ShowDialog();
            ////restore the current directory
            /////restaurar o diretório atual
            //System.IO.Directory.SetCurrentDirectory(currentDirectory);
            ////result file
            ////arquivo de resultado
            //this.txtFile.Text = this.saveFileDialog1.FileName;
            //ExportData(export);


        //    ////Cria um arquivo PDF
        //    Report relatorioPdf = new Report(new PdfFormatter());

        //    // Define a fonte que sera usada no relatório PDF
        //    FontDef tipoFont = new FontDef(relatorioPdf, FontDef.StandardFont.TimesRoman);
        //    FontProp tamanhoFont = new FontProp(tipoFont, 10);

        //    // Cria uma Nova Pagina
        //    Root.Reports.Page PDFpagina = new Root.Reports.Page(relatorioPdf);
        //    //Page PDFpagina = new Page(relatorioPdf);
        //    //Adiciona algumas linhas de texto
        //    // Escreve no Arquivo
        //    PDFpagina.AddCB_MM(60, new RepString(tamanhoFont, "Gerando PDF"));
        //    PDFpagina.AddCB_MM(80, new RepString(tamanhoFont, "Asp Net + C#"));
        //    PDFpagina.AddCB_MM(100, new RepString(tamanhoFont, "POR LEONE COSTA ROCHA™ © 2010 LCR® "));
        //    try
        //    {
        //        //visualiza o PDF
        //        RT.ViewPDF(relatorioPdf, "relatorio.pdf");
        //        //Salvando o documento na pasta bin do projeto
        //        relatorioPdf.Save("relatorio.pdf");
        //        //LblError.Text = "GEROU RELATORIO EM PDF";
        //    }
        //    catch (Exception ex)
        //    {
        //        //LblError.Text = "ERRO CRITICO EXPORTAR RELATORIo :" + ex.Message.ToString();
        //        //MessageBox.Show("Erro ao Gerar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    Impressao.Print_DataGridView(dataGridView1);
        //    this.printDocument1.Print();
        }

        //private void Exibe()
        //{
        //    webBrowser1.Url = null;
        //    string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        //    Uri url = new Uri("file://" + path + "\\" + sFilePDF);
        //    webBrowser1.Url = url;
        //}

        public void GerarPDF2(string nome_arquivo)
        {
            pdf = nome_arquivo; //pdf o é nome do caminho para o .pdf ser salvo

            Document document = new Document();

            try
            {
                PdfWriter whiter = PdfWriter.GetInstance(document, new FileStream(pdf, FileMode.Create));

                document.Open();

                PdfPTable aTable = new PdfPTable(6);
                aTable.WidthPercentage = 110;   //tamanho horizontal da tabela
                PdfPCell cell = new PdfPCell(new Phrase("Fast Food Delivery - Relatório - " +
                    DateTime.Now.Date.ToString("dd/MM/yyyy"),
                    new iTextSharp.text.Font(null, 16, iTextSharp.text.Font.BOLD)));
                cell.Colspan = 6; //células mecladas
                cell.HorizontalAlignment = 1;   //alinhamento
                cell.FixedHeight = 30f;     //tamanho vertical da célula
                cell.PaddingTop = 5;    //distância interna do topo
                aTable.AddCell(cell);  //adiciona a célula

                PdfPCell cell2 = new PdfPCell(new Phrase("Cliente"));
                cell2.HorizontalAlignment = 1;
                cell2.FixedHeight = 20f;
                aTable.AddCell(cell2);

                PdfPCell cell3 = new PdfPCell(new Phrase("Funcionário"));
                cell3.HorizontalAlignment = 1;
                cell3.FixedHeight = 20f;
                aTable.AddCell(cell3);

                PdfPCell cell4 = new PdfPCell(new Phrase("Produtos"));
                cell4.HorizontalAlignment = 1;
                cell4.FixedHeight = 20f;
                aTable.AddCell(cell4);

                PdfPCell cell5 = new PdfPCell(new Phrase("Valor Total"));
                cell5.HorizontalAlignment = 1;
                cell5.FixedHeight = 20f;
                aTable.AddCell(cell5);

                PdfPCell cell6 = new PdfPCell(new Phrase("Data"));
                cell6.HorizontalAlignment = 1;
                cell6.FixedHeight = 20f;
                aTable.AddCell(cell6);

                PdfPCell cell7 = new PdfPCell(new Phrase("Bairro"));
                cell7.HorizontalAlignment = 1;
                cell7.FixedHeight = 20f;
                aTable.AddCell(cell7);

                arr = null;
                TirarBarrasUmaData(dateTimePicker1.Text); //tira as barras e armazena na variável estática "data"
                TirarBarrasDatas(); //tira as barras e armazena nas variáveis estáticas "primeiradata" e "segundadata"

                if (ultimo == 1) { arr = cr.Listar("cliente", cbxNomedocliente.Text); }
                if (ultimo == 2) { arr = cr.Listar("funcionario", cbxNomedofuncionario.Text); }
                if (ultimo == 3) { arr = cr.listar_data(data); data = string.Empty; }
                if (ultimo == 4) { arr = cr.Listar("cliente", cbxNomedocliente.Text); }
                if (ultimo == 5) { arr = cr.Listar("funcionario", cbxNomedofuncionario.Text); }
                if (ultimo == 6) { arr = cr.listar_data(data); data = string.Empty; }
                if (ultimo == 7) { arr = cr.Buscarpordatas(1, "", "", primeiradata, segundadata); }
                if (ultimo == 8) { arr = cr.Buscarpordatas(2, cbxNomedoclienteAV.Text, "", primeiradata, ""); }
                if (ultimo == 9) { arr = cr.Buscarpordatas(3, cbxNomedoclienteAV.Text, "", primeiradata, segundadata); }
                if (ultimo == 10) { arr = cr.Buscarpordatas(4, "", cbxNomedofuncionarioAV.Text, primeiradata, ""); }
                if (ultimo == 11) { arr = cr.Buscarpordatas(5, "", cbxNomedofuncionarioAV.Text, primeiradata, segundadata); }
                if (ultimo == 12) { arr = cr.Buscarpordatas(6, cbxNomedoclienteAV.Text, cbxNomedofuncionarioAV.Text, "", ""); }
                if (ultimo == 13) { arr = cr.Buscarpordatas(7, cbxNomedoclienteAV.Text, cbxNomedofuncionarioAV.Text, primeiradata, ""); }
                if (ultimo == 14) { arr = cr.Buscarpordatas(8, cbxNomedoclienteAV.Text, cbxNomedofuncionarioAV.Text, primeiradata, segundadata); }
                primeiradata = string.Empty;
                segundadata = string.Empty;

                for (int i = 0; i < arr.Count; i++)
                {
                    Classe_relatorio cr = (Classe_relatorio)arr[i];
                    aTable.AddCell(cr.Clientes);
                    aTable.AddCell(cr.Funcionario);
                    aTable.AddCell(cr.Produtos);
                    aTable.AddCell("R$ " + cr.Valortotal);

                    ColocarBarras(cr.Data);
                    aTable.AddCell(datadata);
                    datadata = string.Empty;

                    aTable.AddCell(cr.Bairro);
                }

                document.Add(aTable);
            }
            catch (DocumentException s)
            {
                throw s;
            }
            catch (IOException o)
            {
                throw o;
            }
            document.Close();
        }

        public void GerarPDF()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF|*.pdf";
            sfd.FilterIndex = 1;
            sfd.Title = "Salvar relatório";
            //sfd.Filter = "Texto Comum|*.txt|Formato WordPad|*.rtf|Formato Word|*.doc|PDF|*.pdf|Todos os Arquivos|*.*"; 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                GerarPDF2(sfd.FileName);
            }
        }
        
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1) //se existir somente a linha padrão(linha em branco)
            {
                MessageBox.Show("Não existe dados na tabela para ser salvados!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    GerarPDF();
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Arquivo criado com sucesso!", "Concluído", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
                catch(Exception a)
                {
                    MessageBox.Show("Não foi possível criar o arquivo!\nMotivo: " + a.Message, "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buscaAvançadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cr.Vezdabusca() % 2 != 0) { tsmBusca2.Text = "Busca Simples"; gbxAvancado.Visible = true; gbxSimples.Visible = false; btnBusca.Visible = true; }
            else { tsmBusca2.Text = "Busca Avançada"; gbxSimples.Visible = true; gbxAvancado.Visible = false; btnBusca.Visible = false; }
        }

        Configuration configfile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public void EnviarEmail()
        {
            //fazer um for para verificar se o nome completo do usuário EXISTE
            AppSettingsSection appSetSec = configfile.AppSettings;

            if (appSetSec.Settings["email"].Value == string.Empty)
            {
                MessageBox.Show("Ainda não tem um email configurado para o sistema!", "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                string email_usuario = frmEnviarPDF.email;
                string email_sistema = appSetSec.Settings["email"].Value;
                string senha_email_sistema = appSetSec.Settings["senha"].Value;
                string body_email = frmEnviarPDF.messagem;
                string host_sistema = "smtp.gmail.com";

                MailMessage messagem = new MailMessage();
                messagem.To.Add(email_usuario);         //email do destinatário
                messagem.CC.Add(email_sistema);

                Attachment attachment = new Attachment(pdf); //pega o relatório
                messagem.Attachments.Add(attachment); //adiciona o .pdf como anexo

                messagem.Subject = "Fast Food Delivery - Relatório";
                messagem.From = new MailAddress(email_sistema);
                messagem.Body = body_email;

                SmtpClient smtp = new SmtpClient();

                smtp.Host = host_sistema;
                smtp.EnableSsl = true;

                smtp.Credentials = new NetworkCredential(email_sistema, senha_email_sistema);
                smtp.Send(messagem);
            }
        }

        private void enviarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Não existe dados na tabela para ser enviados!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    new frmEnviarPDF().ShowDialog();
                    if (frmEnviarPDF.enviar == true)  //caso tenha clicado no botão enviar continua dentro do IF
                    {
                        Cursor = Cursors.WaitCursor;
                        GerarPDF2("Relatorios\\Fast Food Delivery - Relatório" + DateTime.Now.Millisecond.ToString() + ".pdf"); //cria pdf
                        EnviarEmail();      //envia por email como anexo o pdf
                        pdf = null;
                        //File.Delete("Fast Food Delivery - Relatório.pdf"); //deleta o arquivo para evitar problemas futuros!
                        MessageBox.Show("Arquivo enviado com sucesso!", "Concluído", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível enviar o arquivo!\nMotivo: " + ex.Message, "Erro!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void ExportData(FormatTextExport export)
        //{
        //    if (string.IsNullOrEmpty(txtFile.Text))
        //    {
        //        return;
        //    }
        //    oleDbConnection1.ConnectionString = this.ConnStr;
        //    OleDbCommand oleDbCommand1 = new OleDbCommand(this.Command, oleDbConnection1);
        //    #region Excel export
        //    if (export is CellExport)
        //    {
        //        CellExport cellExport = (CellExport)export;
        //        WorkSheet workSheet1 = new WorkSheet();
        //        StripStyle stripStyle1 = new StripStyle();
        //        StripStyle stripStyle2 = new StripStyle();
        //        StripStyle stripStyle3 = new StripStyle();
        //        stripStyle1.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle1.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle1.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle1.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle1.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen;
        //        stripStyle1.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
        //        stripStyle2.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle2.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle2.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle2.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle2.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightTurquoise;
        //        stripStyle2.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;
        //        stripStyle3.Borders.Bottom.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle3.Borders.Left.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle3.Borders.Right.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle3.Borders.Top.Style = Spire.DataExport.XLS.CellBorderStyle.Medium;
        //        stripStyle3.FillStyle.Background = Spire.DataExport.XLS.CellColor.LightGreen;
        //        stripStyle3.FillStyle.Pattern = Spire.DataExport.XLS.Pattern.Solid;

        //        //Export Style
        //        cellExport.ActionAfterExport = ActionType.OpenView;
        //        cellExport.AutoFitColWidth = true;
        //        cellExport.DataFormats.CultureName = "en-US";
        //        cellExport.FileName = this.txtFile.Text.Trim();
        //        cellExport.SheetOptions.AggregateFormat.Font.Name = "Times New Roman";
        //        cellExport.SheetOptions.CustomDataFormat.Font.Name = "Times New Roman";
        //        cellExport.SheetOptions.DefaultFont.Name = "Times New Roman";
        //        cellExport.SheetOptions.TitlesFormat.Font.Name = "Times New Roman";
        //        workSheet1.AutoFitColWidth = true;
        //        workSheet1.Options.TitlesFormat.Font.Color = Spire.DataExport.XLS.CellColor.Pink;
        //        workSheet1.Options.TitlesFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Center;
        //        workSheet1.Options.TitlesFormat.Font.Italic = true;
        //        workSheet1.Options.TitlesFormat.Font.Bold = true;
        //        workSheet1.Options.TitlesFormat.Font.Size = 12F;


        //        //Data export            
        //        workSheet1.SheetName = "Demo";
        //        workSheet1.SQLCommand = oleDbCommand1;
        //        cellExport.Sheets.Add(workSheet1);
        //        workSheet1.ItemType = Spire.DataExport.XLS.CellItemType.Row;
        //        workSheet1.ItemStyles.Add(stripStyle1);
        //        workSheet1.ItemStyles.Add(stripStyle2);
        //        workSheet1.ItemStyles.Add(stripStyle3);
        //        oleDbConnection1.Open();
        //        try
        //        {
        //            cellExport.SaveToFile(this.txtFile.Text.Trim());
        //        }
        //        finally
        //        {
        //            oleDbConnection1.Close();
        //        }

        //    }
        //    #endregion
        //    #region Word export
        //    else if (export is RTFExport)
        //    {
        //        RTFExport rtfExport = (RTFExport)export;
        //        rtfExport.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
        //        rtfExport.DataFormats.CultureName = "en-US";
        //        rtfExport.DataFormats.Currency = "c";
        //        rtfExport.DataFormats.DateTime = "yyyy-M-d H:mm";
        //        rtfExport.DataFormats.Float = "g";
        //        rtfExport.DataFormats.Integer = "g";
        //        rtfExport.DataFormats.Time = "H:mm";
        //        rtfExport.FileName = this.txtFile.Text.Trim();
        //        rtfExport.RTFOptions.DataStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
        //        rtfExport.RTFOptions.FooterStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
        //        rtfExport.RTFOptions.HeaderStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
        //        rtfExport.RTFOptions.TitleStyle.Alignment = Spire.DataExport.RTF.RtfTextAlignment.Center;
        //        rtfExport.RTFOptions.TitleStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);


        //        rtfExport.SQLCommand = oleDbCommand1;

        //        oleDbConnection1.Open();
        //        try
        //        {
        //            rtfExport.SaveToFile();
        //        }
        //        finally
        //        {
        //            oleDbConnection1.Close();
        //        }
        //    }
        //    #endregion
        //    #region HTML export
        //    else if (export is HTMLExport)
        //    {
        //        HTMLExport htmlExport1 = (HTMLExport)export;

        //        htmlExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
        //        htmlExport1.DataFormats.CultureName = "en-US";
        //        htmlExport1.DataFormats.Currency = "c";
        //        htmlExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
        //        htmlExport1.DataFormats.Float = "g";
        //        htmlExport1.DataFormats.Integer = "g";
        //        htmlExport1.DataFormats.Time = "H:mm";
        //        htmlExport1.FileName = this.txtFile.Text.Trim();
        //        htmlExport1.HtmlTableOptions.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(122)), ((System.Byte)(236)));
        //        htmlExport1.HtmlTableOptions.FontColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
        //        htmlExport1.HtmlTableOptions.HeadersBackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
        //        htmlExport1.HtmlTableOptions.HeadersFontColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
        //        htmlExport1.HtmlTableOptions.OddBackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(107)), ((System.Byte)(206)));
        //        htmlExport1.HtmlTextOptions.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(51)), ((System.Byte)(51)), ((System.Byte)(153)));
        //        htmlExport1.HtmlTextOptions.Font = new System.Drawing.Font("Arial", 8F);
        //        htmlExport1.HtmlTextOptions.FontColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
        //        htmlExport1.HtmlTextOptions.LinkActiveColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(255)), ((System.Byte)(0)));
        //        htmlExport1.HtmlTextOptions.LinkColor = System.Drawing.Color.FromArgb(((System.Byte)(105)), ((System.Byte)(239)), ((System.Byte)(125)));
        //        htmlExport1.HtmlTextOptions.LinkVisitedColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(255)));


        //        htmlExport1.SQLCommand = oleDbCommand1;
        //        oleDbConnection1.Open();
        //        try
        //        {
        //            htmlExport1.HtmlStyle = Spire.DataExport.HTML.HtmlStyle.Plain;
        //            htmlExport1.SaveToFile();
        //        }
        //        finally
        //        {
        //            oleDbConnection1.Close();
        //        }

        //    }
        //    #endregion
        //    else
        //    {
        //        throw new Exception("RadioButton não existe.");
        //    }
        //}
    }
}
