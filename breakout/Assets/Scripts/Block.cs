using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] AudioClip breakSound;

    level level;

    private void Start()
    {
        level = FindObjectOfType<level>();
        level.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameStatus>().AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
        level.BlockDestroyed();
        //GetComponent<AudioSource>().Play();
        //this.transform.position = Vector3.one * 9999f;
        //Destroy(gameObject, GetComponent<AudioSource>().clip.length);
    }
}
