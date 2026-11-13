using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
public class Boton_Visual : MonoBehaviour
{
    private XRBaseInteractable interaccion;

    public Vector3 localAxis;

    private Vector3 posicion_inicial;
    public float reinicioVelocidad = 5;
    private bool congelado = false;
    private bool estasiguiendo = false;

    public Transform botonvisual;
    public float followAngleThreshold = 45;

    private Vector3 offset;

    private Transform pokeAttachTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicion_inicial = botonvisual.localPosition;

        interaccion = GetComponent<XRBaseInteractable>();
        interaccion.hoverEntered.AddListener(Seguimiento);
        interaccion.hoverExited.AddListener(Reinicio);
        interaccion.selectEntered.AddListener(Congelado);
    }

    public void Seguimiento(BaseInteractionEventArgs hover)
    {
        if (hover.interactorObject is XRPokeInteractor)
        {
            XRPokeInteractor interactor = (XRPokeInteractor)hover.interactorObject;

            pokeAttachTransform = interactor.attachTransform;
            offset = botonvisual.position - pokeAttachTransform.position;

            float pokeAngle = Vector3.Angle(offset, botonvisual.TransformDirection(localAxis));

            if (pokeAngle > followAngleThreshold)
            {
                estasiguiendo = false;
                congelado = true;
            }
        }
    }

    public void Reinicio(BaseInteractionEventArgs hover)
    {
        if(hover.interactorObject is XRPokeInteractor)
        {
            estasiguiendo = false;
            congelado = false;
        }
    }

    public void Congelado(BaseInteractionEventArgs hover)
    {
        if (hover.interactorObject is XRPokeInteractor)
        {
            congelado = true;
        }
    }
    void Update()
    {
        if (congelado)
            return;
        if(estasiguiendo)
        {
            Vector3 posicionlocal = botonvisual.InverseTransformPoint(pokeAttachTransform.position + offset);
            Vector3 contstrainedPosicionLocal = Vector3.Project(posicionlocal, localAxis);


            botonvisual.position = botonvisual.TransformPoint(contstrainedPosicionLocal);
        }
        else
        {
            botonvisual.localPosition = Vector3.Lerp(botonvisual.localPosition, posicion_inicial, Time.deltaTime * reinicioVelocidad);
        }
    }


}
