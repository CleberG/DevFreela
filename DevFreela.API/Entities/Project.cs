using DevFreela.API.Eums;

namespace DevFreela.API.Entities
{
    public class Project
    {
        public string Title { get; private set; }

        public string Description { get; private set; }

        public int IdCliente { get; private set; }

        public User Cliente { get; private set; }

        public int IdFreelancer { get; private set; }

        public User Freelancer { get; private set; }

        public decimal TotalCost { get; private set; }

        public DateTime? StartedAt { get; private set; }

        public DateTime? CompletedAt { get; private set; }

        public ProjectStatusEnum Status { get; private set; }

    }
}
