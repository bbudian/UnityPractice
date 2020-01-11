using UnityEngine;

public class RunnerGameManager : Singleton<RunnerGameManager>
{
    [SerializeField] private InGameMenu m_InGameMenu;
    [SerializeField] private float m_MovementSpeed;

    //public float PlatformSpeed => m_MovementSpeed;

    public float PlatformSpeed => m_MovementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Menu"))
        {
            m_InGameMenu.Show(true);
        }
    }
}
