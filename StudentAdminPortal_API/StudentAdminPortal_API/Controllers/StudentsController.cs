using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal_API.DomainModels;
using StudentAdminPortal_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentsController (IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("StudentsInfo")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            //return Ok(_studentRepository.GetStudents());
            var students = await _studentRepository.GetStudentsAsync();
           
            //var domainModelStudents = new List<Student>();
            //foreach (var student in students)
            //{
            //    domainModelStudents.Add(new Student()
            //    {
            //        Id = student.Id,
            //        FirstName = student.FirstName,
            //        LastName = student.LastName,
            //        DateOfBirth = student.DateOfBirth,
            //        Email = student.Email,
            //        Mobile = student.Mobile,
            //        ProfileImageUrl = student.ProfileImageUrl,
            //        GenderId = student.GenderId,
            //        Address = new Address()
            //        {
            //            Id = student.Address.Id,
            //            PhysicalAddress= student.Address.PhysicalAddress,
            //            PostalAddress=student.Address.PostalAddress
            //        },
            //        Gender= new Gender()
            //        {
            //            Id = student.Gender.Id,
            //            Description= student.Gender.Description
            //        }
            //    }); 
                        
            //}

            return Ok(_mapper.Map<List<Student>>(students));


        }
    }
}
