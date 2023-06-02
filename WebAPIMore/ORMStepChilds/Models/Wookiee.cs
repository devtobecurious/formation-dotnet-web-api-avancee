using ORMStepTres.Models;
using System.ComponentModel.DataAnnotations;

namespace ORMDecouverte.Models
{
    public class Wookiee
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public Weapon? Weapon { get; set; }

        public List<Role> Roles { get; set; } = new();
    }
}
