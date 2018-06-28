using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder
{
    public class TaskModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        public string text { get; set; }

        [Required]
        public DateTime next_date { get; set; }

        [Required]
        public bool remind_flag { get; set; }

        public int? period_min { get; set; }

        public int? duration_min { get; set; }

        public double? price { get; set; }

        public TaskModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
