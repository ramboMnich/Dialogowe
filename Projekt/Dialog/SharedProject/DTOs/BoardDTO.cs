using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject.DTOs
{
    public class BoardDTO
    {
        public int IDBoard { get; set; }
        public int? IDGame { get; set; }
        public List<FieldDTO> Field { get; set; }
    }
}
