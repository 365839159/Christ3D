using AutoMapper;
using AutoMapper.QueryableExtensions;
using Christ3D.Application.ServiceInterface;
using Christ3D.Application.ViewModels;
using Christ3D.Domain.Models;
using Christ3D.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Application.Service
{
    public class StudentService : IStudentService
    {
        //仓储接口
        private readonly IStudentRepository _studentRepository;
        //Dto映射
        private readonly IMapper _mapper;
        public StudentService(IStudentRepository studentrRepository, IMapper mapper)
        {
            this._studentRepository = studentrRepository;
            this._mapper = mapper;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<StudentViewModel> GetAll()
        {
            //第一种写法
            return _mapper.Map<IEnumerable<StudentViewModel>>(_studentRepository.GetAll());

            //第二种写法
            //return _studentRepository.GetAll().ProjectTo<StudentViewModel>(_mapper.ConfigurationProvider);

        }

        public StudentViewModel GetById(Guid id)
        {
            return _mapper.Map<StudentViewModel>(_studentRepository.GetById(id));
        }

        public void Register(StudentViewModel studentViewModel)
        {
            _studentRepository.Add(_mapper.Map<Student>(studentViewModel));
        }

        public void Remove(Guid id)
        {
            _studentRepository.Remove(id);
        }

        public void Update(StudentViewModel studentViewModel)
        {
            _studentRepository.Update(_mapper.Map<Student>(studentViewModel));
        }
    }
}
