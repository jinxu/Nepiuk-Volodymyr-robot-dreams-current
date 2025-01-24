using UnityEngine;
using System.Collections.Generic;

public class Lesson2 : MonoBehaviour
{
    private List<float> _floatList = new List<float>();
    [SerializeField] private float _floatX;

    [ContextMenu("Add to List")]
    private void HelloWorld(){
        _floatList.Add(_floatX);        
    }

    [ContextMenu("Remove from List")]
    private void RemoveFromList(){
        _floatList.Remove(_floatX);
    }

    [ContextMenu("Clear List")]
    private void ClearList(){
        _floatList.Clear();
    }

    [ContextMenu("Sort List")]
    private void SortList(){
        _floatList.Sort();
    }

    [ContextMenu("Reverse List")]
    private void ReverseList(){
        _floatList.Reverse();
    }

    [ContextMenu("Print List")]
    private void PrintList(){
        Debug.Log(string.Join("\n", _floatList));
    }
}

