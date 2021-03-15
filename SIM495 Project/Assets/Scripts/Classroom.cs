using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Classroom : MonoBehaviour
{
    MeshRenderer mr;
    // We can change this reference if we get better geo
    BoxCollider bc;

    public GameObject classroomSchedule;
    public Material highlightMat;
    Material defaultMat;

    // Start is called before the first frame update
    void Start()
    {
        mr = this.GetComponent<MeshRenderer>();
        bc = this.GetComponent<BoxCollider>();
        defaultMat = mr.material;
        // Right now canvas should be a child of the classroom
        //classroomSchedule = GetComponentInChildren<Canvas>();
        Debug.Log(classroomSchedule);
    }

    // Update is called once per frame
    void Update()
    {
    }

	#region mouseInteraction
	private void OnMouseOver()
	{
		mr.material = highlightMat;
	}

	private void OnMouseExit()
	{
        mr.material = defaultMat;
	}
	private void OnMouseDown()
	{
        classroomSchedule.SetActive(true);
	}
	#endregion
}
