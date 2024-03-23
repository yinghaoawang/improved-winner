using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObscuringItemFader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ObscuringItemFader[] obscuringItemFaders = collision.GetComponentsInChildren<ObscuringItemFader>();

        if (obscuringItemFaders.Length > 0)
        {
            foreach (ObscuringItemFader obscuringItemFader in obscuringItemFaders)
                obscuringItemFader.FadeOut();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ObscuringItemFader[] obscuringItemFaders = collision.GetComponentsInChildren<ObscuringItemFader>();

        if (obscuringItemFaders.Length > 0)
        {
            foreach (ObscuringItemFader obscuringItemFader in obscuringItemFaders)
                obscuringItemFader.FadeIn();
        }
    }
}
