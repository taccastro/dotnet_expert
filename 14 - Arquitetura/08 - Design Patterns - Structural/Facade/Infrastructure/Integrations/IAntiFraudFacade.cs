namespace Patterns.API.Infrastructure.Integrations
{
    public interface IAntiFraudFacade
    {
        AntiFraudResultModel Check(AntiFraudModel model);
    }
}