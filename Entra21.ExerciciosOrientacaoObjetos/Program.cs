
using Entra21.ExerciciosOrientacaoObjetos.Exercicio01;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio03;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio04;

Console.WriteLine(@"-------MENU-------
1 - Exercício 1 (Livro)
2 - Exercício 2 (Temperatura)
3 - Exercício 3 (Conversor ASCII)
4 - Exercício 4 (Farmácia)");

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
else if(opcaoDesejada==4)
{
    ExemploFarmacia exercicio04 = new ExemploFarmacia();
    exercicio04.Executar();
}
