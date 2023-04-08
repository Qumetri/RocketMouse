using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Mouse : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] float jetpackForce = 70;
    [SerializeField] float moveForward = 3;
    Animator anim;
    [SerializeField] ParticleSystem ps;
    [SerializeField] int coins;
    [SerializeField] Text scoreText;
    bool fire1;
    bool IsDead;
    // Start is called before the first frame update
    void Start()
    {
        IsDead = false;
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    void FixedUpdate()
    {
        fire1 = Input.GetButton("Fire1");
        if (fire1 && !IsDead)
        {
            rb2d.AddForce(transform.up * jetpackForce);
        }
        Vector2 velo = rb2d.velocity;
        if (!IsDead) { 
            velo.x = moveForward;
            rb2d.velocity = velo;
        }
    }


    // Update is called once per frame

    void Update()
    {
        bool isgrnd = transform.position.y < -2.1;
        if (isgrnd)
        {
            anim.SetBool("IsGrounded", true);//run


        }
        else {

            //fly
            anim.SetBool("IsGrounded", false);
        }
        var em = ps.emission;
        em.enabled = !isgrnd;
        if (fire1 && !IsDead)

        {
            em.rateOverTime = 250;
        }
        else
        {
            em.rateOverTime = 50;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Laser"))
        {
            anim.SetBool("Dead", true);
            IsDead = true;
        }
        else if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            scoreText.text = coins.ToString();
        }
        
    }
}
