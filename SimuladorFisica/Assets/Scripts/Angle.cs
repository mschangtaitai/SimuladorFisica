using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Angle : MonoBehaviour
{
    public Text angle;
    public Slider slider_angle;
    private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.z = slider_angle.value * 45;
        angle.text = (slider_angle.value * 45).ToString();
        transform.rotation = Quaternion.Euler(rotationVector);
    }
}
