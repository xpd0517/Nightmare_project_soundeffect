using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
    public class timer : MonoBehaviour
    {
        public PlayerHealth playerHealth;
        public int timeLeft = 0;  // The player's score.
       // public GameObject canvass;
       
       // private Animator sin;

        Text text;                      // Reference to the Text component.

        void Start()
        {
            StartCoroutine("AddTime");
            //GameOverManager gameover = canvass.GetComponent<GameOverManager>();
            //sin = gameover.GetComponent<Animator>();

        }
        void Awake()
        {
            // Set up the reference.
            text = GetComponent<Text>();

           
        }


        void Update()
        {
            // Set the displayed text to be the word "Score" followed by the score value.
            text.text = "Time:" + timeLeft;
            if (playerHealth.isDead == true)
                {

                StopCoroutine("AddTime");
                //sin.SetTrigger("GameOver");
                //sin.SetTrigger("Die");
            }
        }
        IEnumerator AddTime()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);
                timeLeft++;
            }
        }

    }
}