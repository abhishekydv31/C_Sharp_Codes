using System;

internal class Program
{
    
    private static void Main(string[] args)
    {
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() {ID=101,Name="Mary",Salary=5000,Experience=5 });
        empList.Add(new Employee() { ID = 102, Name = "James", Salary = 3000, Experience =4  });
        empList.Add(new Employee() { ID = 103, Name = "Ivar", Salary = 8000, Experience = 7 });
        empList.Add(new Employee() { ID = 104, Name = "Rollo", Salary = 2000, Experience = 2 });

        IsPromotable isPromotable = new IsPromotable(Promote);
        Employee.PromoteEmployee(empList,isPromotable);
    }

    public static bool Promote(Employee emp) 
    {
        if (emp.Experience >= 5) 
        {
            return true;
        }
        return false;
    }
}

delegate bool IsPromotable(Employee empl);

class Employee 
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee  emp in employeeList ) 
        {
            if (IsEligibleToPromote(emp)) 
            {
                Console.WriteLine(emp.Name+" Promoted ");
            }
        }
    }

}

