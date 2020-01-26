using UnityEngine;
using UnityEngine.SceneManagement;

public class RunnerGameManager : Singleton<RunnerGameManager>
{
    [SerializeField] private InGameMenu m_InGameMenu;
    [SerializeField] private float m_MovementSpeed;
    [SerializeField] private Player m_Player;
    [SerializeField] private float m_WaitTime;

    private float m_Timer;

    //public float PlatformSpeed => m_MovementSpeed;

    public float PlatformSpeed => m_Timer < m_WaitTime ? 0f : m_MovementSpeed;

    public void BeginGame()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Timer < m_WaitTime)
        {
            m_Timer += Time.deltaTime;
            return;
        }

        if (m_Player.Health <= 0)
        {
            EndGame();
        }

        if (Input.GetButtonUp("Menu"))
        {
            m_InGameMenu.Show(true);
        }
    }

    private void EndGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
