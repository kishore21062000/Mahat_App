using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		// Replace with your own Gmail API credentials JSON file path.
		string credentialsFilePath = @"C:\Users\lenovo\Downloads\client_secret_500954476193-dl772jnvig5aedcieg6h0tqrjstugh0j.apps.googleusercontent.com.json";

		// Replace with the recipient's email address.
		string recipientEmail = "kishorekarthik095@gmail.com";

		// Replace with your client ID, client secret, and refresh token.
		string clientId = "500954476193-dl772jnvig5aedcieg6h0tqrjstugh0j.apps.googleusercontent.com";
		string clientSecret = "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";
		string refreshToken = "1//04czLPEaCl0USCgYIARAAGAQSNwF-L9IrZ-gQ2rL6OFq7GBDBzUjTDSRI8p8ehOrWBP6aTWsMXTq9V1yYR9E5VN5UbxNk5hAP6bE";

		try
		{
			var clientSecrets = new ClientSecrets
			{
				ClientId = clientId,
				ClientSecret = clientSecret          //upto this want to complete
			};

			var tokenResponse = new TokenResponse
			{
				RefreshToken = refreshToken
			};

			var credential = new UserCredential(new GoogleAuthorizationCodeFlow(
				new GoogleAuthorizationCodeFlow.Initializer
				{
					ClientSecrets = clientSecrets,
					Scopes = new[] { GmailService.Scope.MailGoogleCom },
				}),
				"user",
				tokenResponse);

			var service = new GmailService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential
			});

			var email = new MimeKit.MimeMessage();
			email.From.Add(new MimeKit.MailboxAddress("kishore", "kishorekarthik095@gmail.com"));
			email.To.Add(new MimeKit.MailboxAddress("", recipientEmail));
			email.Subject = "Demo mail";
			email.Body = new MimeKit.TextPart("plain")
			{
				Text = "Hi kishore your server has turned off let us continue after some time"
			};

			var emailText = email.ToString();

			var message = new Message
			{
				Raw = Base64UrlEncode(emailText)
			};

			service.Users.Messages.Send(message, "me").Execute();
			Console.WriteLine("Email sent successfully.");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}
	}

	private static string Base64UrlEncode(string input)
	{
		byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
		return Convert.ToBase64String(inputBytes)
			.Replace('+', '-')
			.Replace('/', '_')
			.TrimEnd('=');
	}
}
