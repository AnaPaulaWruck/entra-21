using Entra21.ExerciciosFor;

Console.WriteLine(@"
-------MENU--------
1 - Exercício 01");

Console.Write("\nDigite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada==1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}