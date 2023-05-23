using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageManager : MonoBehaviour
{
    public Sprite playerDeadSprite;
    public Sprite playerAliveSprite;

    private SpriteRenderer sr;

    public bool isDead;

    public GameManager gm;

    public float xRange;
    public float yRange;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If the player collides with an enemy, kill the player and make them respawn after 3 seconds
        if(!isDead && collision.gameObject.CompareTag("Enemy"))
        {
            gm.lives--;
            gm.livesText.text = "Lives: " + gm.lives;
            isDead = true;
            StartCoroutine(RespawnPlayer());
        }
    }

    IEnumerator RespawnPlayer()
    {
        sr.sprite = playerDeadSprite;
        yield return new WaitForSeconds(3);
        isDead = false;
        Vector2 RandomPos = new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange));
        transform.position = RandomPos;
        sr.sprite = playerAliveSprite;
    }
}
