﻿namespace QA.SeeSharp.RentalApp.Data.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        public BaseEntity()
        {
            CreatedOn = DateTime.Now;
        }
    }
}
