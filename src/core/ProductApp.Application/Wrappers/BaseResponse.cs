﻿using System;
namespace ProductApp.Application.Wrappers
{
	public class BaseResponse
	{
		public Guid Id { get; set; }

		public bool Secces { get; set; }

		public String Message { get; set; }
	}
}

