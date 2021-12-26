using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Empty Slot", menuName = "Objects/Empty Slot")]
public class EmptySlotObject : ItemObject
{
    public GameObject prefab;

    private void Awake()
    {
        type = ItemType.EmptySlot;
    }
}
