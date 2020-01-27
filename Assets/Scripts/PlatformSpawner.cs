using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private int m_PlatformCount;
    [SerializeField] private float m_PlatformHeight;
    [SerializeField] private float m_DistanceBetweenPlatformsMin;
    [SerializeField] private float m_DistanceBetweenPlatformsMax;
    [SerializeField] private float m_PlatformWidthMin;
    [SerializeField] private float m_PlatformWidthMax;
    [SerializeField] private float m_PlatformDepthMin;
    [SerializeField] private float m_PlatformDepthMax;
    [SerializeField] private GameObject m_PlatformTemplate;
    [SerializeField] private PlatformDespawn m_PlatformDespawner;

    private readonly List<Platform> m_SpawnedPlatforms = new List<Platform>();

    private void Start()
    {
        m_PlatformDespawner.OnPlatformDespawn += HandleDespawnPlatform;

        for (int iPlatform = 0; iPlatform < m_PlatformCount; iPlatform++)
        {
            SpawnPlatform();
        }
    }

    private void HandleDespawnPlatform(Platform platform)
    {
        m_SpawnedPlatforms.Remove(platform);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_SpawnedPlatforms.Count < m_PlatformCount)
            SpawnPlatform();
    }

    private void SpawnPlatform()
    {
        Vector3 scale = Vector3.one;

        scale.x = Random.Range(m_PlatformWidthMin, m_PlatformWidthMax);
        scale.y = m_PlatformHeight;
        scale.z = Random.Range(m_PlatformDepthMin, m_PlatformDepthMax);

        Vector3 position = Vector3.zero + Vector3.forward * scale.z/2f;

        Platform prevSpawnedPlatform = GetLastSpawnedPlatform();
        if (prevSpawnedPlatform != null)
        {
            Vector3 prevForward = prevSpawnedPlatform.transform.forward;
            position = prevSpawnedPlatform.transform.position;
            position += prevForward * prevSpawnedPlatform.transform.localScale.z / 2f;
            position += prevForward * Random.Range(m_DistanceBetweenPlatformsMin, m_DistanceBetweenPlatformsMax);
            position += prevForward * scale.z / 2f;
        }

        GameObject newPlatformObject = Instantiate(m_PlatformTemplate, position, Quaternion.identity);
        newPlatformObject.transform.localScale = scale;
        m_SpawnedPlatforms.Add(newPlatformObject.GetComponent<Platform>());
    }

    private Platform GetLastSpawnedPlatform()
    {
        return m_SpawnedPlatforms.Count == 0 ? null : m_SpawnedPlatforms[m_SpawnedPlatforms.Count - 1];
    }
}
