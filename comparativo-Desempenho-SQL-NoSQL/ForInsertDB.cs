using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comparativo_Desempenho_SQL_NoSQL
{
    public partial class ForInsertDB : Form
    {   
        gravaTxt gravaLog = new gravaTxt();

        public ForInsertDB()
        {
            InitializeComponent();
        }

        public void testeSqlServer()
        {
            // Instancia a class de conexao com o SQL Server
            ConectionDB conection = new ConectionDB();


            // Busca a string d conexão em um arquivo txt...
            string strConnection = gravaLog.lerTxt();

            DateTime HoraInicialvar = DateTime.MinValue;
            DateTime HoraFinalvar = DateTime.MinValue;

            string mensagemToTxt = string.Empty;


            // Limpa os campos da tela inicial
            lblInserindo1.Text = "";
            lblInserindo2.Text = "";
            lblInserindo3.Text = "";
            lblMarcaStatus.Text = "EXECUTANDO";
            lblMarcaHoraIni.Text = "";
            lblMarcaHoraFim.Text = "";
            txtTempoTotal.Text = "";
            txtTempoTotal.Refresh();
            lblMarcaHoraFim.Refresh();
            lblMarcaStatus.Refresh();


            // Declara e seta a var para a qtd de inserts
            Int64 qtdInsert = 0;
            Int64.TryParse(txtQtdInsert.Text, out qtdInsert);

            qtdInsert += 1;
            // Marca a hora inicial e seta a label de hora inicial
            HoraInicialvar = DateTime.Now;
            marcaHora(lblMarcaHoraIni, HoraInicialvar);
            

            // Estrutura de repetição responsável por realizar os INSERTS no SQL Server
            bool bool_controle = true;
            for (Int64 i = 0; i < qtdInsert; i++)
            {
                // Executa o INSERT
                conection.executaDB(i, bool_controle, strConnection);


                // Altera o valor das label na tela
                lblInserindo1.Text = lblInserindo2.Text;
                lblInserindo1.Refresh();

                lblInserindo2.Text = lblInserindo3.Text;
                lblInserindo2.Refresh();

                lblInserindo3.Text = "Insert registro = " + i; ;
                lblInserindo3.Refresh();
                bool_controle = !bool_controle;

                #region SwitchGravaLogTxt
                switch (i)
                {
                    case 10:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);
                        break;

                    case 100:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);
                        break;

                    case 1000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);
                        break;

                    case 5000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);
                        break;

                    case 10000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);
                        break;

                    case 50000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);
                        break;

                    case 100000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);
                        break;

                    case 500000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);

                        break;
                    case 1000000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);
                        break;

                    case 5000000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);
                        break;

                    case 7500000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);
                        break;

                    case 10000000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 0);
                        break;
                    default:
                        break;
                }
                #endregion


            }

            HoraFinalvar = DateTime.Now;
            marcaHora(lblMarcaHoraFim, HoraFinalvar);
            lblMarcaStatus.Text = "FIM";
            lblMarcaStatus.Refresh();

            TimeSpan value = HoraFinalvar.Subtract(HoraInicialvar);
            txtTempoTotal.Text = value.ToString();
            txtTempoTotal.Refresh();
        }

        public void testeNoSqlMongoDB()
        {
            ConnectionMongoDB connectionMongoDB = new ConnectionMongoDB();


            DateTime HoraInicialvar = DateTime.MinValue;
            DateTime HoraFinalvar = DateTime.MinValue;

            string mensagemToTxt = string.Empty;

            lblInserindoMongo1.Text = "";
            lblInserindoMongo2.Text = "";
            label8lblInserindoMongo3.Text = "";
            lblMarcaStatusMongo.Text = "EXECUTANDO";
            lblMarcaHoraIniMongo.Text = "";
            lblMarcaHoraFimMongo.Text = "";
            txtTempoTotalMongo.Text = "";
            txtTempoTotalMongo.Refresh();
            lblMarcaStatusMongo.Refresh();
            lblMarcaHoraFimMongo.Refresh();

            Int64 qtdInsert = 0;
            Int64.TryParse(txtQtdInsert.Text, out qtdInsert);

            qtdInsert += 1;
            HoraInicialvar = DateTime.Now;
            marcaHora(lblMarcaHoraIniMongo, HoraInicialvar);
            bool bool_controle = true;


            for (Int64 i = 0; i < qtdInsert; i++)
            {
                var registroToInsert = new MultipleInsertNoSqlMongoDB() {
                    numerador = i,
                    data_hora = DateTime.Now,
                    nome = "Teste p inserir multiplos registros com MongoDB",
                    numerador_decimal = Convert.ToDecimal(i.ToString() + ".12"),
                    coluna_booleana = bool_controle

                };

                connectionMongoDB.executaMongoDB(registroToInsert);


                lblInserindoMongo1.Text = lblInserindoMongo2.Text;
                lblInserindoMongo1.Refresh();

                lblInserindoMongo2.Text = label8lblInserindoMongo3.Text;
                lblInserindoMongo2.Refresh();

                label8lblInserindoMongo3.Text = "Insert registro = " + i; ;
                label8lblInserindoMongo3.Refresh();
                bool_controle = !bool_controle;

                #region SwitchGravaLogTxtMongo
                switch (i)
                {
                    case 10:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);
                        break;

                    case 100:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);
                        break;

                    case 1000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);
                        break;

                    case 5000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);
                        break;

                    case 10000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);
                        break;

                    case 50000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);
                        break;

                    case 100000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);
                        break;

                    case 500000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);

                        break;
                    case 1000000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);
                        break;

                    case 5000000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);
                        break;

                    case 7500000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);
                        break;

                    case 10000000:
                        mensagemToTxt = string.Empty;
                        mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + i + ";" + DateTime.Now.Subtract(HoraInicialvar));
                        gravaLog.gravaArquivo(mensagemToTxt, 1);
                        break;
                    default:
                        break;
                }
                #endregion
            }

            HoraFinalvar = DateTime.Now;
            marcaHora(lblMarcaHoraFimMongo, HoraFinalvar);
            lblMarcaStatusMongo.Text = "FIM";
            lblMarcaStatusMongo.Refresh();


            TimeSpan value = HoraFinalvar.Subtract(HoraInicialvar);
            txtTempoTotalMongo.Text = value.ToString();
            txtTempoTotalMongo.Refresh();
        }



        public void selectSQLServer()
        {
            // Instancia a class de conexao com o SQL Server
            ConectionDB conection = new ConectionDB();

            // Busca a string d conexão em um arquivo txt...
            string strConnection = gravaLog.lerTxt();

            DateTime HoraInicialvar = DateTime.MinValue;
            DateTime HoraFinalvar = DateTime.MinValue;


            // Limpa os campos da tela inicial
            lblRegistaHoraFimSelectSQl.Text = "";
            txtRegistraHoraLiqSelectSQL.Text = "";
            txtMarcaLinhasRetornoSQL.Text = "";
            lblRegistaHoraFimSelectSQl.Refresh();
            txtRegistraHoraLiqSelectSQL.Refresh();
            txtMarcaLinhasRetornoSQL.Refresh();

            // Declara e seta a var para a qtd de inserts
            Int64 qtdSelect = 0;
            Int64.TryParse(txtQtdSelect.Text, out qtdSelect);


            // Marca a hora inicial e seta a label de hora inicial
            HoraInicialvar = DateTime.Now;
            marcaHora(lblRegistaHoraIniSelectSQl, HoraInicialvar);


            string qtdRetorno = "0";

            // Executa o INSERT
            qtdRetorno = conection.consultaDB(qtdSelect, strConnection, HoraInicialvar);
            

            HoraFinalvar = DateTime.Now;
            marcaHora(lblRegistaHoraFimSelectSQl, HoraFinalvar);

            TimeSpan value = HoraFinalvar.Subtract(HoraInicialvar);
            txtRegistraHoraLiqSelectSQL.Text = value.ToString();
            txtMarcaLinhasRetornoSQL.Text = qtdRetorno.ToString();
        }


        public void selectMongoDB()
        {
            // Instancia a class de conexao com o SQL Server
            ConnectionMongoDB connectionMongoDB = new ConnectionMongoDB();


            DateTime HoraInicialvar = DateTime.MinValue;
            DateTime HoraFinalvar = DateTime.MinValue;


            // Limpa os campos da tela inicial
            lblRegistaHoraFimSelectMongo.Text = "";
            txtRegistraTempoLiqSelectMong.Text = "";
            txtMarcaLinhasRetornoMongoDB.Text = "";
            lblRegistaHoraFimSelectMongo.Refresh();
            txtRegistraTempoLiqSelectMong.Refresh();
            txtMarcaLinhasRetornoMongoDB.Refresh();

            // Declara e seta a var para a qtd de inserts
            Int64 qtdSelect = 0;
            Int64.TryParse(txtQtdSelect.Text, out qtdSelect);


            // Marca a hora inicial e seta a label de hora inicial
            HoraInicialvar = DateTime.Now;
            marcaHora(lblRegistaHoraIniSelectMongo, HoraInicialvar);


            string qtdRetorno = "0";

            // Executa o INSERT
            qtdRetorno = connectionMongoDB.resultadoMongo(qtdSelect, HoraInicialvar);


            HoraFinalvar = DateTime.Now;
            marcaHora(lblRegistaHoraFimSelectMongo, HoraFinalvar);

            TimeSpan value = HoraFinalvar.Subtract(HoraInicialvar);
            txtRegistraTempoLiqSelectMong.Text = value.ToString();
            txtMarcaLinhasRetornoMongoDB.Text = qtdRetorno.ToString();
        }

        public void marcaHora(Label lblAlterar, DateTime hora)
        {
            lblAlterar.Text = string.Format("{0:dd/MM/yyyy/ HH:mm:ss}", hora);
            lblAlterar.Refresh();
        }


        private void btnInsereSQLServer_MouseClick(object sender, MouseEventArgs e)
        {
            testeSqlServer();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ForInsertDB_Load(object sender, EventArgs e)
        {

        }

        private void btnMongoDB_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtHoraInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {

        }

        private void btnMongoDB_Click(object sender, EventArgs e)
        {
            testeNoSqlMongoDB();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            testeSqlServer();
            testeNoSqlMongoDB();
        }

        private void btnInsereSQLServer_Click(object sender, EventArgs e)
        {
            testeSqlServer();
        }

        private void btnSelectSQL_Click(object sender, EventArgs e)
        {
            selectSQLServer();
        }

        private void btnSelectMongoDB_Click(object sender, EventArgs e)
        {
            selectMongoDB();
        }

        private void btnComparaSelect_Click(object sender, EventArgs e)
        {
            selectSQLServer();
            selectMongoDB();
        }

        private void btnRodaTudo_Click(object sender, EventArgs e)
        {
            btnComparar_Click(null, null);
            btnComparaSelect_Click(null, null);
        }
    }
}
