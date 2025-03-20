//Create a SalesPerson class that inherits from Employee and has the following properties:
//SuccessSaleRevenue double, private
//The salary is by default 500 and role is default Sales
//Create constructor that sets all the properties
//Create a method called AddSuccessRevenue that will get a number and set the SuccessSaleRevenue to that value
//Override the GetSalary method to return the value of the salary plus bonus that is calculated by the SuccessSaleRevenue. 
//If less or equal to 2000 then add 500 bonus
//If larger than 2000 but less or equal than 5000 then add 1000 bonus
//If larger than 5000 add 1500 bonus

using Domain.Enums;

namespace Domain.Models
{
    public class SalesPerson : Employee
    {
        private double _SuccessSaleRevenue {  get; set; }

        public SalesPerson(string firstName, string lastName, double successSaleRevenue)
            :base(firstName, lastName, RoleEnum.Sales, 500) //we call the constructor from the parent (Employee)
        {
            _SuccessSaleRevenue = successSaleRevenue;
        }

        public void AddSuccessRevenue(double amount)
        {
            _SuccessSaleRevenue += amount;
        }

        public override double GetSalary()
        {
            if (_SuccessSaleRevenue <= 2000)
            {
                return Salary + 500; //we can access the Salary because SalesPerson inherits from Employee
            }else if(_SuccessSaleRevenue > 200 &&  _SuccessSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else
            {
                return Salary + 1500;
            }
        }
    }
}
