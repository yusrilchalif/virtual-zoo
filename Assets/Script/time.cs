using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.

public class time : MonoBehaviour {

	public Material[] Skyboxs;
	public Light Lampu;
	public float Delay = 1.5f;
	int curSkybox;

	// Use this for initialization
	void Start () {
		curSkybox = 0;
		Lampu.enabled = false;
		RenderSettings.skybox = Skyboxs[0];
		InvokeRepeating("ChangeSkybox",1,Delay);
	}
	
	void ChangeSkybox(){
		RenderSettings.skybox = Skyboxs[curSkybox];
		curSkybox++;
		if(curSkybox > Skyboxs.Length-1){
			curSkybox = 0;
		}
	}

	// Update is called once per frame
	void Update () {
		// if(Input.GetKeyDown("A")){
		// 	Lampu.enabled = !Lampu.enabled;
		// }
		// color default light = FFF4D6
	}
}
