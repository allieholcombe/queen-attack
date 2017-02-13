using System.Collections.Generic;
using System;
using Nancy;

namespace QueenAttack.Objects
{
  public class Queen
  {
    private int _xCoord;
    private int _yCoord;

    public Queen(int xCoord, int yCoord)
    {
      _xCoord = xCoord;
      _yCoord = yCoord;
    }

    public int GetXCoord()
    {
      return _xCoord;
    }
    public void SetXCoord(int inputXCoord)
    {
      _xCoord = inputXCoord;
    }

    public int GetYCoord()
    {
      return _yCoord;
    }
    public void SetYCoord(int inputYCoord)
    {
      _yCoord = inputYCoord;
    }

    public bool CanAttack(Queen newQueen, int pXCoord, int pYCoord)
    {
      int qXCoord = newQueen.GetXCoord();
      int qYCoord = newQueen.GetYCoord();

      if ((qXCoord == pXCoord) && (qYCoord == pYCoord))
      {
        return false;
      }
      else
      {
        return false;
      }
    }
  }
}
