namespace eTicketData.Entities
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
