using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shelf", menuName = "Objects/Shelf")]
public class ShelfObject : ItemObject
{
    public ItemObject emptySlot;
    public Sprite sprite;
    public int shelfSlots;
    public int freeSlots;
    public int reservedSlots;

    private void Awake()
    {
        type = ItemType.Shelf;
    }

    public List<InventorySlot> Container = new List<InventorySlot>();

    public void AddItem(ItemObject _item, int _amount)
    {
        if (freeSlots > 0)
        {
            Container.Add(new InventorySlot(_item, _amount));
        }
    }

    [System.Serializable]
    public class InventorySlot
    {
        public ItemObject item;
        public int amount;

        public InventorySlot(ItemObject _item, int _amount)
        {
            item = _item;
            amount = _amount;
        }

        public void AddAmount(int value)
        {
            amount += value;
        }
    }
}
