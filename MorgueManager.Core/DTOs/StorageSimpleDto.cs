using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgueManager.Core.DTOs
{
    public class StorageSimpleDto
    {
        public int Id { get; set; }
        public string LocationCode { get; set; } = string.Empty;
    }
}
