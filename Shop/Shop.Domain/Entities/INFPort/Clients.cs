namespace Shop.Domain.Entities.INFPort
{
    public class Clients
    {
        public string Id { get; set; }
        public string Secret { get; set; }
        public string Name { get; set; }
        public int ApplicationType { get; set; }
        public bool Active { get; set; }
        public int RefreshTokenLifeTime { get; set; }
        public string AllowedOrigin { get; set; }
    }
}
