using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : Singleton<TerrainManager>
{
    [SerializeField] private PlatformDespawn m_PlatformDespawn;

    // Start is called before the first frame update
    void Start()
    {
        m_PlatformDespawn.OnPlatformDespawn += HandlePlatformDespawn;
    }

    private void HandlePlatformDespawn(GameObject platform)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
