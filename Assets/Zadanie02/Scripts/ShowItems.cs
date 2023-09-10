using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowItems : MonoBehaviour
{
    [SerializeField] List<Animator> items;

    public void Show(int index)
    {
         items[index].SetTrigger("show");
    }

    public void HideItems()
    {
        foreach (var item in items)
        {
            item.ResetTrigger("show");
            item.SetTrigger("hide");
        }
    }
}
