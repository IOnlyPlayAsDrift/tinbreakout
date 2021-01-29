using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparkles : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    private float startWait = 0.5f;
    [SerializeField] AudioClip goodjobnoise;

    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.enabled = false;
    }

    public void Sparkles()
    {
        FindObjectOfType<cup>().Cup();
        this.spriteRenderer.enabled = true;
        Invoke("SparklesAudio", startWait);
        Invoke("SparklesOff", startWait);
    }

    public void SparklesOff()
    {
        this.spriteRenderer.enabled = false;
    }

    public void SparklesAudio()
    {
        AudioSource.PlayClipAtPoint(goodjobnoise, Camera.main.transform.position, 0.5f);
    }

}
