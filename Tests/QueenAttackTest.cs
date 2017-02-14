using Xunit;
using System;
using System.Collections.Generic;

namespace QueenAttack
{
  public class QueenTest
  {
    [Fact]
    public void Queen_ForUserInputHorizonal_True()
    {
      Queen testQueenAttack = new Queen();
      Assert.Equal(true, testQueenAttack.CanAttack(1,2));
    }

    [Fact]
    public void Queen_ForUserInputVertical_True()
    {
      Queen testQueenAttack = new Queen();
      Assert.Equal(true, testQueenAttack.CanAttack(2,1));
    }

    [Fact]
    public void Queen_ForUserInputDiagonal_True()
    {
      Queen testQueenAttack = new Queen();
      Assert.Equal(true, testQueenAttack.CanAttack(2,2));
    }

    [Fact]
    public void Queen_ForUserInputElse_False()
    {
      Queen testQueenAttack = new Queen();
      Assert.Equal(true, testQueenAttack.CanAttack(4,2));
    }
  }
}
