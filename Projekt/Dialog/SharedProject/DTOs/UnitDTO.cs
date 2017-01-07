using System;
using System.Drawing;


namespace SharedProject.DTOs
{
    public class UnitDTO
    {
        static int licznik = 0;
        public int IDUnit = 0;
       
        public UnitTypeDTO UnitType { get; set; }
        
      

        private bool IsCaptured { get; set; }
        public int MovePoint { get; set; }
        public int MoveDiagPoint { get; set; }
        public int Stamina { get; set; }
        public int Damage { get; set; }
        public Image Image { get; set; }
    }
}
