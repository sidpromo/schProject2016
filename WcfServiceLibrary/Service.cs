using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;
using Repository;

namespace WcfServiceLibrary
{
    public class Service : IService
    {

        private EducationDatabaseEntities getEntities()
        {
            EducationDatabaseEntities ent = new EducationDatabaseEntities();
            return ent;
        }

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
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public void AddExam(Exams entityToAdd)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public void AddExamsUser(ExamsUsers entityToAdd)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public void AddGrade(Grades entityToAdd)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public void AddManager(Managers entityToAdd)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public void AddMessage(Messages entityToAdd)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public void AddSemester(Semesters entityToAdd)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public void AddStudent(Students entityToAdd)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public void AddSubject(Subjects entityToAdd)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public void AddSubjectsUser(SubjectsUsers entityToAdd)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public void AddTeacher(Teachers entityToAdd)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public void AddUser(Users entityToAdd)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            repo.Add(entityToAdd);
        }

        public IEnumerable<Administrators> FindAdministrators(Expression<Func<Administrators, bool>> filterPredicate)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public IEnumerable<Exams> FindExams(Expression<Func<Exams, bool>> filterPredicate)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public IEnumerable<ExamsUsers> FindExamsUsers(Expression<Func<ExamsUsers, bool>> filterPredicate)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public IEnumerable<Grades> FindGrades(Expression<Func<Grades, bool>> filterPredicate)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public IEnumerable<Managers> FindManagers(Expression<Func<Managers, bool>> filterPredicate)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public IEnumerable<Messages> FindMessages(Expression<Func<Messages, bool>> filterPredicate)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public IEnumerable<Semesters> FindSemesters(Expression<Func<Semesters, bool>> filterPredicate)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public IEnumerable<Students> FindStudents(Expression<Func<Students, bool>> filterPredicate)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public IEnumerable<Subjects> FindSubjects(Expression<Func<Subjects, bool>> filterPredicate)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public IEnumerable<SubjectsUsers> FindSubjectsUsers(Expression<Func<SubjectsUsers, bool>> filterPredicate)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public IEnumerable<Teachers> FindTeachers(Expression<Func<Teachers, bool>> filterPredicate)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public IEnumerable<Users> FindUsers(Expression<Func<Users, bool>> filterPredicate)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            return repo.Find(filterPredicate);
        }

        public Administrators GetAdministratorById(int entityToGetById)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public IEnumerable<Administrators> GetAllAdministrators()
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            return repo.GetAll();
        }

        public IEnumerable<Exams> GetAllExams()
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            return repo.GetAll();
        }

        public IEnumerable<ExamsUsers> GetAllExamsUsers()
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            return repo.GetAll();
        }

        public IEnumerable<Grades> GetAllGrades()
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            return repo.GetAll();
        }

        public IEnumerable<Managers> GetAllManagers()
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            return repo.GetAll();
        }

        public IEnumerable<Messages> GetAllMessages()
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            return repo.GetAll();
        }

        public IEnumerable<Semesters> GetAllSemesters()
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            return repo.GetAll();
        }

        public IEnumerable<Students> GetAllStudents()
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            return repo.GetAll();
        }

        public IEnumerable<Subjects> GetAllSubjects()
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            return repo.GetAll();
        }

        public IEnumerable<SubjectsUsers> GetAllSubjectsUsers()
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            return repo.GetAll();
        }

        public IEnumerable<Teachers> GetAllTeachers()
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            return repo.GetAll();
        }

        public IEnumerable<Users> GetAllUsers()
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            return repo.GetAll();
        }

        public Exams GetExamById(int entityToGetById)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public ExamsUsers GetExamsUserById(int entityToGetById)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public Grades GetGradeById(int entityToGetById)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public int GetIdOfAdministrator(Administrators entityToGetId)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            return repo.GetAdminId(entityToGetId);
        }

        public int GetIdOfExam(Exams entityToGetId)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            return repo.GetExamId(entityToGetId);
        }

        public int GetIdOfExamsUser(ExamsUsers entityToGetId)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            return repo.GetExamUserId(entityToGetId);
        }

        public int GetIdOfGrade(Grades entityToGetId)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            return repo.GetGradeId(entityToGetId);
        }

        public int GetIdOfManager(Managers entityToGetId)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            return repo.GetManagerId(entityToGetId);
        }

        public int GetIdOfMessage(Messages entityToGetId)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            return repo.GetMessageId(entityToGetId);
        }

        public int GetIdOfSemester(Semesters entityToGetId)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            return repo.GetSemesterId(entityToGetId);
        }

        public int GetIdOfStudent(Students entityToGetId)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            return repo.GetStudentId(entityToGetId);
        }

        public int GetIdOfSubject(Subjects entityToGetId)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            return repo.GetSubjectId(entityToGetId);
        }

        public int GetIdOfSubjectsUser(SubjectsUsers entityToGetId)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            return repo.GetSubjectUserId(entityToGetId);
        }

        public int GetIdOfTeacher(Teachers entityToGetId)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            return repo.GetTeacherId(entityToGetId);
        }

        public int GetIdOfUser(Users entityToGetId)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            return repo.GetUserId(entityToGetId);
        }

        public Managers GetManagerById(int entityToGetById)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public Messages GetMessageById(int entityToGetById)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public Semesters GetSemesterById(int entityToGetById)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public Students GetStudentById(int entityToGetById)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public Subjects GetSubjectById(int entityToGetById)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public SubjectsUsers GetSubjectsUserById(int entityToGetById)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public string GetSubjectTeacherName(Subjects subject)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            return repo.GetSubjectTeacherName(subject);
        }

        public Teachers GetTeacherById(int entityToGetById)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public IEnumerable<Users> GetTeachersFromUsers()
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            return repo.GetTeachersFromUsers();
        }

        public Users GetUserById(int entityToGetById)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            return repo.GetById(entityToGetById);
        }

        public int GetUserId(Users user)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            return repo.GetUserId(user);
        }

        public bool Login(string eduId, string password)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            return repo.Login(eduId, password);
        }

        public void RemoveAdministrator(Administrators entityToRemove)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveAdministratorById(int entityToRemoveById)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveExam(Exams entityToRemove)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveExamById(int entityToRemoveById)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveExamsUser(ExamsUsers entityToRemove)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveExamsUserById(int entityToRemoveById)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveGrade(Grades entityToRemove)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveGradeById(int entityToRemoveById)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveManager(Managers entityToRemove)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveManagerById(int entityToRemoveById)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveMessage(Messages entityToRemove)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveMessageById(int entityToRemoveById)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveSemester(Semesters entityToRemove)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveSemesterById(int entityToRemoveById)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveStudent(Students entityToRemove)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveStudentById(int entityToRemoveById)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveSubject(Subjects entityToRemove)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveSubjectById(int entityToRemoveById)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveSubjectsUser(SubjectsUsers entityToRemove)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveSubjectsUserById(int entityToRemoveById)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveTeacher(Teachers entityToRemove)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveTeacherById(int entityToRemoveById)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveUser(Users entityToRemove)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            repo.Remove(entityToRemove);
        }

        public void RemoveUserById(int entityToRemoveById)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public AppInfo GetAppInfo()
        {
            return new AppInfo();
        }

        public int GetRegisteredStudentsCount(Subjects subject)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            return repo.GetRegisteredStudentsCount(subject);
        }

        public int GetRegisteredTeachersCount(Subjects subject)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            return repo.GetRegisteredTeachersCount(subject);
        }

        public void RegisterUserToSubject(Users user, Subjects subject)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            repo.RegisterUserToSubject(user, subject);
        }

        public IEnumerable<Messages> GetReceivedMessages(int userId)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            return repo.GetReceivedMessages(userId);
        }

        public IEnumerable<Messages> GetSentMessages(int userId)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            return repo.GetSentMessages(userId);
        }
    }
}
