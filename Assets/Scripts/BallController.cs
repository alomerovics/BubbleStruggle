using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    [SerializeField] Vector2 startForce;
    public GameObject nextBall;
    public Rigidbody2D _rb;
    List<int> balls = new List<int>();

    void Start() => _rb.AddForce(startForce, ForceMode2D.Impulse);
    public void Split()
    {
        nextBall.transform.localScale = new Vector3(transform.localScale.x / 2f, transform.localScale.x / 2f, 0f);

        if (nextBall != null)
        {
            if (nextBall.transform.localScale.x >= 0.125f)
            {
                GameObject ball1 = Instantiate(nextBall, _rb.position + Vector2.right / 4f, Quaternion.identity);
                GameObject ball2 = Instantiate(nextBall, _rb.position + Vector2.left / 4f, Quaternion.identity);
                ball1.GetComponent<BallController>().startForce = new Vector2(2f, 5f);
                ball2.GetComponent<BallController>().startForce = new Vector2(-2f, 5f);

            }
            else
            {
                Destroy(gameObject);
            }
        }
        Destroy(gameObject);
    }
}
