  using System;
  
  class Program
{
    public static void Main(string[] args)
    {
        Produto p1 = new Produto("Caneta", 1.99m, 10, 5);
        Produto p2 = new Produto("Lapis", 1.99m, 10, 5);
        Produto p3 = new Produto("Cardeno", 1.30m, 10, 5);
        Produto p4 = new Produto("Borracha", 1.99m, 10, 5);
        Produto p5 = new Produto("Lapis de cor", 1.99m, 10, 5);
        Produto p6 = new Produto("Maquina de lavar", 1.99m, 10, 5);
        Produto p7 = new Produto("CPU", 1.99m, 10, 5);
        Produto p8 = new Produto("Placa mae", 1.99m, 10, 5);
        Produto p9 = new Produto("Monitor", 1.99m, 10, 5);
        Produto p10 = new Produto("Carro", 1.90m, 10, 5);

        Console.WriteLine("Nome do produto: " + p1.tNome);
        Console.WriteLine("Capital mobilizado do produto: " +   p1.calcularCapitallmobilizado()); 
        Console.WriteLine("Repondo estoque: " + p1.reporEstoque(25) + " unidades"); 
        Console.WriteLine("Retirando estoque: " + p1.retirarEstoque(3) + " unidades"); 
        Console.WriteLine("Quantidade do produto: " + p1.tEstoque + " unidades");  
 }
}