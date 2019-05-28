using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMelt : MonoBehaviour
{
    public GameObject Platform;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("Melt", 0, 0.3f);
    }

    void Melt()
    {
        if (Platform.transform.localScale.x > 5)
            Platform.transform.localScale -= new Vector3(0.1f, 0.1f, 0);
    }

    public void IncreaseSize()
    {
        Platform.transform.localScale += new Vector3(1,1,0);
    }
}
