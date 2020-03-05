using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtierEcommerce.MODEL.Entity
{
	public class AppUser
    {
		public int ID { get; set; }
		[MaxLength(25)]
		public string Name { get; set; }
		[MaxLength(25)]
		public string Surname { get; set; }
		[MaxLength(25)]
		public string Username { get; set; }

		public string Password { get; set; }//123
		[Compare("Password")]
		[NotMapped]
		public string ConfirmPassword { get; set; }//321
		[MaxLength(150)]
		public string Email { get; set; }
		[MaxLength(255)]
		public string Address { get; set; }
		[MaxLength(11)]
		public string PhoneNumber { get; set; }
		[MaxLength(255)]
		public string ImagePath { get; set; }
		public DateTime? BirthDate { get; set; }

		public virtual List<Order> Orders { get; set; }

	}
}
