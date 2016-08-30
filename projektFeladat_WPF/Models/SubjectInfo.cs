using ConsoleAppDatabaseTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektFeladat_WPF.Models
{
    class SubjectInfo
    {
        
        
        public Subject SubjectName { get; private set; }
        public bool ActiveInThisSemester { get; private set; }
        public string Teacher { get; private set; }
        public int RegisteredStudents { get; private set; }
        public int Credit { get; private set; }
    }
}
