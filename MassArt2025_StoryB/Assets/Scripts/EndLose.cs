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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GameHandler.endingNumber == 1){ // JOKE ENDINNG
            endDesc.text = "You promptly check out after waking up refreshed. You decide to transfer the case to someone else and go take a vacation.";
        }
        else if (GameHandler.endingNumber == 2){ // BASEMENT BAD ENDING
            endDesc.text = "You charge at the monster with all the force you possess. It is not enough. The horned monster impales you.";
        }
        else if (GameHandler.endingNumber == 3){ //  RECEPTION NEUTRAL ENDING
            endDesc.text = "You decide the hotel is weird, so you leave and try to follow other leads from the comfort of your office. You never solve the case. It will forever haunt you.";
        }
        else if (GameHandler.endingNumber == 4){ // RECEPTION BAD ENDING
            endDesc.text = "";
        }
        else if (GameHandler.endingNumber == 5){ // ROMANCE ENDING
            endDesc.text = "Buzzboy takes a liking to you. He flirts back. You both leave to go on a nice date at the park. You have a buzzboyfriend now. Congrats.";
        }
        else if (GameHandler.endingNumber == 6){ // WORKERS BAD ENDING
            endDesc.text = "The workers don't like rude, meddling customers. They take turns hurting you, before getting bored and killing you.";
        }
        else if (GameHandler.endingNumber == 7){ // BATHROOM BAD ENDING
            endDesc.text = "The monster grabs you, and clamps down on you. A foul-smelling acid covers your head, and you're dissolved from the outside in. You scream, but nobody can hear you.";
        }
        else if (GameHandler.endingNumber == 8){ // CATASTROPHIC ENDING
            endDesc.text = "The voices prompt you to open the boiler and go inside. You follow, and it feels just like home. Your skin melts first, becoming part of something much greater than you could ever have been. You are filled with purpose. Why did you wait so long to do this?";
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
