using Entities;
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
        #region Administrators operations
        //[OperationContract]
        //void AddAdministrator(Administrators entityToAdd);
        //[OperationContract]
        //IEnumerable<Administrators> FindAdministrators(Expression<Func<Administrators, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<Administrators> GetAllAdministrators();
        [OperationContract]
        Administrators GetAdministratorById(int entityToGetById);
        [OperationContract]
        int GetIdOfAdministrator(Administrators entityToGetId);
        //[OperationContract]
        //void RemoveAdministrator(Administrators entityToRemove);
        //[OperationContract]
        //void RemoveAdministratorById(int entityToRemoveById);
        [OperationContract]
        void UpdateAdministrator(Administrators entityToUpdate);
        #endregion

        #region Exams operations
        [OperationContract]
        void AddExam(Exams entityToAdd);
        //[OperationContract]
        //IEnumerable<Exams> FindExams(Expression<Func<Exams, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<Exams> GetAllExams();
        [OperationContract]
        Exams GetExamById(int entityToGetById);
        [OperationContract]
        int GetIdOfExam(Exams entityToGetId);
        //[OperationContract]
        //void RemoveExam(Exams entityToRemove);
        [OperationContract]
        void RemoveExamById(int entityToRemoveById);
        [OperationContract]
        void UpdateExam(Exams entityToUpdate);
        #endregion

        #region ExamsUsers operations
        [OperationContract]
        void AddExamsUser(ExamsUsers entityToAdd);
        //[OperationContract]
        //IEnumerable<ExamsUsers> FindExamsUsers(Expression<Func<ExamsUsers, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<ExamsUsers> GetAllExamsUsers();
        [OperationContract]
        ExamsUsers GetExamsUserById(int entityToGetById);
        [OperationContract]
        int GetIdOfExamsUser(ExamsUsers entityToGetId);
        //[OperationContract]
        //void RemoveExamsUser(ExamsUsers entityToRemove);
        [OperationContract]
        void RemoveExamsUserById(int entityToRemoveById);
        [OperationContract]
        IEnumerable<Users> GetExamStudents(int examId);
        [OperationContract]
        Users GetExamTeacher(int examId);
        [OperationContract]
        void UpdateExamsUser(ExamsUsers entityToUpdate);
        #endregion

        #region Grades operations
        [OperationContract]
        void AddGrade(Grades entityToAdd);
        //[OperationContract]
        //IEnumerable<Grades> FindGrades(Expression<Func<Grades, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<Grades> GetAllGrades();
        [OperationContract]
        Grades GetGradeById(int entityToGetById);
        [OperationContract]
        int GetIdOfGrade(Grades entityToGetId);
        //[OperationContract]
        //void RemoveGrade(Grades entityToRemove);
        [OperationContract]
        void RemoveGradeById(int entityToRemoveById);
        [OperationContract]
        void UpdateGrade(Grades entityToUpdate);
        #endregion

        #region Managers operations
        //[OperationContract]
        //void AddManager(Managers entityToAdd);
        //[OperationContract]
        //IEnumerable<Managers> FindManagers(Expression<Func<Managers, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<Managers> GetAllManagers();
        [OperationContract]
        Managers GetManagerById(int entityToGetById);
        [OperationContract]
        int GetIdOfManager(Managers entityToGetId);
        //[OperationContract]
        //void RemoveManager(Managers entityToRemove);
        //[OperationContract]
        //void RemoveManagerById(int entityToRemoveById);
        [OperationContract]
        void UpdateManager(Managers entityToUpdate);
        #endregion

        #region Messages operations
        [OperationContract]
        void AddMessage(Messages entityToAdd);
        //[OperationContract]
        //IEnumerable<Messages> FindMessages(Expression<Func<Messages, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<Messages> GetAllMessages();
        [OperationContract]
        Messages GetMessageById(int entityToGetById);
        [OperationContract]
        int GetIdOfMessage(Messages entityToGetId);
        [OperationContract]
        IEnumerable<Messages> GetReceivedMessages(int userId);
        [OperationContract]
        IEnumerable<Messages> GetSentMessages(int userId);
        //[OperationContract]
        //void RemoveMessage(Messages entityToRemove);
        [OperationContract]
        void RemoveMessageById(int entityToRemoveById);
        [OperationContract]
        void UpdateMessage(Messages entityToUpdate);
        #endregion

        #region Semesters operations
        [OperationContract]
        void AddSemester(Semesters entityToAdd);
        //[OperationContract]
        //IEnumerable<Semesters> FindSemesters(Expression<Func<Semesters, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<Semesters> GetAllSemesters();
        [OperationContract]
        Semesters GetSemesterById(int entityToGetById);
        [OperationContract]
        int GetIdOfSemester(Semesters entityToGetId);
        //[OperationContract]
        //void RemoveSemester(Semesters entityToRemove);
        [OperationContract]
        void RemoveSemesterById(int entityToRemoveById);
        [OperationContract]
        void UpdateSemester(Semesters entityToUpdate);
        #endregion

        #region Students operations
        //[OperationContract]
        //void AddStudent(Students entityToAdd);
        //[OperationContract]
        //IEnumerable<Students> FindStudents(Expression<Func<Students, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<Students> GetAllStudents();
        [OperationContract]
        Students GetStudentById(int entityToGetById);
        [OperationContract]
        int GetIdOfStudent(Students entityToGetId);
        //[OperationContract]
        //void RemoveStudent(Students entityToRemove);
        //[OperationContract]
        //void RemoveStudentById(int entityToRemoveById);
        [OperationContract]
        void UpdateStudent(Students entityToUpdate);
        #endregion

        #region Subjects operations
        [OperationContract]
        void AddSubject(Subjects entityToAdd);
        //[OperationContract]
        //IEnumerable<Subjects> FindSubjects(Expression<Func<Subjects, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<Subjects> GetAllSubjects();
        [OperationContract]
        Subjects GetSubjectById(int entityToGetById);
        [OperationContract]
        int GetIdOfSubject(Subjects entityToGetId);
        //[OperationContract]
        //void RemoveSubject(Subjects entityToRemove);
        [OperationContract]
        void RemoveSubjectById(int entityToRemoveById);
        [OperationContract]
        void UpdateSubject(Subjects entityToUpdate);
        #endregion

        #region SubjectsUsers operations
        [OperationContract]
        void AddSubjectsUser(SubjectsUsers entityToAdd);
        //[OperationContract]
        //IEnumerable<SubjectsUsers> FindSubjectsUsers(Expression<Func<SubjectsUsers, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<SubjectsUsers> GetAllSubjectsUsers();
        [OperationContract]
        int GetRegisteredStudentsCount(Subjects subject);
        [OperationContract]
        int GetRegisteredTeachersCount(Subjects subject);
        [OperationContract]
        Users GetSubjectTeacher(Subjects subject);
        [OperationContract]
        SubjectsUsers GetSubjectsUserById(int entityToGetById);
        [OperationContract]
        int GetIdOfSubjectsUser(SubjectsUsers entityToGetId);
        [OperationContract]
        void RegisterUserToSubject(Users user, Subjects subject);
        //[OperationContract]
        //void RemoveSubjectsUser(SubjectsUsers entityToRemove);
        [OperationContract]
        void RemoveSubjectsUserById(int entityToRemoveById);
        [OperationContract]
        void UpdateSubjectsUser(SubjectsUsers entityToUpdate);
        #endregion

        #region Teachers operations
        //[OperationContract]
        //void AddTeacher(Teachers entityToAdd);
        //[OperationContract]
        //IEnumerable<Teachers> FindTeachers(Expression<Func<Teachers, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<Teachers> GetAllTeachers();
        [OperationContract]
        Teachers GetTeacherById(int entityToGetById);
        [OperationContract]
        int GetIdOfTeacher(Teachers entityToGetId);
        //[OperationContract]
        //void RemoveTeacher(Teachers entityToRemove);
        //[OperationContract]
        //void RemoveTeacherById(int entityToRemoveById);
        [OperationContract]
        void UpdateTeacher(Teachers entityToUpdate);
        #endregion

        #region Users operations
        [OperationContract]
        void AddUser(Users entityToAdd);
        //[OperationContract]
        //IEnumerable<Users> FindUsers(Expression<Func<Users, bool>> filterPredicate);
        [OperationContract]
        IEnumerable<Users> GetAllUsers();
        [OperationContract]
        Users GetUserById(int entityToGetById);
        [OperationContract]
        int GetIdOfUser(Users entityToGetId);
        //[OperationContract]
        //void RemoveUser(Users entityToRemove);
        [OperationContract]
        void RemoveUserById(int entityToRemoveById);
        [OperationContract]
        int GetUserId(Users user);
        [OperationContract]
        IEnumerable<Users> GetTeachersFromUsers();
        [OperationContract]
        bool Login(string eduId, string password);
        [OperationContract]
        void UpdateUser(Users entityToUpdate);
        #endregion

        #region Other operations
        [OperationContract]
        AppInfo GetAppInfo();
        //[OperationContract]
        //void SaveChanges();
        #endregion

    }

    [DataContract]
    public class AppInfo
    {
        [DataMember]
        public string Version { get; set; } = "0.9";
        [DataMember]
        public string AppName { get; set; } = "EduConnect";
        [DataMember]
        public string Maker { get; set; } = "BBB Solutions";
    }

    [DataContract]
    public class Administrators
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string AdminIdentifier { get; set; }
        [DataMember]
        public Nullable<int> UserId { get; set; }
    }

    [DataContract]
    public class Exams
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exams()
        {
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<System.DateTime> InsertDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ModifyDate { get; set; }
        [DataMember]
        public Nullable<int> ModifiedBy { get; set; }
        [DataMember]
        public string ExamType { get; set; }
        [DataMember]
        public Nullable<int> SubjectID { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ExamDate { get; set; }
        [DataMember]
        public Nullable<int> Limit { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Room { get; set; }
    }

    [DataContract]
    public class ExamsUsers
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<System.DateTime> InsertDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ModifyDate { get; set; }
        [DataMember]
        public Nullable<int> ModifiedBy { get; set; }
        [DataMember]
        public Nullable<int> ExamId { get; set; }
        [DataMember]
        public Nullable<int> UserId { get; set; }
    }

    [DataContract]
    public class Grades
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<System.DateTime> InsertDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ModifyDate { get; set; }
        [DataMember]
        public Nullable<int> ModifiedBy { get; set; }
        [DataMember]
        public Nullable<short> Grade { get; set; }
        [DataMember]
        public Nullable<int> UserId { get; set; }
        [DataMember]
        public Nullable<int> SubjectId { get; set; }
        [DataMember]
        public Nullable<int> ExamId { get; set; }
    }

    [DataContract]
    public class Managers
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ManagerIdentifier { get; set; }
        [DataMember]
        public Nullable<int> UserId { get; set; }
    }

    [DataContract]
    public class Messages
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<System.DateTime> SentDate { get; set; }
        [DataMember]
        public Nullable<int> FromUserId { get; set; }
        [DataMember]
        public Nullable<int> ToUserId { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public Nullable<bool> FromHighlighted { get; set; }
        [DataMember]
        public Nullable<bool> ToHighlighted { get; set; }
        [DataMember]
        public Nullable<bool> FromDeleted { get; set; }
        [DataMember]
        public Nullable<bool> ToDeleted { get; set; }
        [DataMember]
        public Nullable<bool> FromDeletedPerm { get; set; }
        [DataMember]
        public Nullable<bool> ToDeletedPerm { get; set; }
        [DataMember]
        public Nullable<bool> Read { get; set; }
    }

    [DataContract]
    public class Semesters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Semesters()
        {
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Description { get; set; }
    }

    [DataContract]
    public class Students
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string StudyForm { get; set; }
        [DataMember]
        public Nullable<int> UserId { get; set; }
    }

    [DataContract]
    public class Subjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subjects()
        {
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string SubjectName { get; set; }
        [DataMember]
        public Nullable<int> SemesterId { get; set; }
        [DataMember]
        public Nullable<byte> Credits { get; set; }
        [DataMember]
        public string SubjectCode { get; set; }
    }

    [DataContract]
    public class SubjectsUsers
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<System.DateTime> EnrollDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ModifyDate { get; set; }
        [DataMember]
        public Nullable<int> ModifiedBy { get; set; }
        [DataMember]
        public Nullable<int> SubjectId { get; set; }
        [DataMember]
        public Nullable<int> UserId { get; set; }
    }

    [DataContract]
    public class Teachers
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> Rank { get; set; }
        [DataMember]
        public Nullable<int> UserId { get; set; }
    }

    [DataContract]
    public class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<System.DateTime> InsertDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ModifyDate { get; set; }
        [DataMember]
        public Nullable<int> ModifiedBy { get; set; }
        [DataMember]
        public string EduId { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public Nullable<bool> Active { get; set; }
        [DataMember]
        public string UserType { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string MothersName { get; set; }
        [DataMember]
        public Nullable<System.DateTime> BirthDate { get; set; }
        [DataMember]
        public string BirthPlace { get; set; }
        [DataMember]
        public string Nationality { get; set; }
        [DataMember]
        public string PersonalId { get; set; }
        [DataMember]
        public string MedicalCardId { get; set; }
        [DataMember]
        public Nullable<int> SemesterId { get; set; }
        [DataMember]
        public string SemesterState { get; set; }
        [DataMember]
        public string EduCardId { get; set; }
        [DataMember]
        public string Email { get; set; }
    }




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