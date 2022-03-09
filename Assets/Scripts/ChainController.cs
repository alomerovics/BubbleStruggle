using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainController : MonoBehaviour
{
    public static bool IsFired;
    [SerializeField] Transform _player;
    [SerializeField] float _chainSpeed = 5f;
    void Start()
    {
        IsFired = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            IsFired = true;
        }
        if (IsFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * _chainSpeed;
        }
        else
        {
            transform.position = _player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }
}
