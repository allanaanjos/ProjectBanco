
using ProjetoBanco.cs;
using System.Globalization;

namespace Program
{
	
	class ProjetoBanco
	{


		static void Main(string[] args)
		{
			BancoConta conta;

			Console.Write("Entre com o Numero da Conta: ");
			int numconta =  int.Parse(Console.ReadLine());
			Console.Write("Entre com Titular da Conta: ");
			string titular = Console.ReadLine();
			Console.Write("Havera um Deposito Inicial: (s/n)? ");
			char esc = char.Parse(Console.ReadLine());
			if(esc == 's' || esc == 'S')
			{
				Console.Write("Deposito Inicial: ");
				double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				conta = new BancoConta(numconta,titular,depositoInicial);
			}else
			{
				conta = new BancoConta(numconta,titular);
			}

			Console.WriteLine();
			Console.WriteLine("Dados Da Conta");
			Console.WriteLine(conta);

			Console.WriteLine();
			Console.Write("Entre com valor para Deposito: ");
			double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			conta.Deposite(quantia);

			Console.WriteLine();
			Console.WriteLine("Dados Atualizados \n" + conta); 

			Console.WriteLine();
			Console.Write("Valor para Saque: ");
			quantia = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
			conta.Saque(quantia);
			
			Console.WriteLine();
			Console.WriteLine("Dados Atualizados: \n" + conta);

		}
	}
}
