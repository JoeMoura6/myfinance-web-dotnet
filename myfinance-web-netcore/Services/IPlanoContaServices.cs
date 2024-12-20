using myfinance_web_netcore.Domain;

namespace myfinance_web_netcore.Services
{
    public interface IPlanoContaServices
    {
        List<PlanoConta> ListarRegistros();
        void Salvar(PlanoConta item);
        void Excluir(int id);
        PlanoConta RetornarRegistro(int id); 
    }
}