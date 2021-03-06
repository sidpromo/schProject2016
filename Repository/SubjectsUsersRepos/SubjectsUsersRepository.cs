﻿using System.Linq;
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
            IUsersRepository userRepo = new UsersRepository(ent);

            Users user = new Users();
            if (subjUser != null)
            {
                user = userRepo.GetAll().Where(u => u.Id == subjUser.UserId).FirstOrDefault();
                if (user != null) return user;
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
            bool containsRow = (suRepo.GetAll().Where(x => x.UserId == user.Id).Where(x => x.SubjectId == subject.Id).Count() > 0); // Szerepel már benne?
            if (!containsRow)
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
