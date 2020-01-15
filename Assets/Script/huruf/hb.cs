using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hb : MonoBehaviour {

	public GameObject binatang1,tempat1,win;
	Vector2 posbinatang1;
	static AudioSource suara;
	public AudioClip benar,salah;
	


	void Start(){
		posbinatang1 = binatang1.transform.position;
		suara = GetComponent<AudioSource>();
		win.SetActive(false);
		
	}
	void Update(){
		if(binatang1.transform.position == tempat1.transform.position){
			win.SetActive(true);
		}
	}

	public void Dragbinatang1(){
		binatang1.transform.position = Input.mousePosition;
	}
	

	public void Dropbinatang1(){
		float Distance = Vector3.Distance(binatang1.transform.position,tempat1.transform.position);
		if(Distance < 50){
			binatang1.transform.position = tempat1.transform.position;
			suara.clip = benar;
			suara.Play();
			
		}	
		else{
			binatang1.transform.position = posbinatang1;
			suara.clip = salah;
			suara.Play();
			
		}
	}
	
	
}
