using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] private Camera cam;
    private Vector3 dragOrigin;
    [SerializeField] private float zoomStep, minCamSize, maxCamSize;
    [SerializeField] private SpriteRenderer mapRenderer;

    private float mapMinx, mapMaxX, mapMinY, mapMaxY;

    private void Awake()
    {
        mapMinx = mapRenderer.transform.position.x - mapRenderer.bounds.size.x / 2f;
        mapMaxX = mapRenderer.transform.position.x + mapRenderer.bounds.size.x / 2f;

        mapMinY = mapRenderer.transform.position.y - mapRenderer.bounds.size.y / 2f;
        mapMaxY = mapRenderer.transform.position.y + mapRenderer.bounds.size.y / 2f;

        if(Screen.width == 2560 && Screen.height == 1080) { cam.orthographicSize = 21; maxCamSize = 21.8f; }
        if (Screen.width == 3840 && Screen.height == 1440) { cam.orthographicSize = 20; maxCamSize = 19f; }
        if(Screen.width == 3440 && Screen.height == 1440) { cam.orthographicSize = 20; maxCamSize = 21f; }
        else
        {
            cam.orthographicSize = 29;
            maxCamSize = 29f;
        }

    }

    private void Update()
    {

        if(SettingsOptions.changeRes == true)
        {
            cam.transform.position = new Vector3(0, 0, -10);
            StartCoroutine(wait());
        }

        if(Settings.isInSetting == true) { }
        if (Settings.isInSetting == false && Settings.isInMainScreen == false) {

            PanCamera();

            if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
            {
                ZoomIn();
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
            {
                ZoomOut();
            }
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.1f); // Wait for a short delay
        if (Screen.width == 2560 && Screen.height == 1080)
        {
            maxCamSize = 21.8f;
            cam.orthographicSize = 21;
        }
        else if (Screen.width == 3840 && Screen.height == 1440)
        {
            maxCamSize = 20f;
            cam.orthographicSize = 20;
        }
        else if (Screen.width == 3440 && Screen.height == 1440)
        {
            maxCamSize = 21f;
            cam.orthographicSize = 20;
        }
        else
        {
            maxCamSize = 30f;
        }
        SettingsOptions.changeRes = false;
    }

    private void PanCamera()
    {
        if (Input.GetMouseButtonDown(0))
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);

            cam.transform.position = ClampCamera(cam.transform.position + difference);
           
        }
    }

    public void ZoomIn()
    {
        float newSize = cam.orthographicSize - zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

        cam.transform.position = ClampCamera(cam.transform.position);
    }

    public void ZoomOut()
    {
        float newSize = cam.orthographicSize + zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

        cam.transform.position = ClampCamera(cam.transform.position);
    }

    private Vector3 ClampCamera(Vector3 targetPosition)
    {
        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;

        float minX = mapMinx + camWidth;
        float maxX = mapMaxX - camWidth;
        float minY = mapMinY + camHeight;
        float maxY = mapMaxY - camHeight;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);

        return new Vector3(newX, newY, targetPosition.z);
    }

   

}

