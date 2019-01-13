using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
    public class numberManager : MonoBehaviour
    {
        public static int enemy_num;        // The player's score.


        Text text;                      // Reference to the Text component.


        void Awake ()
        {
            // Set up the reference.
            text = GetComponent <Text> ();

            // Reset the score.
            enemy_num = 0;
        }


        void Update ()
        {
            // Set the displayed text to be the word "Score" followed by the score value.
            text.text = "Killed: " + enemy_num;
        }
    }
}