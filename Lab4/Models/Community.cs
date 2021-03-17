using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4.Models
{
    public class Community
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Display(Name = "Registration Number")]
        public string ID
        {
            get;
            set;
        }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title
        {
            get;
            set;
        }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget
        {
            get;
            set;
        }
        public ICollection<CommunityMembership> Memberships
        {
            get;
            set;
        }
    }
}
