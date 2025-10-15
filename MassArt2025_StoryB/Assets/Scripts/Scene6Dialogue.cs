using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6Dialogue : MonoBehaviour {
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
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject Choice2c;
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
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
             Choice2c.SetActive(false);
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
                Char1name.text = "YOU";
                Char1speech.text = "Gross, eugh.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Got a key...I can probably use this to open that terrible looking door.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "Hey, I'm alive for now. Are you there?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "Shit, my phone broke.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "I don't know if I wanna follow through with this.";
                Char2name.text = "";
                Char2speech.text = "";

                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); 
                Choice1b.SetActive(true); 
        }
       
       // after choice 1a
       else if (primeInt == 11){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "Wait! You're that missing girl I've been looking for. And you!";
                Char2name.text = "";
                Char2speech.text = "";

                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); 
                Choice2b.SetActive(true); 
                Choice2c.SetActive(true); 
        }
// 2a       
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl";
                Char2speech.text = "...!";
        }
        else if (primeInt == 22){
                SkipTo();
        }
// 2b
       else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl";
                Char2speech.text = "...";
        }
        else if (primeInt == 32){
                Char1name.text = "YOU";
                Char1speech.text = "I've been looking all over for you, alright? We're all gonna be just fine.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 33){
                SkipTo();
        }
       else if (primeInt == 41){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }        
        else if (primeInt == 42){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl";
                Char2speech.text = "...?";
        }       
        else if (primeInt == 43){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 44){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl";
                Char2speech.text = "...?!";
        } 
        else if (primeInt == 45){
                SkipTo();
        } 
        else if (primeInt == 51){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl";
                Char2speech.text = "...?!";
        } 
        else if (primeInt == 52){
                Char1name.text = "YOU";
                Char1speech.text = "It's...talking to me.";
                Char2name.text = "";
                Char2speech.text = "";

                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        } 
        else if (primeInt == 61){
                Char1name.text = "YOU";
                Char1speech.text = "It's telling me to open that boiler";
                Char2name.text = "";
                Char2speech.text = "";
        }  
        else if (primeInt == 62){
                Char1name.text = "YOU";
                Char1speech.text = "I should. I have to.";
                Char2name.text = "";
                Char2speech.text = "";
        } 
        else if (primeInt == 63){
                Char1name.text = "YOU";
                Char1speech.text = "We're gonna be okay. I just have to go into the boiler. It'll be just fine.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 64){
                SceneChange1();
        }
        else if (primeInt == 71){
                Char1name.text = "YOU";
                Char1speech.text = "I...";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 72){
                Char1name.text = "YOU";
                Char1speech.text = "We have to go. Come on, get up. I'll help you out.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 73){
                Char1name.text = "YOU";
                Char1speech.text = "Let's go. Hurry.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 74){
                SceneChange2();

        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Now why do they have an even creepier basement? Who designed this place?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 10;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                GameHandler.endingNumber = 2;
                SceneManager.LoadScene("EndLose");
        }
        public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Now I've taken on too much. I don't wanna die like this!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 20;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Don't worry. I'll get us out of here. I just gotta think for a moment.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 30;
                 Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2cFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 40;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void NextScene1ButtonFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 60;
                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void NextScene2ButtonFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 70;
                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void SceneChange1(){ //assimilation
                GameHandler.endingNumber = 8;
                SceneManager.LoadScene("EndLose");
        }
        public void SceneChange2(){ //ignore voices
                SceneManager.LoadScene("EndWin");
        }
        public void SkipTo(){
                primeInt = 50;
                Char1name.text = "YOU";
                Char1speech.text = "Do you guys hear that?";
                Char2name.text = "";
                Char2speech.text = "";      
        }

}
