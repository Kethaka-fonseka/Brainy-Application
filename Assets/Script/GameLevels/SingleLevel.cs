using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingleLevel : MonoBehaviour
{
    private int currentStarsNum = 0;
    public int levelIndex;

    public void BackButton(int levelindx, int starnum)
    {
        if (levelindx == 1 && starnum == 1)
        {
            SceneManager.LoadScene("ObjectDetectionYoloV4");
        }
        else if (levelindx == 1 && starnum == 2) 
        {
            SceneManager.LoadScene("StoryTwo");

        }else if (levelindx == 1 && starnum == 3)
        {
            SceneManager.LoadScene("LevelUp");
        }
    }
    
    public void PressStarsButton(int _starsNum)
    {
        currentStarsNum = _starsNum;

        if(currentStarsNum > PlayerPrefs.GetInt("Lv" + levelIndex))
        {
            PlayerPrefs.SetInt("Lv" + levelIndex, _starsNum);
        }

        //BackButton();
        //MARKER Each level has saved their own stars number
        //CORE PLayerPrefs.getInt("KEY", "VALUE"); We can use the KEY to find Our VALUE
        Debug.Log(PlayerPrefs.GetInt("Lv" + levelIndex, _starsNum));

         BackButton(levelIndex, _starsNum);
    }

}
