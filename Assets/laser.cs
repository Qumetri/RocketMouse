using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    [SerializeField] float rotaSpeed = 30;
    [SerializeField] float delay = 0.5f;
    float countDown;
    [SerializeField] bool laserOn = true;
    [SerializeField] Sprite laserOnSprite, laserOffSprite;

    Collider2D col;
    SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        rend = GetComponent<SpriteRenderer>();
        rotaSpeed = Random.Range(-90, 90);
        countDown = 0;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, rotaSpeed * Time.deltaTime);
        countDown += Time.deltaTime;
        if(countDown > delay)
        {
            countDown = 0;
            laserOn = !laserOn;
            col.enabled = laserOn;
            if (laserOn)
            {
                rend.sprite = laserOnSprite;
                
            }
            else
            {
                rend.sprite = laserOffSprite;
            }
        }
    }
}
