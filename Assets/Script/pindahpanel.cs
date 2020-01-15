using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pindahpanel : MonoBehaviour {

	public GameObject panelawal;
	public GameObject paneltujuan;

	public void gantikepanelbaru(){
		panelawal.SetActive (false);
		paneltujuan.SetActive (true);
	}
}
