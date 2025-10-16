using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5Dialogue : MonoBehaviour {
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
        public GameObject Choice2d;
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
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
             Choice2c.SetActive(false);
             Choice2d.SetActive(false);
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
        if (primeInt == 1)
        {
            // audioSource1.Play();
        }
        else if (primeInt == 2)
        {

            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "You enter the bathroom. You feel a presence.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true);
        }

        //choice 1: NOTICE
        else if (primeInt == 10)
        {
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "That sucks. The bathroom over here has a whole jacuzzi.";
        }
        else if (primeInt == 11)
        {
            Char1name.text = playerName;
            Char1speech.text = "Is that someone in the bathtub?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "What? Don't be a creep or something, just leave them be.";
        }
        else if (primeInt == 13)
        {
            Char1name.text = playerName;
            Char1speech.text = "But what if it's the missing girl?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 14)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "Point still stands.";
            primeInt = 29;
        }
        //choice 2: MIRROR
        else if (primeInt == 20)
        {
            Char1name.text = playerName;
            Char1speech.text = "Man, and I looked so nice today.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 29;
        }
        //post choices
        else if (primeInt == 30)
        {
            Char1name.text = playerName;
            Char1speech.text = "AAAAH!!!";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 31)
        {
            Char1name.text = playerName;
            Char1speech.text = "WHAT THE HELL.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 32)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "What? What's going on?";
        }
        else if (primeInt == 33)
        {
            Char1name.text = playerName;
            Char1speech.text = "I've got to do something fast.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice1aFunct()
            Choice2b.SetActive(true);
            Choice2c.SetActive(true);
            Choice2d.SetActive(true);
        }
        //Scene changes
        else if (primeInt == 40)
        {
            SceneChange2();
        }
        else if (primeInt == 50)
        {
            SceneChange1();
        }
        //Please do NOT delete this final bracket that ends the Next() function:
    }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = playerName;
                Char1speech.text = "What a small bathroom.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 9; // so hitting "NEXT" goes to primeInt==20!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = playerName;
                Char1speech.text = "God, all this running around has messed up my hair.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; // so hitting "NEXT" goes to primeInt==30!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2aFunct()
    {
        Char1name.text = playerName;
        Char1speech.text = "Classic move! Go for the head!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 39; // so hitting "NEXT" goes to primeInt==30!
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice2c.SetActive(false);
        Choice2d.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
        public void Choice2bFunct()
        {
            Char1name.text = playerName;
            Char1speech.text = "Shit, it's so big. What can I do?";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 49; // so hitting "NEXT" goes to primeInt==30!
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            Choice2c.SetActive(false);
            Choice2d.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        public void Choice2cFunct()
        {
            Char1name.text = playerName;
            Char1speech.text = "There goes nothing!";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 49; // so hitting "NEXT" goes to primeInt==30!
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            Choice2c.SetActive(false);
            Choice2d.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        public void Choice2dFunct()
        {
            Char1name.text = playerName;
            Char1speech.text = "Maybe I can slow it down and run away.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 39; // so hitting "NEXT" goes to primeInt==30!
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            Choice2c.SetActive(false);
            Choice2d.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }

    public void SceneChange1(){
                GameHandler.prevScene = "Scene5";
               SceneManager.LoadScene("Scene4a");
        }
        public void SceneChange2(){
                GameHandler.prevScene = "Scene5";
                GameHandler.endingNumber = 7;
                SceneManager.LoadScene("EndLose");
        }
}
