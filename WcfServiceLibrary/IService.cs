using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface IService
    {
        //Administrators operations
        [OperationContract]
        void AddAdministrator(Administrators entityToAdd);
        [OperationContract]
        IEnumerable<Administrators> FindAdministrators(Expression<Func<Administrators, bool>> filterPredicate);
        [OperationContract]
        void EditAdministrator(Administrators entityToEdit);
        [OperationContract]
        void EditAdministratorById(int entityToEditById);
        [OperationContract]
        IEnumerable<Administrators> GetAllAdministrators();
        [OperationContract]
        Administrators GetAdministratorById(int entityToGetById);
        [OperationContract]
        int GetIdOfAdministrator(Administrators entityToGetId);
        [OperationContract]
        void RemoveAdministrator(Administrators entityToRemove);
        [OperationContract]
        void RemoveAdministratorById(int entityToRemoveById);

        //Exams operations
        [OperationContract]
        void AddExam(Exams entityToAdd);
        [OperationContract]
        IEnumerable<Exams> FindExams(Expression<Func<Exams, bool>> filterPredicate);
        [OperationContract]
        void EditExam(Exams entityToEdit);
        [OperationContract]
        void EditExamById(int entityToEditById);
        [OperationContract]
        IEnumerable<Exams> GetAllExams();
        [OperationContract]
        Exams GetExamById(int entityToGetById);
        [OperationContract]
        int GetIdOfExam(Exams entityToGetId);
        [OperationContract]
        void RemoveExam(Exams entityToRemove);
        [OperationContract]
        void RemoveExamById(int entityToRemoveById);

        //ExamsUsers operations
        [OperationContract]
        void AddExamsUser(ExamsUsers entityToAdd);
        [OperationContract]
        IEnumerable<ExamsUsers> FindExamsUsers(Expression<Func<ExamsUsers, bool>> filterPredicate);
        [OperationContract]
        void EditExamsUser(ExamsUsers entityToEdit);
        [OperationContract]
        void EditExamsUserById(int entityToEditById);
        [OperationContract]
        IEnumerable<ExamsUsers> GetAllExamsUsers();
        [OperationContract]
        ExamsUsers GetExamsUserById(int entityToGetById);
        [OperationContract]
        int GetIdOfExamsUser(ExamsUsers entityToGetId);
        [OperationContract]
        void RemoveExamsUser(ExamsUsers entityToRemove);
        [OperationContract]
        void RemoveExamsUserById(int entityToRemoveById);

        //Grades operations
        [OperationContract]
        void AddGrade(Grades entityToAdd);
        [OperationContract]
        IEnumerable<Grades> FindGrades(Expression<Func<Grades, bool>> filterPredicate);
        [OperationContract]
        void EditGrade(Grades entityToEdit);
        [OperationContract]
        void EditGradeById(int entityToEditById);
        [OperationContract]
        IEnumerable<Grades> GetAllGrades();
        [OperationContract]
        Grades GetGradeById(int entityToGetById);
        [OperationContract]
        int GetIdOfGrade(Grades entityToGetId);
        [OperationContract]
        void RemoveGrade(Grades entityToRemove);
        [OperationContract]
        void RemoveGradeById(int entityToRemoveById);

        //Managers operations
        [OperationContract]
        void AddManager(Managers entityToAdd);
        [OperationContract]
        IEnumerable<Managers> FindManagers(Expression<Func<Managers, bool>> filterPredicate);
        [OperationContract]
        void EditManager(Managers entityToEdit);
        [OperationContract]
        void EditManagerById(int entityToEditById);
        [OperationContract]
        IEnumerable<Managers> GetAllManagers();
        [OperationContract]
        Managers GetManagerById(int entityToGetById);
        [OperationContract]
        int GetIdOfManager(Managers entityToGetId);
        [OperationContract]
        void RemoveManager(Managers entityToRemove);
        [OperationContract]
        void RemoveManagerById(int entityToRemoveById);

        //Messages operations
        [OperationContract]
        void AddMessage(Messages entityToAdd);
        [OperationContract]
        IEnumerable<Messages> FindMessages(Expression<Func<Messages, bool>> filterPredicate);
        [OperationContract]
        void EditMessage(Messages entityToEdit);
        [OperationContract]
        void EditMessageById(int entityToEditById);
        [OperationContract]
        IEnumerable<Messages> GetAllMessages();
        [OperationContract]
        Messages GetMessageById(int entityToGetById);
        [OperationContract]
        int GetIdOfMessage(Messages entityToGetId);
        [OperationContract]
        void RemoveMessage(Messages entityToRemove);
        [OperationContract]
        void RemoveMessageById(int entityToRemoveById);

        //Semesters operations
        [OperationContract]
        void AddSemester(Semesters entityToAdd);
        [OperationContract]
        IEnumerable<Semesters> FindSemesters(Expression<Func<Semesters, bool>> filterPredicate);
        [OperationContract]
        void EditSemester(Semesters entityToEdit);
        [OperationContract]
        void EditSemesterById(int entityToEditById);
        [OperationContract]
        IEnumerable<Semesters> GetAllSemesters();
        [OperationContract]
        Semesters GetSemesterById(int entityToGetById);
        [OperationContract]
        int GetIdOfSemester(Semesters entityToGetId);
        [OperationContract]
        void RemoveSemester(Semesters entityToRemove);
        [OperationContract]
        void RemoveSemesterById(int entityToRemoveById);

        //Students operations
        [OperationContract]
        void AddStudent(Students entityToAdd);
        [OperationContract]
        IEnumerable<Students> FindStudents(Expression<Func<Students, bool>> filterPredicate);
        [OperationContract]
        void EditStudent(Students entityToEdit);
        [OperationContract]
        void EditStudentById(int entityToEditById);
        [OperationContract]
        IEnumerable<Students> GetAllStudents();
        [OperationContract]
        Students GetStudentById(int entityToGetById);
        [OperationContract]
        int GetIdOfStudent(Students entityToGetId);
        [OperationContract]
        void RemoveStudent(Students entityToRemove);
        [OperationContract]
        void RemoveStudentById(int entityToRemoveById);

        //Subjects operations
        [OperationContract]
        void AddSubject(Subjects entityToAdd);
        [OperationContract]
        IEnumerable<Subjects> FindSubjects(Expression<Func<Subjects, bool>> filterPredicate);
        [OperationContract]
        void EditSubject(Subjects entityToEdit);
        [OperationContract]
        void EditSubjectById(int entityToEditById);
        [OperationContract]
        IEnumerable<Subjects> GetAllSubjects();
        [OperationContract]
        Subjects GetSubjectById(int entityToGetById);
        [OperationContract]
        int GetIdOfSubject(Subjects entityToGetId);
        [OperationContract]
        void RemoveSubject(Subjects entityToRemove);
        [OperationContract]
        void RemoveSubjectById(int entityToRemoveById);

        //SubjectsUsers operations
        [OperationContract]
        void AddSubjectsUser(SubjectsUsers entityToAdd);
        [OperationContract]
        IEnumerable<SubjectsUsers> FindSubjectsUsers(Expression<Func<SubjectsUsers, bool>> filterPredicate);
        [OperationContract]
        void EditSubjectsUser(SubjectsUsers entityToEdit);
        [OperationContract]
        void EditSubjectsUserById(int entityToEditById);
        [OperationContract]
        IEnumerable<SubjectsUsers> GetAllSubjectsUsers();
        [OperationContract]
        SubjectsUsers GetSubjectsUserById(int entityToGetById);
        [OperationContract]
        int GetIdOfSubjectsUser(SubjectsUsers entityToGetId);
        [OperationContract]
        void RemoveSubjectsUser(SubjectsUsers entityToRemove);
        [OperationContract]
        void RemoveSubjectsUserById(int entityToRemoveById);

        //Teachers operations
        [OperationContract]
        void AddTeacher(Teachers entityToAdd);
        [OperationContract]
        IEnumerable<Teachers> FindTeachers(Expression<Func<Teachers, bool>> filterPredicate);
        [OperationContract]
        void EditTeacher(Teachers entityToEdit);
        [OperationContract]
        void EditTeacherById(int entityToEditById);
        [OperationContract]
        IEnumerable<Teachers> GetAllTeachers();
        [OperationContract]
        Teachers GetTeacherById(int entityToGetById);
        [OperationContract]
        int GetIdOfTeacher(Teachers entityToGetId);
        [OperationContract]
        void RemoveTeacher(Teachers entityToRemove);
        [OperationContract]
        void RemoveTeacherById(int entityToRemoveById);

        //Users operations
        [OperationContract]
        void AddUser(Users entityToAdd);
        [OperationContract]
        IEnumerable<Users> FindUsers(Expression<Func<Users, bool>> filterPredicate);
        [OperationContract]
        void EditUser(Users entityToEdit);
        [OperationContract]
        void EditUserById(int entityToEditById);
        [OperationContract]
        IEnumerable<Users> GetAllUsers();
        [OperationContract]
        Users GetUserById(int entityToGetById);
        [OperationContract]
        int GetIdOfUser(Users entityToGetId);
        [OperationContract]
        void RemoveUser(Users entityToRemove);
        [OperationContract]
        void RemoveUserById(int entityToRemoveById);

        int GetUserId(Users user);
        IEnumerable<Users> GetTeachersFromUsers();
        bool Login(string eduId, string password);


    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary.ContractType".



    /*
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
        */
}