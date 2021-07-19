using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace comparativo_Desempenho_SQL_NoSQL
{
    class gravaTxt
    {
        #region caminhos_windows
        
        ////Colocando o caminho fisico e o nome do arquivo a ser criado
        const string CaminhoSQLServer = "C:\\Relatorio_DB\\SQLServer\\conectionConfig.txt";

        // LOGS DE INSERT
        const string CaminhoGravaDadosSQL = "C:\\Relatorio_DB\\SQLServer\\valoresSQLServer.txt";
        const string CaminhoGravaDadosMongoDB = "C:\\Relatorio_DB\\MongoDB\\valoresMongoDB.txt";

        // LOGS DE SELECT
        const string CaminhoGravaDadosSELECTSQL = "C:\\Relatorio_DB\\SQLServer\\valoresSQLServerSELECT.txt";
        const string CaminhoGravaDadosSELECtMongoDB = "C:\\Relatorio_DB\\MongoDB\\valoresMongoDBSELECT.txt";
        
        #endregion

        /*
        #region caminhos_linux

        ////Colocando o caminho fisico e o nome do arquivo a ser criado
        const string CaminhoSQLServer = "\\Usr:\\Relatorio_DB\\conectionConfig.txt";

        // LOGS DE INSERT
        const string CaminhoGravaDadosSQL = "\\Usr:\\Relatorio_DB\\SQLServer\\valoresSQLServer.txt";
        const string CaminhoGravaDadosMongoDB = "\\Usr:\\Relatorio_DB\\MongoDB\\valoresMongoDB.txt";

        // LOGS DE SELECT
        const string CaminhoGravaDadosSELECTSQL = "\\Usr:\\Relatorio_DB\\SQLServer\\valoresSQLServerSELECT.txt";
        const string CaminhoGravaDadosSELECtMongoDB = "\\Usr:\\Relatorio_DB\\MongoDB\\valoresMongoDBSELECT.txt";

        #endregion
        */

        public void gravaArquivo(string log, Int16 opcDB = 0)
        {
            //string CaminhoNome = opcDB == 0 ? CaminhoGravaDadosSQL : CaminhoGravaDadosMongoDB;
            string CaminhoNome = string.Empty;
            switch (opcDB)
            {
                case 0:
                    CaminhoNome = CaminhoGravaDadosSQL; break;

                case 1:
                    CaminhoNome = CaminhoGravaDadosMongoDB; break;

                case 2:
                    CaminhoNome = CaminhoGravaDadosSELECTSQL; break;

                case 3:
                    CaminhoNome = CaminhoGravaDadosSELECtMongoDB; break;

                default: break;
            }


            using (StreamWriter strWrite = new StreamWriter(CaminhoNome, true))
            {
                try
                {
                    strWrite.WriteLine(log);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao gravar arquivo: " + ex.Message);
                }

                finally
                {
                    strWrite.Close();
                    strWrite.Dispose();
                }
            }

        }


        public string lerTxt()
        {
            try
            {
                using (StreamReader sr = new StreamReader(CaminhoSQLServer))
                {

                    return sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                return "Erro ao ler arquivo" + ex.Message;
            }

        }
    }

}
