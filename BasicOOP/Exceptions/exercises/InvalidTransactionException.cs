﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.exercises
{

    public class TransactionData
    {
        public string Sender { get; init; }
        public string Receiver { get; init; }
        public decimal Amount { get; init; }
    }

public class InvalidTransactionException: Exception
    {

        public TransactionData TransactionData { get;}
        public InvalidTransactionException()
        {
            
        }
        public InvalidTransactionException(string message): base(message)
        {
        }

        public InvalidTransactionException(string message, Exception exception ): base(message, exception)
        {

        }
        public InvalidTransactionException(string message, TransactionData transactionData) : base(message)
        {
            TransactionData = transactionData;
        }


        public InvalidTransactionException(string message, TransactionData transactionData, Exception exception) : base(message, exception)
        {
            TransactionData = transactionData;
        }

    }
}
