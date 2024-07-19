using AutoMapper;
using ManejoProesupuesto.Models;

namespace ManejoProesupuesto.Servicios
{
	public class AutoMapperProfiles : Profile
	{

        public AutoMapperProfiles()
        {
            CreateMap<Cuenta, CuentaCreacionViewModel>();
            CreateMap<TransaccionActualizacionViewModel, Transaccion>().ReverseMap();
        }
    }
}
