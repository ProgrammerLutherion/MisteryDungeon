using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/WeaponItem")]
public class WeaponItem : ItemObject
{
    [SerializeField] private int WeaponValue;
    private void Awake()
    {
        type = ItemType.Weapon;
        equipmenttype = EquipmentPart.Weapon;
    }
}
