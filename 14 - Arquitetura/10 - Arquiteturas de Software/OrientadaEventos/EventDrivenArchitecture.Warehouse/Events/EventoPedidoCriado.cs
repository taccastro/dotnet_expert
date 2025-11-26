namespace EventDrivenArchitecture.Warehouse.Events
{
    public class EventoPedidoCriado
    {
        public EventoPedidoCriado(int id, string nomeCliente, string emailCliente, List<ModeloItemPedido> itens, decimal precoTotal)
        {
            Id = id;
            NomeCliente = nomeCliente;
            EmailCliente = emailCliente;
            Itens = itens;
            PrecoTotal = precoTotal;
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
