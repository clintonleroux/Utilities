using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;

namespace Utility
{
    public static class Rest
    {
        /// <param name="url">string URL to query</param>
        /// <returns>Json Results</returns>
        public static async Task<string> Get(string url, Dictionary<string, string> headers)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();

            foreach (var header in headers)
                client.DefaultRequestHeaders.Add(header.Key, header.Value);

            return await client.GetStringAsync(url);
        }

    }
}