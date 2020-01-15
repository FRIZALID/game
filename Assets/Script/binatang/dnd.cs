using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dnd : MonoBehaviour {
	[SerializeField]

	public GameObject binatang1,binatang2,binatang3,binatang4,tempat1,tempat2,tempat3,tempat4,selesai;
	Vector2 posbinatang1,posbinatang2,posbinatang3,posbinatang4;
	static AudioSource suara;
	public AudioClip[] benar;
	public AudioClip salah;
	


	void Start(){
		posbinatang1 = binatang1.transform.position;
		posbinatang2 = binatang2.transform.position;
		posbinatang3 = binatang3.transform.position;
		posbinatang4 = binatang4.transform.position;

		suara = GetComponent<AudioSource>();
		selesai.SetActive(false);
		
	}
	void Update(){
		if(binatang1.transform.position == tempat1.transform.position &&
			binatang2.transform.position == tempat2.transform.position &&
			binatang3.transform.position == tempat3.transform.position &&
			binatang4.transform.position == tempat4.transform.position){
			selesai.SetActive(true);
		}
	}
	

	public void Dragbinatang1(){
		binatang1.transform.position = Input.mousePosition;
	}
	public void Dragbinatang2(){
		binatang2.transform.position = Input.mousePosition;
	}
	public void Dragbinatang3(){
		binatang3.transform.position = Input.mousePosition;
	}
	public void Dragbinatang4(){
		binatang4.transform.position = Input.mousePosition;
	}

	public void Dropbinatang1(){
		float Distance = Vector3.Distance(binatang1.transform.position,tempat1.transform.position);
		if(Distance < 50){
			binatang1.transform.position = tempat1.transform.position;
			
			suara.clip = benar[0];
			suara.Play();
			
		}	
		else{
			binatang1.transform.position = posbinatang1;
			suara.clip = salah;
			suara.Play();
		}

	}
	public void Dropbinatang2(){
		float Distance = Vector3.Distance(binatang2.transform.position,tempat2.transform.position);
		if(Distance < 50){
			binatang2.transform.position = tempat2.transform.position;
			
			suara.clip = benar[1];
			suara.Play();
		}	
		else{
			binatang2.transform.position = posbinatang2;
			suara.clip = salah;
			suara.Play();
		}
	}
	public void Dropbinatang3(){
		float Distance = Vector3.Distance(binatang3.transform.position,tempat3.transform.position);
		if(Distance < 50){
			binatang3.transform.position = tempat3.transform.position;
			
			suara.clip = benar[2];
			suara.Play();
			
		}	
		else{
			binatang3.transform.position = posbinatang3;
			suara.clip = salah;
			suara.Play();
		}
	}
	public void Dropbinatang4(){
		float Distance = Vector3.Distance(binatang4.transform.position,tempat4.transform.position);
		if(Distance < 50){
			binatang4.transform.position = tempat4.transform.position;
			
			suara.clip = benar[3];
			suara.Play();
			
		}	
		else{
			binatang4.transform.position = posbinatang4;
			suara.clip = salah;
			suara.Play();
		}
	}
}
