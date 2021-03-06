﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Models.Csharp
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        //Comparism and mapping.
        public override bool Equals(object obj) => (obj as User).Id == Id;
        public override int GetHashCode() => Id;

    }
}
