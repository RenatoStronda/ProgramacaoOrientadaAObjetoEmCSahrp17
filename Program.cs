// See https://aka.ms/new-console-template for more information
namespace pascoa{

    class Program {

    public static void Main (string[] args) {
     Console.WriteLine("Olá");
    OvoPascoa o = new OvoPascoa();
    Console.WriteLine("Digite O Peso Do Ovo De Pascoa: ");
    o.peso = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite O Tipo De Chocolate: ");
    o.tipoChocolate = (Console.ReadLine());
    Console.WriteLine("O Peso Do Ovo De Pascoa É {0} E O Sabor É {1} ", o.peso, o.tipoChocolate);
    Console.WriteLine(o);
  }
}
public class OvoPascoa{
  public float peso;
  public string tipoChocolate;
}
}