﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole.DataModels
{
    [Table("People")]
    public class PersonModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public AddressModel Address { get; set; }

    }
}
