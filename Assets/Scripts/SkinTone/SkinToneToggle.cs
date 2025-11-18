using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinToneToggle : MonoBehaviour
{
    public delegate void VoidDelegate();
    public delegate void IntDelegate(int i);

    public static IntDelegate OnSkinToneChanged;

    // #########################################################

    /*
        0 = hex[FFFFFF] (pale white)
        1 = hex[FFDAA5] (white tan)
        2 = hex[DE9E46] (orange tan)
        3 = hex[917E5A] (light brown)
        4 = hex[594120] (dark brown)
    */

    // Skin Tone Reference for Color and Index
    //public Color SkinTone = new Color(255, 255, 255);
    //public int SkinToneIndex = 0;
    public List<Color> SkinTone = new List<Color>();

    // Set the skin tone color and index.
    public void SetSkinTone(int colorValueIndex, GameObject patientBody)
    {
        /* switch (i)
         {
             default:
             case 0: // Pale White
                 SkinTone = new Color(255, 255, 255);
                 SkinToneIndex = 0;
                 break;
             case 1: // White Tan
                 SkinTone = new Color(255, 218, 165);
                 SkinToneIndex = 1;
                 break;
             case 2: // Orange Tan
                 SkinTone = new Color(222, 158, 70);
                 SkinToneIndex = 2;
                 break;
             case 3: // Light Brown
                 SkinTone = new Color(145, 126, 90);
                 SkinToneIndex = 3;
                 break;
             case 4: // Dark Brown
                 SkinTone = new Color(89, 65, 32);
                 SkinToneIndex = 4;
                 break;
         }*/



        patientBody.GetComponent<Renderer>().material.SetColor("_BaseColor", SkinTone[colorValueIndex]);

        //OnSkinToneChanged?.Invoke(i);
    }
}
