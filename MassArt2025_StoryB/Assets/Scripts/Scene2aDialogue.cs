using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2aDialogue : MonoBehaviour {
    public string playerName = GameHandler.playerName;
    public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
        //public TMP_Text Char3name;
        //public TMP_Text Char3speech;


        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject DialogueDisplay;
        //public GameObject ArtChar1a;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar1c;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Set initial visibility. 
        void Start(){  
             DialogueDisplay.SetActive(false);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
             ArtChar1c.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             NextScene3Button.SetActive(false);
             nextButton.SetActive(true);
             GameHandler.singleDouble = true;
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
		if (primeInt == 1)
		{
			// audioSource1.Play();
		}
		else if (primeInt == 2)
		{

			DialogueDisplay.SetActive(true);
			Char1name.text = playerName;
			Char1speech.text = "Oh!";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 3)
		{

			DialogueDisplay.SetActive(true);
			Char1name.text = playerName;
			Char1speech.text = "I didn't know they were still working on the room.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 4)
		{

			DialogueDisplay.SetActive(true);
			Char1name.text = playerName;
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";

			nextButton.SetActive(false);
			allowSpace = false;
			Choice1a.SetActive(true); //complain
			Choice1b.SetActive(true); //sweet talk
		}
		// after choice1a complain
		else if (primeInt == 10)
		{
			ArtChar1b.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Maid";
			Char2speech.text = "Yes, is there something I can do for you?";
		}

		else if (primeInt == 11)
		{
			Char1name.text = playerName;
			Char1speech.text = "The receptionist gave me this room saying it was available.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 12)
		{
			Char1name.text = playerName;
			Char1speech.text = "What kind of incompetent system do you have going on in this place?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 13)
		{
			Char1name.text = playerName;
			Char1speech.text = "I thought I was booking a luxury suite for that price";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 14)
		{
			ArtChar1b.SetActive(false);
			ArtChar1a.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Maid";
			Char2speech.text = "We're very sorry sir. An unexpected incident came up. I'm almost done.";
		}
		else if (primeInt == 15)
		{
			Char1name.text = playerName;
			Char1speech.text = "Hurry up then. Don't make a guest wait. I've got work I gotta get to.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 16)
		{
			ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Maid";
			Char2speech.text = "All done, dear guest.";
		}
		else if (primeInt == 17)
		{
			ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Maid";
			Char2speech.text = "";

			nextButton.SetActive(false);
			allowSpace = false;
			NextScene1Button.SetActive(true);
			NextScene2Button.SetActive(true);
			NextScene3Button.SetActive(true);
		}


		// after choice1b sweet talk
		else if (primeInt == 20)
		{
			Char1name.text = playerName;
			Char1speech.text = "I'll just put my stuff down and go take a look around the place.";
			Char2name.text = "";
			Char2speech.text = "";
		}

		else if (primeInt == 21)
		{
			ArtChar1c.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Maid";
			Char2speech.text = "It's not a problem, dear guest. I'm almost done.";
		}
		else if (primeInt == 22)
		{
			ArtChar1c.SetActive(false);
			ArtChar1b.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Maid";
			Char2speech.text = "We had an unexpected incident. I'm terribly sorry.";
		}
		else if (primeInt == 23)
		{
			Char1name.text = playerName;
			Char1speech.text = "Take your time, then. I'll just unpack a bit.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 24)
		{
			ArtChar1c.SetActive(true);
			ArtChar1b.SetActive(false);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Maid";
			Char2speech.text = "That's very kind of you, dear guest.";
		}
		else if (primeInt == 25)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Maid";
			Char2speech.text = "I hope you have a nice stay here at the Hilbert Holmes Hotel.";
		}
		else if (primeInt == 26)
		{
			Char1name.text = playerName;
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";

			nextButton.SetActive(false);
			allowSpace = false;
			NextScene1Button.SetActive(true);
			NextScene2Button.SetActive(true);
			NextScene3Button.SetActive(true);
		}
		// scene change missing girl

		else if (primeInt == 31)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Maid";
			Char2speech.text = "The rest corner at the end of the hallway. She was there.";
		}
		else if (primeInt == 32)
		{
			nextButton.SetActive(false);
			allowSpace = false;
			SceneChange1();
		}
		// scene change mess
		else if (primeInt == 41)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Maid";
			Char2speech.text = "What?";
		}
		else if (primeInt == 42)
		{
			Char1name.text = playerName;
			Char1speech.text = "The unexpected incident. Seems pretty grim. Those bedsheets are ruined.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 43)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Maid";
			Char2speech.text = "Oh. You shouldn't have asked that, dear guest.";
		}
		else if (primeInt == 44)
		{
			nextButton.SetActive(false);
			allowSpace = false;
			SceneChange2();
		}
		// scene change ignore
		else if (primeInt == 50)
		{
			Char1name.text = playerName;
			Char1speech.text = "Mmhum";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 51)
		{
			Char1name.text = playerName;
			Char1speech.text = "This place is kinda draining me. Maybe I'll just lay down for the night.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 52)
		{
			nextButton.SetActive(false);
			allowSpace = false;
			SceneChange3();
		}    
        }
        

// choice changes
        public void Choice1aFunct(){ // be rude
                Char1name.text = playerName;
                Char1speech.text = "Hey, Maid!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 9; 

                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){ // sweet talk
                Char1name.text = playerName;
                Char1speech.text = "Don't mind me!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; 

                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
// scene changes
        public void NextScene1ButtonFunct(){ // sweet talk
                Char1name.text = playerName;
                Char1speech.text = "Wait! Before you leave. Have you seen a guest fitting this description?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 30; 

                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                NextScene3Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void NextScene2ButtonFunct(){ // sweet talk
                Char1name.text = playerName;
                Char1speech.text = "What was the incident?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 40; 

                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                NextScene3Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void NextScene3ButtonFunct(){ // ignore
                Char1name.text = playerName;
                Char1speech.text = "Mmhum";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 50; 

                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(false);
                NextScene3Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void SceneChange1(){
                GameHandler.prevScene = "Scene2a";
                SceneManager.LoadScene("Scene3b");
        }
        public void SceneChange2(){
                GameHandler.prevScene = "Scene2a";
                SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange3(){
                GameHandler.endingNumber = 1;
                SceneManager.LoadScene("EndLose");
        }

}