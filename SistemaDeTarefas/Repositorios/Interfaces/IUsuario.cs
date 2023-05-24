using SistemaDeUsuario.Models;

namespace SistemaDeUsuario.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task <bool> Apagar(int id);
        Task<UsuarioModel> BuscarPorId();
        Task<UsuarioModel> BuscarPorId(int id);
    }
}
