using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternBank
{
    class Account
    {

        private State _state;
        private string _owner;

        public Account(string owner)
        {
            this._owner = owner;
            this._state = new SilverState(0.0, this);
        }

        public double Balance
        {
            get { return _state.Balance; }
        }


        public State State
        {
            get { return _state; }
            set { _state = value; }
        }


        public void Deposit(double amount)
        {
            _state.Deposit(amount);

            Console.WriteLine("Depósito {0:C} --- ", amount);
            Console.WriteLine(" Saldo = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}",

            this.State.GetType().Name);

            Console.WriteLine("");
        }


        public void Withdraw(double amount)
        {
            _state.Withdraw(amount);

            Console.WriteLine("Saque {0:C} --- ", amount);
            Console.WriteLine(" Saldo = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n",

            this.State.GetType().Name);
        }


        public void PayInterest()
        {
            _state.PayInterest();

            Console.WriteLine("Pagamento de juros --- ");
            Console.WriteLine(" Saldo = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n",

            this.State.GetType().Name);
        }

    }
}
