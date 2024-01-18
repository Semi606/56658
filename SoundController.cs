using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip myAudioClip; //посилання на аудіокліп
    private AudioSource myAudioSource; //посилання на аудіокомпонент з файлів

    void Start() //тут ми додаємо аудіокомпонент до об'єкта і встановлюємо аудіокліп
    {
        myAudioSource = gameObject.AddComponent<AudioSource>(); //компонент на персонажі
        myAudioSource.clip = myAudioClip;
    }

    
    void Update() //робимо відтворення звуку по потисканню клавіш
    {
        if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.A)){
            PlaySound();
        }else{
            StopSound();
        }
    }

    void PlaySound(){ //метод для відтворення звуку
    //перевірка чи аудіокомпонент та аудіокліп встановлені
        if(myAudioSource!=null && myAudioClip!=null){
            myAudioSource.Play(); //відтворення звуку
        }
    }

    void StopSound(){ //метод для зупинки звуку
    //перевірка чи аудіокомпонент встановлений та чи відтворення звуку в процесі
        if(myAudioSource!=null && myAudioSource.isPlaying){
            myAudioSource.Stop(); //зупинка звуку
        }
    }
}

