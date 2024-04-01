using Week11.Lab.Models.Entities;
var dbContext = new MMABooksContext();
var customers  = dbContext.Customers;

foreach (var customer in customers)
{
    Console.WriteLine(customer.Name);
}