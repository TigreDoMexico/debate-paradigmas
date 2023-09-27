using System.Text.RegularExpressions;
using Codigo3.Models;

namespace Codigo3.Service;

public class UsuarioService
{
    private List<Usuario> usuarios = new List<Usuario>();

    public bool CriarUsuario(string login, string senha, string email)
    {
        if(IsEmailValido(email)) {
            var usuario = new Usuario(login, senha, email);
            usuarios.Add(usuario);
            return true;
        }

        return false;
    }

    public Usuario? BuscarUsuario(string login) {
        return usuarios.FirstOrDefault(u => u.login.Equals(login));
    }

    private static bool IsEmailValido(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, pattern);
    }
}