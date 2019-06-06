using UnityEngine;
using Microsoft.MixedReality.Toolkit.Audio;

public class LocalAudioManager : MonoBehaviour
{
    public void PlayAudioEvent(AudioEvent eventToPlay)
    {
        AudioManager.PlayEvent(eventToPlay, this.gameObject);
    }
}