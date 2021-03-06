﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternBank
{
    class RedState : State
    {
        private double _serviceFee;


        public RedState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            Initialize();
        }


        private void Initialize()
        {
            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
            _serviceFee = 15.00;
        }


        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }


        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
            Console.WriteLine("Não há saldo para saque!");
        }


        public override void PayInterest()
        {

        }


        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new SilverState(this);
            }

        }

    }
}
