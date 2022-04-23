using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainchar_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    int Zpos = -9;
    public SpriteRenderer spriteRenderer;
    public Collider2D Collider2D;
    public LayerMask wallMask;
    private BoxCollider2D bloquearriba, bloquederecha, bloqueabajo, bloqueizquierda;
    // Start is called before the first frame update
    void Start()
    {
        bloquearriba = this.transform.GetChild(0).GetComponent<BoxCollider2D>();
        bloquederecha = this.transform.GetChild(1).GetComponent<BoxCollider2D>();
        bloqueabajo = this.transform.GetChild(2).GetComponent<BoxCollider2D>();
        bloqueizquierda = this.transform.GetChild(3).GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!bloqueizquierda.IsTouchingLayers(wallMask))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                StartCoroutine(moveXonA());
            }
        }
        if (!bloquederecha.IsTouchingLayers(wallMask))
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                StartCoroutine(moveXonD());
            }
        }
        if (!bloquearriba.IsTouchingLayers(wallMask))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                StartCoroutine(moveXonW());
            }
        }
        if (!bloqueabajo.IsTouchingLayers(wallMask))
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                StartCoroutine(moveXonS());
            }
        }
    }


    IEnumerator moveXonA()
    {
        spriteRenderer.flipX = false;
        for (int x = 0; x < 100; x++)
        {
            this.transform.position = new Vector3((float)(this.transform.position.x - 0.01), this.transform.position.y,Zpos);
            yield return new WaitForSecondsRealtime((float)0.001);
        }       
    }

    IEnumerator moveXonD()
    {

        spriteRenderer.flipX = true;
        
        for (int x = 0; x < 100; x++)
        {
            this.transform.position = new Vector3((float)(this.transform.position.x + 0.01), this.transform.position.y, Zpos);
            yield return new WaitForSecondsRealtime((float)0.001);
        }
    }

    IEnumerator moveXonW()
    {
        for (int x = 0; x < 100; x++)
        {
            this.transform.position = new Vector3(this.transform.position.x, (float)(this.transform.position.y + 0.01), Zpos);
            yield return new WaitForSecondsRealtime((float)0.001);
        }
    }

    IEnumerator moveXonS()
    {
        for (int x = 0; x < 100; x++)
        {
            this.transform.position = new Vector3(this.transform.position.x, (float)(this.transform.position.y - 0.01), Zpos);
            yield return new WaitForSecondsRealtime((float)0.001);
        }
    }


}
