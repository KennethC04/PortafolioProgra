namespace semana6_ejercicioClase;


public class Person
{
    private decimal salary;

    public Person(decimal salary)
    {
        this.salary = salary;
    }

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public void Pay()
    {
        if (salary > 3000.00m)
        {
            decimal tax = salary * 0.05m;
            decimal total = salary - tax;
            Console.WriteLine("Debes pagar teniendo en cuenta que debes pagar el 5% del salario.", total);
        }
        else
        {
            Console.WriteLine("Su salario es inferior a 3000,00, no se requieren impuestos.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Ingrese el salario de la persona: ");
        decimal salary = decimal.Parse(Console.ReadLine());
        Person person = new Person(salary);
        person.Pay(); }
} 


