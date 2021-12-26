using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfScript : MonoBehaviour
{
    [SerializeField] private ShelfObject _shelfObject;
    
    //From ItemObject
    public ItemType type;
    public string objectName;
    [TextArea(10, 20)]
    public string description;

    //From ShelfObject
    public ItemObject emptySlot;
    public int shelfSlots;
    public int freeSlots;
    public int reservedSlots;

    public GameObject slotPrefab;

    private void Awake()
    {
        //TODO: import from save

        //Taking parameters from ItemObject
        type = _shelfObject.type;
        objectName = _shelfObject.name;
        description = _shelfObject.description;

        //Taking parameters from ShelfObject
        emptySlot = _shelfObject.emptySlot;
        shelfSlots = _shelfObject.shelfSlots;
        freeSlots = _shelfObject.freeSlots;
        reservedSlots = _shelfObject.reservedSlots;
    }
    private void Start()
    {
        for (int i = 0; i < _shelfObject.shelfSlots ; i++)
        {
            _shelfObject.AddItem(_shelfObject.emptySlot, 1);
            var shelfSlot = Instantiate(slotPrefab, transform.position, transform.rotation);
            shelfSlot.transform.parent = gameObject.transform.Find("Slots").transform;
        }

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
