using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class MovePipe : MonoBehaviour {

    [SerializeField] private float _speed = 0.65f;
    
    void Update() {
        transform.position += Vector3.left * (_speed * Time.deltaTime);
    }
}
