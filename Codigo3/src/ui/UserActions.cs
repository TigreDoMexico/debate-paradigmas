namespace Codigo3.UI;

public static class UserActions {
    public static int ObterEntradaUsuario() {
        int resultado;
        
        while(true) {
            var digitado = Console.ReadLine();
        
            try {
                resultado = int.Parse(digitado!);
                return resultado;
            } catch(Exception) {
                Console.WriteLine("Texto Incorreto! Digite novamente");
            }
        }
    }
}