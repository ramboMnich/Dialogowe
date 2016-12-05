using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject.Models
{
    public class User : Entity
    {
        public String Name { get; set; }
        public TeamEnum TeamType { get; set; }
    }
}
