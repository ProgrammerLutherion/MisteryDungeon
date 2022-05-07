using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/BraceletItem")]
public class BraceletItem : ItemObject
{
    [SerializeField] private int ArmorValue;
    private void Awake()
    {
        type = ItemType.Armor;
        equipmenttype = EquipmentPart.Bracelet;
    }
}
