using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pointer : MonoBehaviour
{

    private float size = 2f;
    public float speed;
    public float time;

    private Vector2 originScale; //원래 크기

    private void Awake()
    {
        originScale = transform.localScale; //원래 크기 저장
    }
    private void OnEnable()
    {
        StartCoroutine(Up());
    }
    IEnumerator Up()
    {
        while (transform.localScale.x < size)
        {
            transform.localScale = originScale * (1f + time * speed);
            time += Time.deltaTime;

            if (transform.localScale.x >= size)
            {
                time = 0;
                break;
            }
            yield return null;
        }
    }

    private void OnDisable()
    {
        gameObject.transform.localScale = originScale;
    }
}
