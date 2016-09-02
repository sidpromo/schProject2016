using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;

namespace WcfServiceLibrary
{
    public class Service : IService
    {

        /*
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        */
        public void AddAdministrator(Administrators entityToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddExam(Exams entityToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddExamsUser(ExamsUsers entityToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(Grades entityToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddManager(Managers entityToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddMessage(Messages entityToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddSemester(Semesters entityToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddStudent(Students entityToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddSubject(Subjects entityToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddSubjectsUser(SubjectsUsers entityToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddTeacher(Teachers entityToAdd)
        {
            throw new NotImplementedException();
        }

        public void AddUser(Users entityToAdd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Administrators> FindAdministrators(Expression<Func<Administrators, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exams> FindExams(Expression<Func<Exams, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExamsUsers> FindExamsUsers(Expression<Func<ExamsUsers, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Grades> FindGrades(Expression<Func<Grades, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Managers> FindManagers(Expression<Func<Managers, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Messages> FindMessages(Expression<Func<Messages, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Semesters> FindSemesters(Expression<Func<Semesters, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Students> FindStudents(Expression<Func<Students, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subjects> FindSubjects(Expression<Func<Subjects, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubjectsUsers> FindSubjectsUsers(Expression<Func<SubjectsUsers, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Teachers> FindTeachers(Expression<Func<Teachers, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> FindUsers(Expression<Func<Users, bool>> filterPredicate)
        {
            throw new NotImplementedException();
        }

        public Administrators GetAdministratorById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Administrators> GetAllAdministrators()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exams> GetAllExams()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExamsUsers> GetAllExamsUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Grades> GetAllGrades()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Managers> GetAllManagers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Messages> GetAllMessages()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Semesters> GetAllSemesters()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Students> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subjects> GetAllSubjects()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubjectsUsers> GetAllSubjectsUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Teachers> GetAllTeachers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Exams GetExamById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public ExamsUsers GetExamsUserById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public Grades GetGradeById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfAdministrator(Administrators entityToGetId)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfExam(Exams entityToGetId)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfExamsUser(ExamsUsers entityToGetId)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfGrade(Grades entityToGetId)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfManager(Managers entityToGetId)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfMessage(Messages entityToGetId)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfSemester(Semesters entityToGetId)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfStudent(Students entityToGetId)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfSubject(Subjects entityToGetId)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfSubjectsUser(SubjectsUsers entityToGetId)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfTeacher(Teachers entityToGetId)
        {
            throw new NotImplementedException();
        }

        public int GetIdOfUser(Users entityToGetId)
        {
            throw new NotImplementedException();
        }

        public Managers GetManagerById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public Messages GetMessageById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public Semesters GetSemesterById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public Students GetStudentById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public Subjects GetSubjectById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public SubjectsUsers GetSubjectsUserById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public Teachers GetTeacherById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetTeachersFromUsers()
        {
            throw new NotImplementedException();
        }

        public Users GetUserById(int entityToGetById)
        {
            throw new NotImplementedException();
        }

        public int GetUserId(Users user)
        {
            throw new NotImplementedException();
        }

        public bool Login(string eduId, string password)
        {
            throw new NotImplementedException();
        }

        public void RemoveAdministrator(Administrators entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveAdministratorById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }

        public void RemoveExam(Exams entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveExamById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }

        public void RemoveExamsUser(ExamsUsers entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveExamsUserById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }

        public void RemoveGrade(Grades entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveGradeById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }

        public void RemoveManager(Managers entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveManagerById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }

        public void RemoveMessage(Messages entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveMessageById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }

        public void RemoveSemester(Semesters entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveSemesterById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }

        public void RemoveStudent(Students entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveStudentById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubject(Subjects entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubjectById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubjectsUser(SubjectsUsers entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubjectsUserById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }

        public void RemoveTeacher(Teachers entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveTeacherById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(Users entityToRemove)
        {
            throw new NotImplementedException();
        }

        public void RemoveUserById(int entityToRemoveById)
        {
            throw new NotImplementedException();
        }
    }
}
