using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on: MonoBehaviour
{
    public GameObject ster;
    public void steringon()
    {
        ster.gameObject.SetActive(true);
    }
    public void steringoff()
    {
        ster.gameObject.SetActive(false);
    }
}
