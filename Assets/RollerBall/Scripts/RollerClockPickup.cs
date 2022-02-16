using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerClockPickup : RollerPickup, IDestructable
{
    [SerializeField] float addedTime;

    public void Destroyed()
    {
        RollerGameManager.Instance.GameTime += addedTime;
    }

}
