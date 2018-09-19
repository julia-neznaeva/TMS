using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; } //(int, not null)
        public int ConfigurationStep { get; set; } //(int, not null)
        public bool IsConfigured { get; set; } //(bit, not null)
        public string Name { get; set; } //(nvarchar(128), null)
        public bool IsThirdPartyBillingEnabled { get; set; } //(bit, null)
        public int SubscriptionTypeId { get; set; } //(int, null)
        public int CustomerInviteId { get; set; } //(int, null)
        public bool Invited { get; set; } //(bit, not null)
        public string RecurlyAccountCode { get; set; } //(nvarchar(255), null)
        public int SubscriptionStatus { get; set; } //(int, null)
        public bool IsSystemBOL { get; set; } //(bit, null)
        public DateTime ActivationDate { get; set; } //(datetime2(7), null)
        public string SpecialInstructionDefaultText { get; set; } //(nvarchar(350), null)
        public bool SuggestedFreightClassEnabled { get; set; } //(bit, not null)
        public int QuoteTimeoutSetting { get; set; } //(int, not null)
        public string CustomerLogo { get; set; } //(nvarchar(512), null)
        public string ShippingDocumentDefaultText { get; set; } //(nvarchar(1000), null)
        public string TrackingEmailDefaultText { get; set; } //(nvarchar(1000), null)
        public bool IsRequiredNmfcCode { get; set; } //(bit, not null)
        public bool IsEnabledDedicatedThirdParty { get; set; } //(bit, not null)
        public bool IsAllowUnsupportedAccessorials { get; set; }
    }
}
