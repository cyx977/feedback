﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedback.DAL.Model;
using Feedback.DAL.Repo;

namespace Feedback.Service.Service
{
    public interface IStudentInfoService
    {
        List<StudentInfo> GetAllStudentInfo();
    }
    public class StudentInfoService:IStudentInfoService
    {
        private IStudentInfoRepo _studentinforepo;

        public StudentInfoService(IStudentInfoRepo studentinforepo)
        {
            _studentinforepo = studentinforepo;
        }

        public List<StudentInfo> GetAllStudentInfo()
        {
            return _studentinforepo.GetAllStudentInfo();
        }

    }
}
