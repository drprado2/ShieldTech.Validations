﻿using System.Collections.Generic;

 namespace ShieldTech.Validations.Validations
{
    public interface IValidator
    {
        void Add(Validation validation);
        void Add(string name, string value);
        bool IsValid { get; }
        bool IsInvalid { get; }
        IList<Validation> Notifications { get; }
    }
}