using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Window : MonoBehaviour
{
    [SerializeField] private Button CloseButton;
    [SerializeField] private Button MinimizeButton;

    private void OnEnable()
    {
        CloseButton.onClick.RemoveAllListeners();
        CloseButton.onClick.AddListener(Close);

        MinimizeButton.onClick.RemoveAllListeners();
        MinimizeButton.onClick.AddListener(Minimize);
    }

    private void Close()
    {
        Destroy(gameObject);
    }

    private void Minimize()
    {
        Destroy(gameObject);
    }
}
