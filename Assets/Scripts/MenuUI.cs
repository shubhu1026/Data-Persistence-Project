using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUI : MonoBehaviour
{
    [SerializeField] TMP_InputField usernameInput;

    public void StartGame()
    {
        GameManager.Instance.CurrentPlayer = usernameInput.text;
        SceneManager.LoadScene(1);
    }
}
