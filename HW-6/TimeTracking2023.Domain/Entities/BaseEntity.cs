﻿namespace TimeTracking2023.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string Print();
    }
}