using Domain.Models;
using Domain.Enums;

Employee employee = new Employee("Petko", "Petkovski", RoleEnum.Other, 600);
employee.PrintInfo();
//double salary = employee.Salary;//ERROR, Salary is protected
double salary = employee.GetSalary();

SalesPerson salesPerson = new SalesPerson("Stefan", "Stefanovski", 0);
salesPerson.AddSuccessRevenue(2500);
Console.WriteLine(salesPerson.GetSalary());