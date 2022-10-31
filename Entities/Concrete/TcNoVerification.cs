using Core.Entities;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class TcNoVerification :IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }

        public long TCKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int DogumYili { get; set; }
      
    }
}
