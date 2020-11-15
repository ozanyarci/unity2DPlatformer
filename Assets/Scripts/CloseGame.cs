using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    public GameObject endmenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel") && endmenu == null)
        {
            Debug.Log("yesss");
            Application.Quit();
        }
        if (Input.GetButtonDown("Cancel") && endmenu!= null && endmenu.activeSelf)
        {
            Debug.Log("yesss");
            Application.Quit();
        }
    }
}
