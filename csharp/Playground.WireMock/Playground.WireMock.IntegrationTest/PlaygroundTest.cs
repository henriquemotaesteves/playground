using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WireMock.Server;
using WireMock.Settings;
using Xunit;

namespace Playground.WireMock.IntegrationTest
{
    public class PlaygroundTest
    {
        private readonly WireMockServer _server;

        public PlaygroundTest()
        {
            _server = WireMockServer.Start(new WireMockServerSettings
            {
                ReadStaticMappings  = true,
                StartAdminInterface = true,
            });
        }

        [Fact]
        public async Task Playground()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "4d911614-fa48-484f-b8e6-98674fd73964");

            var response = await client.PostAsync(_server.Urls.First() + "/playground", new StringContent("{}", Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();
        }
    }
}
