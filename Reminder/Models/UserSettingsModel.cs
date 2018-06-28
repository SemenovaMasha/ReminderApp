﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder
{
    public class UserSettingsModel
    {
        [Key]
        public int Id { get; set; }
        public string mailUserName { get; set; }
        public string vkToken { get; set; }
        [Required]
        public bool mailMessageFlag { get; set; }
        [Required]
        public bool vkMessageFlag { get; set; }
    }
}