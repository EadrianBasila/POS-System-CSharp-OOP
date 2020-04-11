using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using POS_System_FinalProject_Eadrian;

namespace POS_System_FinalProject_Eadrian
{
    class Workshift
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("employeeUsername")]
        public string employeeUsername { get; set; }

        [BsonElement("shiftDate")]
        public string shiftDate { get; set; }

    }
}
