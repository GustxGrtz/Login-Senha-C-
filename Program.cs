using System;
class Program
{
    static void Main(){

        int tentsenha;
        int senha = 12345;

        string login = "teste@gmail.com";
        string tentlogin;
        
        bool loginsucesso = false;

    for(int cont = 1; cont <= 3; cont++){

        Console.Write("Digite o login: ");
        tentlogin = Console.ReadLine();

        Console.Write("Digite a senha: ");
        tentsenha = Convert.ToInt32(Console.ReadLine());

        if (tentlogin == login && tentsenha == senha){
            Console.WriteLine("Login correto");
            loginsucesso = true;
            break;
        }
        else if(tentlogin == login && tentsenha != senha){
            Console.WriteLine("Senha incorreta");
        } 
        else if(tentlogin != login && tentsenha == senha){
            Console.WriteLine("Login incorreto");
        }
        else if(tentlogin != login && tentsenha != senha){
            Console.WriteLine("Login e senha incorreto");
        }
        else{
            Console.WriteLine("Dados invalidos");
        }
    }
        if(loginsucesso){
            Console.WriteLine("Você tem novas mensagens");
            Console.WriteLine("Deseja Lê-las?");
            Console.WriteLine("Digite S para Sim e N para Não");        
            string email = Console.ReadLine();

            if (email == "S" || email == "s"){

                Console.WriteLine("Você foi selecionado para participar de uma pesquisa rápida e receber um vale-presente grátis! Clique no link abaixo para começar.\n");
                Console.WriteLine("Temos uma oferta especial apenas para você! Ganhe descontos exclusivos em nossa loja online por tempo limitado. Não perca esta oportunidade!\n");
            }
            else if (email == "N" || email == "n"){

                Console.WriteLine("Ok, encerrando o email");
            }
            else{

                Console.WriteLine("Opção inválida. Encerrando o email");
            }
        }

        else{
            
            Console.WriteLine("Encerrando o Login...");
        }
    }
}