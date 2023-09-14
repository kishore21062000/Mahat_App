using Microsoft.Identity.Client;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace APICallExample
{
	class Program
	{
		static async Task Main(string[] args)
		{
			// Azure AD application configuration
			string clientId = "aece7cfd-03b0-4c98-a10c-9176112d0419";
			string clientSecret = "uhW8Q~PIxsimoKSN6tgOxp.1U-_5dwkFdkLUNcxg";
			string authority = "https://login.microsoftonline.com/f4f47804-5d8d-4e7a-a35d-32e03eba3983";
			string graphApiEndpoint = "https://graph.microsoft.com/v1.0/users/$count";

			IConfidentialClientApplication app = ConfidentialClientApplicationBuilder
				.Create(clientId)
				.WithClientSecret(clientSecret)
				.WithAuthority(new Uri(authority))
				.Build();

			string accessToken = "eyJ0eXAiOiJKV1QiLCJub25jZSI6InBLWWJ0d1ZwaVVJS1VkdHdFSnFVb1pURW9UdVVmai14VURFSndJb2xvVGsiLCJhbGciOiJSUzI1NiIsIng1dCI6Ii1LSTNROW5OUjdiUm9meG1lWm9YcWJIWkdldyIsImtpZCI6Ii1LSTNROW5OUjdiUm9meG1lWm9YcWJIWkdldyJ9.eyJhdWQiOiJodHRwczovL2dyYXBoLm1pY3Jvc29mdC5jb20iLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC9mNGY0NzgwNC01ZDhkLTRlN2EtYTM1ZC0zMmUwM2ViYTM5ODMvIiwiaWF0IjoxNjk0MDg2ODIyLCJuYmYiOjE2OTQwODY4MjIsImV4cCI6MTY5NDA5MDcyMiwiYWlvIjoiRTJGZ1lKaXlJUFgvNHNtaGhlVmNXZThVQTY0a0FRQT0iLCJhcHBfZGlzcGxheW5hbWUiOiJBUElfVGVzdCIsImFwcGlkIjoiYWVjZTdjZmQtMDNiMC00Yzk4LWExMGMtOTE3NjExMmQwNDE5IiwiYXBwaWRhY3IiOiIxIiwiaWRwIjoiaHR0cHM6Ly9zdHMud2luZG93cy5uZXQvZjRmNDc4MDQtNWQ4ZC00ZTdhLWEzNWQtMzJlMDNlYmEzOTgzLyIsImlkdHlwIjoiYXBwIiwib2lkIjoiMWVjOWYwODUtYjNhMS00ODdhLWIxODctNGE5OTA4YTYwNTkzIiwicmgiOiIwLkFUMEFCSGowOUkxZGVrNmpYVExnUHJvNWd3TUFBQUFBQUFBQXdBQUFBQUFBQUFDaEFBQS4iLCJyb2xlcyI6WyJDdXN0b21BdXRoZW50aWNhdGlvbkV4dGVuc2lvbi5SZWNlaXZlLlBheWxvYWQiLCJBdXRoZW50aWNhdGlvbkNvbnRleHQuUmVhZC5BbGwiLCJWaXJ0dWFsRXZlbnQuUmVhZC5BbGwiLCJWaXJ0dWFsQXBwb2ludG1lbnQuUmVhZFdyaXRlLkFsbCIsIkN1c3RvbUF1dGhlbnRpY2F0aW9uRXh0ZW5zaW9uLlJlYWQuQWxsIiwiRGV2aWNlTWFuYWdlbWVudFNlcnZpY2VDb25maWcuUmVhZC5BbGwiLCJVc2VyLlJlYWQuQWxsIiwiRGV2aWNlTWFuYWdlbWVudFNlcnZpY2VDb25maWcuUmVhZFdyaXRlLkFsbCIsIkFQSUNvbm5lY3RvcnMuUmVhZC5BbGwiLCJWaXJ0dWFsQXBwb2ludG1lbnQuUmVhZC5BbGwiLCJSZXNvdXJjZVNwZWNpZmljUGVybWlzc2lvbkdyYW50LlJlYWRGb3JVc2VyLkFsbCIsIkRldmljZU1hbmFnZW1lbnRBcHBzLlJlYWRXcml0ZS5BbGwiLCJEZXZpY2VNYW5hZ2VtZW50QXBwcy5SZWFkLkFsbCJdLCJzdWIiOiIxZWM5ZjA4NS1iM2ExLTQ4N2EtYjE4Ny00YTk5MDhhNjA1OTMiLCJ0ZW5hbnRfcmVnaW9uX3Njb3BlIjoiQVMiLCJ0aWQiOiJmNGY0NzgwNC01ZDhkLTRlN2EtYTM1ZC0zMmUwM2ViYTM5ODMiLCJ1dGkiOiJZRHFDWjBGZXYwaUxEbDZfQ2JJMUFBIiwidmVyIjoiMS4wIiwid2lkcyI6WyIwOTk3YTFkMC0wZDFkLTRhY2ItYjQwOC1kNWNhNzMxMjFlOTAiXSwieG1zX3RjZHQiOjE2OTI5NDE1NjJ9.klKB2Kd5rtMUK2bGeYkMfF5kkKzz0S-Qqnc78nBBFqbv79xhySrcj9dj4KPo-g0rFxIofSpoxab7IASMF8mRYthjPI2e2KYrjth7nQ_cMBPbY4PohXLCv5OjshIlJzMq94_fWn2_1vJIIfM_i8JxmQjZeZ-VigKZvm0NAgT3qwSN1OUnOTUcE_AeDemGB-Z5gbT7LKCVXeaGVfVtRdStIIs-wuibKiDFNWajwOHWR54xeOEucwX5O1Knv0X7_JBRPS4UeX9NLayih8TJhh-jlgTmP9tDTtewh2bG18cUQOwaDl7-VMDCyTLJpCmLuLZ5s4UqBgmtNuQOoo01lhi5cA";

			try
			{
				// Create an HttpClient instance
				using (var httpClient = new HttpClient())
				{
					// Add the "consistencyLevel" custom header
					httpClient.DefaultRequestHeaders.Add("consistencyLevel", "eventual");

					// Set the authorization header with the access token
					httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

					// Make the HTTP request with the custom header
					var response = await httpClient.GetAsync(graphApiEndpoint);

					if (response.IsSuccessStatusCode)
					{
						string apiResponse = await response.Content.ReadAsStringAsync();
						Console.WriteLine("API Response:\n" + apiResponse);
					}
					else
					{
						throw new Exception($"Error calling Graph API: {response.StatusCode}");
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}
	}
}
