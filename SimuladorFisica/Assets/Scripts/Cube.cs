using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Cube : MonoBehaviour
{
    private Rigidbody rigid;
    private BoxCollider collider;
    private Transform transform;
    public Slider slider_friction;
    public Slider slider_k;
    public Slider slider_x;
    public Text FrictionText;
    public Text KText;
    public Text XText;
    public Text HText;
    private float maxH = 0;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        collider = GetComponent<BoxCollider>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > maxH)
        {
            maxH = transform.position.y;
            HText.text = maxH.ToString();
        }
        collider.material.dynamicFriction = ((float)(slider_friction.value));
        FrictionText.text = collider.material.dynamicFriction.ToString();
        bool Jump = Input.GetButtonDown("Jump");
        float Force = (float)((slider_k.value * 1000) * (slider_x.value * 0.1));
        KText.text = (slider_k.value * 1000).ToString();
        XText.text = (slider_x.value * 0.1).ToString();

        if (Jump)
        {
            rigid.AddForce(Force, 0, 0, ForceMode.Impulse);
        }

    }
}

