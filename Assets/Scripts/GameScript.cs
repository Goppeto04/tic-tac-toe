using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameScript : MonoBehaviour {

    public Text turn;
    int spriteIndex = -1;

    public int PlayerTurn()
    {
        spriteIndex++;
        spriteIndex %= 2;

        if (spriteIndex == 0)
        {
            turn.text = "O player turn";
        }
        else
        {
            turn.text = "X player turn";
        }

        return spriteIndex;
    }
}
