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
    class purchaseRegistry
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("purchaseRegistry")]
        public string posPurchaseRegistry { get; set; }
    }
}
