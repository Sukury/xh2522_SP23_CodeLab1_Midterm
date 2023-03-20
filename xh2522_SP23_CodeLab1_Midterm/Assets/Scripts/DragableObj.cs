using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragableObj : MonoBehaviour
{
    public GameObject Botton;
    
    private string file_path;
   

   
    // Start is called before the first frame update
    void Start()
    {
        
        file_path = Application.dataPath + "/Data/" + name + ".json";
        if (File.Exists(file_path))
        {
            string file_content = File.ReadAllText(file_path);
            transform.position = JsonUtility.FromJson<Vector3>(file_content);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePosition();
    }

    Vector3 GetMousePosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }

    private void OnApplicationQuit()
    {
        string jsonPosition = JsonUtility.ToJson(transform.position, true);
        File.WriteAllText(file_path, jsonPosition);
    }

    public void BottonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //if (File.Exists(file_path))
        {
            //File.Delete(file_path);
            //AssetDatabase.Refresh();
        }
    }
    
}
