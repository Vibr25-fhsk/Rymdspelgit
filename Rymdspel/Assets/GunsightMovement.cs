using UnityEngine;
using UnityEngine.InputSystem;

public class GunsightMovement : MonoBehaviour
{
    private void followMousePos()
    {
        if(Mouse.current != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, GetMousePos(), 10 * Time.deltaTime);
            Debug.DrawLine(transform.position, GetMousePos(), Color.white, Time.deltaTime);
            //transform.position = GetMousePos();

            //rotate the player to face the mouse position
            /*transform.position = Vector2.MoveTowards(transform.position, GetMousePos(), 10 * Time.deltaTime);
            Vector3 mousePos = (Vector2)cam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            float angleRad = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x);
            float angleDeg = (180 / Mathf.PI) * angleRad -90;
            transform.rotation = Quaternion.Euler(0f,0f,angleDeg);
            */
        }
        else
        {
            Debug.Log("Mouse not found");
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(0, 0), 20 * Time.deltaTime);
        }

    }
    private Vector3 GetMousePos()
    {
        Vector3 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        return mousePos;
    }
    // Update is called once per frame
    void Update()
    {
        followMousePos();
    }
}
