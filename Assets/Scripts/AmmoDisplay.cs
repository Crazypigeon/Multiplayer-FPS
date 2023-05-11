using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Text text2;
    [SerializeField] private GameObject reloadPanel1;
    [SerializeField] private Text reloadText2;
    [SerializeField] private FpsGun ammoNumber;

    void Update()
    {
        text.text = Mathf.Clamp(ammoNumber.ammo, 0, 30).ToString() + "/30";
        text2.text = Mathf.Clamp(ammoNumber.ammo, 0, 30).ToString() + "/30";
        if (ammoNumber.ammo <= 5) { reloadPanel1.SetActive(true); }
        else if (ammoNumber.ammo > 5) { reloadPanel1.SetActive(false); }
        if (ammoNumber.ammo <= 5) { reloadText2.text = "Spausk R, kad užtaisytum ginklą"; }
        else if (ammoNumber.ammo > 5) { reloadText2.text = ""; }
    }
}
