using System;
using System.Collections.Generic;

public class clsCustomerCollection
{
    private static List<clsCustomer> customers = new List<clsCustomer>();

    public void Add(clsCustomer customer)
    {
        customers.Add(customer);
    }

    public void Update(clsCustomer customer)
    {
        var existing = customers.Find(c => c.CustomerID == customer.CustomerID);
        if (existing != null)
        {
            existing.CustomerName = customer.CustomerName;
            existing.EmailAddress = customer.EmailAddress;
            existing.BillingAddress = customer.BillingAddress;
            existing.PhoneNumber = customer.PhoneNumber;
            existing.Gender = customer.Gender;
        }
    }

    public List<clsCustomer> GetAll()
    {
        return customers;
    }
}