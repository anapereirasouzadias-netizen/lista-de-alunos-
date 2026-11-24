using System;
using static System.Console;
using static System.Convert;
				
public class Program
{
	public static void Main()
	{
		int b = -1;
		String[] alunos = new String[6];
		for (int n = 0; n <= 5; n++){
			WriteLine("Digite o nome do aluno: ");
			alunos[n] = ReadLine();
		}
		WriteLine("=================");
		WriteLine("Lista de alunos cadastrados");
		WriteLine("==================");
	
		for (int i = 0; i <= 5; i++){
			Console.WriteLine(alunos[i]);
		
		WriteLine("==================");
		
		}
	Console.WriteLine("digite o nome que você deseja buscar: ");
	string aluno_busca = ReadLine();
	for (int i = 0; i <= 5; i++) {
		if (alunos[i] == aluno_busca){
			WriteLine("aluno encontrado!");
			WriteLine("o aluno " + aluno_busca +" foi encontrado na posição " +i + " do vetor!");
			b=i;
		}
		
	  }
		WriteLine("deseja alterar o nome do aluno: S/N");
		string con = ReadLine();
		if(con == "S" || con =="s"){
			WriteLine("digite o nome do novo aluno");
			string novo_aluno = ReadLine();
			alunos[b]= novo_aluno;
	}
		WriteLine("=================");
		WriteLine("nova Lista de alunos cadastrados");
		WriteLine("==================");
	
		for (int i = 0; i <= 5; i++){
			Console.WriteLine(alunos[i]);
		
		WriteLine("==================");
		
	}
}
}
