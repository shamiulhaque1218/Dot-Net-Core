using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CLIENT_APP.Models
{
    public class Master
    {
        public int   Id  { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(20, ErrorMessage ="Name should contain maximum 20 characters")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [MaxLength(20, ErrorMessage = "Phone should contain maximum 20 characters")]


        public string Phone { get; set; }

        [DataType(DataType.EmailAddress) ]
      


        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [MaxLength(30, ErrorMessage = "Address should contain maximum 30 characters")]



        public string Address { get; set; }
        [Required(ErrorMessage = "Occupation is required")]
        [MaxLength(30, ErrorMessage = "Occupation should contain maximum 30 characters")]


        public string Occupation { get; set; }
    }
}
