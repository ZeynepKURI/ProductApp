using System;
namespace Product.Domain.Common
{
	public class BaseEntity
	{
		public Guid Int { get; set; }

		public DateTime UpdateDate { get; set; }
	}
}

