using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
    float blockLength = .1f;
    public bool canMove = true;
    public char orientation = 'd';
    public char lastOrientation = 'd';

	void FixedUpdate () {
        if (Input.GetKey(KeyCode.W) && canMove) {
            this.GetComponent<Rigidbody2D>().MovePosition(new Vector2(
                transform.position.x,
                transform.position.y + blockLength));
            orientation = 'u';
        }

        if (Input.GetKey(KeyCode.A) && canMove)
        {
            this.GetComponent<Rigidbody2D>().MovePosition(new Vector2(
                transform.position.x - blockLength,
                transform.position.y));
            orientation = 'l';
        }

        if (Input.GetKey(KeyCode.S) && canMove)
        {
            this.GetComponent<Rigidbody2D>().MovePosition(new Vector2(
                transform.position.x,
                transform.position.y - blockLength));
            orientation = 'd';
        }

        if (Input.GetKey(KeyCode.D) && canMove)
        {
            this.GetComponent<Rigidbody2D>().MovePosition(new Vector2(
                transform.position.x + blockLength,
                transform.position.y));
            orientation = 'r';
        }

        if (orientation != lastOrientation) {
            switch (orientation) {
                case 'u':
                    //this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("CharUp");
                    break;
                case 'd':
                    //this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("CharDown");
                    break;
                case 'l':
                    //this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("CharLeft");
                    break;
                case 'r':
                    //this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("CharRight");
                    break;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("collided");
        if (col.gameObject.name == "Top" && orientation == 'u' |
            col.gameObject.name == "Bottom" && orientation == 'd' |
            col.gameObject.name == "Left" && orientation == 'l' |
            col.gameObject.name == "Right" && orientation == 'r')
        {
            Debug.Log("facing the right way");
            if (Input.GetKey(KeyCode.E)){
                Debug.Log("activated");
                GameObject.Find("DontDestroyOnLoad").GetComponent<Activate>().Read(col.gameObject.GetComponent<Object>().line);
            }
        }
    }
}
