using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;

namespace Wichian.Baidu
{
    public class Speech
    {
		private const string clientId = "U3f9sO66iM5tzEXzjFWiAWEQ";
		private const string clientSecret = "UsBEU80gdOMPpeRCLZhnw9eAs1CxMMM8";
		public static String GetAccessToken()
		{
			String authHost = "https://aip.baidubce.com/oauth/2.0/token";
			HttpClient client = new();
			List<KeyValuePair<String, String>> paraList = new List<KeyValuePair<string, string>>();
			paraList.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
			paraList.Add(new KeyValuePair<string, string>("client_id", clientId));
			paraList.Add(new KeyValuePair<string, string>("client_secret", clientSecret));

			HttpResponseMessage response = client.PostAsync(authHost, new FormUrlEncodedContent(paraList)).Result;
			String result = response.Content.ReadAsStringAsync().Result;
			Console.WriteLine(result);
			return result;
		}

		public static String GetAsr(string token)
		{
			var data = File.ReadAllBytes(@"D:\repos\Wichian\Wichian.Baidu\Speech\Sample\16k.pcm");
			var data2 = Convert.ToBase64String(data);

			String serverHost = "http://vop.baidu.com/server_api";
			HttpClient client = new();
			
			//client.DefaultRequestHeaders.Add("Content-Type", "application/json");
			List<KeyValuePair<String, String>> paraList = new();
			paraList.Add(new KeyValuePair<string, string>("format", "pcm"));
			paraList.Add(new KeyValuePair<string, string>("rate", "16000"));
			paraList.Add(new KeyValuePair<string, string>("dev_pid", "1537"));
			paraList.Add(new KeyValuePair<string, string>("channel", "1"));
			paraList.Add(new KeyValuePair<string, string>("token", token));
			paraList.Add(new KeyValuePair<string, string>("cuid", "test"));
			paraList.Add(new KeyValuePair<string, string>("len", data2.Length.ToString()));
			paraList.Add(new KeyValuePair<string, string>("speech", data2));

			HttpResponseMessage response = client.PostAsync(serverHost, new FormUrlEncodedContent(paraList)).Result;

			String result = response.Content.ReadAsStringAsync().Result;
			Console.WriteLine(result);
			return result;
		}
	}
}
