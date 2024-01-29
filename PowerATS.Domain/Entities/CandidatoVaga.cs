using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using PowerATS.Domain.Entities.Base;

namespace PowerATS.Domain.Entities
{
    public class CandidatoVaga : BaseEntity
    {
        public CandidatoVaga() { }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] public Guid IdCandidatoVaga { get; set; }
        public Guid IdCandidato { get; set; }

        [BsonElement("IdVaga")]
        public Guid IdVaga { get; set; }
    }
}