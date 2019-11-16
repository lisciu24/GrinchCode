using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public short redPresents = 0;
    public short greenPresents = 0;
    public short bluePresents = 0;

    public bool CanBuy()
    {
        bool ret = true;

        Grinch gr = GameObject.FindGameObjectWithTag("Player").GetComponent<Grinch>();
        if(redPresents > gr.redPresents)
        {
            ret = false;
        }
        if (greenPresents > gr.greenPresents)
        {
            ret = false;
        }
        if (bluePresents > gr.bluePresents)
        {
            ret = false;
        }

        return ret;
    }

    public void Buy()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Grinch>().redPresents -= redPresents;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Grinch>().greenPresents -= greenPresents;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Grinch>().bluePresents -= bluePresents;
    }
}
