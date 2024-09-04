using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, World!");
        Debug.LogWarning("Hello, I am a warning!");
        Debug.LogError("Hello, I am an error!");
        // Author: Dawson Brown
        /*
         * I've thought of making a game where you would chain hits against a wall using a ball and a paddle. Longer chains without the ball hitting the floor would count for more points. If you're competing against another player, the person with the most points after the ball hits the floor twice before its hit again would win.
         * I'm interested in learning more about how to implement the "saving" functionality to your game.
         * I've also thought of making a card game where you battle others using your own handcrafted deck of cards. You would find more cards throughout the game which you can choose to add to your deck, allowing players to "buildcraft" their deck towards a specific style of play.
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
