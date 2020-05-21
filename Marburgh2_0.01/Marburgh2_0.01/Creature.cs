using System;
using System.Collections.Generic;
using System.Text;

public class Creature
{
    public string name;
    public Body head;
    public Body torso;
    public Body leftArm;
    public Body rightAm;
    public Body other;
    public int endurance;
    public int offence;
    public int defence;
    public int gold;
    public int xp;
    public int mage;
    public int rogue;
    public int warrior;
    public int[] levelUp = new int[] { 0, 20, 40, 70, 100, 150, 200 };
    public int totalLevelPoints;
    public int availableLevelPoints;

    public Creature(string name, Body head, Body torso, Body leftArm, Body rightArm, Body other, int endurance, int offence, int defence)
    {
        this.name = name;
        this.head = head;
        this.torso = torso;
        this.leftArm = leftArm;
        this.rightAm = rightArm;
        this.other = other;
        this.endurance = endurance;
        this.offence = offence;
        this.defence = defence;
        totalLevelPoints = 0;
        availableLevelPoints = 0;
    }
}