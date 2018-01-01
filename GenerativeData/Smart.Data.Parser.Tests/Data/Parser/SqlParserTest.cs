namespace Smart.Data.Parser
{
    using Xunit;

    public class SqlParserTest
    {
        [Fact]
        public void Test1()
        {
            var parser = new SqlParser();

            Assert.NotNull(parser);
        }
    }
}
