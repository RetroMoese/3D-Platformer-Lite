using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class animate : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform _playerTf;
    public float _speedRotation;


    private void Start()
    {
        _playerTf = GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            Rotation(8);
        if (Input.GetKey(KeyCode.RightArrow))
            Rotation(188);
    }


    private void Rotation(float requiredAngle)
    {
        Quaternion target = Quaternion.Euler(0, requiredAngle, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * _speedRotation);
    }
}
*/