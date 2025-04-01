using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBandClass : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new EnemyClass();
        Humanoid orc = new OrcClass();

        //Notice how each Humanoid variable contains
        //a reference to a different class in the
        //inheritance hierarchy, yet each of them
        //calls the Humanoid Yell() method.
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
