using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float velocity = 6f;
    public float rotationVelocity = 30f;
    public Vector3 gravity = Vector3.down * 9.81f;

    public GameObject graphicsPrefab;


    IEmote emote;

    // Start is called before the first frame update

    CharacterController cController;

    void Awake()
    {
        cController = GetComponent<CharacterController>();
        GameObject go = Instantiate(graphicsPrefab, this.transform);
        go.transform.localPosition = Vector3.up;
        emote = go.GetComponent<IEmote>();
        emote.ShowNormal();
    }

    // Update is called once per frame
    void Update()
    {
        float forward = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        // move via position
        //this.transform.position += this.transform.forward * forward * velocity * Time.deltaTime;
        // move via 
        //this.transform.Translate(Vector3.forward * forward * velocity * Time.deltaTime , Space.Self);

        Vector3 currentVelocity = this.transform.forward * forward * velocity;


        cController.Move( (currentVelocity + gravity) * Time.deltaTime);

        // rotation
        //this.transform.eulerAngles += Vector3.up * horizontal * rotationVelocity * Time.deltaTime;
        // rotation via method
        this.transform.Rotate(Vector3.up * rotationVelocity * horizontal * Time.deltaTime);


        // Gestione degli occhiali
        if (Input.GetKeyDown(KeyCode.Alpha1)) emote.ShowNormal();
        if (Input.GetKeyDown(KeyCode.Alpha2)) emote.ShowEmote();

    }
}
