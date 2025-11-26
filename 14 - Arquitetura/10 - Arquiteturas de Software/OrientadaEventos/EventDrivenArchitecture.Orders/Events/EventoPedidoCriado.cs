using EventDrivenArchitecture.Orders.Models;

namespace EventDrivenArchitecture.Orders.Events
{
    public class EventoPedidoCriado
    {
        public EventoPedidoCriado(int id, ModeloEntradaPedido modelo)
        {
            Id = id;
            NomeCliente = modelo.NomeCliente;
            EmailCliente = modelo.EmailCliente;
            Itens = modelo.Itens.Select(i => new ModeloItemPedido(i.IdProduto, i.Quantidade)).ToList();
            PrecoTotal = modelo.Itens.Sum(i => i.Quantidade * i.PrecoUnitario);
        }

        public int Id { get; private set; }
        public string NomeCliente { get; private set; }
        public string EmailCliente { get; private set; }
        public List<ModeloItemPedido> Itens { get; private set; }
        public decimal PrecoTotal { get; private set; }
    }

    public class ModeloItemPedido
    {
        public ModeloItemPedido(int idProduto, int quantidade)
        {
            IdProduto = idProduto;
            Quantidade = quantidade;
        }

        public int IdProduto { get; private set; }
        public int Quantidade { get; private set; }
    }
}
