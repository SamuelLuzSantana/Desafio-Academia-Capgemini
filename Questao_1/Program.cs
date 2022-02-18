//Escreva um algoritmo que mostre na tela uma escada de tamanho n utilizando o caractere * e espaços.
//A base e altura da escada devem ser iguais ao valor de n. A última linha não deve conter nenhum espaço.

Console.WriteLine("Digite um numero");
int numero = Convert.ToInt32(Console.ReadLine()) ;


string padrao = "";

for (var i = 1; i <= numero; i++)
{
    padrao += "*";
     Console.WriteLine(new String(' ', numero - padrao.Length) + padrao);

}

// codigo para rodar no console:
Console.WriteLine(" \n Aperte ENTER para continuar...");
Console.ReadLine();
