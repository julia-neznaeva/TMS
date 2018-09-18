using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Models
{
    public class UserPersonalInfoModel
    {
            public int UserPersonalInfoId { get; set; } //(int, not null)
            public string FirstName { get; set; } //(nvarchar(100), not null)
            public string LastName { get; set; } //(nvarchar(100), not null)
            public string Phone { get; set; } //(nvarchar(20), null)
            public string Email { get; set; } //(nvarchar(255), not null)
            public bool IsActive { get; set; } //(bit, not null)
            public string Extension { get; set; } //(nvarchar(6), null)
            public string Position { get; set; } //(nvarchar(128), null)
            public DateTime ActivityDateTime { get; set; } //(datetime2(7), null)
            public long SupportRequesterId { get; set; } //(bigint, null)
            public bool InitialGuideCompleted { get; set; } //(bit, null)
            public bool IsAgreedWithRule { get; set; } //(bit, null)
    }
}
