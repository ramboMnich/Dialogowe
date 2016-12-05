using System;
using System.Collections.Generic;
using System.Text;


namespace SharedProject
{
    public class Unit
    {
        public String Name { get; set; }
        public Int16 Stamina { get; set; }
        public Field Location { get; set; }
        //Do zmiany
        public Int16 Zasieg { get; set; }
        public Int16 Damage { get; set; }
        public UnitTypeEnum UnitType { get; set; }
        public List<BonusTypeEnum> BonusType { get; set; }
    }



}
