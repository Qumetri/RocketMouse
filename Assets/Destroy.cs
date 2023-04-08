using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject player;
    void Start()
    {
        player = GameObject.Find("mouse");
    }

    // Update is called once per frame
    void Update()
    {
        bool needToDestroy = player.transform.position.x - transform.position.x > 15;
        if (needToDestroy)
        {

            Destroy(gameObject);

        }
    }
}
