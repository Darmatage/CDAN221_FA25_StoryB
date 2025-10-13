using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4cDialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public string playerName;
        public int primeInt = 1;        // This integer drives game progress!
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
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             //ArtChar1a.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice1c.SetActive(false);
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
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


//Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt += 1;
        if (primeInt == 1){
                // audioSource1.Play();
        }
        else if (primeInt == 2){
                //ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Damn, there's people in here";
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bellboy";
                Char2speech.text = "Come on, REDACTED, I've told you not to talk like that. It freaks the guests out.";
                Char3name.text = "";
                Char3speech.text = "";

        // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
                Choice1c.SetActive(true); // function Choice1cFunct()
        }

// after choice1a Be Nice
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bellboy";
                Char2speech.text = "There's a sign outside.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==12){
                Char1name.text = "YOU";
                Char1speech.text = "Must have missed it, haha.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Bellboy";
                Char2speech.text = "Seems unlikely.";
                Char3name.text = "";
                Char3speech.text = "";

        // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true);
                Choice2b.SetActive(true);       
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bellboy";
                Char3speech.text = "Yes, dear guest, wouldn't wanna upset us, no?";

                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true);
                
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
                Choice2a.SetActive(true);
                Choice2b.SetActive(true);
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
                Char1name.text = "YOU";
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
                Char1name.text = "YOU";
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
                Char1name.text = "YOU";
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Buzzboy";
                Char2speech.text = "We don't really take all that kindly to rude guests, you know? We work really hard.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 42){
                nextButton.SetActive(false);
                allowSpace = false;
                SceneChange1();
        }      
        }
// choice changes
        public void Choice1aFunct(){ // be nice
                Char1name.text = "YOU";
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
                Char1name.text = "YOU";
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
                Char1name.text = "YOU";
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
        public void Choice2aFunct(){ // tell them off
                //scene choice dialogue
                Char1name.text = "YOU";
                Char1speech.text = "Just, leave me be, alright? I'll just go.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 40;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
         }
        public void Choice2bFunct(){ // flirt
                Char1name.text = "YOU";
                Char1speech.text = "That's a cute bellboy outfit you have. Is it custom made?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 50;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
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