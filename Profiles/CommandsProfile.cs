using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<Command, CommandUpdateDto>();
            //Target -> Source
            CreateMap<CommandCreateDto, Command>(); 
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}