using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public  abstract InteractableType type { get; set; }
    public abstract Item itenItHas {get;set;}
    public abstract bool hasItemOnIt {get;set;}
    public abstract bool highLightOn{get; set;}
    public abstract Item GiveItens(Item itenToGive);
    public abstract void ReceiveItens(Item itenReceived);
    
}

public enum InteractableType 
{
    _Null,
    _Oven,
    _Storer,
    _Preparer,
    _Balcon,
}
