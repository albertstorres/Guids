using System;

namespace Guids
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); //Criando novo Guid

            id.ToString();//Convertendo tipo Guid para string

            id = new Guid("57ff4b1c-849d-4ef4-ac7b-4da6700cf53e");//Inserindo um Guid específico a uma variável

            Console.WriteLine(id);
        }
    }
}
