using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetBool("isBoom", true);
            //gameObject.AudioSource.Play();
            StartCoroutine(kaboom(this.gameObject));
            //  Destroy(this.gameObject);

        }
        
    }
    IEnumerator kaboom(GameObject gm)
    {
        yield return new WaitForSeconds(0.2f);
        animator.SetBool("isBoom", false);
        Destroy(gm);

    }
}
