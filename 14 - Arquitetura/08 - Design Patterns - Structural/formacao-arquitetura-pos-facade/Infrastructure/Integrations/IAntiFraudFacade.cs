namespace AwesomeShopPatterns.API.Infrastructure.Integrations
{
    public interface IAntiFraudFacade
    {
        AntiFraudResultModel Check(AntiFraudModel model);
    }
}