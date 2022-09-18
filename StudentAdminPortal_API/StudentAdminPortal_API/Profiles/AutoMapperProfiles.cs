using AutoMapper;
using StudentAdminPortal_API.DomainModels;
using DataModels=StudentAdminPortal_API.DataModels;

namespace StudentAdminPortal_API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>()
                .ReverseMap();

            CreateMap<DataModels.Gender, Gender>()
                .ReverseMap();

            CreateMap<DataModels.Address, Address>()
                .ReverseMap();
        }

    }
}
