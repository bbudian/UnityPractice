using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public EventHandler handler;

    [SerializeField] 
    private Button m_PlayButton;
    [SerializeField]
    private Button m_OptionsButton;
    [SerializeField]
    private Button m_QuitButton;

    // Start is called before the first frame update
    void Start()
    {
        m_PlayButton.onClick.AddListener(HandlePlayClick);
        m_OptionsButton.onClick.AddListener(HandleOptionsClick);
        m_QuitButton.onClick.AddListener(HandleQuitClick);
    }

    private void HandleOptionsClick()
    {
    }

    private void HandleQuitClick()
    {
        Application.Quit();
    }


    private void HandlePlayClick()
    {
        SceneManager.LoadScene("Game");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
