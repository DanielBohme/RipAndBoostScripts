using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] Vector3 rotateVector = new Vector3(1f, 1f, 1f);
    [SerializeField] float speed = 0.4f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateVector * speed * Time.deltaTime);
    }
}
