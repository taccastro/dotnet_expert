namespace EventDrivenArchitecture.Orders.Models
{
    public class ModeloEntradaPedido
    {
        public string CodigoPedido { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public List<ModeloItemEntradaPedido> Itens { get; set; }
    }

    public class ModeloItemEntradaPedido
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
    }
}
