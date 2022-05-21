using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetores
{
    internal class ExemploProfessor
    {
        public void Executar()
        {
            var table = new ConsoleTable("one", "two", "three");

            // table.Configure(x => x.EnableCount = false); // Remove o contador no final da tabela

            table.AddRow(1, 2, 3)
                 .AddRow("this line should be longer", "yes it is", "oh");

            table.Write(Format.Alternative); // Format alternative para ter outro formato, conforme explicaod no GitHub do criador
        }
    }
}
