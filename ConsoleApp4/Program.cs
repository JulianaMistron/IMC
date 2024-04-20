double altura, peso, imc;

Console.Write("Digite a sua altura em metros: ");
altura = double.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("Digite o seu peso: ");
peso = double.Parse(Console.ReadLine());
Console.WriteLine("");

imc = peso / (altura*altura);

Console.WriteLine("Seu IMC: " + imc.ToString("N2"));
Console.WriteLine("");

if (imc < 17)
{
    Console.WriteLine("Muito abaixo do peso!");
}
else
  if (imc >= 17 && imc <= 18.99)
{
    Console.WriteLine("Abaixo do peso.");
}
else
    if (imc >= 19 && imc <= 24.99)
{
    Console.WriteLine("Peso Ideal");
}
else
      if (imc >= 25 && imc <= 29.99)
{
    Console.WriteLine("Sobrepeso.");
}
else
        if (imc >= 30 && imc <= 34.99)
{
    Console.WriteLine("Obesidade.");
}
else
          if (imc >= 35 && imc <= 40)
{
    Console.WriteLine("Obesidade Severa.");
}
else
            if (imc > 40)
{
    Console.WriteLine("Obesidade Mórbida");
}
Console.ReadKey();