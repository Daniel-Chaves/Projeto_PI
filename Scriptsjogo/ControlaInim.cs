using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControlaInim : MonoBehaviour
{

    public Transform Player;
    private Animator anim;
    private NavMeshAgent motor;
    public bool cacando;
    public int distmin;
    public bool vivo;


    // Use this for initialization
    void Start()
    {

        anim = this.GetComponent<Animator>();
        motor = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, Player.position);



        if (cacando)
        {
            anim.SetBool("Andando", true);
            motor.SetDestination(Player.position);
            if (distancia < motor.stoppingDistance)
            {
                anim.SetBool("Andando", false);
                anim.SetBool("Atacando", true);
            }
            else
            {
                {
                    anim.SetBool("Andando", true);
                    anim.SetBool("Atacando", false);
                }
            }

        }
        else
        {
            anim.SetBool("Andando", false);
            motor.ResetPath();

        }
        if (distancia < distmin)
        {
            cacando = true;
        }
        else
        {
            cacando = false;
        }
    }

}
