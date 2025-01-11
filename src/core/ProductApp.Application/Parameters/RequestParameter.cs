using System;
namespace ProductApp.Application.Parameters
{
	public class RequestParameter
	{
		public int PageSize { get; set; }

		public int PageNumber { get; set; }


		public RequestParameter(int pagesize, int pageNumber)
		{
			PageNumber = pageNumber;
			PageSize = pagesize;
		}
	}
}

