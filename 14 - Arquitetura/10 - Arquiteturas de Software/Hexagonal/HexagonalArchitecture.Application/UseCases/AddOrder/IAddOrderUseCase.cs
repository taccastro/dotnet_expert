namespace HexagonalArchitecture.Application.UseCases.AddOrder
{
    public interface IAddOrderUseCase
    {
        Task<int> Execute(AddOrderInput input);
    }
}
