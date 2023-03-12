using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// For this to funtion properly you need to pass it within an object that has an audio source
[CreateAssetMenu(fileName = "SFX Player", menuName = "Game Events/SFX Player")]
public class SFXPlayerSO : ScriptableObject
{
   
    [SerializeField]
    List<AudioClip> listOfAlternatingSounds;
    public void Play(AudioSource audioSource)
    {
            audioSource.clip = SelectSound();
            audioSource.Play();
    }
    AudioClip SelectSound()
    {
        int randomIndex = Random.Range(0, listOfAlternatingSounds.Count);
        return listOfAlternatingSounds[randomIndex];
    }
}
