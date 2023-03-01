using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public int playerID;

    private int playeronelife = 3;
    [SerializeField] private Text player1lifet;
    [SerializeField] private Text player2lifet;
    [SerializeField] private AudioSource deathSoundEffect;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            HealthManager.health--;
            if(HealthManager.health<= 0)
            {
                Die();
                playeronelife--;
                player1lifet.text = "Player 1 Life: " + playeronelife;
            }
            else
            {
                StartCoroutine(GetHurt());
            }
        }
    }
    IEnumerator GetHurt()
    {
        Physics2D.IgnoreLayerCollision(6,8);
        GetComponent<Animator>().SetLayerWeight(1, 1);
        yield return new WaitForSeconds(3);
        GetComponent<Animator>().SetLayerWeight(1, 0);
        Physics2D.IgnoreLayerCollision(6, 8, false);
    }
    private void Die() 
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
        Invoke("timedDestroy", .5f);
    }

    void timedDestroy()
    {
        //Look for objects with player tag
        //if there is one, do nothing, if there is none, restart
        if (GameObject.FindGameObjectsWithTag("Player").Length < 2)
        {
            Destroy(gameObject);
            RestartLevel();
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    private void RestartLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
