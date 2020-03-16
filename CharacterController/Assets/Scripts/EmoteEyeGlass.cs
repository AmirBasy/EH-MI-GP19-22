using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// questa classe dichiara di rispettare il contratto IEMOTE, quindi di avere le due funzioni
// dichiarate nell'interfaccia
public class EmoteEyeGlass : MonoBehaviour, IEmote
{
    public Transform eyeGlass;

    public void ShowEmote()
    {
        eyeGlass.localEulerAngles = - Vector3.right * 30;
    }

    public void ShowNormal()
    {
        eyeGlass.localEulerAngles = Vector3.right * 0;
    }
}
