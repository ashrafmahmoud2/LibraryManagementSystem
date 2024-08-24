namespace LibraryManagementSystem.Core.Models
{
	public class Subscription
	{
		public int Id { get; set; }

		public  int SubscriberId { get; set; }

		public Subscriber? Subscriber { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public string? CreateById { get; set; }

		public ApplicationUser? CreateBy { get; set; }

		public DateTime CreatedOn { get; set; }
	}
}
