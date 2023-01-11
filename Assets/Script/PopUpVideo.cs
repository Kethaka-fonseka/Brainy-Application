using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpVideo : MonoBehaviour
{
    public GameObject popUp;
    // Start is called before the first frame update
    void Start()
    {
        popUp.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void popupOpen()
    {
        popUp.SetActive(true);
    }
    public void popupClose()
    {
        popUp.SetActive(false);
    }
}
