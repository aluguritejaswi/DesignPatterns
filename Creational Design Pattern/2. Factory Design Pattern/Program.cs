﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      //Generally we will get the Card Type from UI.
      //Here we are hardcoded the card type
      string cardType = "MoneyBack";
      CreditCard cardDetails = null;
      //Based of the CreditCard Type we are creating the
      //appropriate type instance using if else condition
      if (cardType=="MoneyBack")
      {
        cardDetails=new MoneyBack();
      }
      else if (cardType=="Titanium")
      {
        cardDetails=new Titanium();
      }
      else if (cardType=="Platinum")
      {
        cardDetails=new Platinum();
      }
      if (cardDetails!=null)
      {
        Console.WriteLine("CardType : "+cardDetails.GetCardType());
        Console.WriteLine("CreditLimit : "+cardDetails.GetCreditLimit());
        Console.WriteLine("AnnualCharge :"+cardDetails.GetAnnualCharge());
      }
      else
      {
        Console.Write("Invalid Card Type");
      }
    }
  }
}
