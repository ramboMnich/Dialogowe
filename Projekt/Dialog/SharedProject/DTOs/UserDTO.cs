using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject.DTOs
{
    public class UserDTO
    {
        public short IDUser { get; set; }
        public string Login { get; set; }
        public string Hash { get; set; }
    }
}
