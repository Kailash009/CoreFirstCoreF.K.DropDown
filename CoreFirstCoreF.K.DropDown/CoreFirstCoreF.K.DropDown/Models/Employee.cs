using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreFirstCoreF.K.DropDown.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
        public int age { get; set; }
        public string Mobileno { get; set; }
        public int City { get; set; }
        public decimal Salary { get; set; }

        [Display(Name ="Department")]
        public int Did { get; set; }

        [BindNever]
        [ForeignKey("Did")]
        public Department Department { get; set; }
    }
}

//To unapply and remove last migration:-
//PM > Remove-Migration - Force