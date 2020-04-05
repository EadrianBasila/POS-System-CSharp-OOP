using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using POS_System_FinalProject_Eadrian;

namespace POSSystemOOPFinals
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("productName")]
        public string productName { get; set; }

        [BsonElement("productQuantity")]
        [BsonSerializer(typeof(BsonStringNumericSerializer))]
        public string productQuantity { get; set; }

        [BsonElement("productCost")]
        [BsonSerializer(typeof(BsonStringNumericSerializer))]
        public string productCost { get; set; }

        [BsonElement("productRetail")]
        [BsonSerializer(typeof(BsonStringNumericSerializer))]
        public string productRetail { get; set; }

        [BsonElement("productSupplier")]
        public string productSupplier { get; set; }

        [BsonElement("productCategory")]
        public string productCategory { get; set; }

        [BsonElement("productDate")]
        public string productDate { get; set; }


    }
}
