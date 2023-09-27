using AutoMapper;

namespace DotNetCore_MVC.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<EmployeeModel, Employee>().ForMember(x => x.Email, d => d.MapFrom(y => string.Concat(y.FirstName, y.LastName)));
        }
    }
}
