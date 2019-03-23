using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// note의 월드 좌표를 구합니다.
// 월드좌표는 x,y로 이루어져 누워 있음으로 180도 돌려줍니다.
// 그렇다면 끝

//

public class CreateNote : MonoBehaviour
{
    public GameObject note;
    
    public GameObject canvas;

    void Start(){

    }
    void Update(){}

    public void InitializeNote()
    {
        Transform st_info = GameObject.Find("stposNote").transform;
        
        GameObject obj = Instantiate(note, st_info.position, st_info.rotation);
        obj.transform.SetParent(canvas.transform);
    }
}
