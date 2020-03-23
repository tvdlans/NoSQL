using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModComment
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonId]
        public ObjectId IcidentId { get; set; }
        public string Comment { get; set; }
    }
}
