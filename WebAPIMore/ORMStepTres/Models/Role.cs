using ORMDecouverte.Models;
using System.ComponentModel.DataAnnotations;

namespace ORMStepTres.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        public string Label { get; set; }

        public IEnumerable<Wookiee> Wookiees { get; set; } = new List<Wookiee>();
    }
}
