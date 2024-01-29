using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using PowerATS.Domain.Entities.Base;

namespace PowerATS.Domain.Entities
{
    public class Curriculo : BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] public Guid IdCurriculo { get; set; }
        public Guid IdCandidato { get; set; }

        [BsonElement("CurriculoDocumento")]
        public string CurriculoDocumento { get; set; } = null!;
    }
}