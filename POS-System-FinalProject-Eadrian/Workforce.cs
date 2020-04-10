using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using POS_System_FinalProject_Eadrian;

namespace POSSystemOOPFinals
{
    class Workforce
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("employeeName")]
        public string employeeName { get; set; }

        [BsonElement("loginUsername")]
        public string loginUsername { get; set; }

        [BsonElement("loginPassword")]
        public string loginPassword { get; set; }

        [BsonElement("employeeSalary")]
        [BsonSerializer(typeof(BsonStringNumericSerializer))]
        public string employeeSalary { get; set; }

        [BsonElement("employeeCategory")]
        public string employeeCategory { get; set; }

        [BsonElement("employeeDateHired")]
        public string dateHired { get; set; }
               
    }
}

