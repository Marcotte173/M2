using System;
using System.Collections.Generic;
using System.Text;

public enum Part {Head, Torso, Arm, Leg, Tail, Fang, Claw }
public class Body
{
    public string name;
    public int hp;
    public int maxHp;
    public Part bodyPart;
    public Equipment equipment;
    public Body(string name, int maxHp, Part bodyPart, Equipment equipment)
    {
        this.name = name;
        hp = maxHp = this.maxHp;
        this.bodyPart = bodyPart;
        this.equipment = equipment;
    }
}