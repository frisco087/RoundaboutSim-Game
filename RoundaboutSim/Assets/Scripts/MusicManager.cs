using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    //void Awake()
    //{
       // GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        //if (objs.Length > 1)
            //Destroy(this.gameObject);

        //DontDestroyOnLoad(this.gameObject);
    //}

    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
