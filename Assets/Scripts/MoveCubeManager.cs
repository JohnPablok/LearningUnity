using UnityEngine;
using System.Collections;

public class MoveCubeManager : MonoBehaviour
{

    public GameObject selectedObject;
    public GameObject blueTokenPrefab;
    public bool clicked = false;
    public bool blueTurn = true;
    public bool redTurn = false;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (blueTurn) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (hit.transform.gameObject.tag == "blueToken")
                    {
                        selectedObject = hit.transform.gameObject;
                    }
                }
            }
            if (Input.GetMouseButton(0))
            {

            }
            if (Input.GetMouseButtonUp(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (hit.transform.gameObject.tag == "boardPiece" && selectedObject)
                    {
                        selectedObject.transform.position = hit.transform.position;
                    }
                }
                selectedObject = null;
            }
        }
        if (redTurn)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (hit.transform.gameObject.tag == "redToken")
                    {
                        selectedObject = hit.transform.gameObject;
                    }
                }
            }
            if (Input.GetMouseButton(0))
            {

            }
            if (Input.GetMouseButtonUp(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (hit.transform.gameObject.tag == "boardPiece" && selectedObject)
                    {
                        selectedObject.transform.position = hit.transform.position;
                    }
                }
                selectedObject = null;
            }
        }      

    }

    public void EndTurn()
    {
        blueTurn = redTurn;
        redTurn = !blueTurn;

        Debug.Log("endTurn");
    }
}
