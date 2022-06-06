using System;
using System.Threading;

class Program {
  public static void Main () {
    string operation;
    Console.WriteLine("Use '*' for multiply, '/' for divide, '+' for addition, '-' for subtraction, 'sq' for square, 'cube' for cube, 'sqrt' for square root, and 'pow' for raising to a power.");
    operation = Console.ReadLine();
    if(operation == "*") {
      multiply();
    }
    else if(operation == "/") {
      divide();
    }
    else if(operation == "+") {
      addition();
    }
    else if (operation == "-") {
      subtraction();
    }
    else if (operation == "sq") {
      square();
    }
    else if (operation == "cube") {
      cube();
    }
    else if (operation == "sqrt") {
      sqrt();
    }
    else if (operation == "pow") {
      power();
    }
    else {
      Console.WriteLine("That is not a valid operation. Restarting...");
      Thread.Sleep(3000);
      Console.Clear();
      Main();
    }
  }
  public static void multiply() {
    Console.WriteLine("First number:");
    string num1 = Console.ReadLine();
    Console.WriteLine("Second number:");
    string num2 = Console.ReadLine();
    try { double result =  double.Parse(num1); double result2 = double.Parse(num2); Console.WriteLine(result * result2); 
        Console.WriteLine("Type 1 to restart, 2 to exit:");
      string restart = Console.ReadLine();
      if(restart == "1") {
        Main();
      }
      else {
        Environment.Exit(0);
      }
        } catch (FormatException) { Console.WriteLine($"Non-numeric value entered. '{num1}', '{num2}'"); Console.WriteLine("Restarting..."); Thread.Sleep(3000); Console.Clear(); Main(); }
  }
  public static void divide() {
    Console.WriteLine("First number:");
    string num1 = Console.ReadLine();
    Console.WriteLine("Second number:");
    string num2 = Console.ReadLine();
    try { double result =  double.Parse(num1); double result2 = double.Parse(num2); Console.WriteLine(result / result2);
        Console.WriteLine("Type 1 to restart, 2 to exit:");
      string restart = Console.ReadLine();
      if(restart == "1") {
        Main();
      }
      else {
        Environment.Exit(0);
      }
        } catch (FormatException) { Console.WriteLine($"Non-numeric value entered. '{num1}', '{num2}'"); Console.WriteLine("Restarting..."); Thread.Sleep(3000); Console.Clear(); Main(); }
  }
  public static void addition() {
    Console.WriteLine("First number:");
    string num1 = Console.ReadLine();
    Console.WriteLine("Second number:");
    string num2 = Console.ReadLine();
    try { double result =  double.Parse(num1); double result2 = double.Parse(num2); Console.WriteLine(result + result2);
        Console.WriteLine("Type 1 to restart, 2 to exit:");
      string restart = Console.ReadLine();
      if(restart == "1") {
        Main();
      }
      else {
        Environment.Exit(0);
      }
        } catch (FormatException) { Console.WriteLine($"Non-numeric value entered. '{num1}', '{num2}'"); Console.WriteLine("Restarting..."); Thread.Sleep(3000); Console.Clear(); Main(); }
  }
  public static void subtraction() {
    Console.WriteLine("First number:");
    string num1 = Console.ReadLine();
    Console.WriteLine("Second number:");
    string num2 = Console.ReadLine();
    try { double result =  double.Parse(num1); double result2 = double.Parse(num2); Console.WriteLine(result - result2);
        Console.WriteLine("Type 1 to restart, 2 to exit:");
      string restart = Console.ReadLine();
      if(restart == "1") {
        Main();
      }
      else {
        Environment.Exit(0);
      }
        } catch (FormatException) { Console.WriteLine($"Non-numeric value entered. '{num1}', '{num2}'"); Console.WriteLine("Restarting..."); Thread.Sleep(3000); Console.Clear(); Main(); }
  }
  public static void square() {
    Console.WriteLine("Number to square:");
    string num1 = Console.ReadLine();
    try { double result =  double.Parse(num1); Console.WriteLine(result * result);
        Console.WriteLine("Type 1 to restart, 2 to exit:");
      string restart = Console.ReadLine();
      if(restart == "1") {
        Main();
      }
      else {
        Environment.Exit(0);
      }
        } catch (FormatException) { Console.WriteLine($"Non-numeric value entered. '{num1}'"); Console.WriteLine("Restarting..."); Thread.Sleep(3000); Console.Clear(); Main(); }
  }
  public static void cube() {
    Console.WriteLine("Number to cube:");
    string num1 = Console.ReadLine();
    try { 
      double result =  double.Parse(num1); 
      Console.WriteLine(result * result * result);
      Console.WriteLine("Type 1 to restart, 2 to exit:");
      string restart = Console.ReadLine();
      if(restart == "1") {
        Main();
      }
      else {
        Environment.Exit(0);
      }
    } 
    catch (FormatException) { 
      Console.WriteLine($"Non-numeric value entered. '{num1}'");         
      Console.WriteLine("Restarting..."); 
      Thread.Sleep(3000); 
      Console.Clear(); 
      Main(); }
  }
  public static void sqrt() {
    Console.WriteLine("Number to square root:");
    string num1 = Console.ReadLine();
    try { double result =  double.Parse(num1); Console.WriteLine(Math.Sqrt(result));
         Console.WriteLine("Type 1 to restart, 2 to exit:");
      string restart = Console.ReadLine();
      if(restart == "1") {
        Main();
      }
      else {
        Environment.Exit(0);
      }
        
        } catch (FormatException) { Console.WriteLine($"Non-numeric value entered. '{num1}'"); Console.WriteLine("Restarting..."); Thread.Sleep(3000); Console.Clear(); Main(); }
  }
  public static void power() {
    Console.WriteLine("Number to raise:");
    string num1 = Console.ReadLine();
    Console.WriteLine("Exponent:");
    string num2 = Console.ReadLine();
    try { 
      double result =  double.Parse(num1); 
      double result2 = double.Parse(num2);   
      Console.WriteLine(Math.Pow(result, result2)); 
      Console.WriteLine("Type 1 to restart, 2 to exit:");
      string restart = Console.ReadLine();
      if(restart == "1") {
        Main();
      }
      else {
        Environment.Exit(0);
      }
    } 
    catch (FormatException) { 
      Console.WriteLine($"Non-numeric value entered. '{num1}', '{num2}'"); 
      Console.WriteLine("Restarting..."); 
      Thread.Sleep(3000); 
      Console.Clear(); 
      Main();  
    }
  } 
}