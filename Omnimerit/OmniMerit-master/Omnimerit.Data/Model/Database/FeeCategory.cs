//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Omnimerit.Data.Model.Database
{
    using System;
    using System.Collections.Generic;
    using Omnimerit.Data.BussinessLayer;
    using System.ComponentModel.DataAnnotations;
    public partial class FeeCategory
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*Please enter Fee Category")]
        public string FeeCategory1 { get; set; }

        [Required(ErrorMessage = "*Please enter Receipt Prefix")]
        public string ReceiptPrefix { get; set; }

        [Required(ErrorMessage = "*Please add Description")]
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
