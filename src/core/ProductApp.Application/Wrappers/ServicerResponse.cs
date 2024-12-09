using System;
namespace ProductApp.Application.Wrappers
{
	public class ServicerResponse<T>
	{
		public T Value { get; set; }

		public ServicerResponse(T value)

		{
			Value = value;
		}


		public ServicerResponse()
		{

		}
	}
}

