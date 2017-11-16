using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleControl : MonoBehaviour
{
    public Button normalButton;
    public Button vrButton;

    // Use this for initialization
    void Start ()
    {
        normalButton.onClick.AddListener(OnNormalButtonClick);
        vrButton.onClick.AddListener(OnVRButtonClick);
    }
	
	private void OnNormalButtonClick()
    {
        // ....
        SceneManager.LoadScene("MainScene");
    }

    private void OnVRButtonClick()
    {
        // ....
        SceneManager.LoadScene("MainScene");
    }
}
