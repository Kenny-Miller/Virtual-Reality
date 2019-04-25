using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ToggleMenuV2 : MonoBehaviour {
	public Hand hand;
	public GameObject menu;

	private void OnEnable(){
		if (hand == null){
			hand = this.GetComponent<Hand>();
		}
	}

	private void Update(){
		if (SteamVR_Actions.menuToggle.ToggleMenu[hand.handType].state){
			Toggle();
		}
	}

	private void Toggle(){
		if(menu.activeSelf == false){
			menu.SetActive(true);
		}
		else{
			menu.SetActive(false);
		}
	}
}
