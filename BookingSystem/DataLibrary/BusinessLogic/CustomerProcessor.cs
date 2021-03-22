using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class CustomerProcessor
    {
        public static int CreateCustomer(string firstName, string lastName,
            string emailAddress, string phoneNumber, string checkInDate,
            string checkOutDate)
        {
            CustomerModel data = new CustomerModel
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                PhoneNumber = phoneNumber,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate
            };

            string sql = @"insert into dbo.Customer (FirstName, LastName, EmailAddress, PhoneNumber, CheckInDate, CheckOutDate)
                        values(@FirstName, @LastName, @EmailAddress, @PhoneNumber, @CheckInDate, @CheckOutDate);";

            return SqlDataAccess.SaveData(sql, data);
        }
        public static List<CustomerModel> LoadCustomers()
        {
            string sql = @"select Id, FirstName, LastName, EmailAddress, PhoneNumber, CheckInDate, CheckOutDate
                            from dbo.Customers;";

            return SqlDataAccess.LoadData<CustomerModel>(sql);
        
        }
    }

}
