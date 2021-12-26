using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Shelf,
    RIG,
    PowerSupply,
    GraphicsCard,
    EmptySlot
}

public abstract class ItemObject : ScriptableObject
{
    public ItemType type;

    public string objectName;
    [TextArea(10,20)]
    public string description;
}
