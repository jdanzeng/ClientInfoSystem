using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models.Request;
using AutoMapper;

namespace Infrastructure.Helpers
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<EmployeeRegisterRequestModel, Employee>();
        }
    }
}
