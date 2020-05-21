using System;
using System.Collections.Generic;
using System.Text;

public class EquipmentList
{
    /// <summary>
    /// Slot is empty
    /// </summary>
    public static Equipment noWeapon = new Equipment("None", 1, 0, EquipmentType.Weapon,0);
    public static Equipment noArmor = new Equipment("None", 0, 3, EquipmentType.Armor, 0);
    public static Equipment noSource = new Equipment("None", 0, 0, EquipmentType.Source, 0);
    public static Equipment noShield = new Equipment("None", 0, 0, EquipmentType.Shield, 0);

    /// <summary>
    ///  WEAPONS
    /// </summary>
    public static Equipment shortSword = new Equipment("Short Sword", 2, 0, EquipmentType.Weapon, 1000);
    public static Equipment longSword = new Equipment("Long Sword", 3, 4, EquipmentType.Weapon, 3000);

    //////
    /// Head Armor
    //////
    public static Equipment leatherHead = new Equipment("Leather Helmet", 2, 2, EquipmentType.Armor, 1000);
    public static Equipment chainHead = new Equipment("Chain Coif", 3, 1, EquipmentType.Armor, 2000);
    public static Equipment plateHead = new Equipment("Plate Helm", 4, 0, EquipmentType.Armor, 3000);

}