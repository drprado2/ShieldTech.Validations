﻿namespace ShieldTech.Validations.Validations
{
    public class Error
    {
        public Error(string uniqueName, string value)
        {
            UniqueName = uniqueName;
            Value = value;
        }

        public string UniqueName { get; }
        public string Value { get; }
    }
}