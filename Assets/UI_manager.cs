using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_manager : MonoBehaviour
{
    public BPM BpmInstance;
    public PlaySoundsOnBeat PSOB;
    public Button Startbtn, MedioTonobtn; 
    public Button btn2_4, btn3_4, btn4_4, btn5_4, btn6_4, btn7_4;
    

    // Start is called before the first frame update
    void Start()
    {
        Startbtn.onClick.AddListener(StartBeat);
        MedioTonobtn.onClick.AddListener(MedioTonoStart);
        btn2_4.onClick.AddListener(Set2_4Tone);
        btn3_4.onClick.AddListener(Set3_4Tone);
        btn4_4.onClick.AddListener(Set4_4Tone);
        btn5_4.onClick.AddListener(Set5_4Tone);
        btn6_4.onClick.AddListener(Set6_4Tone);
        btn7_4.onClick.AddListener(Set7_4Tone);
    
    }

    void StartBeat(){
        BpmInstance.StatePlay = !BpmInstance.StatePlay;
        if(BpmInstance.StatePlay ==  false){
            BpmInstance.beatTimer = 0;
            BpmInstance.beatTimerD8 = 0;
        }
    }

    void MedioTonoStart(){
        PSOB.activarMedioTonos = !PSOB.activarMedioTonos;
    }

    void Set2_4Tone(){
        PSOB.top = 2;
    }
    void Set3_4Tone(){
        PSOB.top = 3;
    }
    void Set4_4Tone(){
        PSOB.top = 4;
    }
    void Set5_4Tone(){
        PSOB.top = 5;
    }
    void Set6_4Tone(){
        PSOB.top = 6;
    }
    void Set7_4Tone(){
        PSOB.top = 7;
    }

}
