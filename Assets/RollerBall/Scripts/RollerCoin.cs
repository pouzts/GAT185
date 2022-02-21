using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerCoin : RollerPickup, IDestructable
{
    public void Destroyed()
    {
        RollerGameManager.Instance.Score += points;
        //RollerGameManager.Instance.Counter += 1;
    }
}
