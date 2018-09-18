using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Models
{
    public class CustomerInviteModel
    {
        public int CustomerInviteId { get; set; } //(int, not null)
        public int CarrierId { get; set; } //(int, not null)
        public string Email { get; set; } //(nvarchar(64), not null)
        public string FirstName { get; set; } //(nvarchar(100), not null)
        public string LastName { get; set; } //(nvarchar(100), not null)
        public DateTime InvitedDate { get; set; } //(date, not null)
        public bool IsAccepted { get; set; } //(bit, not null)
        public string UserName1 { get; set; } //(nvarchar(256), null)
        public string Credential1 { get; set; } //(nvarchar(256), null)
        public string Credential2 { get; set; } //(nvarchar(256), null)
        public string Credential3 { get; set; } //(nvarchar(256), null)
        public string AccountNumber1 { get; set; } //(nvarchar(256), null)
        public string AccountNumber2 { get; set; } //(nvarchar(256), null)
        public DateTime AcceptedDate { get; set; } //(date, null)
        public Guid InviteKey { get; set; } //(uniqueidentifier, not null)
        public int SalesRepId { get; set; } //(int, null)
        public int CustomerId { get; set; } //(int, null)
        public bool IsShowIndicator { get; set; } //(bit, null)
        public string PersonalMessage { get; set; } //(nvarchar(500), null)
    }
}
