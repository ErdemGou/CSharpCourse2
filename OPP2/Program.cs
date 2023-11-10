using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        IndividualCustomer customer1 = new IndividualCustomer();
        customer1.Id = 1;
        customer1.CustomerNo = "12345";
        customer1.FirstName = "Engin";
        customer1.LastName = "Demiroğ";
        customer1.TcNo = "12345678910";

        CorporateCustomer customer2 = new CorporateCustomer();
        customer2.Id = 2;
        customer2.CustomerNo = "54321";
        customer2.CompanyName = "Kodlama.io";
        customer2.TaxNumber = "12345543210";

        Customer customer3 = new IndividualCustomer();
        Customer customer4 = new CorporateCustomer();

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(customer3);
        customerManager.Add(customer4);
    }
}