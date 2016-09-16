using AutoMapper;
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

        public Service()
        {
            Mapper.CreateMap<Administrators, Entities.Administrators>();
            Mapper.CreateMap<Exams, Entities.Exams>();
            Mapper.CreateMap<ExamsUsers, Entities.ExamsUsers>();
            Mapper.CreateMap<Grades, Entities.Grades>();
            Mapper.CreateMap<Managers, Entities.Managers>();
            Mapper.CreateMap<Messages, Entities.Messages>();
            Mapper.CreateMap<Semesters, Entities.Semesters>();
            Mapper.CreateMap<Students, Entities.Students>();
            Mapper.CreateMap<Subjects, Entities.Subjects>();
            Mapper.CreateMap<SubjectsUsers, Entities.SubjectsUsers>();
            Mapper.CreateMap<Teachers, Entities.Teachers>();
            Mapper.CreateMap<Users, Entities.Users>();

            Mapper.CreateMap<Entities.Administrators, Administrators>();
            Mapper.CreateMap<Entities.Exams, Exams>();
            Mapper.CreateMap<Entities.ExamsUsers, ExamsUsers>();
            Mapper.CreateMap<Entities.Grades, Grades>();
            Mapper.CreateMap<Entities.Managers, Managers>();
            Mapper.CreateMap<Entities.Messages, Messages>();
            Mapper.CreateMap<Entities.Semesters, Semesters>();
            Mapper.CreateMap<Entities.Students, Students>();
            Mapper.CreateMap<Entities.Subjects, Subjects>();
            Mapper.CreateMap<Entities.SubjectsUsers, SubjectsUsers>();
            Mapper.CreateMap<Entities.Teachers, Teachers>();
            Mapper.CreateMap<Entities.Users, Users>();
        }

        /*
        private void AddAdministrator(Administrators entityToAdd)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            Entities.Administrators entityToAdd2 = Mapper.Map<Administrators, Entities.Administrators>(entityToAdd);
            repo.Add(entityToAdd2);
        }
        */

        public int AddExam(Exams entityToAdd)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            Entities.Exams entityToAdd2 = Mapper.Map<Exams, Entities.Exams>(entityToAdd);
            repo.Add(entityToAdd2);
            if (entityToAdd2 != null) return entityToAdd2.Id;
            return 0;
        }

        public int AddExamsUser(ExamsUsers entityToAdd)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            Entities.ExamsUsers entityToAdd2 = Mapper.Map<ExamsUsers, Entities.ExamsUsers>(entityToAdd);
            repo.Add(entityToAdd2);
            if (entityToAdd2 != null) return entityToAdd2.Id;
            return 0;
        }

        public int AddGrade(Grades entityToAdd)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            Entities.Grades entityToAdd2 = Mapper.Map<Grades, Entities.Grades>(entityToAdd);
            repo.Add(entityToAdd2);
            if (entityToAdd2 != null) return entityToAdd2.Id;
            return 0;
        }

        /*
        private void AddManager(Managers entityToAdd)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            Entities.Managers entityToAdd2 = Mapper.Map<Managers, Entities.Managers>(entityToAdd);
            repo.Add(entityToAdd2);
        }
        */

        public int AddMessage(Messages entityToAdd)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            Entities.Messages entityToAdd2 = Mapper.Map<Messages, Entities.Messages>(entityToAdd);
            repo.Add(entityToAdd2);
            if (entityToAdd2 != null) return entityToAdd2.Id;
            return 0;
        }

        public int AddSemester(Semesters entityToAdd)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            Entities.Semesters entityToAdd2 = Mapper.Map<Semesters, Entities.Semesters>(entityToAdd);
            repo.Add(entityToAdd2);
            if (entityToAdd2 != null) return entityToAdd2.Id;
            return 0;
        }

        /*
        private void AddStudent(Students entityToAdd)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            Entities.Students entityToAdd2 = Mapper.Map<Students, Entities.Students>(entityToAdd);
            repo.Add(entityToAdd2);
        }
        */

        public int AddSubject(Subjects entityToAdd)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            Entities.Subjects entityToAdd2 = Mapper.Map<Subjects, Entities.Subjects>(entityToAdd);
            repo.Add(entityToAdd2);
            if (entityToAdd2 != null) return entityToAdd2.Id;
            return 0;
        }

        public int AddSubjectsUser(SubjectsUsers entityToAdd)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            Entities.SubjectsUsers entityToAdd2 = Mapper.Map<SubjectsUsers, Entities.SubjectsUsers>(entityToAdd);
            repo.Add(entityToAdd2);
            if (entityToAdd2 != null) return entityToAdd2.Id;
            return 0;
        }

        /*
        private void AddTeacher(Teachers entityToAdd)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            Entities.Teachers entityToAdd2 = Mapper.Map<Teachers, Entities.Teachers>(entityToAdd);
            repo.Add(entityToAdd2);
        }
        */

        public int AddUser(Users entityToAdd)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            Entities.Users entityToAdd2 = Mapper.Map<Users, Entities.Users>(entityToAdd);
            repo.Add(entityToAdd2);

            switch(entityToAdd.UserType.ToUpper())
            {
                case "ADMINISTRATOR":
                    IAdministratorsRepository adminRepo = new AdministratorsRepository(getEntities());
                    Entities.Administrators admin = new Entities.Administrators() { UserId = entityToAdd2.Id };
                    adminRepo.Add(admin);
                    break;
                case "MANAGER":
                    IManagersRepository managerRepo = new ManagersRepository(getEntities());
                    Entities.Managers manager = new Entities.Managers() { UserId = entityToAdd2.Id };
                    managerRepo.Add(manager);
                    break;
                case "STUDENT":
                    IStudentsRepository studentRepo = new StudentsRepository(getEntities());
                    Entities.Students student = new Entities.Students() { UserId = entityToAdd2.Id };
                    studentRepo.Add(student);
                    break;
                case "TEACHER":
                    ITeachersRepository teacherRepo = new TeachersRepository(getEntities());
                    Entities.Teachers teacher = new Entities.Teachers() { UserId = entityToAdd2.Id };
                    teacherRepo.Add(teacher);
                    break;
                default:; break;
            }

            if (entityToAdd2 != null) return entityToAdd2.Id;
            return 0;
        }

        #region Find függvények (kikommentelve)
        /*
        public IEnumerable<Administrators> FindAdministrators(Expression<Func<Administrators, bool>> filterPredicate)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            Expression<Func<Entities.Administrators, bool>> filterPredicate2 = Mapper.Map<Expression<Func<Administrators, bool>>, Expression<Func<Entities.Administrators, bool>>>(filterPredicate);
            IEnumerable<Entities.Administrators> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<Administrators> returnedValue2 = Mapper.Map< IEnumerable < Entities.Administrators > , IEnumerable <Administrators>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Exams> FindExams(Expression<Func<Exams, bool>> filterPredicate)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            Expression<Func<Entities.Exams, bool>> filterPredicate2 = Mapper.Map< Expression < Func < Exams, bool>> , Expression <Func<Entities.Exams, bool>>>(filterPredicate);
            IEnumerable<Entities.Exams> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<Exams> returnedValue2 = Mapper.Map< IEnumerable < Entities.Exams >, IEnumerable <Exams>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<ExamsUsers> FindExamsUsers(Expression<Func<ExamsUsers, bool>> filterPredicate)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            Expression<Func<Entities.ExamsUsers, bool>> filterPredicate2 = Mapper.Map< Expression < Func < ExamsUsers, bool>> , Expression <Func<Entities.ExamsUsers, bool>>>(filterPredicate);
            IEnumerable<Entities.ExamsUsers> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<ExamsUsers> returnedValue2 = Mapper.Map< IEnumerable < Entities.ExamsUsers > , IEnumerable <ExamsUsers>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Grades> FindGrades(Expression<Func<Grades, bool>> filterPredicate)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            Expression<Func<Entities.Grades, bool>> filterPredicate2 = Mapper.Map< Expression < Func < Grades, bool>> , Expression <Func<Entities.Grades, bool>>>(filterPredicate);
            IEnumerable<Entities.Grades> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<Grades> returnedValue2 = Mapper.Map< IEnumerable < Entities.Grades > , IEnumerable <Grades>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Managers> FindManagers(Expression<Func<Managers, bool>> filterPredicate)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            Expression<Func<Entities.Managers, bool>> filterPredicate2 = Mapper.Map< Expression < Func < Managers, bool>> , Expression <Func<Entities.Managers, bool>>>(filterPredicate);
            IEnumerable<Entities.Managers> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<Managers> returnedValue2 = Mapper.Map< IEnumerable < Entities.Managers > , IEnumerable <Managers>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Messages> FindMessages(Expression<Func<Messages, bool>> filterPredicate)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            Expression<Func<Entities.Messages, bool>> filterPredicate2 = Mapper.Map< Expression < Func < Messages, bool>> , Expression <Func<Entities.Messages, bool>>>(filterPredicate);
            IEnumerable<Entities.Messages> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<Messages> returnedValue2 = Mapper.Map< IEnumerable < Entities.Messages > , IEnumerable <Messages>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Semesters> FindSemesters(Expression<Func<Semesters, bool>> filterPredicate)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            Expression<Func<Entities.Semesters, bool>> filterPredicate2 = Mapper.Map< Expression < Func < Semesters, bool>> , Expression <Func<Entities.Semesters, bool>>>(filterPredicate);
            IEnumerable<Entities.Semesters> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<Semesters> returnedValue2 = Mapper.Map< IEnumerable < Entities.Semesters > , IEnumerable <Semesters>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Students> FindStudents(Expression<Func<Students, bool>> filterPredicate)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            Expression<Func<Entities.Students, bool>> filterPredicate2 = Mapper.Map< Expression < Func < Students, bool>> , Expression <Func<Entities.Students, bool>>>(filterPredicate);
            IEnumerable<Entities.Students> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<Students> returnedValue2 = Mapper.Map< IEnumerable < Entities.Students > , IEnumerable <Students>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Subjects> FindSubjects(Expression<Func<Subjects, bool>> filterPredicate)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            Expression<Func<Entities.Subjects, bool>> filterPredicate2 = Mapper.Map< Expression < Func < Subjects, bool>> , Expression <Func<Entities.Subjects, bool>>>(filterPredicate);
            IEnumerable<Entities.Subjects> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<Subjects> returnedValue2 = Mapper.Map< IEnumerable < Entities.Subjects > , IEnumerable <Subjects>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<SubjectsUsers> FindSubjectsUsers(Expression<Func<SubjectsUsers, bool>> filterPredicate)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            Expression<Func<Entities.SubjectsUsers, bool>> filterPredicate2 = Mapper.Map< Expression < Func < SubjectsUsers, bool>> , Expression <Func<Entities.SubjectsUsers, bool>>>(filterPredicate);
            IEnumerable<Entities.SubjectsUsers> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<SubjectsUsers> returnedValue2 = Mapper.Map< IEnumerable < Entities.SubjectsUsers > , IEnumerable <SubjectsUsers>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Teachers> FindTeachers(Expression<Func<Teachers, bool>> filterPredicate)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            Expression<Func<Entities.Teachers, bool>> filterPredicate2 = Mapper.Map< Expression < Func < Teachers, bool>> , Expression <Func<Entities.Teachers, bool>>>(filterPredicate);
            IEnumerable<Entities.Teachers> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<Teachers> returnedValue2 = Mapper.Map< IEnumerable < Entities.Teachers > , IEnumerable <Teachers>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Users> FindUsers(Expression<Func<Users, bool>> filterPredicate)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            Expression<Func<Entities.Users, bool>> filterPredicate2 = Mapper.Map< Expression < Func < Users, bool>> , Expression <Func<Entities.Users, bool>>>(filterPredicate);
            IEnumerable<Entities.Users> returnedValue = repo.Find(filterPredicate2);
            IEnumerable<Users> returnedValue2 = Mapper.Map< IEnumerable < Entities.Users > , IEnumerable <Users>>(returnedValue);
            return returnedValue2;
        }
        */
        #endregion

        public Administrators GetAdministratorById(int entityToGetById)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            Entities.Administrators returnedValue = repo.GetById(entityToGetById);
            Administrators returnedValue2 = Mapper.Map<Entities.Administrators, Administrators>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Administrators> GetAllAdministrators()
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            IEnumerable<Entities.Administrators> returnedValue = repo.GetAll();
            IEnumerable<Administrators> returnedValue2 = Mapper.Map<IEnumerable<Entities.Administrators>, IEnumerable<Administrators>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Exams> GetAllExams()
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            IEnumerable<Entities.Exams> returnedValue = repo.GetAll();
            IEnumerable<Exams> returnedValue2 = Mapper.Map<IEnumerable<Entities.Exams>, IEnumerable<Exams>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<ExamsUsers> GetAllExamsUsers()
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            IEnumerable<Entities.ExamsUsers> returnedValue = repo.GetAll();
            IEnumerable<ExamsUsers> returnedValue2 = Mapper.Map<IEnumerable<Entities.ExamsUsers>, IEnumerable<ExamsUsers>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Grades> GetAllGrades()
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            IEnumerable<Entities.Grades> returnedValue = repo.GetAll();
            IEnumerable<Grades> returnedValue2 = Mapper.Map<IEnumerable<Entities.Grades>, IEnumerable<Grades>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Managers> GetAllManagers()
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            IEnumerable<Entities.Managers> returnedValue = repo.GetAll();
            IEnumerable<Managers> returnedValue2 = Mapper.Map<IEnumerable<Entities.Managers>, IEnumerable<Managers>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Messages> GetAllMessages()
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            IEnumerable<Entities.Messages> returnedValue = repo.GetAll();
            IEnumerable<Messages> returnedValue2 = Mapper.Map<IEnumerable<Entities.Messages>, IEnumerable<Messages>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Semesters> GetAllSemesters()
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            IEnumerable<Entities.Semesters> returnedValue = repo.GetAll();
            IEnumerable<Semesters> returnedValue2 = Mapper.Map<IEnumerable<Entities.Semesters>, IEnumerable<Semesters>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Students> GetAllStudents()
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            IEnumerable<Entities.Students> returnedValue = repo.GetAll();
            IEnumerable<Students> returnedValue2 = Mapper.Map<IEnumerable<Entities.Students>, IEnumerable<Students>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Subjects> GetAllSubjects()
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            IEnumerable<Entities.Subjects> returnedValue = repo.GetAll();
            IEnumerable<Subjects> returnedValue2 = Mapper.Map<IEnumerable<Entities.Subjects>, IEnumerable<Subjects>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<SubjectsUsers> GetAllSubjectsUsers()
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            IEnumerable<Entities.SubjectsUsers> returnedValue = repo.GetAll();
            IEnumerable<SubjectsUsers> returnedValue2 = Mapper.Map<IEnumerable<Entities.SubjectsUsers>, IEnumerable<SubjectsUsers>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Teachers> GetAllTeachers()
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            IEnumerable<Entities.Teachers> returnedValue = repo.GetAll();
            IEnumerable<Teachers> returnedValue2 = Mapper.Map<IEnumerable<Entities.Teachers>, IEnumerable<Teachers>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Users> GetAllUsers()
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            IEnumerable<Entities.Users> returnedValue = repo.GetAll();
            IEnumerable<Users> returnedValue2 = Mapper.Map<IEnumerable<Entities.Users>, IEnumerable<Users>>(returnedValue);
            return returnedValue2;
        }

        public Exams GetExamById(int entityToGetById)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            Entities.Exams returnedValue = repo.GetById(entityToGetById);
            Exams returnedValue2 = Mapper.Map<Entities.Exams, Exams>(returnedValue);
            return returnedValue2;
        }

        public ExamsUsers GetExamsUserById(int entityToGetById)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            Entities.ExamsUsers returnedValue = repo.GetById(entityToGetById);
            ExamsUsers returnedValue2 = Mapper.Map<Entities.ExamsUsers, ExamsUsers>(returnedValue);
            return returnedValue2;
        }

        public Grades GetGradeById(int entityToGetById)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            Entities.Grades returnedValue = repo.GetById(entityToGetById);
            Grades returnedValue2 = Mapper.Map<Entities.Grades, Grades>(returnedValue);
            return returnedValue2;
        }

        public int GetIdOfAdministrator(Administrators entityToGetId)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            Entities.Administrators entityToGetId2 = Mapper.Map<Administrators, Entities.Administrators>(entityToGetId);
            return repo.GetAdminId(entityToGetId2);
        }

        public int GetIdOfExam(Exams entityToGetId)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            Entities.Exams entityToGetId2 = Mapper.Map<Exams, Entities.Exams>(entityToGetId);
            return repo.GetExamId(entityToGetId2);
        }

        public int GetIdOfExamsUser(ExamsUsers entityToGetId)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            Entities.ExamsUsers entityToGetId2 = Mapper.Map<ExamsUsers, Entities.ExamsUsers>(entityToGetId);
            return repo.GetExamUserId(entityToGetId2);
        }

        public int GetIdOfGrade(Grades entityToGetId)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            Entities.Grades entityToGetId2 = Mapper.Map<Grades, Entities.Grades>(entityToGetId);
            return repo.GetGradeId(entityToGetId2);
        }

        public int GetIdOfManager(Managers entityToGetId)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            Entities.Managers entityToGetId2 = Mapper.Map<Managers, Entities.Managers>(entityToGetId);
            return repo.GetManagerId(entityToGetId2);
        }

        public int GetIdOfMessage(Messages entityToGetId)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            Entities.Messages entityToGetId2 = Mapper.Map<Messages, Entities.Messages>(entityToGetId);
            return repo.GetMessageId(entityToGetId2);
        }

        public int GetIdOfSemester(Semesters entityToGetId)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            Entities.Semesters entityToGetId2 = Mapper.Map<Semesters, Entities.Semesters>(entityToGetId);
            return repo.GetSemesterId(entityToGetId2);
        }

        public int GetIdOfStudent(Students entityToGetId)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            Entities.Students entityToGetId2 = Mapper.Map<Students, Entities.Students>(entityToGetId);
            return repo.GetStudentId(entityToGetId2);
        }

        public int GetIdOfSubject(Subjects entityToGetId)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            Entities.Subjects entityToGetId2 = Mapper.Map<Subjects, Entities.Subjects>(entityToGetId);
            return repo.GetSubjectId(entityToGetId2);
        }

        public int GetIdOfSubjectsUser(SubjectsUsers entityToGetId)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            Entities.SubjectsUsers entityToGetId2 = Mapper.Map<SubjectsUsers, Entities.SubjectsUsers>(entityToGetId);
            return repo.GetSubjectUserId(entityToGetId2);
        }

        public int GetIdOfTeacher(Teachers entityToGetId)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            Entities.Teachers entityToGetId2 = Mapper.Map<Teachers, Entities.Teachers>(entityToGetId);
            return repo.GetTeacherId(entityToGetId2);
        }

        public int GetIdOfUser(Users entityToGetId)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            Entities.Users entityToGetId2 = Mapper.Map<Users, Entities.Users>(entityToGetId);
            return repo.GetUserId(entityToGetId2);
        }

        public Managers GetManagerById(int entityToGetById)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            Entities.Managers returnedValue = repo.GetById(entityToGetById);
            Managers returnedValue2 = Mapper.Map<Entities.Managers, Managers>(returnedValue);
            return returnedValue2;
        }

        public Messages GetMessageById(int entityToGetById)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            Entities.Messages returnedValue = repo.GetById(entityToGetById);
            Messages returnedValue2 = Mapper.Map<Entities.Messages, Messages>(returnedValue);
            return returnedValue2;
        }

        public Semesters GetSemesterById(int entityToGetById)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            Entities.Semesters returnedValue = repo.GetById(entityToGetById);
            Semesters returnedValue2 = Mapper.Map<Entities.Semesters, Semesters>(returnedValue);
            return returnedValue2;
        }

        public Students GetStudentById(int entityToGetById)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            Entities.Students returnedValue = repo.GetById(entityToGetById);
            Students returnedValue2 = Mapper.Map<Entities.Students, Students>(returnedValue);
            return returnedValue2;
        }

        public Subjects GetSubjectById(int entityToGetById)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            Entities.Subjects returnedValue = repo.GetById(entityToGetById);
            Subjects returnedValue2 = Mapper.Map<Entities.Subjects, Subjects>(returnedValue);
            return returnedValue2;
        }

        public SubjectsUsers GetSubjectsUserById(int entityToGetById)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            Entities.SubjectsUsers returnedValue = repo.GetById(entityToGetById);
            SubjectsUsers returnedValue2 = Mapper.Map<Entities.SubjectsUsers, SubjectsUsers>(returnedValue);
            return returnedValue2;
        }

        public Users GetSubjectTeacher(Subjects subject)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            Entities.Subjects subject2 = Mapper.Map<Subjects, Entities.Subjects>(subject);
            Entities.Users returnedValue = repo.GetSubjectTeacher(subject2);
            Users returnedValue2 = Mapper.Map<Entities.Users, Users>(returnedValue);
            return returnedValue2;
        }

        public Teachers GetTeacherById(int entityToGetById)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            Entities.Teachers returnedValue = repo.GetById(entityToGetById);
            Teachers returnedValue2 = Mapper.Map<Entities.Teachers, Teachers>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Users> GetTeachersFromUsers()
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            IEnumerable<Entities.Users> returnedValue = repo.GetTeachersFromUsers();
            IEnumerable<Users> returnedValue2 = Mapper.Map<IEnumerable<Entities.Users>, IEnumerable<Users>>(returnedValue);
            return returnedValue2;
        }

        public Users GetUserById(int entityToGetById)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            Entities.Users returnedValue = repo.GetById(entityToGetById);
            Users returnedValue2 = Mapper.Map<Entities.Users, Users>(returnedValue);
            return returnedValue2;
        }

        public int GetUserId(Users user)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            Entities.Users user2 = Mapper.Map<Users, Entities.Users>(user);
            return repo.GetUserId(user2);
        }

        public bool Login(string eduId, string password)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            return repo.Login(eduId, password);
        }

        public void RemoveAdministrator(Administrators entityToRemove)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            Entities.Administrators entityToRemove2 = Mapper.Map<Administrators, Entities.Administrators>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveAdministratorById(int entityToRemoveById)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveExam(Exams entityToRemove)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            Entities.Exams entityToRemove2 = Mapper.Map<Exams, Entities.Exams>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveExamById(int entityToRemoveById)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveExamsUser(ExamsUsers entityToRemove)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            Entities.ExamsUsers entityToRemove2 = Mapper.Map<ExamsUsers, Entities.ExamsUsers>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveExamsUserById(int entityToRemoveById)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveGrade(Grades entityToRemove)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            Entities.Grades entityToRemove2 = Mapper.Map<Grades, Entities.Grades>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveGradeById(int entityToRemoveById)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveManager(Managers entityToRemove)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            Entities.Managers entityToRemove2 = Mapper.Map<Managers, Entities.Managers>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveManagerById(int entityToRemoveById)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveMessage(Messages entityToRemove)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            Entities.Messages entityToRemove2 = Mapper.Map<Messages, Entities.Messages>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveMessageById(int entityToRemoveById)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveSemester(Semesters entityToRemove)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            Entities.Semesters entityToRemove2 = Mapper.Map<Semesters, Entities.Semesters>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveSemesterById(int entityToRemoveById)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveStudent(Students entityToRemove)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            Entities.Students entityToRemove2 = Mapper.Map<Students, Entities.Students>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveStudentById(int entityToRemoveById)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveSubject(Subjects entityToRemove)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            Entities.Subjects entityToRemove2 = Mapper.Map<Subjects, Entities.Subjects>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveSubjectById(int entityToRemoveById)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveSubjectsUser(SubjectsUsers entityToRemove)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            Entities.SubjectsUsers entityToRemove2 = Mapper.Map<SubjectsUsers, Entities.SubjectsUsers>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveSubjectsUserById(int entityToRemoveById)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveTeacher(Teachers entityToRemove)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            Entities.Teachers entityToRemove2 = Mapper.Map<Teachers, Entities.Teachers>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveTeacherById(int entityToRemoveById)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            repo.RemoveById(entityToRemoveById);
        }

        public void RemoveUser(Users entityToRemove)
        {
            switch (entityToRemove.UserType.ToUpper())
            {
                case "ADMINISTRATOR":
                    IAdministratorsRepository adminRepo = new AdministratorsRepository(getEntities());
                    Entities.Administrators returnedObj = adminRepo.GetAll().Where(x => x.UserId == entityToRemove.Id).FirstOrDefault();
                    adminRepo.Remove(returnedObj);
                    break;
                case "MANAGER":
                    IManagersRepository managerRepo = new ManagersRepository(getEntities());
                    Entities.Managers returnedObj2 = managerRepo.GetAll().Where(x => x.UserId == entityToRemove.Id).FirstOrDefault();
                    managerRepo.Remove(returnedObj2);
                    break;
                case "STUDENT":
                    IStudentsRepository studentRepo = new StudentsRepository(getEntities());
                    Entities.Students returnedObj3 = studentRepo.GetAll().Where(x => x.UserId == entityToRemove.Id).FirstOrDefault();
                    studentRepo.Remove(returnedObj3);
                    break;
                case "TEACHER":
                    ITeachersRepository teacherRepo = new TeachersRepository(getEntities());
                    Entities.Teachers returnedObj4 = teacherRepo.GetAll().Where(x => x.UserId == entityToRemove.Id).FirstOrDefault();
                    teacherRepo.Remove(returnedObj4);
                    break;
                default:; break;
            }

            IUsersRepository repo = new UsersRepository(getEntities());
            Entities.Users entityToRemove2 = Mapper.Map<Users, Entities.Users>(entityToRemove);
            repo.Remove(entityToRemove2);
        }

        public void RemoveUserById(int entityToRemoveById)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            Entities.Users userToRemove = repo.GetAll().Where(x => x.Id == entityToRemoveById).FirstOrDefault();
            Users userToRemove2 = Mapper.Map<Entities.Users, Users>(userToRemove);

            switch (userToRemove2.UserType.ToUpper())
            {
                case "ADMINISTRATOR":
                    IAdministratorsRepository adminRepo = new AdministratorsRepository(getEntities());
                    Entities.Administrators returnedObj = adminRepo.GetAll().Where(x => x.UserId == userToRemove2.Id).FirstOrDefault();
                    if(returnedObj != null) adminRepo.Remove(returnedObj);
                    break;
                case "MANAGER":
                    IManagersRepository managerRepo = new ManagersRepository(getEntities());
                    Entities.Managers returnedObj2 = managerRepo.GetAll().Where(x => x.UserId == userToRemove2.Id).FirstOrDefault();
                    if (returnedObj2 != null) managerRepo.Remove(returnedObj2);
                    break;
                case "STUDENT":
                    IStudentsRepository studentRepo = new StudentsRepository(getEntities());
                    Entities.Students returnedObj3 = studentRepo.GetAll().Where(x => x.UserId == userToRemove2.Id).FirstOrDefault();
                    if (returnedObj3 != null) studentRepo.Remove(returnedObj3);
                    break;
                case "TEACHER":
                    ITeachersRepository teacherRepo = new TeachersRepository(getEntities());
                    Entities.Teachers returnedObj4 = teacherRepo.GetAll().Where(x => x.UserId == userToRemove2.Id).FirstOrDefault();
                    if (returnedObj4 != null) teacherRepo.Remove(returnedObj4);
                    break;
                default:; break;
            }

            repo.RemoveById(entityToRemoveById);
        }

        public AppInfo GetAppInfo()
        {
            return new AppInfo();
        }

        public int GetRegisteredStudentsCount(Subjects subject)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            Entities.Subjects subject2 = Mapper.Map<Subjects, Entities.Subjects>(subject);
            return repo.GetRegisteredStudentsCount(subject2);
        }

        public int GetRegisteredTeachersCount(Subjects subject)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            Entities.Subjects subject2 = Mapper.Map<Subjects, Entities.Subjects>(subject);
            return repo.GetRegisteredTeachersCount(subject2);
        }

        public void RegisterUserToSubject(Users user, Subjects subject)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            Entities.Users user2 = Mapper.Map<Users, Entities.Users>(user);
            Entities.Subjects subject2 = Mapper.Map<Subjects, Entities.Subjects>(subject);
            repo.RegisterUserToSubject(user2, subject2);
        }

        public IEnumerable<Messages> GetReceivedMessages(int userId)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            IEnumerable<Entities.Messages> returnedValue = repo.GetReceivedMessages(userId);
            IEnumerable<Messages> returnedValue2 = Mapper.Map<IEnumerable<Entities.Messages>, IEnumerable<Messages>>(returnedValue);
            return returnedValue2;
        }

        public IEnumerable<Messages> GetSentMessages(int userId)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            IEnumerable<Entities.Messages> returnedValue = repo.GetSentMessages(userId);
            IEnumerable<Messages> returnedValue2 = Mapper.Map<IEnumerable<Entities.Messages>, IEnumerable<Messages>>(returnedValue);
            return returnedValue2;
        }

        public void SaveChanges()
        {
            getEntities().SaveChanges();
        }

        public IEnumerable<Users> GetExamStudents(int examId)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            IEnumerable<Entities.Users> returnedValue = repo.GetExamStudents(examId);
            return Mapper.Map<IEnumerable<Entities.Users>, IEnumerable<Users>>(returnedValue);
        }

        public Users GetExamTeacher(int examId)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            Entities.Users returnedValue = repo.Find(x => x.ExamId == examId).FirstOrDefault().Users;
            return Mapper.Map<Entities.Users, Users>(returnedValue);
        }

        public void UpdateAdministrator(Administrators entityToUpdate)
        {
            IAdministratorsRepository repo = new AdministratorsRepository(getEntities());
            Entities.Administrators entityToUpdate2 = Mapper.Map<Administrators, Entities.Administrators>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }

        public void UpdateExam(Exams entityToUpdate)
        {
            IExamsRepository repo = new ExamsRepository(getEntities());
            Entities.Exams entityToUpdate2 = Mapper.Map<Exams, Entities.Exams>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }

        public void UpdateExamsUser(ExamsUsers entityToUpdate)
        {
            IExamsUsersRepository repo = new ExamsUsersRepository(getEntities());
            Entities.ExamsUsers entityToUpdate2 = Mapper.Map<ExamsUsers, Entities.ExamsUsers>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }

        public void UpdateGrade(Grades entityToUpdate)
        {
            IGradesRepository repo = new GradesRepository(getEntities());
            Entities.Grades entityToUpdate2 = Mapper.Map<Grades, Entities.Grades>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }

        public void UpdateManager(Managers entityToUpdate)
        {
            IManagersRepository repo = new ManagersRepository(getEntities());
            Entities.Managers entityToUpdate2 = Mapper.Map<Managers, Entities.Managers>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }

        public void UpdateMessage(Messages entityToUpdate)
        {
            IMessagesRepository repo = new MessagesRepository(getEntities());
            Entities.Messages entityToUpdate2 = Mapper.Map<Messages, Entities.Messages>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }

        public void UpdateSemester(Semesters entityToUpdate)
        {
            ISemestersRepository repo = new SemestersRepository(getEntities());
            Entities.Semesters entityToUpdate2 = Mapper.Map<Semesters, Entities.Semesters>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }

        public void UpdateStudent(Students entityToUpdate)
        {
            IStudentsRepository repo = new StudentsRepository(getEntities());
            Entities.Students entityToUpdate2 = Mapper.Map<Students, Entities.Students>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }

        public void UpdateSubject(Subjects entityToUpdate)
        {
            ISubjectsRepository repo = new SubjectsRepository(getEntities());
            Entities.Subjects entityToUpdate2 = Mapper.Map<Subjects, Entities.Subjects>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }

        public void UpdateSubjectsUser(SubjectsUsers entityToUpdate)
        {
            ISubjectsUsersRepository repo = new SubjectsUsersRepository(getEntities());
            Entities.SubjectsUsers entityToUpdate2 = Mapper.Map<SubjectsUsers, Entities.SubjectsUsers>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }

        public void UpdateTeacher(Teachers entityToUpdate)
        {
            ITeachersRepository repo = new TeachersRepository(getEntities());
            Entities.Teachers entityToUpdate2 = Mapper.Map<Teachers, Entities.Teachers>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }

        public void UpdateUser(Users entityToUpdate)
        {
            IUsersRepository repo = new UsersRepository(getEntities());
            Entities.Users entityToUpdate2 = Mapper.Map<Users, Entities.Users>(entityToUpdate);
            repo.Update(entityToUpdate2);
        }
    }
}
