using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using PowerATS.Domain.Entities.Base;
using PowerATS.Domain.Enums;

namespace PowerATS.Domain.Entities
{
    public class Vaga : BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid IdVaga { get; set; }

        [BsonElement("Titulo")]
        public string Titulo { get; set; } = null!;

        [BsonElement("Descricao")]
        public string Descricao { get; set; } = null!;

        [BsonElement("Valor")]
        public decimal Valor { get; set; }

        [BsonElement("TipoContratacao")]
        public EnumTipoContratacao? TipoContratacao { get; set; }

        [BsonElement("Status")]
        public bool? Status { get; set; }
    }
}