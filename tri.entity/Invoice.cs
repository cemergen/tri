using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tri.entity
{
    public class Invoice : BaseEntity
    {
        [Display(Name = "Invoice Id")]
        public int InvoiceId { get; set; }
        [Display(Name = "Account Id")]
        public int AccountId { get; set; }
        [Display(Name = "Tax Point Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TaxPointDate { get; set; }
        [Display(Name = "Reference")]
        public string Reference { get; set; }
        [Display(Name = "Total Net")]
        public decimal TotalNet { get; set; }
        [Display(Name = "Total Vat")]
        public decimal TotalVat { get; set; }
        [Display(Name = "Total Gross")]
        public decimal TotalGross { get; set; }

        public virtual Account Account { get; set; }
    }
}
