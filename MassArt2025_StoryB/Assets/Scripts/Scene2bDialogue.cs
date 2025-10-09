using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2bDialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
       //public TMP_Text Char3name;
       //public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar1c;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar1a.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             nextButton.SetActive(true);
        }

// Use the spacebar as a faster "Next" button:
        void Update(){        
             if (allowSpace == true){
                 if (Input.GetKeyDown("space")){
                      Next();
                 }

                 // secret debug code: go back 1 Story Unit, if NEXT is visible
                 if (Input.GetKeyDown("p")) {
                      primeInt -= 2;
                      Next();
                 }
             }
        }

//Story Units! The main story function.
//Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt += 1;
        if (primeInt == 1){
                // audioSource1.Play();
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Oh, hey! Didn't know they were actually gonna send me a roomie.";
        }

        else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Kind of a bummer, no offense. I thought I was getting a cheaper room all to myself... ";
        }

        else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "... been here a while already. Anyways, I'm Ruben. Nice to meet you, dude.";

                // Turn off the "Next" button, turn on "Choice" buttons
              nextButton.SetActive(false);
              allowSpace = false;
              Choice1a.SetActive(true); // function Choice1aFunct()
              Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Okay, man, no need for the 'tude. I got you, though...";
        }
        else if (primeInt == 21){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "By the way, have you seen anything weird around here?";
                Char2name.text = "";
                Char2speech.text = "";
        }
         else if (primeInt == 22){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Sure have. What kinda weird are we talking?";
        }
         else if (primeInt == 23){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "I'm a PI, just tell me something useful.";
                Char2name.text = "";
                Char2speech.text = "";
        }
         else if (primeInt == 24){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "That little rest spot at the end of the hall gives me the creeeeeps. And that freaky laundry room... doesn't work and there's always people leaving stuff all over. Like, hair, and... teeth. What're you lookin' for anyway?";
        }
        else if (primeInt == 25){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "Can't disclose.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 26){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "...Kay. Nice talking to you, I guess.";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Work? What kinda work are you doing in some run-down joint like this?";
        }
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "I'm a private investigator. I'm on a missing person's case right now.";
                Char2name.text = "";
                Char2speech.text = "";
       }
        else if (primeInt == 32){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Damn, that's cool. Missing person at this hotel? Now I'm really creeped out.";
        }
        else if (primeInt == 33){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 34){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "";
        }
        else if (primeInt == 35){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 36){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "";
        }
        else if (primeInt == 37){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 38){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "";
        }
        else if (primeInt == 39){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "";
        }
        else if (primeInt == 40){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 41){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "";
        }
        else if (primeInt == 42){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "That's very helpful, thank you. I'll go take a look now and get out of your hair.";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Okay. Can you move your shit off my bed, please?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; // so hitting "NEXT" goes to primeInt==20!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Nice to meet you too... bro. I'm just gonna be staying here for a little, doing some work.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29; // so hitting "NEXT" goes to primeInt==30!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){ //rest corner
                GameHandler.prevScene = "Scene2b";
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2(){ //laundry room
                GameHandler.prevScene = "Scene2b";
                SceneManager.LoadScene("Scene3c");
        }
}
