using System.Collections.Generic;
using System.Linq;
using SharedProject.DTOs;
using AutoMapper;

namespace SharedProject.Infrastructure
{
   public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<FieldType, FieldTypeDTO>();
            this.CreateMap<UnitType, UnitTypeDTO>();
            this.CreateMap<User, UserDTO>();
            this.CreateMap<Field, FieldDTO>();
            this.CreateMap<Board, BoardDTO>();
            this.CreateMap<Game, GameDTO>().ForMember(s=>s.Board,
                                            opts => opts.MapFrom(src=>src.Board.SingleOrDefault()));
            this.CreateMap<Unit, UnitDTO>();


        }
    }
}
