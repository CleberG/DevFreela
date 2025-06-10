namespace DevFreela.API.Entities
{
    public class User :BaseEntity
    {

        public string FullName { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }

        public bool Active { get; private set; }

        public IList<UserSkill> Skills { get; private set; }

        public IList<Project> OwnedProject { get; private set; }

        public IList<Project> FreelanceProject { get; private set; }

        public IList<ProjectComment> Comments { get; private set; }

        public User(string fullName, string email, DateTime birthDate) : base()
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Active = true;

            Skills = [];
            OwnedProject = [];
            FreelanceProject = [];
            Comments = [];

        }
    }
}
