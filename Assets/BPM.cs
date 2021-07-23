using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BPM : MonoBehaviour
{
    private static BPM BPMInstance;
    public float bpm = 60;
    public float betaInterval, beatTimer, betaIntervalD8, beatTimerD8;
    public static bool beatFull, beatD8;
    public static int beatCountFull, beatCountD8;
    public bool StatePlay = false;


    private void awake(){

        if(BPMInstance != null && BPMInstance != this){
            Destroy(this.gameObject);
        }else{
            BPMInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            bpm++;

        if (Input.GetKeyDown(KeyCode.DownArrow))
            bpm--;
        beatDetection();
    }

    void beatDetection(){

        //full beat count
        if(StatePlay){
            beatFull = false;
            betaInterval = 60 / bpm;
            beatTimer += Time.deltaTime;
            if(beatTimer >= betaInterval){
                beatTimer -= betaInterval;
                beatFull = true;
                beatCountFull++;
                // Debug.Log("Full");
            }

            beatD8 = false;
            betaIntervalD8 = betaInterval / 8;
            beatTimerD8 += Time.deltaTime;
            if(beatTimerD8 >= betaIntervalD8){
                beatTimerD8 -= betaIntervalD8;
                beatD8 = true;
                beatCountD8++;
                // Debug.Log("D8");
            }
        }
        
    }


}
