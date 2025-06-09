using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1100.Models
{
    [Table("Партнеры")]
    public class PartnersDemo
    {
        [Key]
        [Column("Id_партнера")]
        public int Id_partner { get; set; }

        [ForeignKey("typesDemo")]
        [Column("Тип_партнера")]
        public int Type_partner { get; set; }

        [Column("Наименование")]
        public string Name_partner { get; set; }

        [ForeignKey("adressDemo")]
        [Column("Адресс")]
        public int Adress_partner { get; set; }

        [Column("Инн")]
        public long Inn_partner { get; set; }
        [ForeignKey("direktorsDemo")]
        [Column("Директор")]
        public int Direktor_partner { get; set; }

        [Column("Телефон")]
        public string Phone_pertner { get; set; }

        [Column("Email")]
        public string Email_partner { get; set; }

        [Column("Рейтинг")]
        public int Rank_pertner { get; set; }

        public TypesDemo typesDemo { get; set; }
        public DirektorsDemo direktorsDemo { get; set; }
        public AdressDemo adressDemo { get; set; }
    }
}
