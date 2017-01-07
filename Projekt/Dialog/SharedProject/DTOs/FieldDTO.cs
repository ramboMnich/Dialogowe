using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject.DTOs
{
    public class FieldDTO
    {
        public int IDField { get; set; }
        public FieldTypeDTO FieldType { get; set; }
        public UnitDTO Unit { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
