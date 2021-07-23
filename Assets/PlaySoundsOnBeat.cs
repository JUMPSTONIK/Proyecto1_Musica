using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeat : MonoBehaviour
{
    public SoundManager soundManager;
    public AudioClip tap, klack, tac;
    public AudioClip[] strum;
    private int Contador = 1;
    public int top;
    public bool activarMedioTonos = false;
    int randomStrum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        
        //Tono completo
     if(BPM.beatFull){
         
         if(Contador == 1){
            soundManager.PlaySound(tap, 1);
            Debug.Log("Tono tap");
         }else{
            soundManager.PlaySound(klack, 1);
            Debug.Log("Tono klack");
         }
         Contador++;
     }   

    //  Medio Tono
    if(activarMedioTonos){
        if(BPM.beatD8 && (BPM.beatCountD8 % 4 == 0 )){
            soundManager.PlaySound(tac, 0.5f);
            Debug.Log("Medio Tono");
        }
    }
     
     //resetear contador
     if(Contador >= top){
            Contador = 0;
         }
    }
}
