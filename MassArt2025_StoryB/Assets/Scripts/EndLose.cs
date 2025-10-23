using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;



public class EndLose : MonoBehaviour
{
    public TMP_Text endDesc;
    public TMP_Text endTitle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GameHandler.endingNumber == 1){ // JOKE ENDING
            endTitle.text = "JOKE ENDING";
            endDesc.text = "You promptly check out after waking up refreshed. You decide to transfer the case to someone else and go take a vacation.";
        }
        else if (GameHandler.endingNumber == 2){ // CHARGE WITH PIPE
            endTitle.text = "BAD ENDING";
            endDesc.text = "You try a head-on attack, but the pipe is deflected by the monster's horn. It grabs the pipe and breaks it in half.";
        }
        else if (GameHandler.endingNumber == 3){ // THROW PIPE
            endTitle.text = "BAD ENDING";
            endDesc.text = "You throw the pipe. It bounces uselessly against the monster's armored head. It doesn't like that.";
        }
        else if (GameHandler.endingNumber == 4){ // TOOLBOX AMBUSH
            endTitle.text = "BAD ENDING";
            endDesc.text = "You grab a screwdiver and wait to try and puncture the monster. The screwdiver is to small, and it continues unhurt by its intrusion.";
        }
        else if (GameHandler.endingNumber == 5){ // THROW FIRE AXE
            endTitle.text = "BAD ENDING";
            endDesc.text = "You hold the fire axe high about your head and throw it. It's too heavy. You fall with it, alerting the monster.";
        }
        else if (GameHandler.endingNumber == 5){ // NEUTRAL ENDING
            endTitle.text = "NEUTRAL ENDING";
            endDesc.text = "You decide the hotel is weird, so you leave and try to follow other leads from the comfort of your office. You never solve the case. It will forever haunt you.";
        }
        else if (GameHandler.endingNumber == 5){ // BAD ENDING RECEPTION
            endTitle.text = "BAD ENDING";
            endDesc.text = "The receptionist doesn't take kindly to being accused of hiding things. She also doesn't like meddling guests. She steps out from behind the counter and tears you in half.";
        }
        else if (GameHandler.endingNumber == 5){ // ROMANCE ENDING
            endTitle.text = "ROMANCE ENDING";
            endDesc.text = "Buzzboy takes a liking to you. He flirts back. You both leave to go on a nice date at the park. You have a buzzboyfriend now. Congrats.";
        }
        else if (GameHandler.endingNumber == 6){ // BAD ENDING LAUNDRY ROOM
            endTitle.text = "BAD ENDING";
            endDesc.text = "The workers don't like rude, meddling customers. They take turns hurting you, before getting bored and killing you.";
        }
        else if (GameHandler.endingNumber == 7){ // BAD ENDING BATHROOM
            endTitle.text = "BAD ENDING";
            endDesc.text = "The monster grabs you, and clamps down on you. A foul-smelling acid covers your head, and you're dissolved from the outside in. You scream, but nobody can hear you.";
        }
        else if (GameHandler.endingNumber == 8){ // CATASTROPHIC ENDING
            endTitle.text = "CATASTROPHIC ENDING";
            endDesc.text = "The voices prompt you to open the boiler and go inside. You follow, and it feels just like home. Your skin melts first, becoming part of something much greater than you could ever have been. You are filled with purpose. Why did you wait so long to do this?";
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
