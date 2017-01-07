using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SharedProject.DTOs;
using SharedProject.Infrastructure;

namespace SharedProject
{
    public class Controller 
    {
        private static Dao dao;
        private static IMapper mapper;

        static Controller()
        {
            MapperConfiguration mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });

            mapper = mapperConfig.CreateMapper();

            dao = new Dao();
        }

        public  bool checkConnection()
        {
            return dao.checkConnection();
        }

        public List<FieldTypeDTO> GetFieldTypes()
        {
            var result = dao.GetFieldTypes();
            return mapper.Map<List<FieldType>, List<FieldTypeDTO>>(result);
        }

        public List<UnitTypeDTO> GetUnitTypes()
        {
            var result = dao.GetUnitTypes();
            return mapper.Map<List<UnitType>, List<UnitTypeDTO>>(result);
        }

        public List<FieldDTO> GetFields()
        {
            var result = dao.GetFields();
            return mapper.Map<List<Field>, List<FieldDTO>>(result);
        }

        public FieldDTO GetField(int id)
        {
            var result = dao.GetField(id);
            return mapper.Map<Field, FieldDTO>(result);
        }

        public UserDTO GetUser(int id)
        {
            var result = dao.GetUser(id);
            return mapper.Map<User, UserDTO>(result);
        }

        public BoardDTO GetBoard(int id)
        {
            var result = dao.GetBoard(id);
            return mapper.Map<Board, BoardDTO>(result);
        }

        public GameDTO GetGame(int id)
        {
            var result = dao.GetGame(id);
            return mapper.Map<Game, GameDTO>(result); 
        }

        public List<UnitDTO> GetUnits()
        {
            var result = dao.GetUnits();
            return mapper.Map<List<Unit>, List<UnitDTO>>(result);
        }
    }
}
