using System;
using Xunit;
using Wichian.Baidu;
namespace Wichian.xUnit
{
    public class BaiduAISpeech
    {
        [Fact]
        public void Test_GetAccessToken()
        {
            var result = Speech.GetAccessToken();
            Assert.Contains("refresh_token", result);
        }
        [Fact]
        public void Test_GetAsr()
        {
            var token = Speech.GetAccessToken();
            var result = Speech.GetAsr(token);
            Assert.Contains("corpus_no", result);
        }
    }
}
