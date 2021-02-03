using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateBonusAtHitPoint();
        }
    }


    private void CreateBonusAtHitPoint()
    {
        Ray clickRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHit;
        if (Physics.Raycast(clickRay, out raycastHit))
        {
            GameObject instance = Instantiate(prefab, raycastHit.point, Quaternion.identity);
        }
    }
}
