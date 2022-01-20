using PreAcademyAEquazione2Grado.Core;

Console.WriteLine("Equazione di secondo grado");
Console.WriteLine("Immetti i 3 coefficienti dell'equazione completa ax^2+bx+c=0");
Console.Write("a= ");
double a = double.Parse(Console.ReadLine());
Console.Write("b= ");
double b = double.Parse(Console.ReadLine()); ;
Console.Write("c= ");
double c = double.Parse(Console.ReadLine());
Console.WriteLine($"\nL'equazione da risolvere è: {a}x^2 + {b}x + {c} = 0");

Equation eq= new Equation();
double[] risultato = eq.RisolviEquazioneDiSecondoGrado(a,b,c);

if (risultato == null)
{
    Console.WriteLine("Equazione impossibile");
}
else if (risultato.Length == 1)
{
    Console.WriteLine($"Risultato: x1=x2= {risultato[0]}");
}
else
{
    Console.WriteLine($"Risultati: x1={risultato[0]} , x2={risultato[1]}");
}

