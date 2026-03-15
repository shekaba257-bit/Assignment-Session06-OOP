using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace Assignment_Session06_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Question01
            //Q1 : What is abstraction in OOP?
            //How is it different from encapsulation?
            //Give a real-world example (not from the session) that shows the difference between the two
            //Answer
            //Abstraction ==> showing only the important features of an object and hiding the complex implementation details
            //Abstraction: hides complex implementation (focus on what the object does)
            //Encapsulation: protects data and controls access  By (Access Modefiers)
            //EX: Abstraction ==> ATM machine, you just insert the card and choose withdraw or deposit
            //You don't know how the bank system processes the transaction internally


            //EX:Encapsulation ==>bank account data (balance, PIN, account number) is protected inside the bank system
            //You cannot access or change it directly

            #endregion

            #region Question02
            // What is the difference between an abstract class and an interface? Give at least four differences.
            // When would you choose one over the other?

            //Answer

            // Abstract class can have implemented methods, interface usually cannot

            //Abstract class can have fields and constructors, interface cannot

            //A class can inherit only one abstract class

            //A class can implement multiple interfaces

            //When to use:
            //Use abstract class when classes share common code
            //Use interface when you want different classes to follow the same contract

            #endregion
            #region Question03
            //Q3 : Look at the following code and answer the questions below:
            //(a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
            //No,cannot create objects from Abstract classes

            //b) What is the difference between the three methods: PowerConsumption(), Status(), and Label()? Why did the designer make each one abstract, virtual, or concrete?
            // (1) PowerConsumption() – abstract

            //It has no implementation in the base class
            //Every derived class must override it
            // Why abstract?
            //Because each appliance has a different power consumption


            //(2) Status() – virtual
            //it has a default implementation("Standby")
            //Derived classes can override it if needed

            //(3)Label() – concrete(normal method)
            //It has a full implementation.
            //Derived classes use it as it is

            //c) If you call Status() on a Toaster object, what will it return? Why?
            //it will return "Standby"
            //Because Toaster did not override the Status() method
            //so it uses the default implementation from the Appliance class







            #endregion

            #region Question04
            //a) What is a partial class? Why would a developer split Calculator into two files?
            //A partial class is a class that is split across multiple files, but the compiler combines them into one single class during compilation

            // Why split Calculator into two files?
            //To organize the code better

            //b) What is a partial method? What happens if the OnCalculated() implementation in Calculator.Logging.cs is deleted — will the code still compile? Why?
            //A partial method is a method declared in one part of a partial class and optionally implemented in another part.

            //What happens if OnCalculated() implementation is deleted?

            //A partial method is a method declared in one part of a partial class and
            //optionally implemented in another part
            //Yes, the code will still compile because partial methods are optional
            //If there is no implementation, the compiler simply removes the call

            //c) What is an extension method?


            // An extension method allows you to add new methods to an existing type without modifying
            // its source code

            //Ex:
            //ToCurrency() adds a new method to the double type
            //Three rules for writing an extension method:

            //The method must be inside a static class
            //The method itself must be static
            //The first parameter must use the this keyword with the type you want to extend

            // d) What will the following code print?
            //Calculator calc = new Calculator();
            //  double result = calc.Add(19.5, 0.5);
            // Console.WriteLine(result.ToCurrency());
            //Answer
            //Log: result = 20
            //$20.00


            #endregion
            #endregion
            #region Part02
            //Cinema cinema = new Cinema();
            //cinema.Open();

            //// Ticket t = new Ticket("Test", 100);  // ERROR: Cannot create instance of abstract type 'Ticket'

            //var standard = new StandardTicket("Inception", 80, "A5");
            //var vip = new VIPTicket("Avengers", 200, true, 50);
            //var imax = new IMAXTicket("Dune", 130, true);

            //standard.Book();
            //vip.Book();
            //imax.Book();

            //cinema.AddTicket(standard);
            //cinema.AddTicket(vip);
            //cinema.AddTicket(imax);

            //cinema.PrintAllTickets();

            //Console.WriteLine("\n --- Polymorphism: Final Price per Ticket ---");
            //Ticket[] arr = { standard, vip, imax };
            //foreach (var t in arr)
            //    Console.WriteLine($"{t.GetType().Name} => Final Price: {t.CalculateFinalPrice():F2}");

            //Console.WriteLine("\n --- Extension Method: Receipt ---");
            //Console.WriteLine(vip.GenerateReceipt());

            //Console.WriteLine("\n --- Extension Method: Total Revenue ---");
            //Console.WriteLine($" Total Revenue: {arr.TotalRevenue():F2}");

            //cinema.Close();
            #endregion
        }
    }
}
