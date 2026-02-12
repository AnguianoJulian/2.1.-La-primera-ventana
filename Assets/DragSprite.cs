using UnityEngine;

public class DragSprite : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;

    void OnMouseDown()
    {
        offset = transform.position - GetMouseWorldPosition();
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    Vector3 GetMouseWorldPosition()
{
    Vector3 mousePoint = Input.mousePosition;
    mousePoint.z = Mathf.Abs(Camera.main.transform.position.z - transform.position.z);
    return Camera.main.ScreenToWorldPoint(mousePoint);
}

}
