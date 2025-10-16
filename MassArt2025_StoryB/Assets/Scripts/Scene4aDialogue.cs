using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4aDialogue : MonoBehaviour {
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
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             nextButton.SetActive(true);
        //check how i got here
            if (GameHandler.prevScene == "Scene5") //from bathroom
            {
            primeInt = 99;
            }
            else if (GameHandler.singleDouble == true)
            {
            primeInt = 9;
            }
            else
            {
            //do nothing
            }
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
        //Coming from single
        else if (primeInt == 2)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Should take a look at my research, maybe I'll get some ideas on how to continue.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = playerName;
            Char1speech.text = "...What the hell happened here? Where’s that guy?";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "Is your roommate missing?";
        }
        else if (primeInt == 5)
        {
            Char1name.text = playerName;
            Char1speech.text = "His things are still here. Maybe he's still alive. I've got to do something quick, and make sure none of the workers spot me.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "I liked the guy. Shame.";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true);
        }
        //coming from double
        else if (primeInt == 10)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "This hotel seems to just get bigger and bigger.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = playerName;
            Char1speech.text = "Wait, that door over there wasn't open before.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = playerName;
            Char1speech.text = "Jesus, what happened in here!?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "What? What is it?";
        }
        else if (primeInt == 14)
        {
            Char1name.text = playerName;
            Char1speech.text = "There's blood everywhere. Someone had to have been attacked.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 15)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "Oh! There’s a pool area! I love the pool!";
        }
        else if (primeInt == 16)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "Sorry, I was talking to the receptionist, haha.";
        }
        else if (primeInt == 17)
        {
            Char1name.text = playerName;
            Char1speech.text = "(...)";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true);
        }
        // Choice: mean
        else if (primeInt == 20)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = playerName;
            Char1speech.text = "(...)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 21)
        {
            Char1name.text = playerName;
            Char1speech.text = "I can't just leave, though.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 22)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "Yeah, you can’t just leave.";
            primeInt = 40;
        }
        // Choice: annoyed
        else if (primeInt == 30)
        {
            Char1name.text = playerName;
            Char1speech.text = "But noooo, there's always some weird crap going on.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 40;
        }
        // Choice: worry
        else if (primeInt == 40)
        {
            Char1name.text = playerName;
            Char1speech.text = "God, this must have been going on for a while. How many people have disappeared here without anyone noticing?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        //continue
        else if (primeInt == 41)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "Very glad I didn’t take that job.";
        }
        else if (primeInt == 42)
        {
            Char1name.text = playerName;
            Char1speech.text = "The blood looks like it leads down that way, but there might be more clues in this room.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 41)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Phone";
            Char2speech.text = "Take care, man. Who else is going to cover me when I’ve got a hangover?";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }
        //Please do NOT delete this final bracket that ends the Next() function:
    }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){ //MEAN
               if (GameHandler.singleDouble == true) //from single
                {
                    Char1name.text = playerName;
                    Char1speech.text = "This idiot couldn't keep themselves alive, huh?";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 19;
                }
                else
                {
                    Char1name.text = playerName;
                    Char1speech.text = "I mean, the guy was kind of annoying anyways.";
                    Char2name.text = "";
                    Char2speech.text = "";
                     primeInt = 20;
                 }

             // so hitting "NEXT" goes to primeInt==20!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){ //ANNOYED
                Char1name.text = playerName;
                Char1speech.text = "How does this job keep getting weirder? Why can't it ever be  a simple case where the person is alive and well and just broke their phone...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29; // so hitting "NEXT" goes to primeInt==30!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
    public void Choice1cFunct() //WORRIED
    { 
        Char1name.text = "YOU";
        Char1speech.text = "Sure, anything you want... just lay off the club.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 29; // so hitting "NEXT" goes to primeInt==30!
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1(){ //basement
                GameHandler.prevScene = "Scene4a";
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2(){ //bathroom
                GameHandler.prevScene = "Scene4a";
                SceneManager.LoadScene("Scene5");
        }
}
