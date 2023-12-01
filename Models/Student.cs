using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.Entity;

namespace CodeFirst2.Models
{
    [Table("tbl_student")]
    public class Student
    {
        [Key]
        public int studentId { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        [StringLength(40, ErrorMessage ="cannot accept more than 40 char")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage ="Invalid Name")]
        public String std_name { get; set; }

        // Some Change gterg sgdfggf

        [Required(ErrorMessage = "Address is Required")]
        public String address { get; set; }


        [Required(ErrorMessage = "Email is Required")]
        public String Email { get; set; }


        [Required(ErrorMessage ="Date is Required")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        public String Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Required")]
        [Compare("Password", ErrorMessage ="Password does not match")]
        public String cPassword { get; set; }

         /*public*/ 



        int age { get; set; }


    }

    public class CS : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}