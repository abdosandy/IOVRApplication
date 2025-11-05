using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LineRenderer))]
public class EyeTrackingRenderer : MonoBehaviour
{
    public Camera camera;
    

    private float _rayDistance = 10.0f;
    private float _rayWidth = 0.0025f;
    private LayerMask _layers;
    private Color _rayColorDefault = Color.red;
    private Color _rayColorHover = Color.green;
    private LineRenderer _lineRenderer;
    public float timeLookAvatar;
  

    // Start is called before the first frame update
    void Start()
    {
        //if (!isLocalPlayer)
        //{
        //    return;
        //}


        _layers = LayerMask.GetMask("ColliderChatbot"); // funziona solo in Awake o Start, non spostare
        _lineRenderer = GetComponent<LineRenderer>();
        SetUpRay();

    }

    private void SetUpRay()
    {
        _lineRenderer.useWorldSpace = false;
        _lineRenderer.positionCount = 2;
        _lineRenderer.startWidth = _rayWidth;
        _lineRenderer.endWidth = _rayWidth;
        _lineRenderer.startColor = _rayColorDefault;
        _lineRenderer.endColor = _rayColorDefault;
        _lineRenderer.SetPosition(0, new Vector3(camera.transform.position.x, camera.transform.position.y, transform.position.z - 1f));
        _lineRenderer.SetPosition(1, new Vector3(camera.transform.position.x, camera.transform.position.y, transform.position.z + _rayDistance - 1f));
    }

    private void Update()
    {
        //if (!isLocalPlayer)
        //{
        //    return;
        //}

        RaycastHit hit;

        Vector3 rayDirection = transform.TransformDirection(Vector3.forward) * _rayDistance;

        if (Physics.Raycast(transform.position, rayDirection, out hit, Mathf.Infinity, _layers))
        {
            //Debug.Log("Ray HIT: " + hit.collider.name);
            //UnSelect();
            //_lineRenderer.startColor = _rayColorHover;
            //_lineRenderer.endColor = _rayColorHover;
            //var observed = hit.transform.GetComponent<Observed>();
            //_observeds.Add(observed);
            //observed.IsHovered = true;
            //Debug.Log("Hit: " + hit.collider.name);

            //Debug.DrawRay(transform.position, rayDirection, Color.green);
            //Debug.DrawRay(hit.point, hit.normal, Color.green, 1, false);
            //Debug.Log("Collider's gameobject: " + hit.collider.gameObject.name);
            //hit.collider.gameObject.SendMessage("EyeContact"); // no perchè prende la testa, non conviene cercare a ritroso la radice
            //Debug.Log("ENTRATO VISTO QUALCOSA" + transform.name + hit.transform.name);
            timeLookAvatar += Time.deltaTime;

        }
        else
        {
            //Debug.Log("Ray MISS");
            //_lineRenderer.startColor = _rayColorDefault;
            //_lineRenderer.endColor = _rayColorDefault;
            //UnSelect(true);
            //Debug.DrawRay(transform.position, rayDirection, Color.red);
        }
    }
}
