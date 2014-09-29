using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    //Step 2: Make a partial class for class we're trying to validate
    //Step 3: Add data annotation for the metadataType to the validation class
    [MetadataType(typeof(ContactMeFormValidation))]
    public partial class ContactMeForm
    {
    }
    public class ContactMeFormValidation
    {
        //Step 4: Declare the properties of the class you want to validate, set data annotations
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}