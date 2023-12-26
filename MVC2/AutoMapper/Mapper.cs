using AutoMapper;
using MVC2.Repository.Interface;
using MVC2.Repository.Repo;

namespace _M_V_C.AutoMapper
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<IStudent, StudentRepo>().ReverseMap();
        }
    }
}
