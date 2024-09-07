using FluentAssertions;
using FluentAssertions.Extensions;
using Preuba2.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Preuba2Test.PingTest
{
    public class NetworkServiceTest
    {
        private readonly NetworkService _networkService;

        public NetworkServiceTest()
        {
            _networkService = new NetworkService();
        }

        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange

            //Act - Execute
            var result = _networkService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping sent");
            result.Should().Contain("Success", Exactly.Once());
        }

        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(2, 2, 4)]
        public void NetworkService_PingTimeOut_ReturnInt(int a, int b, int expected)
        {
            //arrange

            //act
            var result = _networkService.PingTimeOut(a, b);

            //assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-500, 0);
        }

        [Fact]
        public void NetworkService_LastPingDate_ReturnDateTime()
        {
            //Arrange

            //Act - Execute
            var result = _networkService.LastPingDate();

            //Assert
            result.Should().BeAfter(1.January(2020));
            result.Should().BeBefore(1.July(2030));
        }

        [Fact]
        public void NetworkService_GetPingOptions_ReturnPingOptions()
        {
            //Arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            //Act - Execute
            var result = _networkService.GetPingOptions();

            //Assert
            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.Ttl.Should().Be(1);
        }

        [Fact]
        public void NetworkService_MostRecentPings_ReturnObject()
        {
            //Arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            //Act - Execute
            var result = _networkService.MostRecentPings();

            //Assert
            result.Should().NotBeNull();    
            result.Should().BeOfType<List<PingOptions>>();
            result.Should().Contain(x => x.Ttl == 2);
            result.Should().NotContain(x => x.Ttl == 4);
        }

    }
}
