using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game 
{
    // Start is called before the first frame update
    void Start()
    {
        Player myPlayer = new Player();

        //Properties can be used just like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
