using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4cDialogue : MonoBehaviour {
    public string playerName = GameHandler.playerName;
    public int primeInt = 1; // This integer drives game progress!
        public TMP_Text Char1name; //MC
        public TMP_Text Char1speech;
        public TMP_Text Char2name; //Buzzboy
        public TMP_Text Char2speech;
        public TMP_Text Char3name; //Maid
        public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        //public GameObject ArtChar1a;
        //public GameObject ArtChar1b;
        //public GameObject ArtChar1c;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtChar2d;
        public GameObject ArtChar2e;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
        public AudioSource beeBuzz;
        //public AudioSource audioSource1;
        private bool allowSpace = true;

// Set initial visibility.
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar2a.SetActive(false);
             ArtChar2b.SetActive(false);
             ArtChar2c.SetActive(false);
             ArtChar2d.SetActive(false);
             ArtChar2e.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice1c.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             nextButton.SetActive(true);
        playerName = GameHandler.playerName;
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
public void Next(){
        primeInt += 1;
        if (primeInt == 1){
                // audioSource1.Play();
        }
        else if (primeInt == 2){
                //ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = playerName;
                Char1speech.text = "Damn, there's people in here.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Maid";
                Char3speech.text = "You're not allowed in here, dear guest.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bellboy";
                Char2speech.text = "Come on, REDACTED, I've told you not to talk like that. It freaks the guests out.";
                Char3name.text = "";
                Char3speech.text = "";
         }
        else if (primeInt == 4){
                ArtChar2a.SetActive(true);
                Char1name.text = playerName;
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";

                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
                Choice1c.SetActive(true); // function Choice1cFunct()
         }

// after choice1a Be Nice
       else if (primeInt == 11){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bellboy";
                Char2speech.text = "There's a sign outside.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==12){
                Char1name.text = playerName;
                Char1speech.text = "Must have missed it, haha.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 13){
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bellboy";
                Char2speech.text = "Seems unlikely.";
                Char3name.text = "";
                Char3speech.text = "";

        // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);     
        }
// after choice 1b Be Rude
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Maid";
                Char3speech.text = "That's not very polite, dear guest.";
        }
       else if (primeInt == 22){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bellboy";
                Char3speech.text = "Yes, dear guest, wouldn't wanna upset us, no?";

                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
            //scene 2 button missing. seems intentional tho
                
        }
// after choice1c Blood
       else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Maid";
                Char3speech.text = "...";
        }
       else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bellboy";
                Char3speech.text = "...";

                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
// scene change flirt           
       else if (primeInt == 51){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bellboy";
                Char2speech.text = "Yes, thank you for noticing. Feels good to be noticed.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 52){
                Char1name.text = playerName;
                Char1speech.text = "You look very handsome.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        } 
       else if (primeInt == 53){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bellboy";
                Char2speech.text = "You're not too bad yourself. Wink.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 54){
                Char1name.text = playerName;
                Char1speech.text = "Haha, you're cute.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }  
       else if (primeInt == 55){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bellboy";
                Char2speech.text = "Maid, mind leaving us alone? I can take care of this myself.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 56){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Maid";
                Char3speech.text = "...";
        }
       else if (primeInt == 57){
                Char1name.text = playerName;
                Char1speech.text = "Oh, you're gonna take care of me?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }     
       else if (primeInt == 58){
                nextButton.SetActive(false);
                allowSpace = false;
                SceneChange2();
        }    
// scene change tell them off           
       else if (primeInt == 41){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Buzzboy";
                Char2speech.text = "We don't really take all that kindly to rude guests, you know? We work really hard.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 42){
                beeBuzz.Play();
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Buzzboy";
                Char2speech.text = "...";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 43){
                nextButton.SetActive(false);
                allowSpace = false;
                SceneChange1();
        }      
        }
// choice changes
        public void Choice1aFunct(){ // be nice
                Char1name.text = playerName;
                Char1speech.text = "I'm very sorry, I didn't mean to interrupt you. I just got, uh, lost looking for a bathroom.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 10; // so hitting "NEXT" goes to primeInt==11!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){ // be rude
                Char1name.text = playerName;
                Char1speech.text = "Can't forgive a simple mistake? This place really does suck.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 20;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1cFunct(){ // blood
                Char1name.text = playerName;
                Char1speech.text = "Is...is that blood on the sheets?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 30;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
// scene changes
        public void NextScene1ButtonFunct(){ // tell them off
                Char1name.text = playerName;
                Char1speech.text = "Just, leave me be, alright? I'll just go.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 40;
                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void NextScene2ButtonFunct(){ // flirt
                Char1name.text = playerName;
                Char1speech.text = "That's a cute bellboy outfit you have. Is it custom made?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 50;
                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

public void SceneChange1(){ //bad ending
                GameHandler.endingNumber = 6;
               SceneManager.LoadScene("EndLose");
        }
public void SceneChange2(){ //romance
                GameHandler.endingNumber = 5;
                SceneManager.LoadScene("EndLose");
        }
}