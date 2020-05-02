﻿namespace ShieldTech.Validations.Validations
{
    public class Validation
    {
        public Validation(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public string Value { get; }
    }
}