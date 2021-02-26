using System;
namespace Shop.Domain.Entities.INFPort
{
    public class CorePair
    {
        public long ID { get; set; }
        public long? FromCore { get; set; }
        public long? ToCore { get; set; }
        public int StatusFromCore { get; set; }
        public int? StatusToCore { get; set; }
        public int? Type { get; set; }
    }
}
