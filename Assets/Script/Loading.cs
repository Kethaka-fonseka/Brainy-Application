using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Loading : MonoBehaviour
{
    float time, second;
    [SerializeField]
    public Image FillImage;
    // Start is called before the first frame update
    void Start()
    {
        second = 9;
        Invoke("LoadApp", 9f);
    }

    // Update is called once per frame
    void Update()
    {
        if (time < 9) {
            time += Time.deltaTime;
            FillImage.fillAmount = time / second;
        }
    }

    public void LoadApp()
    {
        SceneManager.LoadScene("Home");
    }
}
