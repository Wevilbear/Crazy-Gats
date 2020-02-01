using ATXK.Helpers.UnityEvents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{

    [SerializeField] List<GameObject> hp;
    [SerializeField] UnityEventInt onHit;

    public void TakeDMG()
    {
        if (hp.Count > 0)
        {
            hp[hp.Count - 1].SetActive(false);
            hp.Remove(hp[hp.Count - 1]);
            onHit.Invoke(hp.Count);
        }
    }
}
