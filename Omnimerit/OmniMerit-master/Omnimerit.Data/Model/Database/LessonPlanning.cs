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
    public partial class LessonPlanning
    {
        public int Id { get; set; }

       [Required(ErrorMessage = "*Please enter Lecture Code")]
        public string Lect_Code { get; set; }

        [Required(ErrorMessage = "*Please Select valid Course")]
        public string Course { get; set; }

        [Required(ErrorMessage = "*Please Select valid Batch")]
        public string Batch { get; set; }

        [Required(ErrorMessage = "*Please Select valid Subject")]
        public string Subject { get; set; }
    }
}
