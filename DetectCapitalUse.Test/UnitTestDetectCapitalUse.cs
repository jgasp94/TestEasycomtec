namespace DetectCapitalUse.Test
{
    public class UnitTestDetectCapitalUse
    {
        [Theory(DisplayName = "Teste com valores válidos")]
        [InlineData("USA")]
        [InlineData("Google")]
        [InlineData("Easycomtec")]
        public void IsValid(string word)
        {
            Assert.True(DetectCapitalUse.Run(word));
        }

        [Theory(DisplayName = "Teste com valores inválidos")]
        [InlineData("UsA")]
        [InlineData("GoogLe")]
        [InlineData("EasyComtec")]
        public void IsNotValid(string word)
        {
            Assert.False(DetectCapitalUse.Run(word));
        }
    }
}