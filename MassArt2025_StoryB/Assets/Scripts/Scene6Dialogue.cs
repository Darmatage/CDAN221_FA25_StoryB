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
    public string playerName = GameHandler.playerName;
    public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
       //public TMP_Text Char3name;
       //public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //girl scared
        public GameObject ArtChar1b; //girl happy
        public GameObject ArtChar1c; //girl terrified
        public GameObject ArtChar2; //felix static
        public GameObject ArtBG1;//boiler bg
        public GameObject ArtBG2;//basement bg
        public GameObject Key;
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
             ArtChar1b.SetActive(false);
             ArtChar1c.SetActive(false);
             ArtChar2.SetActive(false);
             ArtBG1.SetActive(false);
        ArtBG2.SetActive(true);
        Key.SetActive(false);
        Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
             Choice2c.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             nextButton.SetActive(true);
        playerName = GameHandler.playerName;
        Next();
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
                
                DialogueDisplay.SetActive(true);
                Char1name.text = playerName;
                Char1speech.text = "Gross, eugh.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = playerName;
                Char1speech.text = "Got a key...I can probably use this to open that terrible looking door.";
                Char2name.text = "";
                Char2speech.text = "";
                Key.SetActive(true);
                
        }
       else if (primeInt == 4){
                ArtChar2.SetActive(true);
                Char1name.text = playerName;
                Char1speech.text = "Hey, I'm alive for now. Are you there?";
                Char2name.text = "";
                Char2speech.text = "";
                Key.SetActive(false);
        }
       else if (primeInt == 5){
                Char1name.text = playerName;
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = playerName;
            Char1speech.text = "...Over?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7){
                Char1name.text = playerName;
                Char1speech.text = "Shit, my phone...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
            ArtChar2.SetActive(false);
            Char1name.text = playerName;
                Char1speech.text = "I don't know if I wanna follow through with this alone.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 9){
            Char1name.text = playerName;
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";

                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); 
                Choice1b.SetActive(true); 
        }
       
       
       
        // 1a - FLEE
        else if (primeInt == 11)
        {
            Char1name.text = playerName;
            Char1speech.text = "Maybe someone else can, but...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = playerName;
            Char1speech.text = "I don't want to die! I'm going home!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            GameHandler.endingNumber = 3;
            SceneManager.LoadScene("EndLose");
        }
        // 1b - GO IN
               else if (primeInt == 14){
                       
                        ArtBG2.SetActive(false);
                        ArtBG1.SetActive(true); //switch backgrounds
                         ArtChar1a.SetActive(true);

                         Char1name.text = playerName;
                        Char1speech.text = "God, it smells like death in here...";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 15)
                {
                    ArtChar1a.SetActive(false);
                    ArtChar1b.SetActive(true);
                    Char1name.text = playerName;
                    Char1speech.text = "Wait, that's the missing girl!";
                    Char2name.text = "";
                    Char2speech.text = "";
                }
                else if (primeInt == 16)
                {
                    ArtChar1a.SetActive(false);
                    ArtChar1b.SetActive(true);
                    Char1name.text = playerName;
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";

                    nextButton.SetActive(false);
                    allowSpace = false;
                    Choice2a.SetActive(true);
                    Choice2b.SetActive(true);
                    Choice2c.SetActive(true);
                }
        // 2a - PANIC
        else if (primeInt == 21){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl";
                Char2speech.text = "...!";
        }
        else if (primeInt == 22){
                SkipTo();
        }
        // 2b - REASSURE
       else if (primeInt == 31){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl";
                Char2speech.text = "...";
        }
        else if (primeInt == 32){
                Char1name.text = playerName;
                Char1speech.text = "I've been looking all over for you, alright? We're all gonna be just fine.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 33){
                SkipTo();
        }
        //2c - STARE
    
        else if (primeInt == 41){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl";
                Char2speech.text = "...?";
        }       
        else if (primeInt == 42){
                Char1name.text = playerName;
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 43){
                ArtChar1a.SetActive(false);
                ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Girl";
                Char2speech.text = "...?!";
        } 
        else if (primeInt == 44){
                SkipTo();
        } 
        //continue after choice 2
        else if (primeInt == 51)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(true);
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "It's...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 52){
                Char1name.text = playerName;
                Char1speech.text = "...talking to me.";
                Char2name.text = "";
                Char2speech.text = "";      
        } 
        else if (primeInt == 53){
                Char1name.text = playerName;
                Char1speech.text = "It's telling me to join it.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 54)
        {
            Char1name.text = playerName;
            Char1speech.text = "I'll be warm. I'll be safe.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 55)
        {
            Char1name.text = playerName;
            Char1speech.text = "All of my worries... gone. Forever. Like they never existed at all...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 56)
        {
            Char1name.text = playerName;
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";

            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }
        //GIVE IN
        else if (primeInt == 61)
        {
            Char1name.text = playerName;
            Char1speech.text = "Yes, of course...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 62){
                Char1name.text = playerName;
                Char1speech.text = "I should. I have to.";
                Char2name.text = "";
                Char2speech.text = "";
        } 
        else if (primeInt == 63){
                Char1name.text = playerName;
                Char1speech.text = "We're gonna be okay. I just have to go home. It'll be just fine.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 64){
                SceneChange1();
        }
        //RESIST
        else if (primeInt == 71){
                Char1name.text = playerName;
                Char1speech.text = "I...";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 72){
                Char1name.text = playerName;
                Char1speech.text = "We...we have to go. Come on, get up. I'll help you out.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 73){
            ArtChar1b.SetActive(true);
            ArtChar1c.SetActive(false);
            Char1name.text = playerName;
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
        public void Choice1aFunct(){ //GO IN
                Char1name.text = playerName;
                Char1speech.text = "No, I have to. Nobody else will go in for me.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 13;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){ //FLEE
        //  GameHandler.endingNumber = 3;
        // SceneManager.LoadScene("EndLose");
            Char1name.text = playerName;
            Char1speech.text = "I... I can't do this.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 10;
            Choice1a.SetActive(false);
            Choice1b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        public void Choice2aFunct(){ //PANIC
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text = "I've taken on too much. I don't wanna die like this!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 20;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){ //REASSURE
                Char1name.text = playerName;
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
        public void Choice2cFunct(){ //STARE
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = playerName;
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
        public void NextScene1ButtonFunct(){ //GIVE IN
                Char1name.text = playerName;
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 60;
                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void NextScene2ButtonFunct(){ //RESIST
                Char1name.text = playerName;
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
                Char1name.text = playerName;
                Char1speech.text = "...Hm?";
                Char2name.text = "";
                Char2speech.text = "";      
        }

}
