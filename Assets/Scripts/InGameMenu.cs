using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class InGameMenu : MonoBehaviour
{
    [SerializeField] private Button m_ResumeButton;
    [SerializeField] private Button m_OptionsButton;
    [SerializeField] private Button m_QuitButton;
    [SerializeField] private GameObject m_MenuObject;

    public void Show(bool isVisible)
    {
        m_MenuObject.SetActive(isVisible);
    }

    // Start is called before the first frame update
    void Start()
    {
        m_ResumeButton.onClick.AddListener(HandleResumeClick);
        m_OptionsButton.onClick.AddListener(HandleOptionsClick);
        m_QuitButton.onClick.AddListener(HandleQuitClick);
        Show(false);
    }

    private void HandleOptionsClick(){}

    private void HandleQuitClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void HandleResumeClick()
    {
        Show(false);
    }
}