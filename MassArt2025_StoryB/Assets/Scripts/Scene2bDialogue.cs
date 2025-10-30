using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2bDialogue : MonoBehaviour {
    public string playerName = GameHandler.playerName;
    public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
       //public TMP_Text Char3name;
       //public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        //public GameObject ArtChar1a;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar1c;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
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
             ArtChar2a.SetActive(false);
             ArtChar2b.SetActive(false);
             ArtChar2c.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             nextButton.SetActive(true);
             GameHandler.singleDouble = false;
        playerName = GameHandler.playerName;
       // print("local name: " + playerName);
       // print("global name: " + GameHandler.playerName);
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
            print(playerName);
            ArtChar2a.SetActive(true);
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
                Char2speech.text = "Kind of a bummer, no offense. I thought I was getting a cheaper room all to myself...";
        }
        else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "... been here a while already. Anyways, I'm Ruben.";
        }
        else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Nice to meet you, dude.";
        }
        else if (primeInt == 6){
                Char1name.text = GameHandler.playerName;
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
              nextButton.SetActive(false);
              allowSpace = false;
              Choice1a.SetActive(true); // function Choice1aFunct()
              Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Okay, man, no need for the 'tude. I got you, though...";
        }
        else if (primeInt == 21){
            //gameHandler.AddPlayerStat(1);
               
            Char1name.text = playerName;
                Char1speech.text = "By the way, have you seen anything weird around here?";
                Char2name.text = "";
                Char2speech.text = "";
        }
         else if (primeInt == 22){
                //gameHandler.AddPlayerStat(1);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Sure have. What kinda weird are we talking?";
        }
         else if (primeInt == 23){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = playerName;
                Char1speech.text = "I'm a PI, just tell me something useful.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 24){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "That little rest spot at the end of the hall gives me the creeeeeps.";
        }
        else if (primeInt == 25)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ruben";
            Char2speech.text = "And that freaky laundry room...";
        }
        else if (primeInt == 26)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ruben";
            Char2speech.text = "...doesn't work and there's always people leaving stuff all over.";
        }
        else if (primeInt == 27)
        {
         ArtChar2a.SetActive(true);
         ArtChar2b.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ruben";
            Char2speech.text = "Like, hair, and... teeth. \nWhat're you lookin' for anyway?";
        }
        else if (primeInt == 28){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = playerName;
                Char1speech.text = "Can't disclose.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 29){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "...Kay. Nice talking to you, I guess.";
        
        }
        else if (primeInt == 30){
                Char1name.text = GameHandler.playerName;
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Work? What kinda work are you doing in some run-down joint like this?";
        }
       else if (primeInt == 32){
                Char1name.text = playerName;
                Char1speech.text = "I'm a private investigator. I'm on a missing person's case right now.";
                Char2name.text = "";
                Char2speech.text = "";
       }
        else if (primeInt == 33){
                //gameHandler.AddPlayerStat(1);
                 ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Damn, that's cool. Missing person at this hotel? Now I'm really creeped out.";
        }
        else if (primeInt == 34){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = playerName;
                Char1speech.text = "Actually, since you've been here a while, would you mind helping me out?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 35){
                 ArtChar2c.SetActive(true);
                ArtChar2b.SetActive(false);
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Hell yeah! I love detective work. Lemme be your Watson.";
        }
        else if (primeInt == 36){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = playerName;
                Char1speech.text = "Haha, there's no need for that. Just gonna ask a couple questions.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 37){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Fire away.";
        }
        else if (primeInt == 38){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = playerName;
                Char1speech.text = "Have you seen a guest matching this description?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 39){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = playerName;
                Char1speech.text = "Here, I have a picture. She would have been staying here for the past 2-ish weeks.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 40){
                ArtChar2c.SetActive(false);
                ArtChar2a.SetActive(true);
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Seems familiar...";
        }
        else if (primeInt == 41){
                ArtChar2c.SetActive(true);
                ArtChar2a.SetActive(false);
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Got it! I think I saw her once or twice at the rest corner around the hall.";
        }
         else if (primeInt == 42){
                ArtChar2c.SetActive(false);
                ArtChar2b.SetActive(true);
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "That place gives me the creeps, man.";
        }
         else if (primeInt == 43){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = playerName;
                Char1speech.text = "About creepy stuff, any other weird stuff you've seen?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 44){
                //gameHandler.AddPlayerStat(1);
                ArtChar2a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "I've done my laundry here a couple times...";
        }
        else if (primeInt == 45){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "...and there's always weird noises down in the laundry room.";
        }
        else if (primeInt == 46){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "Gives me the heebie jeebies.";
        }
        else if (primeInt == 47){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ruben";
                Char2speech.text = "If you said this person was here a while, they probably did laundry too.";
        }
        else if (primeInt == 48){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = GameHandler.playerName;
                Char1speech.text = "That's very helpful, thank you. \nI'll go take a look now and get out of your hair.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 49){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = GameHandler.playerName;
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
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
                Char1name.text = playerName;
                Char1speech.text = "Nice to meet you too... bro. I'm just gonna be staying here for a little, doing some work.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 30; // so hitting "NEXT" goes to primeInt==30!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){ //rest corner
                GameHandler.prevScene = "Scene2b";
                SceneManager.LoadScene("Scene3b");
        }
        public void SceneChange2(){ //laundry room
                GameHandler.prevScene = "Scene2b";
                SceneManager.LoadScene("Scene3c");
        }
}
