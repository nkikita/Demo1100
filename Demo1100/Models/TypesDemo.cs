using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1100.Models
{
    [Table("Тип_партнера")]
    public class TypesDemo
    {
        [Key]
        [Column("Id_типа")]
        public int Id_type { get; set; }


        [Column("Название_типа")]
        public string Name_type { get; set; }


        public ICollection<PartnersDemo> Partners { get; set; }
    }
}
