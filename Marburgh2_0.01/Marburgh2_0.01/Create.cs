using System;
using System.Collections.Generic;
using System.Text;

public class Create
{
    public static Creature player = new Creature("Marcotte", BodyPartList.humanHead, BodyPartList.humanTorso, BodyPartList.humanLeftArm, BodyPartList.humanRightArm, BodyPartList.humanLegs, 20, 5, 5);
    public static void Player()
    {
        Write.Line("What is your name?");
        player.name = Return.String();
    }
}