﻿using System;
using System.Text;

//link: http://www.codewars.com/kata/55c9a8cda33889d69e00008b
public class Kata6
{
    public static string Bob(string monsterName)
    {
        var answer = string.Empty;
        switch (monsterName)
        {
            case "vampire": answer = "Behead it with a machete"; break;
            case "pagan god": answer = "It depends on which one it is"; break;
            case "werewolf": answer = "Silver knife or bullet to the heart"; break;
            case "wendigo": answer = "Burn it to death"; break;
            case "shapeshifter": answer = "Silver knife or bullet to the heart"; break;
            case "angel": answer = "Use the angelic blade"; break;
            case "demon": answer = "Use Ruby's knife, or some Jesus-juice"; break;
            case "ghost": answer = "Salt and iron, and don't forget to burn the corpse"; break;
            case "dragon": answer = "You have to find the excalibur for that"; break;
            case "djinn": answer = "Stab it with silver knife dipped in a lamb's blood"; break;
            case "leviathan": answer = "Use some Borax, then kill Dick"; break;
            case "ghoul": answer = "Behead it"; break;
            case "jefferson starship": answer = "Behead it with a silver blade"; break;
            case "reaper": answer = "If it's nasty, you should gank who controls it"; break;
            case "rugaru": answer = "Burn it alive"; break;
            case "skinwalker": answer = "A silver bullet will do it"; break;
            case "phoenix": answer = "Use the colt"; break;
            case "witch": answer = "They are humans"; break;
            default: answer = "I have friggin no idea yet"; break;
        }

        return answer + ", idjits!";
    }
}