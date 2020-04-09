﻿namespace DatingApp.API.Helpers
{
	public class MessageParams
    {
		private const int MaxPageSize = 50;
		public int PageNumber { get; set; } = 1;

		private int pagesize = 10;
		public int PageSize
		{
			get { return pagesize; }
			set { pagesize = (value > MaxPageSize) ? MaxPageSize : value; }
		}

		public int UserId { get; set; }

		public string MessageContainer { get; set; } = "Unread";
	}
}
