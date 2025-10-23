using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour {
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
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject Choice3a;
        public GameObject Choice3b;
        public GameObject Choice3c;
        public GameObject Choice4a;
        public GameObject Choice4b;
        public GameObject Choice4c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
        public AudioSource phoneRing;
        private bool allowSpace = true;

        public bool canAmbush = false;
        public bool canCharge = false;
        public bool canThrow = false;

// Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar1a.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        Choice3c.SetActive(false);
        Choice4a.SetActive(false);
        Choice4b.SetActive(false);
        Choice4c.SetActive(false);
        NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             nextButton.SetActive(true);

        //check how I got here:
             if (GameHandler.singleDouble == false){
                primeInt=9;
             } else {
                //go to the next area of the dialogue for the other room
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

        //start from single room:
        else if (primeInt == 2)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "What just happened? God, my head hurts.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 4)
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "What is this place?";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 14;
        }

        //start from double room:
        else if (primeInt == 10)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "Creepy basement, naturally.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "Shit, did the door just lock?";
            primeInt = 14;
        }


        //resume from both entrances:
        else if (primeInt == 15)
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "What should I do?";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // after choice 1a
        else if (primeInt == 20)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
            Char2speech.text = "Some old lady just gifted me 50 bucks. Score.";
            primeInt = 49;
        }

        // after choice 1b
        else if (primeInt == 30)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
            Char2speech.text = "Well, I'm having a great time! I just got invited to a party on a yacht. Isn't that crazy?";
        }
        else if (primeInt == 31)
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "Maybe I can lockpick the door? Is there anything I can do?";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 49;
        }


        else if (primeInt == 50)
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "Shit! What the hell is that!?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 51)
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "Shit, shit shit, what do I do?";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
        }
        //choice: HIDE
        else if (primeInt == 60)
        {
            phoneRing.Play();
        }
        else if (primeInt == 61)
        {
            SceneChange1();
        }
        //choice: FIGHT
        else if (primeInt == 70)
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "I need a weapon.";
            Char2name.text = "";
            Char2speech.text = "";
            if (GameHandler.gotGun == true)
            {
                primeInt = 110;
            }
            else
            {
            nextButton.SetActive(false);
             allowSpace = false;
             Choice3a.SetActive(true);
             Choice3b.SetActive(true);           
             Choice3c.SetActive(true);                      
            }
                
        }
        else if (primeInt == 71)
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "There, that's it!";
            Char2name.text = "";
            Char2speech.text = "";

            nextButton.SetActive(false);
            allowSpace = false;
            Choice3a.SetActive(true);
            Choice3b.SetActive(true);
            Choice3c.SetActive(true);
        }
       
        //after weapon choice
        else if (primeInt == 80)
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "Now! I have one chance!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice4a.SetActive(true);
            Choice4b.SetActive(true);
            Choice4c.SetActive(true);
        }
         /*
        //rusty pipe, ambush
        else if (primeInt == 90)
        {
            Char1name.text = "";
            Char1speech.text = "You sneak up behind the monster, and whack it in the back of the head!";
        }
        else if (primeInt == 91)
        {
            SceneChange2();
        }
        //rusty pipe, charge
        else if (primeInt == 93)
        {
            Char1name.text = "";
            Char1speech.text = "You try a head-on attack, but the pipe is deflected by the monster's horn.";
        }
        else if (primeInt == 94)
        {
            SceneChange1();
        }
        //rusty pipe, throw
        else if (primeInt == 96)
        {
            Char1name.text = "";
            Char1speech.text = "You throw the pipe. It doinks uselessly against the monster's armored head.";
            primeInt = 93;
        }
        //toolbox, ambush
        else if (primeInt == 98)
        {
            Char1name.text = "";
            Char1speech.text = "You wait patiently, then throw a screwdriver at the monster's neck!";
            primeInt = 90;
        }
        //toolbox, charge
        else if (primeInt == 109)
        {
            Char1name.text = "";
            Char1speech.text = "You run at the monster screaming, with the toolbox held above your head.";
        }
        else if (primeInt ==110)
        {
            Char1name.text = "";
            Char1speech.text = "You were hoping this would intimidate it. Not one of your finest ideas.";
            primeInt = 93;
        }
        //toolbox, throw
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "You throw a screwdriver directly into the monster's heart!";
            primeInt = 90;
        }
        //axe, ambush
        else if (primeInt == 103)
        {
            Char1name.text = "";
            Char1speech.text = "You sneak up behind the monster, axe held high.";
        }
        else if (primeInt == 104)
        {
            Char1name.text = "";
            Char1speech.text = "But it's too heavy! Before you can swing, the monster turns around and grabs you!";
            primeInt = 93;
        }
        //axe, charge
        else if (primeInt == 106)
        {
            Char1name.text = "";
            Char1speech.text = "You chop off the monster's head in one clean swing!";
            primeInt = 90;
        }
        //axe, throw
        else if (primeInt == 108)
        {
            Char1name.text = "";
            Char1speech.text = "You throw the heavy axe at the monster, and it lodges itself directly in the monster's throat!";
            primeInt = 90;
        }
        */
           else if (primeInt == 111)
        {
            Char1name.text = "";
            Char1speech.text = "You steady your revolver at the monster, and shoot it square in the forehead!";
        }
        else if (primeInt == 112)
        {
            SceneChange2();
        }

        //Please do NOT delete this final bracket that ends the Next() function:

