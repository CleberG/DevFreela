﻿using DevFreela.API.Eums;

namespace DevFreela.API.Entities
{
    public class Project : BaseEntity
    {

        public Project(string title, string description, int idCliente, int idFreelancer, decimal totalCost): base()
        {
            Title = title;
            Description = description;
            IdCliente = idCliente;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;
            Status = ProjectStatusEnum.Created;
            Comments = [];
        }

        public Project()
        {
        }

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

        public IList<ProjectComment> Comments { get; set; }

        public void Cancel()
        {
            if (Status == ProjectStatusEnum.Created || Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.Canceled;
            }
        }

        public void Start()
        {
            if (Status == ProjectStatusEnum.Created)
            {
                Status = ProjectStatusEnum.InProgress;
                StartedAt = DateTime.Now;
            }
        }

        public void Complete()
        {
            if (Status == ProjectStatusEnum.PaymentPending || Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.Completed;
                CompletedAt = DateTime.Now;
            }
        }

        public void SetAsPaymentPending()
        {
            if (Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.PaymentPending;
            }
        }

        public void update(string title, string description, decimal totalCost)
        {
            Title = title;
            Description = description;
            TotalCost = totalCost;
        }


    }
}
