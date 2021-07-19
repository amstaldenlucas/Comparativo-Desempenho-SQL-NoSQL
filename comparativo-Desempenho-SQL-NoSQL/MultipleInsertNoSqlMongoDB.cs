using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace comparativo_Desempenho_SQL_NoSQL
{
    public class MultipleInsertNoSqlMongoDB
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public long numerador { get; set; }

        public DateTime data_hora { get; set; }

        public string nome { get; set; }

        public decimal numerador_decimal { get; set; }

        public bool coluna_booleana { get; set; }

    }
}
