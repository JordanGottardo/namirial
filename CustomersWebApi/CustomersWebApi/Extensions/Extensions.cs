using CustomersWebApi.Dtos;
using CustomersWebApi.Models;

namespace CustomersWebApi.Extensions
{
    public static class Extensions
    {
        public static CustomerDto AsDto(this Customer customer)
        {
            return new CustomerDto
            {
                Address = customer.Address,
                City = customer.City,
                CompanyName = customer.CompanyName,
                ContactName = customer.ContactName,
                ContactTitle = customer.ContactTitle,
                Country = customer.Country,
                CustomerID = customer.CustomerID,
                Fax = customer.Fax,
                Phone = customer.Phone,
                PostalCode = customer.PostalCode,
                Region = customer.Region
            };
        }
    }
}
