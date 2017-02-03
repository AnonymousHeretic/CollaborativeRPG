using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    float blockLength = .1f;
    bool canMove = true;

	void FixedUpdate () {
        if (Input.GetKey(KeyCode.W) && canMove) {
            this.GetComponent<Rigidbody2D>().MovePosition(new Vector2(
                transform.position.x,
                transform.position.y + blockLength));
        }

        if (Input.GetKey(KeyCode.A) && canMove)
        {
            this.GetComponent<Rigidbody2D>().MovePosition(new Vector2(
                transform.position.x - blockLength,
                transform.position.y));
        }

        if (Input.GetKey(KeyCode.S) && canMove)
        {
            this.GetComponent<Rigidbody2D>().MovePosition(new Vector2(
                transform.position.x,
                transform.position.y - blockLength));
        }

        if (Input.GetKey(KeyCode.D) && canMove)
        {
            this.GetComponent<Rigidbody2D>().MovePosition(new Vector2(
                transform.position.x + blockLength,
                transform.position.y));
        }
    }
}
