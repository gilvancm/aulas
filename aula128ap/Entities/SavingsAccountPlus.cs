using System;
using System.Collections.Generic;
using System.Text;
using aula128ap.Entities;

namespace aula128ap.Entities
{
    // o exemplo 1 ela mostra erro abaixo , que na classse que herdamos não pode ela tá selada;
   // class SavingsAccountPlus : SavingsAccount
    class SavingsAccountPlus : SavingsAccount
    {
        //exemplo 2 usando sealed na classe anterior o metodo se tiver selado no override não pode herdar o metodo da o erro
        /*
          public override void Withdraw(double amount)
          {
              base.Withdraw(amount);
          }
          */
    }


}
