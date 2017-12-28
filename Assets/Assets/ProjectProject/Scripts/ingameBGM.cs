using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingameBGM : MonoBehaviour {
    public AudioSource t0;
    public AudioSource t1;
    public AudioSource t2;
    public AudioSource t3;
    public AudioSource t4;
    public int playlist;
    public static bool next;
    int p_song;
    bool firsttime;

    void Start() {
        firsttime = true;
        next = true;
        StartCoroutine(PauseCoroutine());
    }

    void FixedUpdate() {
        if (next == true) {
            playlist = Random.Range(0, 5);

            if (firsttime == false) {
                if (p_song == 0) t0.Stop();
                else if (p_song == 1) t1.Stop();
                else if (p_song == 2) t2.Stop();
                else if (p_song == 3) t3.Stop();
                else t4.Stop();
                p_song = playlist;
            }
            else {
                firsttime = false;
                p_song = playlist;
            }

            if (playlist == 0) t0.Play();
            else if (playlist == 1) t1.Play();
            else if (playlist == 2) t2.Play();
            else if (playlist == 3) t3.Play();
            else t4.Play();
            next = false;
        }
    }

    public IEnumerator PauseCoroutine() {
        while (true) {
            if (Pause.gOver == true) {
                t0.Stop();
                t1.Stop();
                t2.Stop();
                t3.Stop();
            }

            if (Time.timeScale == 0) {
                if (playlist == 0) t0.Pause();
                else if (playlist == 1) t1.Pause();
                else if (playlist == 2) t2.Pause();
                else if (playlist == 3) t3.Pause();
                else t4.Pause();
            }
            else {
                if (playlist == 0) t0.UnPause();
                else if (playlist == 1) t1.UnPause();
                else if (playlist == 2) t2.UnPause();
                else if (playlist == 3) t3.UnPause();
                else t4.UnPause();
            }
            yield return null;
        }
    }
}
