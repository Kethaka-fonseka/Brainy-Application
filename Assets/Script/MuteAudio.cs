using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        if(muted == false)
        {
            AudioListener.volume = 1;
        }

    }

 
}
