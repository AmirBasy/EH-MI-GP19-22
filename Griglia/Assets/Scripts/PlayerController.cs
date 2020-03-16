using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool isMoving;
    Vector3 moveTo;
    public float velocita = 1;

    bool isRotating;
    Quaternion rotateTo;
    public float velocitaRotazione = 90;


    enum Stato { Fermo, Movimento, Rotazione };

    Stato statoCorrente = Stato.Fermo;


    private void Update()
    {
        if (statoCorrente == Stato.Fermo) UpdateFermo();
        if (statoCorrente == Stato.Movimento) UpdateMovimento();
        if (statoCorrente == Stato.Rotazione) UpdateRotazione();
    }


    void UpdateFermo()
    {
        // quando prendo avanti
        if (Input.GetKey(KeyCode.W))
        {
            statoCorrente = Stato.Movimento;
            moveTo = this.transform.position + this.transform.forward;
        }
        // quando prendo avanti
        if (Input.GetKey(KeyCode.S))
        {
            statoCorrente = Stato.Movimento;
            moveTo = this.transform.position - this.transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            isRotating = true;
            rotateTo = Quaternion.Euler(0, -90, 0) * this.transform.rotation;
        }
        if (Input.GetKey(KeyCode.D))
        {
            isRotating = true;
            rotateTo = Quaternion.Euler(0, 90, 0) * this.transform.rotation;
        }
    }

    void UpdateMovimento()
    {

    }

    void UpdateRotazione()
    {

    }


    // Update is called once per frame
    void Update_ConSemaforo()
    {

        if (isRotating)
        {
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, rotateTo, velocitaRotazione * Time.deltaTime);

            if (this.transform.rotation == rotateTo) isRotating = false;

        }
        else if (isMoving)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, moveTo, velocita * Time.deltaTime);

            if (this.transform.position == moveTo) isMoving = false;
        }
        else
        {
            // quando prendo avanti
            if (Input.GetKey(KeyCode.W))
            {
                isMoving = true;
                moveTo = this.transform.position + this.transform.forward;
            }
            // quando prendo avanti
            if (Input.GetKey(KeyCode.S))
            {
                isMoving = true;
                moveTo = this.transform.position - this.transform.forward;
            }

            if (Input.GetKey(KeyCode.A))
            {
                isRotating = true;
                rotateTo = Quaternion.Euler(0, -90, 0) * this.transform.rotation;
            }
            if (Input.GetKey(KeyCode.D))
            {
                isRotating = true;
                rotateTo = Quaternion.Euler(0, 90, 0) * this.transform.rotation;
            }
        }


        //if (Input.GetKeyDown(KeyCode.S)) this.transform.Translate(-Vector3.forward*1);
        //if (Input.GetKeyDown(KeyCode.D)) this.transform.Rotate(Vector3.up * 90);
        //if (Input.GetKeyDown(KeyCode.A)) this.transform.Rotate(-Vector3.up * 90);

        

    }
}
