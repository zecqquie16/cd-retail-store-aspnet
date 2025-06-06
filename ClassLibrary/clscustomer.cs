using System;

public class clsCustomer
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string EmailAddress { get; set; }
    public string BillingAddress { get; set; }
    public string PhoneNumber { get; set; }
    public string Gender { get; set; }
    public string Password { get; set; }
    public bool Active { get; set; }

    public bool Find(int id)
    {
        throw new NotImplementedException();
    }
}