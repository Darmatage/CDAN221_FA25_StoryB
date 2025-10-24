using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{

        public static string playerName = "YOUU";
        //public static int playerStat1;
        public static int basementWeapon;
        /*
                1 = rusty pipe
                2 = toolbox
                3 = fire axe
        */
        public static bool hair;
        public static bool teeth;
        public static bool note;
        public static bool journal;
        public static bool key;
        public static bool monsterAlive;
        public static bool gotGun;
        public static bool singleDouble;
        /*
         *      true = single
         *      false = double
         */
        public static int endingNumber;
        /*
                1 = JOKE ENDING (checkout)
                2x =  BAD ENDING (basement)
                        1. charge with pipe
                        2. throw pipe
                        3. toolbox ambush
                        4. throw fire axe
                3 = NEUTRAL ENDING (cold case)
                4 = BAD ENDING (reception)
                5 = ROMANCE ENDING
                6 = BAD ENDING (laundry room)
                7 = BAD ENDING (bathroom)
                8 = CATASTROPHIC ENDING
                9 = GOOD ENDING
        */
        public static string prevScene;
        // public GameObject textGameObject;

        // void Start () { UpdateScore (); }

        void Update(){
        //NOTE: delete this quit functionality when a Pause Menu is added!
                // if (Input.GetKey("escape")){
                //         Application.Quit();
                // }

                // Stat tester:
                //if (Input.GetKey("p")){
                //       Debug.Log("Player Stat = " + playerStat1);
                //}
        }

        // void UpdateScore () {
        //        Text scoreTemp = textGameObject.GetComponent<Text>();
        //        scoreTemp.text = "Score: " + score; }

        public void UpdateName(string theName){
                playerName = theName;
        }

        public void StartGame(){
                SceneManager.LoadScene("Scene1");
        }

        public void OpenCredits(){
                SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
                Time.timeScale = 1f;
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
  
}