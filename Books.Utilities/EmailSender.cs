using Microsoft.AspNetCore.Identity.UI.Services;

namespace Books.Utilities
{
	public class EmailSender : IEmailSender

	{
		public Task SendEmailAsync(string email, string subject, string htmlMessage)
		{
			//logic to send email
			//throw new NotImplementedException();
			return Task.CompletedTask;
		}
	}
}
