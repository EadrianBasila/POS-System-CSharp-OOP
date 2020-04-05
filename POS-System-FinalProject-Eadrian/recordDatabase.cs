using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POSSystemOOPFinals
{
    public class recordDatabase
    {
        private IMongoDatabase pDatabase;

        public recordDatabase(string database)
        {
            var client = new MongoClient();
            pDatabase = client.GetDatabase(database);
        }

        public void addRecords<P>(string table, P record)
        {
            var collection = pDatabase.GetCollection<P>(table);
            collection.InsertOne(record);
        }

        public List<L> checkRecords<L>(string table)
        {
            var collection = pDatabase.GetCollection<L>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        [Obsolete]
        public void UpsertRecords<U>(string table, ObjectId id, U record)
        {
            var collection = pDatabase.GetCollection<U>(table);
            var result = collection.ReplaceOne(new BsonDocument("_id", id), record, new UpdateOptions { IsUpsert = true });

        }

    }

}
