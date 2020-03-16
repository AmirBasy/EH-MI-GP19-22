using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// questa classe dichiara di rispettare il contratto IEMOTE, quindi di avere le due funzioni
// dichiarate nell'interfaccia
public class EmoteArm : MonoBehaviour, IEmote
{
    public Transform pivotArm;
    bool animate=false;

    public void ShowEmote()
    {
        animate = true;
    }

    public void ShowNormal()
    {
        animate = false;
    }

    void Update()
    {
        // gestione della animazione
        if (!animate)
        {
            pivotArm.localEulerAngles = Vector3.right * 0;
            return;
        }
        else
        {
            pivotArm.localEulerAngles = Vector3.forward * Mathf.Abs(Mathf.Cos(Time.time*9)) * -130;
        }

    }


}
