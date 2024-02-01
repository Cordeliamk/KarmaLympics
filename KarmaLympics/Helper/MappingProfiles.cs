using AutoMapper;
using KarmaLympics.Dto;
using KarmaLympics.Models;

namespace KarmaLympics.Helper {

    public class MappingProfiles : Profile {

        public MappingProfiles() {

            CreateMap<Event, EventDto>();
            CreateMap<Team, TeamDto>();

        }
    }
}
