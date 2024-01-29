using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using PowerATS.Domain.Entities.Base;

namespace PowerATS.Domain.Entities
{
    public class Candidato : BaseEntity
    {
        public Candidato() { }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] 
        public Guid IdCandidato { get; set; }

        [BsonElement("NomeCompleto")]
        public string NomeCompleto { get; set; } = null!;

        [BsonElement("Email")]
        public string Email { get; set; } = null!;

        [BsonElement("Idade")]
        public int Idade { get; set; }
    }
}