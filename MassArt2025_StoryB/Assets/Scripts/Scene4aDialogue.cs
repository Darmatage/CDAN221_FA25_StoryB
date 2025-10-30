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
	public GameObject CharacterNameTag;	

        public GameObject ArtChar1a;
       public GameObject ArtChar1b;
       public GameObject ArtChar1c;
       public GameObject ArtChar1d;
       public GameObject ArtChar1e;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        //Choice: reaction
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        //Choice: stay or leave
        public GameObject Choice2a;
        public GameObject Choice2b;
        //alt text
        public TMP_Text Choice2aText;
        public TMP_Text Choice2bText;
        //Scene: Bathroom or basement
        //public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start(){
			CharacterNameTag.SetActive(true);
			DialogueDisplay.SetActive(false);
			 
             ArtChar1a.SetActive(false);
             ArtChar1b.SetActive(false);
             ArtChar1c.SetActive(false);
             ArtChar1d.SetActive(false);
             ArtChar1e.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice1c.SetActive(false);
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
             //NextScene1Button.SetActive(false);
             //NextScene2Button.SetActive(false);
             nextButton.SetActive(true);
        playerName = GameHandler.playerName;
        //check how i got here
        if (GameHandler.prevScene == "Scene5" && GameHandler.monsterAlive == true) //from bathroom
            {
            primeInt = 99;
            Choice2aText.text = "Keep searching";
            Choice2bText.text = "Leave";
        }
            else if (GameHandler.prevScene == "Scene5" && GameHandler.monsterAlive == false)
            {
            primeInt = 109;
            Choice2aText.text = "Keep searching";
            Choice2bText.text = "Leave";
        }
            else if (GameHandler.singleDouble == true) //from single
            {
            primeInt = 9;
            Choice2aText.text = "Check bathroom";
            Choice2bText.text = "Check basement";
        }
            
            else
            {
            Choice2aText.text = "Check bathroom";
            Choice2bText.text = "Check basement";
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
        //Coming from double
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
            Char1speech.text = "...what the hell happened here? Where's Ruben?";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
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
            ArtChar1d.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
            Char2speech.text = "I liked the guy. Shame.";
        }
        else if (primeInt == 7)
        {
            ArtChar1a.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true);
        }
        //coming from single
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
            Char2name.text = "Felix";
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
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
            Char2speech.text = "Oh! There's a pool area! I love the pool!";
        }
        else if (primeInt == 16)
        {
            ArtChar1a.SetActive(true);
            ArtChar1b.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
            Char2speech.text = "Sorry, I was talking to the receptionist, haha.";
        }
        else if (primeInt == 17)
        {
            Char1name.text = playerName;
            Char1speech.text = "...right.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true);
        }
        // Choice: mean
        else if (primeInt == 20)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = playerName;
            Char1speech.text = "...";
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
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(false);
            ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
            Char2speech.text = "Yeah, you can't just leave.";
            primeInt = 40;
        }
        // Choice: annoyed
        else if (primeInt == 30)
        {
            Char1name.text = playerName;
            Char1speech.text = "Why can't it ever be a simple case where the person is alive and well and just broke their phone...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 31)
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
            Char1speech.text = "God, this must have been going on for a while.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 41)
        {
            Char1name.text = playerName;
            Char1speech.text = "How many people have disappeared here without anyone noticing?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        //continue
        else if (primeInt == 42)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            ArtChar1e.SetActive(false);
            ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
            Char2speech.text = "Very glad I didn't take that job.";
        }
        else if (primeInt == 43)
        {
            Char1name.text = playerName;
            Char1speech.text = "The blood looks like it leads down that way...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 44)
        {
            Char1name.text = playerName;
            Char1speech.text = "...but there might be more clues in this room.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 45)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
            Char2speech.text = "Take care, man. Who else is going to cover me when I've got a hangover?";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
        }
        //From bathroom, monster alive
        else if (primeInt == 100)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Shit! I barely escaped!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = playerName;
            Char1speech.text = "It should be stuck in there... no way it can break through that.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 102)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
            Char2speech.text = "Probably! What's the worst that could happen?";
        }
        else if (primeInt == 103)
        {
            Char1name.text = playerName;
            Char1speech.text = "What to do now?";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
        }
        //From bathroom, monster dead
        else if (primeInt == 110)
        {
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "That was close! I hope there's nothing else in here.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 111)
        {
            Char1name.text = playerName;
            Char1speech.text = "Well, no monsters at least. But maybe there's some clues around here?";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
        }
        //Search, monster alive
        else if (primeInt == 120)
		{
			CharacterNameTag.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "Suddenly, the bathroom door swings open!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 121)
		{
			CharacterNameTag.SetActive(true);
            SceneChange3();

        }
        //Search, mosnter dead
        else if (primeInt == 130)
        {
            Char1name.text = playerName;
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 131)
        {
            Char1name.text = playerName;
            Char1speech.text = "Oh, there's something in this drawer...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 132)
        {
            Char1name.text = playerName;
            Char1speech.text = "A revolver!";
            Char2name.text = "";
            Char2speech.text = "";
            GameHandler.gotGun = true;
        }
        else if (primeInt == 133)
        {
            if (GameHandler.singleDouble == true){
                Char1name.text = playerName;
            Char1speech.text = "Looks like the owner didn't get a chance to use it...";
            Char2name.text = "";
            Char2speech.text = "";
            }
            else{
                Char1name.text = playerName;
            Char1speech.text = "Looks like Ruben didn't get a chance to use it...";
            Char2name.text = "";
            Char2speech.text = "";
            }
            primeInt = 140;
        }
        //Leave, monster alive
        else if (primeInt == 140)
        {
            Char1name.text = playerName;
            Char1speech.text = "I'm outta here!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 141)
        {
            Char1name.text = playerName;
            Char1speech.text = "I'll check the basement next.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 142)
        {
            SceneChange1();
        }
        //Leave, monster dead OR Check basement
        else if (primeInt == 150)
        {
            Char1name.text = playerName;
            Char1speech.text = "She might be in the basement. A classic place to store victims.";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt = 141; //scene change: basement when hitting next
        }
        //Check bathroom
        else if (primeInt == 160)
        {
            SceneChange2();
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
                     primeInt = 19;
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
                Char1speech.text = "How does this job keep getting weirder?";
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
        if (GameHandler.singleDouble == true) //from single
                {
                    Char1name.text = playerName;
                    Char1speech.text = "...was someone here?";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 39;
                }
                else //from double
                {
                    Char1name.text = playerName;
                    Char1speech.text = "Shit, I hope Ruben is safe... or alive, at least.";
                    Char2name.text = "";
                    Char2speech.text = "";
                     primeInt = 39;
                 }
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void Choice2aFunct(){  //SEARCH ROOM, CHECK BATHROOM
                
                if (GameHandler.prevScene != "Scene5")
                {
                    Char1name.text = playerName;
                    Char1speech.text = "The bathroom's as good a place as any...";
                    Char2name.text = "";
                    Char2speech.text = "";
                     primeInt = 159;
                  }
                else if (GameHandler.monsterAlive == true){
                    Char1name.text = playerName;
                    Char1speech.text = "Maybe I can look for clues while it's trapped.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 119;
                }
                else {
                    Char1name.text = playerName;
                    Char1speech.text = "Let's get searching!";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 129;
                }
            // so hitting "NEXT" goes to primeInt==30!
            Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
    public void Choice2bFunct(){  //LEAVE, CHECK BASEMENT
                if (GameHandler.prevScene != "Scene5")
                {
                    Char1name.text = playerName;
                    Char1speech.text = "There might be a body in that bathroom... and not the one I'm looking for.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 149;
                }
                else if (GameHandler.monsterAlive == true){
                    Char1name.text = playerName;
                    Char1speech.text = "Maybe it's best not to risk it.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 139;
                }
                else {
                    Char1name.text = playerName;
                    Char1speech.text = "I should hurry and find that girl, actually.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 149;
                }
                 // so hitting "NEXT" goes to primeInt==30!
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
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
        public void SceneChange3(){ //monster
                GameHandler.endingNumber = 7;
                SceneManager.LoadScene("EndLose");
        }
}
