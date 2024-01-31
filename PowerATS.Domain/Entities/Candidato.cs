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
        public int idCandidato { get; set; }

        [BsonElement("NomeCompleto")]
        public string NomeCompleto { get; set; } = null!;

        [BsonElement("Email")]
        public string Email { get; set; } = null!;

        [BsonElement("Idade")]
        public int Idade { get; set; }

        public virtual ICollection<CandidatoVaga> CandidatoVagas { get; set; } = new List<CandidatoVaga>();
        public virtual ICollection<Curriculo> Curriculos { get; set; } = new List<Curriculo>();
    }
}