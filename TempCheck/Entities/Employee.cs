﻿namespace AmplituderChecker.Entities 
{
    public class Employee : EntityBase
    {

        public string? FirstName { get; set; }

        public override string ToString() => $":{Id}, FirstName: {FirstName}";


    }
}
