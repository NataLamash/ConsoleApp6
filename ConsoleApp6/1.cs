using System;
using System.Collections.Generic; 
using System.Linq; 


class Item
{
    public string Name { get; set; } 
    public decimal Price { get; set; } 
}


class Order
{
    private List<Item> itemList = new List<Item>(); 

   
    public List<Item> GetItems() => itemList;

   
    public int GetItemCount() => itemList.Count;


    public void AddItem(Item item) => itemList.Add(item);

    
    public void DeleteItem(Item item) => itemList.Remove(item);

 
    public decimal CalculateTotalSum()
    {
        return itemList.Sum(item => item.Price); 
    }
}


class OrderRepository
{
    public void Save(Order order)
    {
        
        Console.WriteLine("Order has been saved.");
    }

    public Order Load(int orderId)
    {
       
        Console.WriteLine("Order has been loaded.");
        return new Order();
    }

    public void Update(Order order)
    {
       
        Console.WriteLine("Order has been updated.");
    }

    public void Delete(int orderId)
    {
        
        Console.WriteLine("Order has been deleted.");
    }
}


class OrderPrinter
{
    public void PrintOrder(Order order)
    {
      
        Console.WriteLine("Order details:");
        foreach (var item in order.GetItems())
        {
            Console.WriteLine($"Item: {item.Name}, Price: {item.Price}");
        }
    }

    public void ShowOrder(Order order)
    {

        Console.WriteLine("Showing order details:");
        foreach (var item in order.GetItems())
        {
            Console.WriteLine($"Item: {item.Name}, Price: {item.Price}");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {

        var order = new Order();


        order.AddItem(new Item { Name = "Apple", Price = 1.5m });
        order.AddItem(new Item { Name = "Banana", Price = 2.0m });


        Console.WriteLine("Total Sum: " + order.CalculateTotalSum());


        var printer = new OrderPrinter();
        printer.PrintOrder(order);


        var repository = new OrderRepository();
        repository.Save(order);

        var loadedOrder = repository.Load(1);
        Console.WriteLine("Order has been loaded successfully.");
    }
}
