using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1100.Models
{
    [Table("Адреса_партнера")]
    public class AdressDemo
    {
        [Key]
        [Column("Id_адреса")]
        public int Id_adress { get; set; }

        [Column("Область")]
        public string State_adress { get; set; }    

        [Column("Город")]
        public string Town_adress { get; set; }

        [Column("Улица")]
        public string Street_adress { get; set; }

        [Column("Дом")]
        public int Home_adress { get; set; }

        [Column("Индекс")]
        public long Index_adress { get; set; }  

        public ICollection<PartnersDemo> Partners { get; set; }

    }
}
