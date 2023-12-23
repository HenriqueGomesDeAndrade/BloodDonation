using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.Helpers
{
    public class PageQuery
    {
        [Range(0, 50)]
        public int Top { get; set; } = 10;

        [Range(0, int.MaxValue)]
        public int Skip { get; set; } = 0;
    }
}
