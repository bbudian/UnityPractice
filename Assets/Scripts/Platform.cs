using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, -1);
        transform.Translate(direction * Time.deltaTime * RunnerGameManager.Instance.PlatformSpeed);
    }
}
