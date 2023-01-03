using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[DefaultExecutionOrder(1000)]
public class UsernameInputField : MonoBehaviour
{
    private void Awake()
    {
        if(MenuManager.Instance != null)
        {
            gameObject.GetComponent<TextMeshProUGUI>().text = MenuManager.Instance.username;
        }
    }
}
