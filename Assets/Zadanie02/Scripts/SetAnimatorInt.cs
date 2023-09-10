using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SetAnimatorInt : MonoBehaviour
{
    public string intName; // nazwa wysyłanego inta
    public int intValue;
    private Animator animator; // referencja do animatora obiektu

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // pobieranie referencji do animatora
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger(intName, intValue); // wysyłanie wartości int do animatora pod podaną nazwą
    }
}

