using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Weapon weaponScript;
    public float speed;
    public float lifeTime;
    public int damage;

    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.left * speed* Time.deltaTime);
    }

    void DestroyProjectile() 
    { 
        Destroy(gameObject); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
            collision.GetComponent<Enemy>().TakeDamage(damage);
            DestroyProjectile(); 
    }
}
