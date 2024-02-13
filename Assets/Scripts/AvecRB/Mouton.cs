using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouton : MonoBehaviour
{

    [SerializeField] private GameObject _parachute;
    [SerializeField] private GameObject _zone;

    private Rigidbody _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        BougeMouton();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void BougeMouton()
    {
        _rb.AddForce(Vector3.forward * 50, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == _zone.transform.tag)
        {
            OuvreParachute();
        }
    }


    void OuvreParachute()
    {
        _parachute.SetActive(true);
    }
}
