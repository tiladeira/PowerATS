using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using PowerATS.Domain.Entities.Base;

namespace PowerATS.Domain.Entities
{
    public class Curriculo : BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] public int idCurriculo { get; set; }
        public int idCandidato { get; set; }

        [BsonElement("CurriculoDocumento")]
        public string CurriculoDocumento { get; set; } = null!;
    }
}