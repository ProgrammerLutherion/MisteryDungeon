using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/BootsItem")]
public class BootsItem : ItemObject
{
    [SerializeField] private int ArmorValue;
    private void Awake()
    {
        type = ItemType.Armor;
        equipmenttype = EquipmentPart.Boots;
    }
}
