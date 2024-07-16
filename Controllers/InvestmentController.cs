using System.Web.Http;
using System.Web.Http.Cors;
using CdbCalculatorAPI.Services;

[EnableCors(origins: "*", headers: "*", methods: "*")]
public class InvestmentController : ApiController
{
    private readonly IInvestmentService _investmentService;

    public InvestmentController(IInvestmentService investmentService)
    {
        _investmentService = investmentService;
    }

    [HttpPost]
    [Route("api/investment/calculate")]
    public IHttpActionResult calculate(decimal initialAmount, int months)
    {                                          
        var result = _investmentService.CalculateInvestment(initialAmount, months);
        return Ok(result);
    }
}


