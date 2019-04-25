using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ToggleMenu : MonoBehaviour {
	public SteamVR_Action_Boolean menuToggle;
	public Hand hand;
	public GameObject menu;

	private void OnEnable(){
		if (hand == null){
			hand = this.GetComponent<Hand>();
		}

		if(menuToggle == null){
			print("OwO");
			return;
		}

		menuToggle.AddOnChangeListener(MenuActionChange, hand.handType);
	}

	private void OnDisable(){
		if(menuToggle != null){
			menuToggle.RemoveOnChangeListener(MenuActionChange, hand.handType);
		}
	}

	private void MenuActionChange(SteamVR_Action_Boolean actionIn, SteamVR_Input_Sources inputSource, bool newValue){
		if(newValue){
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
