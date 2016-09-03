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

        public string GetSubjectTeacherName(Subjects subject)
        {
            SubjectsUsers subjUser = new SubjectsUsers();
            subjUser = GetAll().Where(u => u.SubjectId == subject.Id).FirstOrDefault();

            EducationDatabaseEntities ent = new EducationDatabaseEntities();
            TeachersRepository teacherRepo = new TeachersRepository(ent);
            UsersRepository userRepo = new UsersRepository(ent);

            Teachers teacher = new Teachers();
            teacher = teacherRepo.GetAll().Where(t => t.UserId == subjUser.UserId).FirstOrDefault();
            if (teacher != null)
            {
                Users CurrentUser = userRepo.GetAll().Where(u => u.Id == teacher.UserId).FirstOrDefault();
                string name = $"{CurrentUser.FirstName} {CurrentUser.MiddleName} {CurrentUser.LastName}";
                return name;
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

    }
}
