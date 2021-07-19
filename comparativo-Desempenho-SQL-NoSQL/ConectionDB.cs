using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace comparativo_Desempenho_SQL_NoSQL
{
    class ConectionDB
    {
        public string executaDB(Int64 aux, bool trueFalse, string ParametersConection)
        {

            string connection = ParametersConection.Trim();
            string sqlCommand = "INSERT INTO multiple_insert_sql VALUES ("+ aux + ",'"+ string.Format("{0:dd/MM/yyyy  HH:mm:ss:fff}", DateTime.Now) + "', 'Teste p inserir multiplos registros com SQL Server'," + (aux.ToString() + ".12") + ",'" + trueFalse + "')";

            SqlConnection myConnection = new SqlConnection(connection);
            SqlCommand sql = new SqlCommand(sqlCommand, myConnection);

            try
            {
                sql.Connection.Open();
                sql.ExecuteNonQuery();
                return ("Inserido com sucesso");
            }
            catch (SqlException ex)
            {
                return ("Erro ao inserir: " + ex.ToString());
            }
            finally
            {
                sql.Connection.Close();
            }
        }

        public string consultaDB(Int64 aux, string ParametersConection, DateTime HoraInicialvar)
        {
            Int64 contadorLinhas = 0;

            string mensagemToTxt = string.Empty;
            gravaTxt gravaLog = new gravaTxt();

            string connection = ParametersConection.Trim();
            string sqlCommand = "SELECT * FROM multiple_insert_sql WHERE numerador < " + aux;

            SqlConnection myConnection = new SqlConnection(connection);
            SqlCommand sql = new SqlCommand(sqlCommand, myConnection);

            try
            {
                sql.Connection.Open();
                SqlDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    contadorLinhas++;
                    #region SwitchGravaLogTxt
                    switch (contadorLinhas)
                    {
                        case 10:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);
                            break;

                        case 100:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);
                            break;

                        case 1000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);
                            break;

                        case 5000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);
                            break;

                        case 10000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);
                            break;

                        case 50000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);
                            break;

                        case 100000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);
                            break;

                        case 500000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);

                            break;
                        case 1000000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);
                            break;

                        case 5000000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);
                            break;

                        case 7500000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);
                            break;

                        case 10000000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 2);
                            break;
                        default:
                            break;
                    }
                    #endregion
                }
                reader.Close();

                return Convert.ToString(contadorLinhas);
            }
            catch (Exception ex)
            {
                return Convert.ToString("Erro" + ex.Message);
            }
            finally
            {
                sql.Connection.Close();
            }
        }
    }
}
