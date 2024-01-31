using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using PowerATS.Domain.Entities.Base;

namespace PowerATS.Domain.Entities
{
    public class CandidatoVaga : BaseEntity
    {
        public CandidatoVaga() { }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] public int idCandidatoVaga { get; set; }
        public int idCandidato { get; set; }

        [BsonElement("IdVaga")]
        public int idVaga { get; set; }
    }
}