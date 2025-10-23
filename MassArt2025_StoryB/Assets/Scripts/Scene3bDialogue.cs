    using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3bDialogue : MonoBehaviour {
        public string playerName;
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name; //YOU
        public TMP_Text Char1speech; //Phone
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
       //public TMP_Text Char3name;
       //public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtChar1e;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

        public bool canScene1 = false;
        public bool canScene2 = false;

// Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar1a.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice1c.SetActive(false);
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
                ArtChar1b.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "Do you copy? Over.";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Just got to the rest corner to investigate. Some witnesses said the girl was seen around here. What about you?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "...";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "...over.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "Great! I just got to the Murder Mills Motel. I'm about to check in.";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "Good luck with that. Hey, this is a nice little spot! Except for everything in it, I guess. Where should I start?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "Come on, you have to use the codewords.";
        }        
       else if (primeInt ==9){
                Char1name.text = "YOU";
                Char1speech.text = "We're literally talking on the phone.";
                Char2name.text = "";
                Char2speech.text = "";        
                
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); 
                Choice1b.SetActive(true); 
                Choice1c.SetActive(true); 
        }
// after choice 1a vending machine
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "Snacks! Probably expired, though.";
        } 
       else if (primeInt == 22){
                Char1name.text = "YOU";
                Char1speech.text = "Now what is this piece of trash doing here?";
                Char2name.text = "";
                Char2speech.text = "";
        } 

        else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "Unsuccesful snacking, uh? What's the next step?";
                      
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }

// after choice 1b couch cushions
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "Is that...hair?";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
        else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "Any coins? What's the next step?";

                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
// after choice1c water fountain
       else if (primeInt == 41){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "...";
                
        }
        else if (primeInt == 42){
                Char1name.text = "YOU";
                Char1speech.text = "Not even gonna say anything, uh?";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
       else if (primeInt == 43){
                Char1name.text = "YOU";
                Char1speech.text = "Oh god, what the fuck is that?";
                Char2name.text = "";
                Char2speech.text = "";
                
        } 
        else if (primeInt == 44){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "What's the plan now?";

                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
        else if (primeInt == 51){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "You would have been a terrible actuary.";
        }
        else if (primeInt == 52){
                Char1name.text = "YOU";
                Char1speech.text = "I didn't ask you.";
                Char2name.text = "";
                Char2speech.text = "";

                if (canScene1 == true){        
                Char1name.text = "YOU";
                Char1speech.text = "Maybe the receptionist has thought of something?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 60;}

                else if (canScene2 == true){
                Char1name.text = "YOU";
                Char1speech.text = "I should go back to my room and take a look at what's been said about this place. Gives me the creeps.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 70;}
        }        
        else if (primeInt == 61){  
                SceneChange1();  
        }     
        else if (primeInt == 71){   
                SceneChange2();     
        }
        }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "That vending machine looks like it hasn't been used in years.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 20; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Let's go the old fashioned coins in the couch route.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 30; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1cFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Man, that trip made me thirsty.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 40; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void NextScene1ButtonFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "This didn't really point me in any particular way. God, this case keeps hitting dead ends. I should have been an actuary instead.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 50; 
                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                canScene1 = true;
        }
        public void NextScene2ButtonFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "This didn't really point me in any particular way. God, this case keeps hitting dead ends. I should have been an actuary instead.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 50; 
                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                canScene2 = true;
        }
        public void SceneChange1(){ //receptionist
                GameHandler.prevScene = "Scene3b";
                SceneManager.LoadScene("Scene4b");
        }
        public void SceneChange2(){ //go back to room
                GameHandler.prevScene = "Scene3b";
                SceneManager.LoadScene("Scene4a");
        }
}
