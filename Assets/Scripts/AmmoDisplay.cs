using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private Text text2;
    [SerializeField] private FpsGun ammoNumber;

    void Update()
    {
        text.text = Mathf.Clamp(ammoNumber.ammo, 0, 30).ToString() + "/30";
        text2.text = Mathf.Clamp(ammoNumber.ammo, 0, 30).ToString() + "/30";
    }
}
