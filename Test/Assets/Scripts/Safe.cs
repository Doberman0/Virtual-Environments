using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour
{
    private string cur_input;
    private string pwd = "420";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Update the input bar

        //Temporary
        Debug.Log(cur_input);
    }

    void OpenSafe()
    {
        // Implement actual mechanism later
        Debug.Log("You have opened the safe");
    }

    public void ButtonPressed(int input)
    {
        /*if (input == 10) //You've pressed the clear button
        {
            cur_input = "";
        }
        else if (input == 11) //You've pressed enter
        {
            if (string.Equals(cur_input, pwd))
            {
                OpenSafe();
            }
        }
        else //You've pressed a number
        {
            //if (cur_input.Length < 5) //Don't want more than 4 characters entered for pwd
            //{*/
        cur_input += input.ToString();
            //}
        //}
    }
}
