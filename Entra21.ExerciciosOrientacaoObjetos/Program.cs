
using Entra21.ExerciciosOrientacaoObjetos.Exercicio01;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio03;

Console.WriteLine(@"-------MENU-------
1 - Exercício 1 (Livro)
2 - Exercício 2 (Temperatura)
3 - Exercício 3 (Conversor ASCII)");

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
else if (opcaoDesejada == 3)
{
    ExemploConversorAscii exercicio03 = new ExemploConversorAscii();
    exercicio03.Executar();
}
