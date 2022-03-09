using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    [SerializeField] Rigidbody2D _rb;
    
    private float movement = 0f;
    void Update() => movement = Input.GetAxisRaw("Horizontal") * speed;
    private void FixedUpdate() => _rb.MovePosition(_rb.position + new Vector2(movement * Time.fixedDeltaTime, 0f));

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag=="Ball")
        {
            Debug.Log("GAME OVER!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

}
