using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1100.Models
{
    [Table("История_реализации")]
    public class StoryDemo
    {
        [Key]
        [Column("Id_истории")]
        public int Id_story { get; set; }
        [Column("Id_пртнера")]
        public int Id_part_story{ get; set;}

        [Column("Количество_товара")]
        public long Count_story_prod { get; set; }

        [Column("Дата_продажи")]
        public DateTime Date_story {  get; set; }

    }
}
