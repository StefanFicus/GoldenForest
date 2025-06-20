using UnityEngine;

public class PrasleaMovementSOMEHOW : MonoBehaviour
{
    private Rigidbody2D body;
    private Vector2 movement;
    public float speed=3.5f;
    private Animator animating;
    void Awake()
    { body=GetComponent<Rigidbody2D>();
    animating=GetComponent<Animator>(); }
    void Update()
    { movement= Vector2.zero;
        if(Input.GetKey(KeyCode.W))
        movement.y=1;
      else if(Input.GetKey(KeyCode.S))
       movement.y=-1;
    if(Input.GetKey(KeyCode.D))
        movement.x=1;
      else if(Input.GetKey(KeyCode.A))
       movement.x=-1;
if(movement.x!=0 || movement.y!=0)
{animating.SetFloat("X",movement.x);
    animating.SetFloat("Y", movement.y);

       }
    }
    void FixedUpdate()
    { body.MovePosition(body.position+speed*movement*Time.fixedDeltaTime);



    }}