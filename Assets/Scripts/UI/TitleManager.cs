using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    public GameObject startButton;

    

   
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            ChangeScene cs = startButton.GetComponent<ChangeScene>();
            if(cs != null)
            {
                cs.Load();
            }
        }
    }
}
