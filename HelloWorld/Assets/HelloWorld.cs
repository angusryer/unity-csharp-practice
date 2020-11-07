using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore
{

    public int myInt = 0;

    public int increaseInt(int thisInt) {
        return thisInt++;
    } 
}

public class HelloWorld : MonoBehaviour
{
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        GameScore gs = new GameScore();

    }

    // Update is called once per frame
    void Update()
    {

        

        if (myInt < 5) {
            increaseInt(myInt);
            print(myInt);
        }
    }
}
