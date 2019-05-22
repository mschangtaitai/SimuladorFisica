using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Cube : MonoBehaviour
{
    private Rigidbody rigid;
    private BoxCollider collider;
    public Slider slider_friction;
    public Slider slider_k;
    public Slider slider_x;
    public Text FrictionText;
    public Text KText;
    public Text XText;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        collider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        collider.material.dynamicFriction = ((float)(0.1*slider_friction.value));
        FrictionText.text = collider.material.dynamicFriction.ToString();
        bool Jump = Input.GetButtonDown("Jump");
        float Force = (slider_k.value * 10) * (slider_x.value * 10);
        KText.text = (slider_k.value * 10).ToString();
        XText.text = (slider_x.value * 10).ToString();

        if (Jump)
        {
            rigid.AddForce(Force, 0, 0, ForceMode.Impulse);
        }

    }
}

