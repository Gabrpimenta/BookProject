﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookWeb.Models
	{
	public class Category
		{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[DisplayName("Display Order")]
		[Range(1, 1000, ErrorMessage = "Display Order must be between 1 and 100.")]
		public int DisplayOrder { get; set; }

		public DateTime CreatedDateRime { get; set; } = DateTime.Now;
		}
	}