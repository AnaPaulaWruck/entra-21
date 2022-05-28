
using Entra21.ExerciciosOrientacaoObjetos.Exercicio01;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;

Console.WriteLine(@"-------MENU-------
1 - Exercício 1 (Livro)
2 - Exercício 2 (Temperatura)");

Console.Write("\nDigite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    ExemploLivro exercicio01 = new ExemploLivro();
    exercicio01.Executar();
}
else if (opcaoDesejada == 2)
{
    ExemploTemperatura exercicio02 = new ExemploTemperatura();
    exercicio02.Executar();
}
