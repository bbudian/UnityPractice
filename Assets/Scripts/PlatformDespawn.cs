using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void OnPlatformDespawnEvent(Platform platform);

public class PlatformDespawn : MonoBehaviour
{
    public OnPlatformDespawnEvent OnPlatformDespawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Platform platform = other.gameObject.GetComponent<Platform>();
        if (platform == null)
            return;

        OnPlatformDespawn?.Invoke(platform);
        Destroy(other.gameObject);
    }
}
