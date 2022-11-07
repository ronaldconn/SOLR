using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Button))]
 
public class ClickChanger : MonoBehaviour
{
     public KeyCode key;

     void Update()
     {
       if (Input.GetKeyDown(key))
         {
             GetComponent<Button>().onClick.Invoke();
         } 
     }
}
