using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float m_JumpForce;
    [SerializeField] private float m_MaxHealth;
    [SerializeField] private float m_MovementSpeed;

    private float m_CurrentHealth;

    public float Health => m_CurrentHealth;

    private Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_CurrentHealth = m_MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsGrounded())
            return;

        Vector3 velocity = m_Rigidbody.velocity;

        float deltaX = Input.GetAxis("Horizontal");
        velocity = m_Rigidbody.transform.right * deltaX * Time.deltaTime * m_MovementSpeed;
        velocity.y = m_Rigidbody.velocity.y;

        m_Rigidbody.velocity = velocity;

        if (Input.GetButtonUp("Jump"))
        {
            m_Rigidbody.AddForce(Vector3.up * Time.deltaTime * m_JumpForce, ForceMode.Impulse);
        }
    }

    private bool IsGrounded()
    {

        RaycastHit hit; 
        if (Physics.Raycast(new Ray(transform.position, -transform.up), out hit))
        {
            CapsuleCollider collider = GetComponent<CapsuleCollider>();
            return hit.distance <= collider.height / 2f;
        }

        return false;
    }

    public void Kill()
    {
        m_CurrentHealth = 0;
    }
}
