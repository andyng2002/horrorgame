using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnButtonClick() {
        Debug.Log("clicky");
        if (PlayerInventory.BatteryNumber > 0) {
            flashlightController.RechargeBattery();
        }
    }
}
