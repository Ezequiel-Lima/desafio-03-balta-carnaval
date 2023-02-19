using Desafio;

Console.WriteLine("Informe o valor do litro do álcool:");
double valorAlcool = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor do litro da gasolina:");
double valorGasolina = double.Parse(Console.ReadLine());

Combustivel combustivel = new Combustivel(valorGasolina, valorAlcool);

Console.WriteLine($"\n{combustivel}");