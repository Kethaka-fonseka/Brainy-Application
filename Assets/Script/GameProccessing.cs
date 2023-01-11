using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameProccessing : MonoBehaviour
{
    float time, second;
    [SerializeField]
    public Image FillImage;
    // Start is called before the first frame update
    void Start()
    {
        second = 5;
        Invoke("LoadApp", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (time < 5) {
            time += Time.deltaTime;
            FillImage.fillAmount = time / second;
        }
    }

    public void LoadApp()
    {
        SceneManager.LoadScene("Congrat");
    }
}