else if (primeInt == 100)
        {   Char1name.text = GameHandler.playerName;
            Char1speech.text = "Shit, there.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(true);
            allowSpace = true;
            SceneChange2 ();
        }
        }


// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = GameHandler.playerName;
                Char1speech.text = "Oh god,I'm gonna die here. I should have never taken this stupid job. I'm never getting paid now.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; // so hitting "NEXT" goes to primeInt==20!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = GameHandler.playerName;
                Char1speech.text = "I've got to do something, I need to find a way out of this godforsaken hotel.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29; // so hitting "NEXT" goes to primeInt==30!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2aFunct()
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "Maybe it hasn't seen me.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 59; // so hitting "NEXT" goes to primeInt==30!
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        public void Choice2bFunct()
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "Maybe I could take it on in a fight...";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 69; // nice
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        public void Choice3aFunct()
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "You can never go wrong with a good ol' lead pipe.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 79;
            GameHandler.basementWeapon = 1;
            Choice3a.SetActive(false);
            Choice3b.SetActive(false);
            Choice3c.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;

            canAmbush = true;
        }
        public void Choice3bFunct()
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "There's probably a few things I can throw in here, huh?";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 79; 
            GameHandler.basementWeapon = 2;
            Choice3a.SetActive(false);
            Choice3b.SetActive(false);
            Choice3c.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;

            canCharge = true;
            canThrow = true;
        }
        public void Choice3cFunct()
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "Whatever's approaching sounds heavy... I'll need something strong.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 79; 
            GameHandler.basementWeapon = 3;
            Choice3a.SetActive(false);
            Choice3b.SetActive(false);
            Choice3c.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;

            canAmbush = true;
            canCharge = true;
        }
        /*
        public void Choice4aFunct() //AMBUSH
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "I can't take this thing in a direct fight. Gotta do something else.";
            Char2name.text = "";
            Char2speech.text = "";

            if (canAmbush = true) + (GameHandler.basementWeapon = 1 || GameHandler.basementWeapon = 3); 
            {primeInt = 100;}
            else if (
                GameHandler.endingNumber = 3;
                SceneManager.LoadScene("Scene6");)}
        }
            
            (GameHandler.basementWeapon == 1)
            {
                primeInt = 89;
            }
            else if (GameHandler.basementWeapon == 2)
            {
                primeInt = 97;
            }
            else if (GameHandler.basementWeapon == 3)
            {
                primeInt = 102;
            }
            
            Choice4a.SetActive(false);
            Choice4b.SetActive(false);
            Choice4c.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        
        public void Choice4bFunct() //CHARGE
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";

            if (canCharge = true) + (GameHandler.basementWeapon = 2 || GameHandler.basementWeapon = 3); {primeInt = 100;}
            else if {
                GameHandler.endingNumber = 3;
                SceneManager.LoadScene("Scene6") }
        /*
        if (GameHandler.basementWeapon == 1)
        {
            primeInt = 92;
        }
        else if (GameHandler.basementWeapon == 2)
        {
            primeInt = 108;
        }
        else if (GameHandler.basementWeapon == 3)
        {
            primeInt = 105;
        }
        
        Choice4a.SetActive(false);
            Choice4b.SetActive(false);
            Choice4c.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        public void Choice4cFunct() //THROW
        {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "(That thing would maul me up close... guess I'll have to trust in my throwing arm.)";
            Char2name.text = "";
            Char2speech.text = "";

            if (canThrow = true) + (GameHandler.basementWeapon = 2); {primeInt = 100;}
            else if {
                GameHandler.endingNumber = 3;
                SceneManager.LoadScene("Scene6") }
        /*        
        if (GameHandler.basementWeapon == 1)
        {
            primeInt = 95;
        }
        else if (GameHandler.basementWeapon == 2)
        {
            primeInt = 100;
        }
        else if (GameHandler.basementWeapon == 3)
        {
            primeInt = 107;
        }
        Choice4a.SetActive(false);
            Choice4b.SetActive(false);
            Choice4c.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        
        public void SceneChange1(){ //bad end
                GameHandler.prevScene = "Scene3a";
                GameHandler.endingNumber = 2;
               SceneManager.LoadScene("EndLose");
        }
        public void SceneChange2(){ //enter boiler
                GameHandler.prevScene = "Scene3a";
                GameHandler.endingNumber = 3;
                SceneManager.LoadScene("Scene6");
        }
        /*
         public void SceneChange3(){ //open door
                GameHandler.prevScene = "Scene3a";
                SceneManager.LoadScene("Scene6");
        }
   
}
*/
        public void Choice4aFunct() //AMBUSH
    {
        Char1name.text = GameHandler.playerName;
        Char1speech.text = "I can't take this thing in a direct fight. Gotta do something else.";
        Char2name.text = "";
        Char2speech.text = "";

            Choice4a.SetActive(false);
            Choice4b.SetActive(false);
            Choice4c.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;

        if (canAmbush == true) {primeInt = 100;}
        else if (canAmbush == false) {SceneChange1();}
    }   
        public void Choice4bFunct() //CHARGE
    {
        Char1name.text = GameHandler.playerName;
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";

            Choice4a.SetActive(false);
            Choice4b.SetActive(false);
            Choice4c.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;

        if (canCharge == true) {
            primeInt = 100;
            }

        else if (canCharge == false)
         {
            SceneChange1();
        }
    }
        public void Choice4cFunct() //THROW
    {
            Char1name.text = GameHandler.playerName;
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";

            Choice4a.SetActive(false);
            Choice4b.SetActive(false);
            Choice4c.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;   

            if (canThrow == true) {primeInt = 100;}
            else if (canThrow == false) {SceneChange1();}        
    }        
        /*        
        if (GameHandler.basementWeapon == 1)
        {
            primeInt = 95;
        }
        else if (GameHandler.basementWeapon == 2)
        {
            primeInt = 100;
        }
        else if (GameHandler.basementWeapon == 3)
        {
            primeInt = 107;
        }
        Choice4a.SetActive(false);
            Choice4b.SetActive(false);
            Choice4c.SetActive(false);
            nextButton.SetActive(true);
            allowSpace = true;
        }
        */
        public void SceneChange1(){ //bad end
                GameHandler.prevScene = "Scene3a";
                GameHandler.endingNumber = 2;
               SceneManager.LoadScene("EndLose");
        }
        public void SceneChange2(){ //enter boiler
                GameHandler.prevScene = "Scene3a";
                GameHandler.endingNumber = 3;
                SceneManager.LoadScene("Scene6");
        }
        /*
         public void SceneChange3(){ //open door
                GameHandler.prevScene = "Scene3a";
                SceneManager.LoadScene("Scene6");
        }
        */
}
