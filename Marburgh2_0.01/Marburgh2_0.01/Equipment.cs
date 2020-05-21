using System;
using System.Collections.Generic;
using System.Text;

public enum EquipmentType {Armor, Weapon, Shield, Source }
public class Equipment
{
    public string name;
    public int hp;
    public int maxHp;
    public int damage;
    public int offence;
    public int defence;
    public int effect1;
    public int effect2;
    public int spellpower;
    public EquipmentType type;
    public int value;

    public Equipment(string name, int effect1, int effect2, EquipmentType type, int value)
    {
        this.name = name;
        this.effect1 = effect1;
        this.effect2 = effect2;
        this.type = type;
        this.value = value;
        if (type == EquipmentType.Armor)
        {
            hp = maxHp = effect1;
            defence = effect2;
        }
        if (type == EquipmentType.Weapon)
        {
            damage = effect1;
            offence = effect2;
        }
        if (type == EquipmentType.Shield)
        {
            defence = effect1;
        }
        if (type == EquipmentType.Source)
        {
            spellpower = effect1;
        }
    }

}