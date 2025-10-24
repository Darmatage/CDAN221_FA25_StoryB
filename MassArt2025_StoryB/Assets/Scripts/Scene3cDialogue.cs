using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3cDialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public string playerName = GameHandler.playerName;
        public int primeInt = 1;       
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
        public GameObject Choice1c;
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
                Char1name.text = playerName;
                Char1speech.text = "That guy was right, this place does kinda suck.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "What place?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = playerName;
                Char1speech.text = "Laundry room.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "The laundry rooms here are great! They're free so you never have to worry about carrying quarters.";
        }
       else if (primeInt == 6){
                Char1name.text = playerName;
                Char1speech.text = "I literally don't care.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "So, great detective, where are you starting? Over.";
        }
        else if (primeInt ==8){
                Char1name.text = playerName;
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
                Choice1b.SetActive(true); 
                Choice1c.SetActive(true);
        }

       // after choice 1a washers
       else if (primeInt == 11){
                Char1name.text = playerName;
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }        
        else if (primeInt == 12){
                Char1name.text = playerName;
                Char1speech.text = "Thats, uh, disgusting.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 13){
                SkipTo();
        }
       // after choice 1b
       else if (primeInt == 21){
                Char1name.text = playerName;
                Char1speech.text = "These are for sure a fire hazard.";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
        else if (primeInt == 22){
                SkipTo();
        }
// after choice 1c
       else if (primeInt == 31){
                Char1name.text = playerName;
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
        else if (primeInt == 32){
                Char1name.text = playerName;
                Char1speech.text = "Gross, who spits out gum into their bedsheets?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 33){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "I do...sometimes.";
        }
        else if (primeInt == 34){
                SkipTo();
        }
// SkipTo    
        else if (primeInt == 41){
                Char1name.text = "";
                Char1speech.text = "Your roomie mentioned seeing the missing girl in the rest corner, right? Seems like a more productive choice.";
                Char2name.text = "Felix";
                Char2speech.text = "";
        }
        else if (primeInt == 42){
                Char1name.text = playerName;
                Char1speech.text = "Now you care about being productive?";
                Char2name.text = "";
                Char2speech.text = "";

                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = playerName;
                Char1speech.text = "There's a weird noise coming from the washing machines.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 10; // so hitting "NEXT" goes to primeInt==20!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = playerName;
                Char1speech.text = "Dryers seem like less of a gross bet for now.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 20; // so hitting "NEXT" goes to primeInt==30!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1cFunct(){
                Char1name.text = playerName;
                Char1speech.text = "Maybe I'll find some more items in the laundry baskets over there.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 30; // so hitting "NEXT" goes to primeInt==20!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){ //go back
                GameHandler.prevScene = "Scene3c";
                SceneManager.LoadScene("Scene3b");
        }
        public void SceneChange2(){ //worker's area
                GameHandler.prevScene = "Scene3c";
                SceneManager.LoadScene("Scene4c");
        }
        public void SkipTo(){
                primeInt = 40;
                Char1name.text = playerName;
                Char1speech.text = "I could try that door over there. I think it's an employee only area. They seem a bit scatterbrained, so it's probably unlocked.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        
}
