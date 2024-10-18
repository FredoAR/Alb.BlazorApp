namespace Alb.BlazorApp.Shared.Contracts.Comunication
{
    public interface IComunication
    {
        Task<string> SendDtoToMicroservice(string msg);
    }
}
