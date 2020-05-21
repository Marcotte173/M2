using System;
using System.Collections.Generic;
using System.Text;

public class BodyPartList
{
    /// <summary>
    /// HUMAN PARTS
    /// </summary>
    public static Body humanHead = new Body("Head",4,Part.Head, EquipmentList.noArmor);
    public static Body humanLeftArm = new Body("Left Arm", 3, Part.Arm, EquipmentList.noArmor);
    public static Body humanRightArm = new Body("Right Arm", 3, Part.Arm, EquipmentList.noArmor);
    public static Body humanTorso = new Body("Right Arm", 5, Part.Torso, EquipmentList.noArmor);
    public static Body humanLegs = new Body("Legs", 4, Part.Leg, EquipmentList.noArmor);
}