using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiLevelSetter : MonoBehaviour
{
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text += Convert.ToString(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
