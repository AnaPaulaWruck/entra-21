using Entra21.ExemplosWhile;

Console.WriteLine(@"------------Menu-----------
1 - Exemplo 01
2 - Exemplo 02
3 - Exemplo 03
4 - Exemplo 04");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exemplo01 exemplo01 = new Exemplo01();
    exemplo01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exemplo02 exemplo02 = new Exemplo02();
    exemplo02.Executar();
}
else if (opcaoDesejada == 3)
{
    Exemplo03 exemplo03 = new Exemplo03();
    exemplo03.Executar();
}
else if (opcaoDesejada == 4)
{
    Exemplo04 exemplo04 = new Exemplo04();
    exemplo04.Executar();
}