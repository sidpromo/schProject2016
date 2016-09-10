using System.Linq;
using System.Data.Entity;
using Entities;
using System;

namespace Repository
{
    public class SubjectsUsersRepository : Repository<SubjectsUsers>, ISubjectsUsersRepository
    {
        public SubjectsUsersRepository(DbContext context) : base(context)
        {
        }

        public int GetRegisteredStudentsCount(Subjects subject)
        {
            EducationDatabaseEntities ent = new EducationDatabaseEntities();
            ISubjectsUsersRepository suRepo = new SubjectsUsersRepository(ent);
            return suRepo.GetAll().Where(x => x.SubjectId == subject.Id).Where(x => x.Users.UserType == "Student").Count();
        }

        public int GetRegisteredTeachersCount(Subjects subject)
        {
            EducationDatabaseEntities ent = new EducationDatabaseEntities();
            ISubjectsUsersRepository suRepo = new SubjectsUsersRepository(ent);
            return suRepo.GetAll().Where(x => x.SubjectId == subject.Id).Where(x => x.Users.UserType == "Teacher").Count();
        }

        public Users GetSubjectTeacher(Subjects subject)
        {
            SubjectsUsers subjUser = new SubjectsUsers();
            subjUser = GetAll().Where(u => u.SubjectId == subject.Id).FirstOrDefault();

            EducationDatabaseEntities ent = new EducationDatabaseEntities();
            ITeachersRepository teacherRepo = new TeachersRepository(ent);
            IUsersRepository userRepo = new UsersRepository(ent);

            Teachers teacher = new Teachers();
            teacher = teacherRepo.GetAll().Where(t => t.UserId == subjUser.UserId).FirstOrDefault();
            if (teacher != null)
            {
                Users CurrentUser = userRepo.GetAll().Where(u => u.Id == teacher.UserId).FirstOrDefault();
                return CurrentUser;
            }
            return null;
        }

        /// <summary>
        /// A megadott subjectuser id-ját adja vissza.
        /// </summary>
        /// <param name="subjectuser"></param>
        /// <returns></returns>
        public int GetSubjectUserId(SubjectsUsers subjectuser)
        {
            return GetAll().Where(x => x.Id == subjectuser.Id).FirstOrDefault().Id;
        }

        public void RegisterUserToSubject(Users user, Subjects subject)
        {
            EducationDatabaseEntities ent = new EducationDatabaseEntities();
            ISubjectsUsersRepository suRepo = new SubjectsUsersRepository(ent);
            bool allowOperation = (suRepo.GetAll().Where(x => x.UserId == user.Id).Where(x => x.SubjectId == subject.Id).Count() > 0); // Szerepel már benne?
            if (allowOperation)
            {
                suRepo.Add(new SubjectsUsers()
                {
                    EnrollDate = DateTime.Now,
                    SubjectId = subject.Id,
                    UserId = user.Id
                });
            }
        }
    }
}
