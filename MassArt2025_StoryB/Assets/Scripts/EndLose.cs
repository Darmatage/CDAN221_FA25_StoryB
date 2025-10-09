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
        if (GameHandler.endingNumber == 1){
            endDesc.text = "You promptly check out after waking up refreshed. You decide to transfer the case to someone else and go take a vacation.";
        }
        else if (GameHandler.endingNumber == 2){
            endDesc.text = "You charge at the monster with all the force you possess. It is not enough. The horned monster impales you.";
        }
        else if (GameHandler.endingNumber == 3){
            endDesc.text = "You decide the hotel is weird, so it might be best to investigate from home. You never solve the case. It will forever haunt you.";
        }
        else if (GameHandler.endingNumber == 4){
            endDesc.text = "";
        }
        else if (GameHandler.endingNumber == 5){
            endDesc.text = "Buzzboy takes a liking to you. He flirts back. You both leave to go on a nice date at the park. You have a buzzboyfriend now. Congrats.";
        }
        else if (GameHandler.endingNumber == 6){
            endDesc.text = "The workers don't like rude, meddling customers. They take turns in killing you.";
        }
        else if (GameHandler.endingNumber == 7){
            endDesc.text = "";
        }
        else if (GameHandler.endingNumber == 8){
            endDesc.text = "The voices prompt you to open the boiler and go inside. You follow. You’re now part of the hotel hivemind, and it is now strong enough to take over the world.";
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
