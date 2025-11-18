using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToneListener : MonoBehaviour
{
    private void Awake()
    {
        //SkinToneToggle.OnSkinToneChanged += UpdateSkinTone;
    }

    public void UpdateSkinTone(int i)
    {
        var r = gameObject.GetComponent<Renderer>();
        //r.material = Resources.Load<Material>("Materials/Tones/" + SkinToneToggle.SkinToneIndex);
    }
}
