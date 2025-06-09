using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1100.Models
{
    [Table("Дироектора_партнера")]
    public class DirektorsDemo
    {
        [Key]
        [Column("Id_директор")]
        public int Id_direkor { get; set; }

        [Column("Фамилия_директора")]
        public string Fam_direktor { get; set; }

        [Column("Имя_директора")]
        public string Name_direktor { get; set; }

        [Column("Отчество_директора")]
        public string Otch_direktor { get; set; }

        public string FullName => $"{Fam_direktor} {Name_direktor} {Otch_direktor}";
        public ICollection<PartnersDemo> Partners {get; set;}
    }
}
