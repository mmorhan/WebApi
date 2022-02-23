using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    public class User 
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Address{ get; set; }
        public bool status { get; set; }
    }
}
