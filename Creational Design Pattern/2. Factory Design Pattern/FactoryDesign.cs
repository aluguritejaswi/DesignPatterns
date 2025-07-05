using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{

  /*create either an interface or an abstract class that 
   will expose the operations a credit card should have*/
  public interface CreditCard
  {
    string GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();
  }
  class MoneyBack : CreditCard
  {
    public string GetCardType()
    {
      return "MoneyBack";
    }
    public int GetCreditLimit()
    {
      return 15000;
    }
    public int GetAnnualCharge()
    {
      return 500;
    }
  }
  public class Titanium : CreditCard
  {
    public string GetCardType()
    {
      return "Titanium Edge";
    }
    public int GetCreditLimit()
    {
      return 25000;
    }
    public int GetAnnualCharge()
    {
      return 1500;
    }
  }
  public class Platinum : CreditCard
  {
    public string GetCardType()
    {
      return "Platinum Plus";
    }
    public int GetCreditLimit()
    {
      return 35000;
    }
    public int GetAnnualCharge()
    {
      return 2000;
    }
  }
}
