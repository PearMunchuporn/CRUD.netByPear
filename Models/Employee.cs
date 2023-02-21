using CRUD.Controllers;
using CRUD.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Models
{
    public class Employee
    {

        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [DisplayName("Name: ")]

        public string Name { get; set; }

        [DisplayName("Age: ")]
        [Range(20, 65, ErrorMessage ="Age neither less than 20 nor more than 65.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Position is required.")]
        [DisplayName("Position: ")]
        public string Position { get; set; }
    }
}
