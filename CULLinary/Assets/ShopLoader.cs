using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopLoader : MonoBehaviour
{
    [SerializeField] private Text text;
    private void Update()
    {
        if (PopulateShop.isPopulated)
        {
            text.text = "Autosaving in progress...";
            StartCoroutine(ShowAutosave());
        }
    }

    private IEnumerator ShowAutosave()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

}
