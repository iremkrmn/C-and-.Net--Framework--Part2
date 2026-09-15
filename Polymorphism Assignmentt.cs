using System; // Imports the System namespace so we can use Console and other basic C# functionality.

// Defines the IQuittable interface.
// Any class that implements this interface must provide a Quit() method.
public interface IQuittable
{
// Declares a void method named Quit().
// The method does not return a value and takes no parameters.
void Quit();
}

// Defines the Employee class.
// The Employee class implements the IQuittable interface.
public class Employee : IQuittable
{
// Stores the employee's first name.
public string FirstName { get; set; }

```
// Stores the employee's last name.
public string LastName { get; set; }

// Stores the employee's identification number.
public int Id { get; set; }

// Implements the Quit() method required by the IQuittable interface.
public void Quit()
{
    // Displays a message when the employee quits.
    Console.WriteLine($"{FirstName} {LastName} has quit the company.");
}
```

}

// Defines the Program class, which contains the application's entry point.
public class Program
{
// The Main() method is where the console application begins execution.
public static void Main(string[] args)
{
// Creates a new Employee object and assigns values to its properties.
Employee employee = new Employee
{
FirstName = "John",
LastName = "Smith",
Id = 1
};

```
    // Uses polymorphism to assign the Employee object to an IQuittable variable.
    // Employee implements IQuittable, so an Employee object can be treated as an IQuittable object.
    IQuittable quittableEmployee = employee;

    // Calls the Quit() method through the IQuittable interface.
    // Because the actual object is an Employee, Employee's implementation of Quit() runs.
    quittableEmployee.Quit();

    // Keeps the console window open so the user can see the output.
    Console.ReadLine();
}
```

}

