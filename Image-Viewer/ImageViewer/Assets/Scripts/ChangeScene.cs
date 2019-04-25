using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
	public Material[] scenes;

	private Renderer rend;
	private int sceneNum;

	void Start(){
		rend = GetComponent<Renderer>();
		sceneNum = 0;
	}


	void OnTriggerEnter(Collider other){
		if(other.name.Equals("LeftArrow")){
			if(sceneNum - 1 < 0){
				sceneNum = scenes.Length - 1;
			}
			else{
				sceneNum--;
			}
			RenderSettings.skybox = scenes[sceneNum];
			DynamicGI.UpdateEnvironment();
		}

		if(other.name.Equals("RightArrow")){
			if(sceneNum + 1 == scenes.Length){
				sceneNum = 0;
			}
			else{
				sceneNum++;
			}
			RenderSettings.skybox = scenes[sceneNum];
			DynamicGI.UpdateEnvironment();
		}
	}
}
