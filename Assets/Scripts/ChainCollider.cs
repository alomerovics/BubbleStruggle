using UnityEngine;

public class ChainCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Bi�ey zincire �arpt�.");
        ChainController.IsFired = false;
        if (col.tag=="Ball")
        {
            col.GetComponent<BallController>().Split();
        }
    }
}
