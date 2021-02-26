using System;

namespace Shop.Domain.Entities.INFPortObject
{
    public class TLogHistoryFile
    {
        public long ID { get; set; }
        public long? TacitID { get; set; }
        public string NameFile { get; set; }
        public string Description { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
