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

        [BsonElement("purchaseDate")]
        public string posPurchaseDate { get; set; }

        [BsonElement("purchaseCost")]
        public string posCost { get; set; }

        [BsonElement("purchaseProfit")]
        public string purchaseProfit { get; set; }

    }
}
