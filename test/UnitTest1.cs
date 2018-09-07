using System;
using Xunit;
using web;

namespace test
{
    public class IdProviderTest
    {
        [Fact]
        public void NewIdShouldReturnValues()
        {
            var idProvider = new web.IdProvider();
            var id1 = idProvider.NewId();
            var id2 = idProvider.NewId();
            Assert.NotEqual(id1,id2);
        }
    }
}