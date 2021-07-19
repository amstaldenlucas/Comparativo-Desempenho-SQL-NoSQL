using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace comparativo_Desempenho_SQL_NoSQL
{
    class ConnectionMongoDB
    {
        public string executaMongoDB(MultipleInsertNoSqlMongoDB registro)
        {

            try
            {
                var settings = new MongoClientSettings
                {
                    ServerSelectionTimeout = new TimeSpan(0, 0, 5),
                    Server = new MongoServerAddress("localhost", 27017),
                    //Credentials = new []
                    //{
                    //	MongoCredential.CreateCredential("loja","sa","Br@51l@dm")
                    //}
                };


                // Caminho do banco
                var client = new MongoClient(settings);

                // Nome da tabela
                var database = client.GetDatabase("comparativo_sql_nosql");

                // Colecao de banco (tabela)
                var colecao = database.GetCollection<MultipleInsertNoSqlMongoDB>("multiple_insert_sql");


                colecao.InsertOne(registro);
                return ("Inserido com sucesso");
            }
            catch (Exception e)
            {
                return ("erro" + e.Message);
            }
        }


        public string  resultadoMongo(Int64 qtdRegistro, DateTime HoraInicialvar)
        {
            string mensagemToTxt = string.Empty;
            gravaTxt gravaLog = new gravaTxt();

            try
            {
                var settings = new MongoClientSettings
                {
                    ServerSelectionTimeout = new TimeSpan(0, 0, 5),
                    Server = new MongoServerAddress("localhost", 27017),
                };

                // Caminho do banco
                var client = new MongoClient(settings);

                // Nome da tabela
                var database = client.GetDatabase("comparativo_sql_nosql");

                // Colecao de banco (tabela)
                var colecao = database.GetCollection<MultipleInsertNoSqlMongoDB>("multiple_insert_sql");


                //var filter = new FilterDefinitionBuilder<MultipleInsertNoSqlMongoDB>().Empty;
                var filter = new FilterDefinitionBuilder<MultipleInsertNoSqlMongoDB>().Lt("numerador", qtdRegistro);
                var result = colecao.Find<MultipleInsertNoSqlMongoDB>(filter).ToList();

                Int64 contadorLinhas = 0;

                foreach (MultipleInsertNoSqlMongoDB d in result)
                {
                    contadorLinhas++;

                    #region SwitchGravaLogTxt
                    switch (contadorLinhas)
                    {
                        case 10:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);
                            break;

                        case 100:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);
                            break;

                        case 1000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);
                            break;

                        case 5000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);
                            break;

                        case 10000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);
                            break;

                        case 50000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);
                            break;

                        case 100000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);
                            break;

                        case 500000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);

                            break;
                        case 1000000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);
                            break;

                        case 5000000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);
                            break;

                        case 7500000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);
                            break;

                        case 10000000:
                            mensagemToTxt = string.Empty;
                            mensagemToTxt = (string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) + ";" + contadorLinhas + ";" + DateTime.Now.Subtract(HoraInicialvar));
                            gravaLog.gravaArquivo(mensagemToTxt, 3);
                            break;
                        default:
                            break;
                    }
                    #endregion
                }

                return contadorLinhas.ToString();
            }
            catch (Exception e)
            {
                return ("erro" + e.Message);
            }
        }
    }
}
