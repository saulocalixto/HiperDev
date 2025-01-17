﻿using CalixtosStore.Domain.Core.Events;
using FluentValidation.Results;
using System;

namespace CalixtosStore.Domain.Core.Commands
{
    public abstract class Command : Mensagem
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}