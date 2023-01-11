using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitAndNavigateToHome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitBeforeNavigate());
    }

    IEnumerator WaitBeforeNavigate()
    {
        yield return new WaitForSeconds(3);
        PageNavigation pg = new PageNavigation();
        pg.Map();
    }
}
