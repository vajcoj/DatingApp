namespace DatingApp.API.Helpers
{
	public class UserParams
    {
		private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;

		private int pagesize = 10;
		public int PageSize
		{
			get { return pagesize; }
			set { pagesize = (value > MaxPageSize) ? MaxPageSize : value; }
		}

	}
}
