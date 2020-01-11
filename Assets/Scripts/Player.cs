using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InGameMenu m_InGameMenu;

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
