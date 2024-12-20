using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace asm_csharp.Data
{
	public class Employee
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string User_name { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		
		public double Salary { get; set; }
		public int Is_deleted { get; set; }
		public string Img_user { get; set; }
		public int Room_id { get; set; }
		public string Room_name { get;set; }

	}
}
