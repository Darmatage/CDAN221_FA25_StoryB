using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public string playerName; //Name Input
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name; //YOU
        public TMP_Text Char1speech;
        public TMP_Text Char2name; //Phone
        public TMP_Text Char2speech;
        public TMP_Text Char3name; //Receptionist
        public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject NameDisplay;

       //public GameObject ArtChar1a;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar1c;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a; //be straightforward
        public GameObject Choice1b; //make conversation
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
             NameDisplay.SetActive(false);
             //ArtChar1a.SetActive(false);
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
                //ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "???";
                Char1speech.text = "Man, they sure built this hotel in the middle of nowhere.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "Hello! Are you there? Over.";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "???";
                Char1speech.text = "I just got to the hotel";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Phone";
                Char2speech.text = "I'm still travelling. Over. Signal's bad. Over.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "???";
                Char1speech.text = "I think I'll check in for the night, then I'll start my investigation.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "Good afternoon, dear guest! How might I help you today?";

         // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }        
        // after choice 1a
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "Right away! Just a moment.";
        }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "...";
        }        
        else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "So right now, we have two options we can offer you.";       
        }
         else if (primeInt == 14){
        Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "There's a single room available on the thirteenth floor, or, if you're feeling frugal, we have a discounted double room that already has a guest in it.";
                
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }   
// after choice 1b
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "Right ahead! Just a moment.";
        }
        else if (primeInt == 22){
                Char1name.text = "???";
                Char1speech.text = "I'm currently investigating a case in the area. Have you seen a girl fitting this description lately?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }        
        else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "Well, I see a lot of people daily, so it might be hard to recall. I'll think about it and come back to you if I remember anything. Are you a detective with the local department?";
        }        
        else if (primeInt == 24){
                Char1name.text = "???";
                Char1speech.text = "Private investigator, actually.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 25){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "Ah. Well, I'm seeing here we have two options available for you.";     
        }
        else if (primeInt == 26){
        Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "There's a single room available on the thirteenth floor, or, if you're feeling frugal, we have a discounted double room that already has a guest in it.";
                
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }        
     else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "Fantastic! I'll just need to see your ID.";     
        }
     else if (primeInt == 32){
                NameDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "Fantastic! I'll just need to see your ID.";     
                nextButton.SetActive(false);
                allowSpace = false;
        }
       else if (primeInt == 33){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Receptionist";
                Char3speech.text = "Great, " + GameHandler.playerName + "! Thank you, and here are your keys.";     
        } 

	  else if (primeInt == 34){
                Char1name.text = GameHandler.playerName;
                Char1speech.text = "Thank you.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";     
        }

       else if (primeInt == 35){
                nextButton.SetActive(false);
                allowSpace = false;
                if (canScene1 == true) {SceneChange1();} 
                else if (canScene2 == true) {SceneChange2();}
        }         
        }
        
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "???";
                Char1speech.text = "Yes, hello, I would like to reserve a room. Make it an indefinite stay.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        
                primeInt = 10; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "???";
                Char1speech.text = "Good afternoon! i have a job around here, so I would like to book a room indefinitely.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 20; // so hitting "NEXT" goes to primeInt==30!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void NextScene1ButtonFunct(){
                primeInt = 30; 
                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                canScene1 = true;
                Next();
        }        
        public void NextScene2ButtonFunct(){
                primeInt = 30; 
                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                canScene2 = true;
                Next();
        }          
   
        public void SceneChange1(){ //single
               GameHandler.prevScene = "Scene1";
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){ //double
                GameHandler.prevScene = "Scene1";
                SceneManager.LoadScene("Scene2b");
        }



//transfer button for naming


        public string theName;
        public GameObject inputField;
       // public GameHandler gameHandler;

        public void StoreName(){
                theName = inputField.GetComponentInChildren<TMP_Text>().text;
                NameDisplay.SetActive(false);
                //gameHandler.UpdateName(theName);
                GameHandler.playerName = theName;

                nextButton.SetActive(true);
                allowSpace = true;
                Next();
        }

   } 