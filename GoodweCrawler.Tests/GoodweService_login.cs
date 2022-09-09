using Moq;
using Moq.Protected;
using NetCoreCraw;

namespace GoodweCrawler.Tests
{
    [TestFixture]
    public class GoodweService_login
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GoodweService_LoginOk_ReturnTrue()
        {
            var httpMessageHandlerMock = new Mock<HttpClientHandler>();
            // Set up the SendAsync method behavior.
            httpMessageHandlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage(System.Net.HttpStatusCode.OK));

            GoodweService _service = new GoodweService(httpMessageHandlerMock.Object);

            var result = _service.IsSiteOnline();
            Assert.IsTrue(result, "If login OK should be true");
        }
        [Test]
        public void GoodweService_LoginFalse_ReturnFalse()
        {
            var httpMessageHandlerMock = new Mock<HttpClientHandler>();
            // Set up the SendAsync method behavior.
            httpMessageHandlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized));

            GoodweService _service = new GoodweService(httpMessageHandlerMock.Object);

            var result = _service.IsSiteOnline();
            Assert.IsFalse(result, "If login fail should be false");
        }
    }
}