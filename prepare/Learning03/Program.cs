using System;

class Program
{
  static public void P(object s)
  {
    Console.WriteLine(s);
  }
  static void Main(string[] args)
  {
    Fraction f1 = new Fraction(1, 1);
    P(f1.GetFractionString(true));
    P(f1.GetFractionString());
    Fraction f2 = new Fraction(5);
    P(f2.GetFractionString(true));
    P(f2.GetFractionString());
    f2.SetTop(3);
    f2.SetBottom(4);
    P(f2.GetFractionString());
    P(f2.GetDecimalValue());
    f2.SetTop(1);
    f2.SetBottom(3);
    P(f2.GetFractionString());
    P(f2.GetDecimalValue());
  }
}