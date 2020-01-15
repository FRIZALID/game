using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sema : MonoBehaviour {

	public GameObject binatang0,binatang1,binatang2,binatang3,binatang4,binatang5,binatang6,binatang7,binatang8,binatang9,
		tempat0,tempat1,tempat2,tempat3,tempat4,tempat5,tempat6,tempat7,tempat8,tempat9,selesai;
	Vector3 posbinatang0,posbinatang1,posbinatang2,posbinatang3,posbinatang4,posbinatang5,posbinatang6,posbinatang7,posbinatang8,posbinatang9;
	static AudioSource suara;
	public AudioClip[] benar;
	public AudioClip salah;

	void Start(){
		posbinatang0 = binatang0.transform.position;
		posbinatang1 = binatang1.transform.position;
		posbinatang2 = binatang2.transform.position;
		posbinatang3 = binatang3.transform.position;
		posbinatang4 = binatang4.transform.position;
		posbinatang5 = binatang5.transform.position;
		posbinatang6 = binatang6.transform.position;
		posbinatang7 = binatang7.transform.position;
		posbinatang8 = binatang8.transform.position;
		posbinatang9 = binatang9.transform.position;
		selesai.SetActive(false);
		suara = GetComponent<AudioSource>();
	}
	void Update(){
		if(binatang0.transform.position == tempat0.transform.position &&
			binatang1.transform.position == tempat1.transform.position &&
			binatang2.transform.position == tempat2.transform.position &&
			binatang3.transform.position == tempat3.transform.position &&
			binatang4.transform.position == tempat4.transform.position &&
			binatang5.transform.position == tempat5.transform.position &&
			binatang6.transform.position == tempat6.transform.position &&
			binatang7.transform.position == tempat7.transform.position &&
			binatang8.transform.position == tempat8.transform.position &&
			binatang9.transform.position == tempat9.transform.position 
			){
			selesai.SetActive(true);
		}
	}
	public void Dragbinatang0(){
		binatang0.transform.position = Input.mousePosition;
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
	public void Dragbinatang5(){
		binatang5.transform.position = Input.mousePosition;
	}
	public void Dragbinatang6(){
		binatang6.transform.position = Input.mousePosition;
	}
	public void Dragbinatang7(){
		binatang7.transform.position = Input.mousePosition;
	}
	public void Dragbinatang8(){
		binatang8.transform.position = Input.mousePosition;
	}
	public void Dragbinatang9(){
		binatang9.transform.position = Input.mousePosition;
	}

	public void Dropbinatang0(){
		float Distance = Vector3.Distance(binatang0.transform.position,tempat0.transform.position);
		if(Distance < 50){
			binatang0.transform.position = tempat0.transform.position;
			suara.clip = benar[0];
			suara.Play();
		}	
		else{
			binatang0.transform.position = posbinatang0;
			suara.clip = salah;
			suara.Play();
		}
	}
	public void Dropbinatang1(){
		float Distance = Vector3.Distance(binatang1.transform.position,tempat1.transform.position);
		if(Distance < 50 && binatang0.transform.position == tempat0.transform.position){
			binatang1.transform.position = tempat1.transform.position;
			suara.clip = benar[1];
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
		if(Distance < 50 && binatang1.transform.position == tempat1.transform.position){
			binatang2.transform.position = tempat2.transform.position;
			suara.clip = benar[2];
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
		if(Distance < 50 && binatang2.transform.position == tempat2.transform.position){
			binatang3.transform.position = tempat3.transform.position;
			suara.clip = benar[3];
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
		if(Distance < 50 && binatang3.transform.position == tempat3.transform.position){
			binatang4.transform.position = tempat4.transform.position;
			suara.clip = benar[4];
			suara.Play();
		}	
		else{
			binatang4.transform.position = posbinatang4;
			suara.clip = salah;
			suara.Play();
		}
	}
	public void Dropbinatang5(){
		float Distance = Vector3.Distance(binatang5.transform.position,tempat5.transform.position);
		if(Distance < 50 && binatang4.transform.position == tempat4.transform.position){
			binatang5.transform.position = tempat5.transform.position;
			suara.clip = benar[5];
			suara.Play();
		}	
		else{
			binatang5.transform.position = posbinatang5;
			suara.clip = salah;
			suara.Play();
		}
	}
	public void Dropbinatang6(){
		float Distance = Vector3.Distance(binatang6.transform.position,tempat6.transform.position);
		if(Distance < 50 && binatang5.transform.position == tempat5.transform.position){
			binatang6.transform.position = tempat6.transform.position;
			suara.clip = benar[6];
			suara.Play();
		}	
		else{
			binatang6.transform.position = posbinatang6;
			suara.clip = salah;
			suara.Play();
		}
	}
	public void Dropbinatang7(){
		float Distance = Vector3.Distance(binatang7.transform.position,tempat7.transform.position);
		if(Distance < 50 && binatang6.transform.position == tempat6.transform.position){
			binatang7.transform.position = tempat7.transform.position;
			suara.clip = benar[7];
			suara.Play();
		}	
		else{
			binatang7.transform.position = posbinatang7;
			suara.clip = salah;
			suara.Play();
		}
	}
	public void Dropbinatang8(){
		float Distance = Vector3.Distance(binatang8.transform.position,tempat8.transform.position);
		if(Distance < 50 && binatang7.transform.position == tempat7.transform.position){
			binatang8.transform.position = tempat8.transform.position;
			suara.clip = benar[8];
			suara.Play();
		}	
		else{
			binatang8.transform.position = posbinatang8;
			suara.clip = salah;
			suara.Play();
		}
	}
	public void Dropbinatang9(){
		float Distance = Vector3.Distance(binatang9.transform.position,tempat9.transform.position);
		if(Distance < 50 && binatang8.transform.position == tempat8.transform.position){
			binatang9.transform.position = tempat9.transform.position;
			suara.clip = benar[9];
			suara.Play();
		}	
		else{
			binatang9.transform.position = posbinatang9;
			suara.clip = salah;
			suara.Play();
		}
	}
}

