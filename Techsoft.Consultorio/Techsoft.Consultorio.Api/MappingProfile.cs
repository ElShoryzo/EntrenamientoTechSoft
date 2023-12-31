﻿using AutoMapper;
using Techsoft.Consultorio.Dominio.Entidades;
using Techsoft.Consultorio.Aplicacion.DataTransferObjects;

namespace Techsoft.Consultorio.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Doctor, DoctorDto>();
            CreateMap<Paciente, PacienteDto>();
            CreateMap<Consulta, ConsultaDto>();
            CreateMap<DoctorCreationDto, Doctor>();
            CreateMap<PacienteCreationDto, Paciente>();
            CreateMap<ConsultaCreationDto, Consulta>();
        }
    }
}
