using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainchar_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    int Zpos = -9;
    public SpriteRenderer spriteRenderer;
    public Collider2D Collider2D;
    public LayerMask[] wallMask;
    private BoxCollider2D bloquearriba, bloquederecha, bloqueabajo, bloqueizquierda;
    [SerializeField]
    private Sprite spriteArriba;
    [SerializeField]
    private Sprite spriteAbajo;
    [SerializeField]
    private Sprite spriteLateral;
    [SerializeField]
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
        if (moveValidate(bloqueizquierda))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                StartCoroutine(moveXonA());
            }
        }
        if (moveValidate(bloquederecha))
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                StartCoroutine(moveXonD());
            }
        }
        if (moveValidate(bloquearriba))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                StartCoroutine(moveXonW());
            }
        }
        if (moveValidate(bloqueabajo))
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
        spriteRenderer.sprite = spriteLateral;
        for (int x = 0; x < 40; x++)
        {
            this.transform.position = new Vector3((float)(this.transform.position.x - 0.025), this.transform.position.y,Zpos);
            yield return new WaitForSecondsRealtime((float)0.0002);
        }       
    }

    IEnumerator moveXonD()
    {

        spriteRenderer.flipX = true;
        spriteRenderer.sprite = spriteLateral;
        for (int x = 0; x < 40; x++)
        {
            this.transform.position = new Vector3((float)(this.transform.position.x + 0.025), this.transform.position.y, Zpos);
            yield return new WaitForSecondsRealtime((float)0.0002);
        }
    }

    IEnumerator moveXonW()
    {
        spriteRenderer.sprite = spriteArriba;
        for (int x = 0; x < 40; x++)
        {
            this.transform.position = new Vector3(this.transform.position.x, (float)(this.transform.position.y + 0.025), Zpos);
            yield return new WaitForSecondsRealtime((float)0.0002);
        }
    }

    IEnumerator moveXonS()
    {
        spriteRenderer.sprite = spriteAbajo;
        for (int x = 0; x < 40; x++)
        {
            this.transform.position = new Vector3(this.transform.position.x, (float)(this.transform.position.y - 0.025), Zpos);
            yield return new WaitForSecondsRealtime((float)0.0002);
        }
        
    }

    private bool moveValidate(BoxCollider2D collider)
    {
        foreach(LayerMask layerMask in wallMask)
        {
            if (!collider.IsTouchingLayers(layerMask))
            {
                return true;
            }
        }
        return false;
    }
}
