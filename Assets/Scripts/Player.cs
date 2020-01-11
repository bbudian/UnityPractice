using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float m_JumpForce;

    private Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            m_Rigidbody.AddForce(Vector3.up * Time.deltaTime * m_JumpForce, ForceMode.Impulse);
        }
    }
}
