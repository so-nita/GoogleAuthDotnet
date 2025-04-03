using Microsoft.AspNetCore.Identity;

namespace GoogleAuthDotnet.Entities
{
	public class User : IdentityUser<int>
	{
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public bool IsDeleted { get; set; } = false;
	}
}
