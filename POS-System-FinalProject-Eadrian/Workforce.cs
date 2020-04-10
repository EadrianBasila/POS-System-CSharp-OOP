using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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
        public string employeeSalary { get; set; }

        [BsonElement("employeeCategory")]
        public string employeeCategory { get; set; }

        [BsonElement("employeeDateHired")]
        public string dateHired { get; set; }

        public Workforce(string employeeName, string loginUsername, string loginPassword, string employeeSalary, string employeeCategory, string dateHired)
        {
            this.employeeName = employeeName;
            this.loginUsername = loginUsername;
            this.loginPassword = loginPassword;
            this.employeeSalary = employeeSalary;
            this.employeeCategory = employeeCategory;
            this.dateHired = dateHired;
        }
    }
}

