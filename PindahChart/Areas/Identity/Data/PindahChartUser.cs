using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PindahChart.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the PindahChartUser class
    public class PindahChartUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
    }
}
