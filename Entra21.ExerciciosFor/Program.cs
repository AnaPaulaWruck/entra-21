using Entra21.ExerciciosFor;

Console.WriteLine(@"
-------MENU--------
1 - Exercício 01
5 - Exercício 05
8 - Exercício 08
10 - Exercício 10
12 - Exercício 12
13 - Exercício 13");

Console.Write("\nDigite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (opcaoDesejada == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if (opcaoDesejada == 10)
{
    Exercicio10 exercicio10 = new Exercicio10();
    exercicio10.Executar();
}
else if (opcaoDesejada == 12)
{
    Exercicio12 exercicio12 = new Exercicio12();
    exercicio12.Executar();
}
else if (opcaoDesejada == 13)
{
    Exercicio13 exercicio13 = new Exercicio13();
    exercicio13.Executar();
}