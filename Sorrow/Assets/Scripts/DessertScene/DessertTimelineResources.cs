using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DessertTimelineResources : MonoBehaviour
{
    [SerializeField] float movingSandMaxSpeed;
    [SerializeField] Renderer sandRenderer;
    Material sandMaterial => sandRenderer.material;
    [SerializeField] Vector2 sandMoveDirection;

    [SerializeField] BGMovingObject[] bgObjects;

    bool sandMoving = false;
    Vector2 currOffset;
    float speed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeWalkMode(!sandMoving);
        }//PLACEHOLDER

        currOffset += sandMoveDirection * speed * Time.deltaTime;
        if (currOffset.magnitude > 1)
            currOffset = Vector2.zero;
        sandMaterial.SetVector("_TextureOffset", currOffset);
    }
    public void ChangeWalkMode(bool isStarting)
    {
        StartCoroutine(ChangeMovingSandSpeed(isStarting));
        foreach (BGMovingObject bgObject in bgObjects)
            bgObject.isMoving = isStarting;
    }

    public IEnumerator ChangeMovingSandSpeed(bool isStarting)
    {
        float x = 0;
        float oao = isStarting ? 0 : movingSandMaxSpeed; 
        float a = movingSandMaxSpeed/2;

        if (!isStarting)
            a *= -1;

        while (isStarting ? speed < movingSandMaxSpeed : speed > 0)
        {
            yield return new WaitForEndOfFrame();

            x += Time.deltaTime;
            speed = a * (x * x) + oao;
        }
        speed = isStarting ? movingSandMaxSpeed : 0;
        yield return new WaitForEndOfFrame();
        sandMoving = isStarting;
    }
}
