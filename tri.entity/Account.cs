using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tri.entity
{
    public class Account : BaseEntity
    {
        public Account()
        {
            this.Invoices = new HashSet<Invoice>();
        }

        [Display(Name = "Account Id")]
        public int AccountId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Address 1")]
        public string Address1 { get; set; }
        [Display(Name = "Address 2")]
        public string Address2 { get; set; }
        [Display(Name = "Town")]
        public string Town { get; set; }
        [Display(Name = "County")]
        public string County { get; set; }
        [Display(Name = "Post Code")]
        public string PostCode { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
