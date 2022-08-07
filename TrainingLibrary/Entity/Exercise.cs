using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingLibrary.Entity
{
    [Table("Exercise")]
    public class Exercise
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string? Observation { get; set; }
    }
}
