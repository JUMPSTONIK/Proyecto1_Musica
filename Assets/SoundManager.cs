using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public int bankSize;
    private List<AudioSource> soundClip;

    // Start is called before the first frame update
    void Start()
    {
        soundClip = new List<AudioSource>();
        for(int i = 0; i < bankSize; i++){
            GameObject soundInstace = new GameObject("sound");
            soundInstace.AddComponent<AudioSource>();
            soundInstace.transform.parent = this.transform;
            soundClip.Add(soundInstace.GetComponent<AudioSource>());
        }
    }

    // Update is called once per frame
    public void PlaySound(AudioClip clip, float volume)
    {
        for(int i = 0; i < soundClip.Count; i++){
            if(!soundClip[i].isPlaying){
                soundClip[i].clip = clip;
                soundClip[i].volume = volume;
                soundClip[i].Play();
                return;
            }
        }

        GameObject soundInstace = new GameObject("sound");
        soundInstace.AddComponent<AudioSource>();
        soundInstace.transform.parent = this.transform;
        soundInstace.GetComponent<AudioSource>().clip = clip;
        soundInstace.GetComponent<AudioSource>().volume = volume;
        soundInstace.GetComponent<AudioSource>().Play();
        soundClip.Add(soundInstace.GetComponent<AudioSource>());
    }
}
