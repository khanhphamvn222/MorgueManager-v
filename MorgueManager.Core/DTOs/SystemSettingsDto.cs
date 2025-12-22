using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgueManager.Core.DTOs
{
    public class SystemSettingsDto
    {
        public string OrganizationName { get; set; } = "Bệnh viện Đa Khoa X";
        public decimal PricePerDay { get; set; } = 500000;
    }
}
