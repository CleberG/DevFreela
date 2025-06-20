﻿namespace DevFreela.API.Entities
{
    public abstract class BaseEntity
    {

        public int Id { get; set; }
        public DateTime CreateAt { get; private set; }

        public bool IsDeleted { get; set; }

        protected BaseEntity()
        {
            CreateAt = DateTime.Now;
            IsDeleted = false;
        }

        public void SetAsDeleted()
        {
            IsDeleted = true;
        }
    }
}
