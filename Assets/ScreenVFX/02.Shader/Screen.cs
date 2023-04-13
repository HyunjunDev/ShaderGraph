using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{   
    public Material mat;
    public float curIntensity = 0f;

    public Color color1 = Color.red;
    public Color color2 = Color.green;
    public Color color3 = Color.blue;
    public Color color4 = Color.white;
    void Start()
    {
        //Debug.Log(mat.name);
        //mat.shader = Shader.Find("ScreenVFX");
        //Debug.Log(mat.shader.name);
        mat.SetFloat("_FullScreenIntensity", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if(curIntensity <1f)
            curIntensity += Time.deltaTime;
            mat.SetFloat("_FullScreenIntensity", curIntensity);
        }
        else if(Input.GetKey(KeyCode.Return))
        {
            if(curIntensity > 0f)
                curIntensity -= Time.deltaTime;
            mat.SetFloat("_FullScreenIntensity", curIntensity);
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            mat.SetColor("_Color", color1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            mat.SetColor("_Color", color2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            mat.SetColor("_Color", color3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            mat.SetColor("_Color", color4);
        }
    }
}
