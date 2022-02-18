using System.Text.RegularExpressions;

//Débora se inscreveu em uma rede social para se manter em contato com seus amigos. A página de cadastro exigia
// o preenchimento dos campos de nome e senha, porém a senha precisa ser forte. 
// O site considera uma senha forte quando ela satisfaz os seguintes critérios:

// -- Possui no mínimo 6 caracteres.
// -- Contém no mínimo 1 digito.
// -- Contém no mínimo 1 letra em minúsculo.
// -- Contém no mínimo 1 letra em maiúsculo.
// -- Contém no mínimo 1 caractere especial. Os caracteres especiais são: !@#$%^&*()-+

// construa um algoritmo que informe qual é o número mínimo de caracteres que devem ser adicionados 
// para uma string qualquer ser considerada segura.

bool password = true;




do
{
    Console.WriteLine("Digite sua senha: ");
    string senha = (Console.ReadLine());

    if (senha.Length <= 6)
    {
      
        Console.WriteLine("A sua senha possui " + senha.Length + " caracteres");
        Console.WriteLine("para a sua senha ser segura ela deve conter no minimo 6 caracteres \n");


        password = false;
    }

    else if (senha.Any(c => char.IsDigit(c)) == false)
    {

        Console.WriteLine("A sua senha deve conter no minimo 1 digito \n");
        password = false;
    }

    else if (Regex.IsMatch(senha, (@"[A-Z]")) == false)
    {
        Console.WriteLine("A sua senha deve conter no minimo UMA Letre Maiscula \n");
    }

    else if (Regex.IsMatch(senha, (@"[a-z]")) == false)
    {
        Console.WriteLine("A sua senha deve conter no minimo UMA Letre minuscula \n");
    }

    else if (Regex.IsMatch(senha, (@"[^a-zA-Z0-9]")) == false)
    {

        Console.WriteLine("A sua senha deve conter algum caractere especial \n");

    }


    else
    {
        password = true;
    }



} while (password == false);


Console.WriteLine("\n Senha cadastrada com sucesso :)");


// codigo para rodar no console:
Console.WriteLine(" \n Aperte ENTER para continuar...");
Console.ReadLine();