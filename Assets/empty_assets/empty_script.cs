using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empty_script : MonoBehaviour
{

    [SerializeField]
    float i;

    // Start is called before the first frame update
    void Start()
    {

        i = 0;
        Debug.Log(i);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("allo" + i);
        i += Time.deltaTime;
    }
}
