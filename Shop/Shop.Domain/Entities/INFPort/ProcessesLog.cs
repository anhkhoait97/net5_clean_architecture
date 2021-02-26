using System;

namespace Shop.Domain.Entities.INFPort
{
    public class ProcessesLog
    {
        public long ID { get; set; }
        public int? stmt_start { get; set; }
        public int? stmt_end { get; set; }
        public int? Cpu { get; set; }
        public string Hostname { get; set; }
        public string Query { get; set; }
        public string Status { get; set; }
        public string Loginname { get; set; }
        public string DBName { get; set; }
        public DateTime? Date { get; set; }
        public string program_name { get; set; }
        public DateTime? StartTime { get; set; }
        public string Command { get; set; }
        public int? Time { get; set; }
        public string ClientIP { get; set; }
    }
}
