using Codigo3.Service;
using Codigo3.UI;

Console.WriteLine("CRIAÇÃO DE USUARIOS");
var service = new UsuarioService();
bool endProgram = false;

while(!endProgram) {
    Console.WriteLine("ESCOLHA UMA OPCAO");
    Console.WriteLine("1 - CRIAR USUARIO");
    Console.WriteLine("2 - OBTER USUARIO");
    Console.WriteLine("0 - SAIR");

    var escolha = UserActions.ObterEntradaUsuario();

    switch(escolha) {
        case 0:
            endProgram = true;
            break;
        case 1:
            Console.WriteLine("Digite o login do Usuario");
            var login = Console.ReadLine();
            Console.WriteLine("Digite o email do Usuario");
            var email = Console.ReadLine();
            Console.WriteLine("Digite a senha do Usuario");
            var senha = Console.ReadLine();

            if(service.CriarUsuario(login!, senha!, email!)) {
                Console.WriteLine("Usuario Criado com Sucesso!");
            } else {
                Console.WriteLine("Falha ao criar o Usuario!");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadLine();

            break;
        
        case 2:
            Console.WriteLine("Digite o login do Usuario para buscar");
            var searchTerm = Console.ReadLine();

            var encontrado = service.BuscarUsuario(searchTerm!);
            
            if(encontrado is not null) {
                Console.WriteLine("Usuario Existe!");
            } else {
                Console.WriteLine("Usuario Não Existe!");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadLine();

            break;

        default:
            Console.WriteLine("Opção Errada! Escolha novamente");
            break;
    }
}
