﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMSv2.Models
{
	public class Topic
	{
		public int Id { get; set; }

		[Required]
		[DisplayName("Topic Name")]
		public string Name { get; set; }

		[DisplayName ("Topic Description")]
		public string Description { get; set; }
	}
}