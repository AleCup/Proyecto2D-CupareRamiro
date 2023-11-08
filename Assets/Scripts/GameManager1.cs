using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{   
    public int TotalPoints {  get { return totalPoints;  } }
    private int totalPoints;
    
    public void SumPoints(int pointsToSum)
    {
        totalPoints += pointsToSum;
    }
}
