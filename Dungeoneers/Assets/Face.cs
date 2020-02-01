using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Face : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] Sprite high;
    [SerializeField] Sprite med;
    [SerializeField] Sprite low;
    [SerializeField] Sprite oofSprite;

    float time;
    int hp;

    public void OnHit(int hpLeft)
    {
        if (hpLeft <= 0)
            return;

        hp = hpLeft;
        time = 2f;
        StartCoroutine("oof");
    }

    private IEnumerator oof()
    {
        while(time >= 0f)
        {
            image.sprite = oofSprite;
            time -= Time.deltaTime;
            Debug.Log(time);   
            yield return null;
        }

        switch (hp)
        {
            case 3:
                image.sprite = high;
                break;
            case 2:
                image.sprite = med;
                break;
            case 1:
                image.sprite = low;
                break;
            case 0:
                image.sprite = oofSprite;
                break;
            default:
                image.sprite = oofSprite;
                break;
        }
    }
}
