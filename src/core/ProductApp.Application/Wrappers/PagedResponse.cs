using System;
namespace ProductApp.Application.Wrappers
{
	public class PagedResponse<T>: ServicerResponse<T>
	{
		public int PageNumber { get; set; }

		public int PageSize { get; set; }

		public PagedResponse(T value): base(value)
		{

		}

        public PagedResponse()
        {
            PageNumber = 1;
            PageSize = 10;
        }


        public PagedResponse(int pageNumber, int pageSize)
		{
			pageNumber = pageNumber;
			pageSize = pageSize;
		}
	}
}

