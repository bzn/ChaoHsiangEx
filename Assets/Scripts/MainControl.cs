using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainControl : MonoBehaviour
{
    public Button openMenuButton;
    public Button closeMenuButton;
    public Button titleMenuButton;
    public Button resumeButton;
    public Button openCreditButton;
    public Button closeCreditButton;
    public GameObject menuUI;
    public GameObject creditUI;

    void Start ()
    {
        openMenuButton.onClick.AddListener(OnOpenMenuButtonClick);
        closeMenuButton.onClick.AddListener(OnCloseMenuButtonClick);
        openCreditButton.onClick.AddListener(OnOpenCreditButtonClick);
        closeCreditButton.onClick.AddListener(OnCloseCreditButtonClick);
        titleMenuButton.onClick.AddListener(OnTitleButtonClick);
        resumeButton.onClick.AddListener(OnResumeButtonClick);
    }

    private void OnOpenMenuButtonClick()
    {
        menuUI.SetActive(true);
    }

    private void OnCloseMenuButtonClick()
    {
        menuUI.SetActive(false);
    }

    private void OnOpenCreditButtonClick()
    {
        creditUI.SetActive(true);
    }

    private void OnCloseCreditButtonClick()
    {
        creditUI.SetActive(false);
    }

    private void OnTitleButtonClick()
    {
        SceneManager.LoadScene("TitleScene");
    }

    private void OnResumeButtonClick()
    {
        menuUI.SetActive(false);
    }
}
