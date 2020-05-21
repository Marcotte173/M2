using System;
using System.Collections.Generic;
using System.Text;

public class Return
{
    public static Creature player = Create.player;
    internal static Random rand = new Random();
    internal static int RandomInt(int min, int max) => rand.Next(min, max);

    internal static bool Afford(int price) => true;
    internal static int Integer()
    {
        int sellChoice;
        do
        {

        } while (!int.TryParse(Console.ReadLine(), out sellChoice));
        return sellChoice;
    }
    internal static int Int()
    {
        int sellChoice;
        do
        {

        } while (!int.TryParse(Console.ReadKey(true).KeyChar.ToString().ToLower(), out sellChoice));
        return sellChoice;
    }

    internal static void Character()
    {
        //Write.Line(60, 28, Color.TIME + $"It is Day { Hub.day}" + Color.RESET);
        //Character Info
        Write.Line(0, 0, $"Name: " + Color.NAME + $"{player.name}" + Color.RESET);
        Write.Line(17, 0, $"Gold: " + Color.GOLD + $"{player.gold}" + Color.RESET);
        Write.Line(30, 0, $"XP: " + Color.XP + player.xp + Color.RESET + "/" + Color.XP + player.levelUp[player.totalLevelPoints + 1] + Color.RESET);
        Write.Line(44, 0, $"Level Points: " + Color.TIME + $"{player.availableLevelPoints}" + Color.RESET);
        Write.Line(62, 0, $"Mage: " + Color.CLASS + $"{player.mage}" + Color.RESET);
        Write.Line(72, 0, $"Rogue: " + Color.CLASS + $"{player.rogue}" + Color.RESET);
        Write.Line(83, 0, $"Warrior: " + Color.CLASS + $"{player.warrior}" + Color.RESET);
        Write.Line(95, 0, $"Endurance: " + Color.ENERGY + $"{player.endurance}" + Color.RESET);
        //MainHand, OffHand, Offence, Defence
        Write.Line(0, 2, $"Weapon:   {player.rightAm.equipment.name}");
        Write.Line(0, 3, $"OffHand:  {player.leftArm.equipment.name}");
        Write.Line(0, 5, $"Offence:  {player.offence}");
        Write.Line(0, 6, $"Defence:  {player.defence}");
        //Body Status
        Write.Line(25, 2, $"Head Status:      {CheckStatus(player.head)}");
        Write.Line(25, 3, $"Torso Status:     {CheckStatus(player.torso)}");
        Write.Line(25, 4, $"Left Arm Status:  {CheckStatus(player.leftArm)}");
        Write.Line(25, 5, $"Right Arm Status: {CheckStatus(player.rightAm)}");
        Write.Line(25, 6, $"Legs Status:      {CheckStatus(player.other)}");
        //Armor Status
        Write.Line(65, 2, $"Head Armor:      {player.head.equipment.name}{CheckStatus(player.head.equipment)}");
        Write.Line(65, 3, $"Torso Armor:     {player.torso.equipment.name}{CheckStatus(player.torso.equipment)}");
        Write.Line(65, 4, $"Left Arm Armor:  {player.leftArm.equipment.name}{CheckStatus(player.leftArm.equipment)}");
        Write.Line(65, 5, $"Right Arm Armor: {player.rightAm.equipment.name}{CheckStatus(player.rightAm.equipment)}");
        Write.Line(65, 6, $"Legs Armor:      {player.other.equipment.name}{CheckStatus(player.other.equipment)}\n\n");
    }

    private static string CheckStatus(Body body)
    {
        if (body.hp == body.maxHp) return Color.HEALTH + "Uninjured" + Color.RESET;
        else if (body.hp < body.maxHp && body.hp > 2) return Color.HIT + "Injured" + Color.RESET;
        else if (body.hp > 0) return Color.GOLD + "Severely Injured" + Color.RESET;
        else return Color.DAMAGE + "Disabled" + Color.RESET;
    }
    private static string CheckStatus(Equipment equip)
    {
        if (equip.name == "None") return "";
        else if (equip.hp == equip.maxHp) return " - " + Color.HEALTH + "Undamaged" + Color.RESET;
        else if (equip.hp < equip.maxHp && equip.hp > 2) return " - " + Color.HIT + "Damaged" + Color.RESET;
        else if (equip.hp > 0) return " - " + Color.GOLD + "Severely Damaged" + Color.RESET;
        else return " - " + Color.DAMAGE + "Destroyed" + Color.RESET;
    }

    internal static string Option() =>  Console.ReadKey(true).KeyChar.ToString().ToLower();
    internal static string String() => Console.ReadLine();
}