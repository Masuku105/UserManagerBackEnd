﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataAccess.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
      
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Company { get; set; }

        public string? Notes { get; set; }
    }
}
