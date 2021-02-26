namespace Shop.Application.Interfaces.Shared
{
    public interface ICurrentUserService
    {
        string UserId { get; }
        public string Username { get; }
    }
}
