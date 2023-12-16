using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    //shooting
    [SerializeField] AudioClip jumplip;
    [SerializeField] [Range(0f, 1f)] float jumpVolume = 1f;

    //explosions
    [SerializeField] AudioClip attackSound;
    [SerializeField] [Range(0f, 1f)] float attackSoundVolume;

    public void PlayShootingClip()
    {
        if (jumplip != null)
        {
            PlayClip(jumplip, jumpVolume);
        }
        
    }

    public void CasualExplosion()
    {
        if (attackSound != null)
        {
            PlayClip(attackSound, attackSoundVolume);
        }
        
    }

    void PlayMusic()
    {
        audioSource.mute = false;
    }
   void StopMusicClip()
    {
        audioSource.mute = true;
    }

    void PlayClip(AudioClip clip, float volume)
    {
        Vector3 cameraPos = Camera.main.transform.position;
        AudioSource.PlayClipAtPoint(clip, cameraPos, volume);
    }
}
