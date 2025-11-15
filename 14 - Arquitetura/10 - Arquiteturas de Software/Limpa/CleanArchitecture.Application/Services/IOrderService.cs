using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Services
{
    public interface IOrderService
    {
        Task<ResultBase<int>> Add(AddOrderInputModel input);
        Task<ResultBase<GetAllOrdersViewModel>> GetAll();
        Task<ResultBase<GetOrderByIdViewModel>> GetById(int id);
    }
}
