using UnityEngine;

public class SecretHandler : MonoBehaviour
{
	public int floorNum;
/*
	public GameObject button1;
    public GameObject button3;
    public GameObject button5;
    public GameObject button7;
    public GameObject button9;
    public GameObject button11;
    public GameObject button13;
*/

    void Start()
    {
        
    }


    public void ClickElevatorButton()
	{
		GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().ElevatorCodeAttempt(floorNum);
    }
}
