using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public enum Type
    { 
        SWORD,
        GUN,
        KEY
    }

    public Type type;
    public Animator animator;
    public GameObject visual;
    public string input;

    public abstract void Activate();
    public abstract void Deactivate();
    public abstract void UpdateItem();
}
