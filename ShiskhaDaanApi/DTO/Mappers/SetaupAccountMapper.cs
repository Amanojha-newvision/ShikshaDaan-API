using AutoMapper;
using Entity;

namespace DTO.Mappers
{
    internal class SetaupAccountMapper : Profile
    {
        public SetaupAccountMapper()
        {
            CreateMap<SetupAccount, SetupAccountDto>();
        }
    }
}
