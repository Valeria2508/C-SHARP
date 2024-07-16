//Define type of dates
public class Products
{
    //Name = Nombre
    public string? Name { get; set; }
    //Cantidad = Quantity
    public int Quantity { get; set; }
    //PrecioUnitario = UnitPrice
    public decimal UnitPrice { get; set; }
    public Products(string name, int quantity, decimal unitPrice)
    {
        Name = name;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
}
public class Program
{
    static List<Products> Lista = new List<Products>();
    public static void Main()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("|                   Bienvenido al Menù:                        |");
            Console.WriteLine("|                   Elige una opciòn                           |");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("|                   1. Añadir producto                         |");
            Console.WriteLine("|                   2. Eliminar producto                       |");
            Console.WriteLine("|                   3. Actualizar producto                     |");
            Console.WriteLine("|                   4. Mostrar inventario                      |");
            Console.WriteLine("|                   5. Salir                                   |");
            Console.WriteLine("----------------------------------------------------------------");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    AddProduct();
                    break;
                case 2:
                    Console.Clear();
                    DeleteProduct();
                    break;
                case 3:
                    Console.Clear();
                    UpdateProduct();
                    break;
                case 4:
                    Console.Clear();
                    ShowInventory();
                    break;
                case 5:
                    Console.Clear();
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Opciòn no válida");
                    break;
            }
        }
    }
    static void AddProduct()
    {
        Console.WriteLine("Ingresa el nombre del producto");
        string? nombre = Console.ReadLine().ToLower();
        Console.WriteLine("Ingresa la cantidad del producto");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el precio del producto");
        decimal precio = Convert.ToDecimal(Console.ReadLine());
        if (!string.IsNullOrEmpty(nombre))
        {
            Lista.Add(new Products(nombre, cantidad, precio));
        }
    }
    static void DeleteProduct()
    {
        Console.WriteLine("Ingresa el nombre del producto a eliminar");
        string? nombre = Console.ReadLine().ToLower();
        Products? producto = Lista.Find(x => x.Name.ToLower() == nombre);
        if (producto != null)
        {
            Lista.Remove(producto);
        }
    }
    static void UpdateProduct()
    {
        Console.WriteLine("Ingresa el nombre del producto a actualizar");
        string? nombre = Console.ReadLine().ToLower();
        Products? producto = Lista.Find(x => x.Name.ToLower() == nombre);
        if (producto != null)
        {
            Console.WriteLine("Ingresa la nueva cantidad del producto");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el nuevo precio del producto");
            decimal precio = Convert.ToDecimal(Console.ReadLine());
            producto.Quantity = cantidad;
            producto.UnitPrice = precio;
        }
    }
    static void ShowInventory()
    {
        decimal totalTotal = 0;
        Console.WriteLine("----------------------------------------");
        foreach (Products product in Lista)
        {
            decimal total = product.Quantity * product.UnitPrice;
            Console.WriteLine($"|Name: {product.Name,-25} |Quantity: {product.Quantity,-25} |Unit Price: {product.UnitPrice,-25:C} |Total: {total,-25:C}");
            totalTotal += product.Quantity * product.UnitPrice;
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Total Inventory: {totalTotal:C}");
        Pause();
    }
    static void Pause(){
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadKey();
    }
}