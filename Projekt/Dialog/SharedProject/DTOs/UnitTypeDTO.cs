using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject.DTOs
{
    public class UnitTypeDTO
    {
        public string Name { get; set; }
        public int Move { get; set; }
        public int Stamina { get; set; }
        public int Damage { get; set; }

        public UnitTypeDTO(int move, int stamina, int damage)
        {
            Move = move;         
            Stamina = stamina;
            Damage = damage;
        }
    }
}
