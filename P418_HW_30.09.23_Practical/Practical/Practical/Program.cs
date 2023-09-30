using Practical.Models;

static Employee[] GetEmployees()
{
    Employee employee1 = new()
    {
        id = 1,
        name = "Test 1",
        surname = "Test A",
        age = 30,
        address = "Address 1",
        email = "test1testa@gmail.com"
    };

    Employee employee2 = new()
    {
        id = 2,
        name = "Test 2",
        surname = "Test B",
        age = 20,
        address = "Address 2",
        email = "test2testC@gmail.com"
    };

    Employee employee3 = new()
    {
        id =3,
        name = "Test 3",
        surname = "Test C",
        age = 40,
        address = "Address 3",
        email = "test3testC@gmail.com"
    };
    Employee[] employees = { employee1, employee2, employee3 };
    return employees;
}

//static void GetEmplyeesByAge(int age)
//{
//    Employee[] employees = GetEmployees();

//    Employee[] filterEmployees = employees.Where(m => m.age > age).ToArray();

//    foreach(var employee in filterEmployees)
//    {
//        string result = $"{employee.name} - {employee.surname} - {employee.age} - {employee.address} - {employee.email}";
//        Console.WriteLine(result);
//    }
//}

//GetEmplyeesByAge(20);

// -------------------------------------------------------------------------


//static int CountOfEmplyeeByAge(int startAge, int endAge)
//{
//    {
//        Employee[] employees = GetEmployees();
//        Employee[] filterEmployees = employees.Where(m => m.age >= startAge && m.age <= endAge).ToArray();
        
//        return filterEmployees.Length;
//    }
//}


//Console.WriteLine(CountOfEmplyeeByAge(20,30));

// -------------------------------------------------------------------------

//static void GetEmployeesByFilteredEmail(string str)
//{
//    var employees = GetEmployees();

//    var filteredEmployees = employees.Where(m=>m.email.ToLower().StartsWith(str.ToLower())).ToArray();
//    foreach (var employee in filteredEmployees)
//    {
//        string result = $"{employee.name} - {employee.surname} - {employee.age} - {employee.address} - {employee.email}";
//        Console.WriteLine(result);
//    }
//    }

//GetEmployeesByFilteredEmail("n");

// -------------------------------------------------------------------------