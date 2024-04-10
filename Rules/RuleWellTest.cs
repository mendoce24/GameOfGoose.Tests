using GameOfGoose.Factories;

namespace GameOfGoose.Tests.Rules
{
    public class RuleWellTest
    {
        [Fact]
        public void IfPlayerEntersWell_ThenPlayerHasToSkip_Indefenitely()
        {
            //Arrange
            Player player = new Player("N");
            IRules ruleWell = new RuleFactory().CreateRule(39, RuleType.Well);

            //Act
            ruleWell.ValidateRule(player);

            //Assert
            Assert.True(player.InWell);
        }

        [Fact(Skip = "Not implemented yet")]
        public void IfPlayerIsStuckInWell_ThenPlayerCannotMove()
        {
            throw new NotImplementedException();
        }

        [Fact(Skip = "Not implemented yet")]
        public void IfPlayerIsStuckInWell_ThenPlayerCannotMove_UntilAnotherPlayersEnters()
        {
            throw new NotImplementedException();
        }
    }
}