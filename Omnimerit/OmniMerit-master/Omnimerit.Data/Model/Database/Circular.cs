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
    public partial class Circular
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*Please enter Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "*Please enter Reference Number")]
        public string Reference_Number { get; set; }

  
        public string Content { get; set; }

        [Required(ErrorMessage = "*Please enter Date")]
         [DataType(DataType.Date)]
        public Nullable<System.DateTime> Date { get; set; }
    }
}
