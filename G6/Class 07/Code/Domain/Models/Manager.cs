//Add class Manager that inherits from Employee and has a new property called Bonus - double, private
//Create a constructor that sets all properties except Bonus
//Create a method called AddBonus that adds bonus to the Bonus property
//Override the method GetSalary to return the Salary + Bonus

using Domain.Enums;

namespace Domain.Models
{
    public class Manager : Employee
    {
        private double _Bonus { get; set; }

        public Manager(string firstName, string lastName,double salary) 
            :base(firstName, lastName, RoleEnum.Manager, salary)
        {
            _Bonus = 0;
        }

        public void AddBonus(double bonus)
        {
            _Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _Bonus;
            //return base.GetSalary() + _Bonus;
        }
    }
}
