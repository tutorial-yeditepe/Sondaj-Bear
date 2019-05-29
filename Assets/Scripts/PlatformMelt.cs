using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMelt : MonoBehaviour
{
    public GameObject Platform;

    void Start()
    {
        InvokeRepeating("Melt", 0, 0.3f);
    }

    private void Update()
    {
        if (Platform.transform.localScale.x <= 8)
            GetComponentInParent<PlayerStats>().PlatformMelted();
    }

    void Melt()
    {
        if (Platform.transform.localScale.x > 8)
            Platform.transform.localScale -= new Vector3(0.1f, 0.1f, 0);
    }

    public void IncreaseSize(float size)
    {
        Platform.transform.localScale += new Vector3(size,size,0);
    }
}
