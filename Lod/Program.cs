namespace Lod;

class Program
{
    public static void Main(string[] args)
    {
        var address1 = new Address("jl sukamahi 123", "bandung", "indonesia");
        var customer1 = new Customer("gilang", address1);
        var order1 = new Order(customer1);
        order1.Process();
    }
}
public class Order
{
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void Process()
    {
        // Proses pesanan
        Inventory inventory = new Inventory();
        PaymentProcessor paymentProcessor = new PaymentProcessor();

        if (inventory.HasStock())
        {
            decimal totalPrice = inventory.CalculateTotalPrice();
            paymentProcessor.ProcessPayment(customer, totalPrice);
            inventory.UpdateStock(10);
            // ...
        }
        else
        {
            // ...
        }
    }
}

public class Customer
{
    private string name;
    private Address address;
    private decimal balance = 1000000;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void SetBalance(decimal newBalance)
    {
        balance = newBalance;
    }
}

public class Address
{
    private string street;
    private string city;
    private string country;

    public Address(string street, string city, string country)
    {
        this.street = street;
        this.city = city;
        this.country = country;
    }

    public string GetStreet()
    {
        return street;
    }

    public string GetCity()
    {
        return city;
    }

    public string GetCountry()
    {
        return country;
    }
}

public class Inventory
{
    public int stock = 10;
    public decimal price = 10000;
    public bool HasStock()
    {
        // Periksa persediaan
        // ...

        if (stock > 0) // Contoh: Jika jumlahPersediaan lebih dari 0
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public decimal CalculateTotalPrice()
    {
        // Hitung total harga
        // ...

        decimal totalPrice = 0;
        // Lakukan perhitungan
        totalPrice = stock * price;

        return totalPrice;
    }

    public void UpdateStock(int jumlah)
    {
        // Update persediaan
        // ...
        stock += jumlah;
    }
}

public class PaymentProcessor
{
    public void ProcessPayment(Customer customer, decimal amount)
    {
        // Proses pembayaran
        // ...
        if (customer.GetBalance() < amount)
        {
            Console.WriteLine("dana tidak mencukupi!!!");
        }
        else
        {
            customer.SetBalance(customer.GetBalance() - amount);
            Console.WriteLine("Pembayaran berhasil");
        }
    }
}