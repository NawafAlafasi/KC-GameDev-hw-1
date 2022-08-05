
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW : MonoBehaviour
{
    // jassem is the best
    //who ever checked this your the best

    string hero = "Hero";
    int health = 100;
    int damaged = 20;
    int boost = 10;
    int newhealth = 0;
    int compare = 0;

    // Start is called before the first frame update
    void Start()
    {
        print("Your name is " + hero + ".");
        print("You have " + health + " health.");
        damagec(damaged);
        print("You have been damaged your health is now " + newhealth);
        boosted(boost);
        print("Your health has been boosted to " + newhealth + ".");

        if (health > newhealth)
        {
            compare1(health - newhealth);
            print("Your health has decreased by " + compare + ".");
        }
        else if (health == newhealth)
        {
            print("You haven't gained or lost any health");
        }
        else
        {
            compare2(newhealth - health);
            print("Your health has increased by " + compare + ".");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void boosted(int bst)
    {
        newhealth = newhealth + bst;
    }

    void damagec(int newh)
    {
        newhealth = health - newh;
    }

    void compare1(int c)
    {
        compare = c;
    }

    void compare2(int c1)
    {
        compare = c1;
    }
}
