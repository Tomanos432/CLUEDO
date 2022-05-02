using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetAudio : MonoBehaviour {
  	public AudioMixer mixer;

	public void SetLevel(float sliderValue)
	{
		mixer.SetFloat ("Ambience", Mathf.Log10 (sliderValue) * 20 );
	}
}