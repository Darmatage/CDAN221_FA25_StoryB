using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{

        public static string playerName = "YOU";
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
        public static bool singleDouble;
        /*
         *      true = single
         *      false = double
         */
        public static int endingNumber;
        /*
                1 = checkout ending
                2 = basement monster death
                3 = cold case
                4 = receptionist death
                5 = buzzboy romance
                6 = worker death
                7 = bathroom death
                8 = assimilation death
                9 = good end :)
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