using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4bDialogue : MonoBehaviour {
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
        public string playerName = GameHandler.playerName;
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

//Story Units! The main story function.
//Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt += 1;
         if (primeInt == 1){

        }
        if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Receptionist";
                Char2speech.text = "Good afternoon, dear guest."; 
        }
        else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Receptionist";
                Char2speech.text = "What can I do for you?";
                
        }
        else if (primeInt == 4){
                Char1name.text = GameHandler.playerName;
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // ASK
                Choice1b.SetActive(true); // ACCUSE RECEPTIONIST
        }

       // after choice 1a
        else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Receptionist";
                Char2speech.text = "Yeah?";
        }
        else if (primeInt == 22){
                Char1name.text = playerName;
                Char1speech.text = "The pool!";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 23){
                Char1name.text = playerName;
                Char1speech.text = "Could you point me towards the pool, please?";
                Char2name.text = "";
                Char2speech.text = "";
        }
         else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Receptionist";
                Char2speech.text = "Sure thing, dear guest!";
        }
        else if (primeInt == 25){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Receptionist";
                Char2speech.text = "It's down that corridor, you'll have to go down to the floor and open the dark door.";
        }
        else if (primeInt == 26){
                Char1name.text = playerName;
                Char1speech.text = "Suspicious way of answering, but alright.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 27){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Receptionist";
                Char2speech.text = "I don't see what you mean, dear guest.";
        }
        else if (primeInt == 28){
                Char1name.text = GameHandler.playerName;
                Char1speech.text = "Everyone in this place is...weird.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 29){
                Char1name.text = GameHandler.playerName;
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
               
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
       // after choice 1b
        else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Receptionist";
                Char2speech.text = "Has there been a problem, dear guest?";
        }
        else if (primeInt == 32){
                Char1name.text = playerName;
                Char1speech.text = "Yes, there's been a problem.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 33){
                Char1name.text = playerName;
                Char1speech.text = "There's clearly something weird going on in here.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 34){
                Char1name.text = playerName;
                Char1speech.text = "All your employees are acting oddly, everyone seems to be hiding something...";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 35){
                Char1name.text = playerName;
                Char1speech.text = "...and a girl disappeared and no one seems to know or care!";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 36){
                Char1name.text = playerName;
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }

        //scene choice: leave
        else if (primeInt == 40){
                Char1name.text = playerName;
                Char1speech.text = "You know what? I think I'm gonna check out.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 41){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Receptionist";
                Char2speech.text = "If that's what you want, dear guest, I'll do that right away.";
        }
        else if (primeInt == 42){
                nextButton.SetActive(false);
                allowSpace = false;
                SceneChange1();
        }
        //scene choice: accuse
        else if (primeInt == 50){
                Char1name.text = playerName;
                Char1speech.text = "You didn't even call the police when that poor girl disappeared.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 51){
                Char1name.text = playerName;
                Char1speech.text = "I know there's something going on, and you're covering it up.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 52){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Receptionist";
                Char2speech.text = "That wasn't very nice, dear guest.";
        }
        else if (primeInt == 53){
                Char1name.text = playerName;
                Char1speech.text = "Oh god, what the hell are you?!";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 54){
                nextButton.SetActive(false);
                allowSpace = false;
                SceneChange2();
        }
      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                primeInt = 20; // so hitting "NEXT" goes to primeInt==20!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                Char1name.text = playerName;
                Char1speech.text = "Yes, um, could you tell me where the…";
                Char2name.text = "";
                Char2speech.text = "";


        }
        public void Choice1bFunct(){
                primeInt = 30; // so hitting "NEXT" goes to primeInt==30!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                Char1name.text = playerName;
                Char1speech.text = "Now what the hell is going on in this place?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        public void NextScene2ButtonFunct(){
                primeInt = 49;
                Char1name.text = playerName;
                Char1speech.text = "You! You're clearly hiding something! ";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = true;
                 NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
        }

        public void SceneChange1(){ //leave
                GameHandler.prevScene = "Scene4b";
                GameHandler.endingNumber = 3;
               SceneManager.LoadScene("EndLose");
        }
        public void SceneChange2(){ //interrogate
                GameHandler.prevScene = "Scene4b";
                GameHandler.endingNumber = 4;
                SceneManager.LoadScene("EndLose");
        }
}
