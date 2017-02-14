using System;
using System.Collections.Generic;

namespace QueenAttack
{
  public class Queen
  {
    private int _x;
    private int _y;

    public Queen()
    {
      _x = 1;
      _y = 1;
    }

    public bool CanAttack(int enemyX, int enemyY)
    {
      // if (enemyX == _x){
      //   return true;
      // }
      // else if (enemyY == _y)
      // {
      //   return true;
      // }
      // else
      // {
      //   return false;
      // }
      int xDiff = Math.Abs(enemyX-_x);
      int yDiff = Math.Abs(enemyY-_y);
      return (enemyX == _x || enemyY == _y || xDiff == yDiff);
    }
  }
}
