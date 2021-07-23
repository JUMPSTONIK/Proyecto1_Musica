using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBPM : MonoBehaviour
{
    public Text textBPM;
    public BPM BPM;

    // Start is called before the first frame update
    void Start()
    {
        textBPM = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textBPM.text = "BPM: " + BPM.bpm.ToString();
    }
}
