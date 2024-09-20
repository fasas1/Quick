using AutoMapper;
using QuickLogistics.Models;
using QuickLogistics.Models.Dto;

namespace QuickLogistics
{
    public class MappingConfig 
    {
        public static MapperConfiguration RegisterMaps()
        {
             var mappingConfig = new MapperConfiguration(config =>
             {
                 config.CreateMap<Vehicle, VehicleDto>().ReverseMap();
                 config.CreateMap<Vehicle, CreateVehicleDto>().ReverseMap();
                 config.CreateMap<Vehicle, UpdateVehicleDto>().ReverseMap();
                 

                 config.CreateMap<Driver, DriverDto>().ReverseMap();
                 config.CreateMap<Driver, CreateDriverDto>().ReverseMap();
                 config.CreateMap<Driver, UpdateDriverDto>().ReverseMap();

                 config.CreateMap<Shipment, ShipmentDto>().ReverseMap();
                // config.CreateMap<CreateShipmentDto, Shipment>().ReverseMap();
             });
            return mappingConfig;
        }
    }
}
