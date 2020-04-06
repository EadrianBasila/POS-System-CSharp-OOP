﻿using MongoDB.Bson;
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
        public int employeeSalary { get; set; }

        public Workforce(string employeeName, string loginUsername, string loginPassword, int employeeSalary)
        {
            this.employeeName = employeeName;
            this.loginUsername = loginUsername;
            this.loginPassword = loginPassword;
            this.employeeSalary = employeeSalary;
        }
    }
}
