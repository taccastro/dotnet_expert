using HexagonalArchitecture.Application.UseCases;
using HexagonalArchitecture.Application.UseCases.AddOrder;
using HexagonalArchitecture.Application.UseCases.GetAllOrders;
using HexagonalArchitecture.Application.UseCases.GetOrderById;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    private readonly IUseCase<NoInput, UseCaseResult<GetAllOrdersOutput>> _getAllUseCase;
    private readonly IUseCase<int, UseCaseResult<GetOrderByIdOutput>> _getByIdUseCase;
    private readonly IAddOrderUseCase _addUseCase;

    public OrdersController(
        IUseCase<NoInput, UseCaseResult<GetAllOrdersOutput>> getAllUseCase,
        IUseCase<int, UseCaseResult<GetOrderByIdOutput>> getByIdUseCase,
        IAddOrderUseCase addUseCase)
    {
        _getAllUseCase = getAllUseCase;
        _getByIdUseCase = getByIdUseCase;
        _addUseCase = addUseCase;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _getAllUseCase.Execute();
        return Ok(result.Data); // ou conforme seu contrato UseCaseResult
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _getByIdUseCase.Execute(id);
        if (!result.Success || result.Data == null) return NotFound();
        return Ok(result.Data);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] AddOrderInput input)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var createdId = await _addUseCase.Execute(input);
        return CreatedAtAction(nameof(GetById), new { id = createdId }, input);
    }
}
