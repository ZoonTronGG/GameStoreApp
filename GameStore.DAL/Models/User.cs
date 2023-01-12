﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DAL.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
