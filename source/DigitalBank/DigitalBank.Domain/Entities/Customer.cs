using System;

namespace DigitalBank.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public long CellNumber { get; set; }
        public long? HomePhoneNumber { get; set; }
        public long? WorkPhoneNumber { get; set; }
        public Guid Address { get; set; }
    }
}
