namespace EduServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Administrators", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class Administrators : object
    {
        
        private string AdminIdentifierField;
        
        private int IdField;
        
        private System.Nullable<int> UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AdminIdentifier
        {
            get
            {
                return this.AdminIdentifierField;
            }
            set
            {
                this.AdminIdentifierField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Exams", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class Exams : object
    {
        
        private string DescriptionField;
        
        private System.Nullable<System.DateTime> ExamDateField;
        
        private string ExamTypeField;
        
        private int IdField;
        
        private System.Nullable<System.DateTime> InsertDateField;
        
        private System.Nullable<int> LimitField;
        
        private System.Nullable<int> ModifiedByField;
        
        private System.Nullable<System.DateTime> ModifyDateField;
        
        private string RoomField;
        
        private System.Nullable<int> SubjectIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ExamDate
        {
            get
            {
                return this.ExamDateField;
            }
            set
            {
                this.ExamDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExamType
        {
            get
            {
                return this.ExamTypeField;
            }
            set
            {
                this.ExamTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> InsertDate
        {
            get
            {
                return this.InsertDateField;
            }
            set
            {
                this.InsertDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Limit
        {
            get
            {
                return this.LimitField;
            }
            set
            {
                this.LimitField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ModifiedBy
        {
            get
            {
                return this.ModifiedByField;
            }
            set
            {
                this.ModifiedByField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModifyDate
        {
            get
            {
                return this.ModifyDateField;
            }
            set
            {
                this.ModifyDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Room
        {
            get
            {
                return this.RoomField;
            }
            set
            {
                this.RoomField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SubjectID
        {
            get
            {
                return this.SubjectIDField;
            }
            set
            {
                this.SubjectIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExamsUsers", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class ExamsUsers : object
    {
        
        private System.Nullable<int> ExamIdField;
        
        private int IdField;
        
        private System.Nullable<System.DateTime> InsertDateField;
        
        private System.Nullable<int> ModifiedByField;
        
        private System.Nullable<System.DateTime> ModifyDateField;
        
        private System.Nullable<int> UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ExamId
        {
            get
            {
                return this.ExamIdField;
            }
            set
            {
                this.ExamIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> InsertDate
        {
            get
            {
                return this.InsertDateField;
            }
            set
            {
                this.InsertDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ModifiedBy
        {
            get
            {
                return this.ModifiedByField;
            }
            set
            {
                this.ModifiedByField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModifyDate
        {
            get
            {
                return this.ModifyDateField;
            }
            set
            {
                this.ModifyDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Users", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class Users : object
    {
        
        private System.Nullable<bool> ActiveField;
        
        private System.Nullable<System.DateTime> BirthDateField;
        
        private string BirthPlaceField;
        
        private string EduCardIdField;
        
        private string EduIdField;
        
        private string EmailField;
        
        private string FirstNameField;
        
        private int IdField;
        
        private System.Nullable<System.DateTime> InsertDateField;
        
        private string LastNameField;
        
        private string MedicalCardIdField;
        
        private string MiddleNameField;
        
        private System.Nullable<int> ModifiedByField;
        
        private System.Nullable<System.DateTime> ModifyDateField;
        
        private string MothersNameField;
        
        private string NationalityField;
        
        private string PasswordField;
        
        private string PersonalIdField;
        
        private System.Nullable<int> SemesterIdField;
        
        private string SemesterStateField;
        
        private string UserTypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Active
        {
            get
            {
                return this.ActiveField;
            }
            set
            {
                this.ActiveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> BirthDate
        {
            get
            {
                return this.BirthDateField;
            }
            set
            {
                this.BirthDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BirthPlace
        {
            get
            {
                return this.BirthPlaceField;
            }
            set
            {
                this.BirthPlaceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EduCardId
        {
            get
            {
                return this.EduCardIdField;
            }
            set
            {
                this.EduCardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EduId
        {
            get
            {
                return this.EduIdField;
            }
            set
            {
                this.EduIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> InsertDate
        {
            get
            {
                return this.InsertDateField;
            }
            set
            {
                this.InsertDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MedicalCardId
        {
            get
            {
                return this.MedicalCardIdField;
            }
            set
            {
                this.MedicalCardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName
        {
            get
            {
                return this.MiddleNameField;
            }
            set
            {
                this.MiddleNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ModifiedBy
        {
            get
            {
                return this.ModifiedByField;
            }
            set
            {
                this.ModifiedByField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModifyDate
        {
            get
            {
                return this.ModifyDateField;
            }
            set
            {
                this.ModifyDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MothersName
        {
            get
            {
                return this.MothersNameField;
            }
            set
            {
                this.MothersNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nationality
        {
            get
            {
                return this.NationalityField;
            }
            set
            {
                this.NationalityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PersonalId
        {
            get
            {
                return this.PersonalIdField;
            }
            set
            {
                this.PersonalIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SemesterId
        {
            get
            {
                return this.SemesterIdField;
            }
            set
            {
                this.SemesterIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SemesterState
        {
            get
            {
                return this.SemesterStateField;
            }
            set
            {
                this.SemesterStateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserType
        {
            get
            {
                return this.UserTypeField;
            }
            set
            {
                this.UserTypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Grades", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class Grades : object
    {
        
        private System.Nullable<int> ExamIdField;
        
        private System.Nullable<short> GradeField;
        
        private int IdField;
        
        private System.Nullable<System.DateTime> InsertDateField;
        
        private System.Nullable<int> ModifiedByField;
        
        private System.Nullable<System.DateTime> ModifyDateField;
        
        private System.Nullable<int> SubjectIdField;
        
        private System.Nullable<int> UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ExamId
        {
            get
            {
                return this.ExamIdField;
            }
            set
            {
                this.ExamIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> Grade
        {
            get
            {
                return this.GradeField;
            }
            set
            {
                this.GradeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> InsertDate
        {
            get
            {
                return this.InsertDateField;
            }
            set
            {
                this.InsertDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ModifiedBy
        {
            get
            {
                return this.ModifiedByField;
            }
            set
            {
                this.ModifiedByField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModifyDate
        {
            get
            {
                return this.ModifyDateField;
            }
            set
            {
                this.ModifyDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SubjectId
        {
            get
            {
                return this.SubjectIdField;
            }
            set
            {
                this.SubjectIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Managers", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class Managers : object
    {
        
        private int IdField;
        
        private string ManagerIdentifierField;
        
        private System.Nullable<int> UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ManagerIdentifier
        {
            get
            {
                return this.ManagerIdentifierField;
            }
            set
            {
                this.ManagerIdentifierField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Messages", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class Messages : object
    {
        
        private System.Nullable<bool> FromDeletedField;
        
        private System.Nullable<bool> FromDeletedPermField;
        
        private System.Nullable<bool> FromHighlightedField;
        
        private System.Nullable<int> FromUserIdField;
        
        private int IdField;
        
        private string MessageField;
        
        private System.Nullable<bool> ReadField;
        
        private System.Nullable<System.DateTime> SentDateField;
        
        private string SubjectField;
        
        private System.Nullable<bool> ToDeletedField;
        
        private System.Nullable<bool> ToDeletedPermField;
        
        private System.Nullable<bool> ToHighlightedField;
        
        private System.Nullable<int> ToUserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> FromDeleted
        {
            get
            {
                return this.FromDeletedField;
            }
            set
            {
                this.FromDeletedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> FromDeletedPerm
        {
            get
            {
                return this.FromDeletedPermField;
            }
            set
            {
                this.FromDeletedPermField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> FromHighlighted
        {
            get
            {
                return this.FromHighlightedField;
            }
            set
            {
                this.FromHighlightedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> FromUserId
        {
            get
            {
                return this.FromUserIdField;
            }
            set
            {
                this.FromUserIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Read
        {
            get
            {
                return this.ReadField;
            }
            set
            {
                this.ReadField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> SentDate
        {
            get
            {
                return this.SentDateField;
            }
            set
            {
                this.SentDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject
        {
            get
            {
                return this.SubjectField;
            }
            set
            {
                this.SubjectField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> ToDeleted
        {
            get
            {
                return this.ToDeletedField;
            }
            set
            {
                this.ToDeletedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> ToDeletedPerm
        {
            get
            {
                return this.ToDeletedPermField;
            }
            set
            {
                this.ToDeletedPermField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> ToHighlighted
        {
            get
            {
                return this.ToHighlightedField;
            }
            set
            {
                this.ToHighlightedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ToUserId
        {
            get
            {
                return this.ToUserIdField;
            }
            set
            {
                this.ToUserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Semesters", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class Semesters : object
    {
        
        private string DescriptionField;
        
        private int IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Students", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class Students : object
    {
        
        private int IdField;
        
        private string StudyFormField;
        
        private System.Nullable<int> UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudyForm
        {
            get
            {
                return this.StudyFormField;
            }
            set
            {
                this.StudyFormField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Subjects", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class Subjects : object
    {
        
        private System.Nullable<byte> CreditsField;
        
        private int IdField;
        
        private System.Nullable<int> SemesterIdField;
        
        private string SubjectCodeField;
        
        private string SubjectNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<byte> Credits
        {
            get
            {
                return this.CreditsField;
            }
            set
            {
                this.CreditsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SemesterId
        {
            get
            {
                return this.SemesterIdField;
            }
            set
            {
                this.SemesterIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubjectCode
        {
            get
            {
                return this.SubjectCodeField;
            }
            set
            {
                this.SubjectCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubjectName
        {
            get
            {
                return this.SubjectNameField;
            }
            set
            {
                this.SubjectNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SubjectsUsers", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class SubjectsUsers : object
    {
        
        private System.Nullable<System.DateTime> EnrollDateField;
        
        private int IdField;
        
        private System.Nullable<int> ModifiedByField;
        
        private System.Nullable<System.DateTime> ModifyDateField;
        
        private System.Nullable<int> SubjectIdField;
        
        private System.Nullable<int> UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> EnrollDate
        {
            get
            {
                return this.EnrollDateField;
            }
            set
            {
                this.EnrollDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ModifiedBy
        {
            get
            {
                return this.ModifiedByField;
            }
            set
            {
                this.ModifiedByField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModifyDate
        {
            get
            {
                return this.ModifyDateField;
            }
            set
            {
                this.ModifyDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SubjectId
        {
            get
            {
                return this.SubjectIdField;
            }
            set
            {
                this.SubjectIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Teachers", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class Teachers : object
    {
        
        private int IdField;
        
        private System.Nullable<int> RankField;
        
        private System.Nullable<int> UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Rank
        {
            get
            {
                return this.RankField;
            }
            set
            {
                this.RankField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AppInfo", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    public partial class AppInfo : object
    {
        
        private string AppNameField;
        
        private string MakerField;
        
        private string VersionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AppName
        {
            get
            {
                return this.AppNameField;
            }
            set
            {
                this.AppNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Maker
        {
            get
            {
                return this.MakerField;
            }
            set
            {
                this.MakerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Version
        {
            get
            {
                return this.VersionField;
            }
            set
            {
                this.VersionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EduServiceReference.IService")]
    public interface IService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllAdministrators", ReplyAction="http://tempuri.org/IService/GetAllAdministratorsResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Administrators[]> GetAllAdministratorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAdministratorById", ReplyAction="http://tempuri.org/IService/GetAdministratorByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Administrators> GetAdministratorByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfAdministrator", ReplyAction="http://tempuri.org/IService/GetIdOfAdministratorResponse")]
        System.Threading.Tasks.Task<int> GetIdOfAdministratorAsync(EduServiceReference.Administrators entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateAdministrator", ReplyAction="http://tempuri.org/IService/UpdateAdministratorResponse")]
        System.Threading.Tasks.Task UpdateAdministratorAsync(EduServiceReference.Administrators entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddExam", ReplyAction="http://tempuri.org/IService/AddExamResponse")]
        System.Threading.Tasks.Task AddExamAsync(EduServiceReference.Exams entityToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllExams", ReplyAction="http://tempuri.org/IService/GetAllExamsResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Exams[]> GetAllExamsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetExamById", ReplyAction="http://tempuri.org/IService/GetExamByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Exams> GetExamByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfExam", ReplyAction="http://tempuri.org/IService/GetIdOfExamResponse")]
        System.Threading.Tasks.Task<int> GetIdOfExamAsync(EduServiceReference.Exams entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveExamById", ReplyAction="http://tempuri.org/IService/RemoveExamByIdResponse")]
        System.Threading.Tasks.Task RemoveExamByIdAsync(int entityToRemoveById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateExam", ReplyAction="http://tempuri.org/IService/UpdateExamResponse")]
        System.Threading.Tasks.Task UpdateExamAsync(EduServiceReference.Exams entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddExamsUser", ReplyAction="http://tempuri.org/IService/AddExamsUserResponse")]
        System.Threading.Tasks.Task AddExamsUserAsync(EduServiceReference.ExamsUsers entityToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllExamsUsers", ReplyAction="http://tempuri.org/IService/GetAllExamsUsersResponse")]
        System.Threading.Tasks.Task<EduServiceReference.ExamsUsers[]> GetAllExamsUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetExamsUserById", ReplyAction="http://tempuri.org/IService/GetExamsUserByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.ExamsUsers> GetExamsUserByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfExamsUser", ReplyAction="http://tempuri.org/IService/GetIdOfExamsUserResponse")]
        System.Threading.Tasks.Task<int> GetIdOfExamsUserAsync(EduServiceReference.ExamsUsers entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveExamsUserById", ReplyAction="http://tempuri.org/IService/RemoveExamsUserByIdResponse")]
        System.Threading.Tasks.Task RemoveExamsUserByIdAsync(int entityToRemoveById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetExamStudents", ReplyAction="http://tempuri.org/IService/GetExamStudentsResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Users[]> GetExamStudentsAsync(int examId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetExamTeacher", ReplyAction="http://tempuri.org/IService/GetExamTeacherResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Users> GetExamTeacherAsync(int examId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateExamsUser", ReplyAction="http://tempuri.org/IService/UpdateExamsUserResponse")]
        System.Threading.Tasks.Task UpdateExamsUserAsync(EduServiceReference.ExamsUsers entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddGrade", ReplyAction="http://tempuri.org/IService/AddGradeResponse")]
        System.Threading.Tasks.Task AddGradeAsync(EduServiceReference.Grades entityToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllGrades", ReplyAction="http://tempuri.org/IService/GetAllGradesResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Grades[]> GetAllGradesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetGradeById", ReplyAction="http://tempuri.org/IService/GetGradeByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Grades> GetGradeByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfGrade", ReplyAction="http://tempuri.org/IService/GetIdOfGradeResponse")]
        System.Threading.Tasks.Task<int> GetIdOfGradeAsync(EduServiceReference.Grades entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveGradeById", ReplyAction="http://tempuri.org/IService/RemoveGradeByIdResponse")]
        System.Threading.Tasks.Task RemoveGradeByIdAsync(int entityToRemoveById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateGrade", ReplyAction="http://tempuri.org/IService/UpdateGradeResponse")]
        System.Threading.Tasks.Task UpdateGradeAsync(EduServiceReference.Grades entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllManagers", ReplyAction="http://tempuri.org/IService/GetAllManagersResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Managers[]> GetAllManagersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetManagerById", ReplyAction="http://tempuri.org/IService/GetManagerByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Managers> GetManagerByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfManager", ReplyAction="http://tempuri.org/IService/GetIdOfManagerResponse")]
        System.Threading.Tasks.Task<int> GetIdOfManagerAsync(EduServiceReference.Managers entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateManager", ReplyAction="http://tempuri.org/IService/UpdateManagerResponse")]
        System.Threading.Tasks.Task UpdateManagerAsync(EduServiceReference.Managers entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddMessage", ReplyAction="http://tempuri.org/IService/AddMessageResponse")]
        System.Threading.Tasks.Task AddMessageAsync(EduServiceReference.Messages entityToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllMessages", ReplyAction="http://tempuri.org/IService/GetAllMessagesResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Messages[]> GetAllMessagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMessageById", ReplyAction="http://tempuri.org/IService/GetMessageByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Messages> GetMessageByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfMessage", ReplyAction="http://tempuri.org/IService/GetIdOfMessageResponse")]
        System.Threading.Tasks.Task<int> GetIdOfMessageAsync(EduServiceReference.Messages entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetReceivedMessages", ReplyAction="http://tempuri.org/IService/GetReceivedMessagesResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Messages[]> GetReceivedMessagesAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSentMessages", ReplyAction="http://tempuri.org/IService/GetSentMessagesResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Messages[]> GetSentMessagesAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveMessageById", ReplyAction="http://tempuri.org/IService/RemoveMessageByIdResponse")]
        System.Threading.Tasks.Task RemoveMessageByIdAsync(int entityToRemoveById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateMessage", ReplyAction="http://tempuri.org/IService/UpdateMessageResponse")]
        System.Threading.Tasks.Task UpdateMessageAsync(EduServiceReference.Messages entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddSemester", ReplyAction="http://tempuri.org/IService/AddSemesterResponse")]
        System.Threading.Tasks.Task AddSemesterAsync(EduServiceReference.Semesters entityToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllSemesters", ReplyAction="http://tempuri.org/IService/GetAllSemestersResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Semesters[]> GetAllSemestersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSemesterById", ReplyAction="http://tempuri.org/IService/GetSemesterByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Semesters> GetSemesterByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfSemester", ReplyAction="http://tempuri.org/IService/GetIdOfSemesterResponse")]
        System.Threading.Tasks.Task<int> GetIdOfSemesterAsync(EduServiceReference.Semesters entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveSemesterById", ReplyAction="http://tempuri.org/IService/RemoveSemesterByIdResponse")]
        System.Threading.Tasks.Task RemoveSemesterByIdAsync(int entityToRemoveById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateSemester", ReplyAction="http://tempuri.org/IService/UpdateSemesterResponse")]
        System.Threading.Tasks.Task UpdateSemesterAsync(EduServiceReference.Semesters entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllStudents", ReplyAction="http://tempuri.org/IService/GetAllStudentsResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Students[]> GetAllStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudentById", ReplyAction="http://tempuri.org/IService/GetStudentByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Students> GetStudentByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfStudent", ReplyAction="http://tempuri.org/IService/GetIdOfStudentResponse")]
        System.Threading.Tasks.Task<int> GetIdOfStudentAsync(EduServiceReference.Students entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateStudent", ReplyAction="http://tempuri.org/IService/UpdateStudentResponse")]
        System.Threading.Tasks.Task UpdateStudentAsync(EduServiceReference.Students entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddSubject", ReplyAction="http://tempuri.org/IService/AddSubjectResponse")]
        System.Threading.Tasks.Task AddSubjectAsync(EduServiceReference.Subjects entityToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllSubjects", ReplyAction="http://tempuri.org/IService/GetAllSubjectsResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Subjects[]> GetAllSubjectsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSubjectById", ReplyAction="http://tempuri.org/IService/GetSubjectByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Subjects> GetSubjectByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfSubject", ReplyAction="http://tempuri.org/IService/GetIdOfSubjectResponse")]
        System.Threading.Tasks.Task<int> GetIdOfSubjectAsync(EduServiceReference.Subjects entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveSubjectById", ReplyAction="http://tempuri.org/IService/RemoveSubjectByIdResponse")]
        System.Threading.Tasks.Task RemoveSubjectByIdAsync(int entityToRemoveById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateSubject", ReplyAction="http://tempuri.org/IService/UpdateSubjectResponse")]
        System.Threading.Tasks.Task UpdateSubjectAsync(EduServiceReference.Subjects entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddSubjectsUser", ReplyAction="http://tempuri.org/IService/AddSubjectsUserResponse")]
        System.Threading.Tasks.Task AddSubjectsUserAsync(EduServiceReference.SubjectsUsers entityToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllSubjectsUsers", ReplyAction="http://tempuri.org/IService/GetAllSubjectsUsersResponse")]
        System.Threading.Tasks.Task<EduServiceReference.SubjectsUsers[]> GetAllSubjectsUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetRegisteredStudentsCount", ReplyAction="http://tempuri.org/IService/GetRegisteredStudentsCountResponse")]
        System.Threading.Tasks.Task<int> GetRegisteredStudentsCountAsync(EduServiceReference.Subjects subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetRegisteredTeachersCount", ReplyAction="http://tempuri.org/IService/GetRegisteredTeachersCountResponse")]
        System.Threading.Tasks.Task<int> GetRegisteredTeachersCountAsync(EduServiceReference.Subjects subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSubjectTeacher", ReplyAction="http://tempuri.org/IService/GetSubjectTeacherResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Users> GetSubjectTeacherAsync(EduServiceReference.Subjects subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSubjectsUserById", ReplyAction="http://tempuri.org/IService/GetSubjectsUserByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.SubjectsUsers> GetSubjectsUserByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfSubjectsUser", ReplyAction="http://tempuri.org/IService/GetIdOfSubjectsUserResponse")]
        System.Threading.Tasks.Task<int> GetIdOfSubjectsUserAsync(EduServiceReference.SubjectsUsers entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RegisterUserToSubject", ReplyAction="http://tempuri.org/IService/RegisterUserToSubjectResponse")]
        System.Threading.Tasks.Task RegisterUserToSubjectAsync(EduServiceReference.Users user, EduServiceReference.Subjects subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveSubjectsUserById", ReplyAction="http://tempuri.org/IService/RemoveSubjectsUserByIdResponse")]
        System.Threading.Tasks.Task RemoveSubjectsUserByIdAsync(int entityToRemoveById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateSubjectsUser", ReplyAction="http://tempuri.org/IService/UpdateSubjectsUserResponse")]
        System.Threading.Tasks.Task UpdateSubjectsUserAsync(EduServiceReference.SubjectsUsers entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllTeachers", ReplyAction="http://tempuri.org/IService/GetAllTeachersResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Teachers[]> GetAllTeachersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTeacherById", ReplyAction="http://tempuri.org/IService/GetTeacherByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Teachers> GetTeacherByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfTeacher", ReplyAction="http://tempuri.org/IService/GetIdOfTeacherResponse")]
        System.Threading.Tasks.Task<int> GetIdOfTeacherAsync(EduServiceReference.Teachers entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateTeacher", ReplyAction="http://tempuri.org/IService/UpdateTeacherResponse")]
        System.Threading.Tasks.Task UpdateTeacherAsync(EduServiceReference.Teachers entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddUser", ReplyAction="http://tempuri.org/IService/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(EduServiceReference.Users entityToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllUsers", ReplyAction="http://tempuri.org/IService/GetAllUsersResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Users[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUserById", ReplyAction="http://tempuri.org/IService/GetUserByIdResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Users> GetUserByIdAsync(int entityToGetById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIdOfUser", ReplyAction="http://tempuri.org/IService/GetIdOfUserResponse")]
        System.Threading.Tasks.Task<int> GetIdOfUserAsync(EduServiceReference.Users entityToGetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RemoveUserById", ReplyAction="http://tempuri.org/IService/RemoveUserByIdResponse")]
        System.Threading.Tasks.Task RemoveUserByIdAsync(int entityToRemoveById);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUserId", ReplyAction="http://tempuri.org/IService/GetUserIdResponse")]
        System.Threading.Tasks.Task<int> GetUserIdAsync(EduServiceReference.Users user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTeachersFromUsers", ReplyAction="http://tempuri.org/IService/GetTeachersFromUsersResponse")]
        System.Threading.Tasks.Task<EduServiceReference.Users[]> GetTeachersFromUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Login", ReplyAction="http://tempuri.org/IService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string eduId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateUser", ReplyAction="http://tempuri.org/IService/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(EduServiceReference.Users entityToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAppInfo", ReplyAction="http://tempuri.org/IService/GetAppInfoResponse")]
        System.Threading.Tasks.Task<EduServiceReference.AppInfo> GetAppInfoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    public interface IServiceChannel : EduServiceReference.IService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<EduServiceReference.IService>, EduServiceReference.IService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceClient() : 
                base(ServiceClient.GetDefaultBinding(), ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ServiceEndpoint.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Administrators[]> GetAllAdministratorsAsync()
        {
            return base.Channel.GetAllAdministratorsAsync();
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Administrators> GetAdministratorByIdAsync(int entityToGetById)
        {
            return base.Channel.GetAdministratorByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfAdministratorAsync(EduServiceReference.Administrators entityToGetId)
        {
            return base.Channel.GetIdOfAdministratorAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task UpdateAdministratorAsync(EduServiceReference.Administrators entityToUpdate)
        {
            return base.Channel.UpdateAdministratorAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task AddExamAsync(EduServiceReference.Exams entityToAdd)
        {
            return base.Channel.AddExamAsync(entityToAdd);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Exams[]> GetAllExamsAsync()
        {
            return base.Channel.GetAllExamsAsync();
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Exams> GetExamByIdAsync(int entityToGetById)
        {
            return base.Channel.GetExamByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfExamAsync(EduServiceReference.Exams entityToGetId)
        {
            return base.Channel.GetIdOfExamAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task RemoveExamByIdAsync(int entityToRemoveById)
        {
            return base.Channel.RemoveExamByIdAsync(entityToRemoveById);
        }
        
        public System.Threading.Tasks.Task UpdateExamAsync(EduServiceReference.Exams entityToUpdate)
        {
            return base.Channel.UpdateExamAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task AddExamsUserAsync(EduServiceReference.ExamsUsers entityToAdd)
        {
            return base.Channel.AddExamsUserAsync(entityToAdd);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.ExamsUsers[]> GetAllExamsUsersAsync()
        {
            return base.Channel.GetAllExamsUsersAsync();
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.ExamsUsers> GetExamsUserByIdAsync(int entityToGetById)
        {
            return base.Channel.GetExamsUserByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfExamsUserAsync(EduServiceReference.ExamsUsers entityToGetId)
        {
            return base.Channel.GetIdOfExamsUserAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task RemoveExamsUserByIdAsync(int entityToRemoveById)
        {
            return base.Channel.RemoveExamsUserByIdAsync(entityToRemoveById);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Users[]> GetExamStudentsAsync(int examId)
        {
            return base.Channel.GetExamStudentsAsync(examId);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Users> GetExamTeacherAsync(int examId)
        {
            return base.Channel.GetExamTeacherAsync(examId);
        }
        
        public System.Threading.Tasks.Task UpdateExamsUserAsync(EduServiceReference.ExamsUsers entityToUpdate)
        {
            return base.Channel.UpdateExamsUserAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task AddGradeAsync(EduServiceReference.Grades entityToAdd)
        {
            return base.Channel.AddGradeAsync(entityToAdd);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Grades[]> GetAllGradesAsync()
        {
            return base.Channel.GetAllGradesAsync();
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Grades> GetGradeByIdAsync(int entityToGetById)
        {
            return base.Channel.GetGradeByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfGradeAsync(EduServiceReference.Grades entityToGetId)
        {
            return base.Channel.GetIdOfGradeAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task RemoveGradeByIdAsync(int entityToRemoveById)
        {
            return base.Channel.RemoveGradeByIdAsync(entityToRemoveById);
        }
        
        public System.Threading.Tasks.Task UpdateGradeAsync(EduServiceReference.Grades entityToUpdate)
        {
            return base.Channel.UpdateGradeAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Managers[]> GetAllManagersAsync()
        {
            return base.Channel.GetAllManagersAsync();
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Managers> GetManagerByIdAsync(int entityToGetById)
        {
            return base.Channel.GetManagerByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfManagerAsync(EduServiceReference.Managers entityToGetId)
        {
            return base.Channel.GetIdOfManagerAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task UpdateManagerAsync(EduServiceReference.Managers entityToUpdate)
        {
            return base.Channel.UpdateManagerAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task AddMessageAsync(EduServiceReference.Messages entityToAdd)
        {
            return base.Channel.AddMessageAsync(entityToAdd);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Messages[]> GetAllMessagesAsync()
        {
            return base.Channel.GetAllMessagesAsync();
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Messages> GetMessageByIdAsync(int entityToGetById)
        {
            return base.Channel.GetMessageByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfMessageAsync(EduServiceReference.Messages entityToGetId)
        {
            return base.Channel.GetIdOfMessageAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Messages[]> GetReceivedMessagesAsync(int userId)
        {
            return base.Channel.GetReceivedMessagesAsync(userId);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Messages[]> GetSentMessagesAsync(int userId)
        {
            return base.Channel.GetSentMessagesAsync(userId);
        }
        
        public System.Threading.Tasks.Task RemoveMessageByIdAsync(int entityToRemoveById)
        {
            return base.Channel.RemoveMessageByIdAsync(entityToRemoveById);
        }
        
        public System.Threading.Tasks.Task UpdateMessageAsync(EduServiceReference.Messages entityToUpdate)
        {
            return base.Channel.UpdateMessageAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task AddSemesterAsync(EduServiceReference.Semesters entityToAdd)
        {
            return base.Channel.AddSemesterAsync(entityToAdd);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Semesters[]> GetAllSemestersAsync()
        {
            return base.Channel.GetAllSemestersAsync();
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Semesters> GetSemesterByIdAsync(int entityToGetById)
        {
            return base.Channel.GetSemesterByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfSemesterAsync(EduServiceReference.Semesters entityToGetId)
        {
            return base.Channel.GetIdOfSemesterAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task RemoveSemesterByIdAsync(int entityToRemoveById)
        {
            return base.Channel.RemoveSemesterByIdAsync(entityToRemoveById);
        }
        
        public System.Threading.Tasks.Task UpdateSemesterAsync(EduServiceReference.Semesters entityToUpdate)
        {
            return base.Channel.UpdateSemesterAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Students[]> GetAllStudentsAsync()
        {
            return base.Channel.GetAllStudentsAsync();
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Students> GetStudentByIdAsync(int entityToGetById)
        {
            return base.Channel.GetStudentByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfStudentAsync(EduServiceReference.Students entityToGetId)
        {
            return base.Channel.GetIdOfStudentAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task UpdateStudentAsync(EduServiceReference.Students entityToUpdate)
        {
            return base.Channel.UpdateStudentAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task AddSubjectAsync(EduServiceReference.Subjects entityToAdd)
        {
            return base.Channel.AddSubjectAsync(entityToAdd);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Subjects[]> GetAllSubjectsAsync()
        {
            return base.Channel.GetAllSubjectsAsync();
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Subjects> GetSubjectByIdAsync(int entityToGetById)
        {
            return base.Channel.GetSubjectByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfSubjectAsync(EduServiceReference.Subjects entityToGetId)
        {
            return base.Channel.GetIdOfSubjectAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task RemoveSubjectByIdAsync(int entityToRemoveById)
        {
            return base.Channel.RemoveSubjectByIdAsync(entityToRemoveById);
        }
        
        public System.Threading.Tasks.Task UpdateSubjectAsync(EduServiceReference.Subjects entityToUpdate)
        {
            return base.Channel.UpdateSubjectAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task AddSubjectsUserAsync(EduServiceReference.SubjectsUsers entityToAdd)
        {
            return base.Channel.AddSubjectsUserAsync(entityToAdd);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.SubjectsUsers[]> GetAllSubjectsUsersAsync()
        {
            return base.Channel.GetAllSubjectsUsersAsync();
        }
        
        public System.Threading.Tasks.Task<int> GetRegisteredStudentsCountAsync(EduServiceReference.Subjects subject)
        {
            return base.Channel.GetRegisteredStudentsCountAsync(subject);
        }
        
        public System.Threading.Tasks.Task<int> GetRegisteredTeachersCountAsync(EduServiceReference.Subjects subject)
        {
            return base.Channel.GetRegisteredTeachersCountAsync(subject);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Users> GetSubjectTeacherAsync(EduServiceReference.Subjects subject)
        {
            return base.Channel.GetSubjectTeacherAsync(subject);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.SubjectsUsers> GetSubjectsUserByIdAsync(int entityToGetById)
        {
            return base.Channel.GetSubjectsUserByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfSubjectsUserAsync(EduServiceReference.SubjectsUsers entityToGetId)
        {
            return base.Channel.GetIdOfSubjectsUserAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task RegisterUserToSubjectAsync(EduServiceReference.Users user, EduServiceReference.Subjects subject)
        {
            return base.Channel.RegisterUserToSubjectAsync(user, subject);
        }
        
        public System.Threading.Tasks.Task RemoveSubjectsUserByIdAsync(int entityToRemoveById)
        {
            return base.Channel.RemoveSubjectsUserByIdAsync(entityToRemoveById);
        }
        
        public System.Threading.Tasks.Task UpdateSubjectsUserAsync(EduServiceReference.SubjectsUsers entityToUpdate)
        {
            return base.Channel.UpdateSubjectsUserAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Teachers[]> GetAllTeachersAsync()
        {
            return base.Channel.GetAllTeachersAsync();
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Teachers> GetTeacherByIdAsync(int entityToGetById)
        {
            return base.Channel.GetTeacherByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfTeacherAsync(EduServiceReference.Teachers entityToGetId)
        {
            return base.Channel.GetIdOfTeacherAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task UpdateTeacherAsync(EduServiceReference.Teachers entityToUpdate)
        {
            return base.Channel.UpdateTeacherAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(EduServiceReference.Users entityToAdd)
        {
            return base.Channel.AddUserAsync(entityToAdd);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Users[]> GetAllUsersAsync()
        {
            return base.Channel.GetAllUsersAsync();
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Users> GetUserByIdAsync(int entityToGetById)
        {
            return base.Channel.GetUserByIdAsync(entityToGetById);
        }
        
        public System.Threading.Tasks.Task<int> GetIdOfUserAsync(EduServiceReference.Users entityToGetId)
        {
            return base.Channel.GetIdOfUserAsync(entityToGetId);
        }
        
        public System.Threading.Tasks.Task RemoveUserByIdAsync(int entityToRemoveById)
        {
            return base.Channel.RemoveUserByIdAsync(entityToRemoveById);
        }
        
        public System.Threading.Tasks.Task<int> GetUserIdAsync(EduServiceReference.Users user)
        {
            return base.Channel.GetUserIdAsync(user);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.Users[]> GetTeachersFromUsersAsync()
        {
            return base.Channel.GetTeachersFromUsersAsync();
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string eduId, string password)
        {
            return base.Channel.LoginAsync(eduId, password);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(EduServiceReference.Users entityToUpdate)
        {
            return base.Channel.UpdateUserAsync(entityToUpdate);
        }
        
        public System.Threading.Tasks.Task<EduServiceReference.AppInfo> GetAppInfoAsync()
        {
            return base.Channel.GetAppInfoAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ServiceEndpoint))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ServiceEndpoint))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:12345/Service");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceClient.GetBindingForEndpoint(EndpointConfiguration.ServiceEndpoint);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceClient.GetEndpointAddress(EndpointConfiguration.ServiceEndpoint);
        }
        
        public enum EndpointConfiguration
        {
            
            ServiceEndpoint,
        }
    }
}
