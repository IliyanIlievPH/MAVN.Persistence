﻿using System;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace MAVN.Persistence.PostgreSQL.Legacy
{
    [PublicAPI]
    public interface ITransactionRunner
    {
        Task<T> RunWithTransactionAsync<T>(Func<TransactionContext?, Task<T>> func);
        Task RunWithTransactionAsync(Func<TransactionContext?, Task> func);
    }
}