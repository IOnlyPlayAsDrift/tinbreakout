using UnityEngine;
//using UnityEngine.XR;

public class Ball : MonoBehaviour
{
    [SerializeField] paddle paddle1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
    [SerializeField] float randomFactor = 0.2f;
    [SerializeField] AudioClip ballExplodeSound;
    [SerializeField] GameObject ballExplode;

    Vector2 paddleToBallVector;
    bool hasStarted = false;

    Rigidbody2D myRigidBody2D;
    private Vector3 rend;
    public float maxSpeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        myRigidBody2D = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        if (myRigidBody2D.velocity.magnitude > maxSpeed)
        {
            myRigidBody2D.velocity = myRigidBody2D.velocity.normalized * maxSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            //LaunchOnMouseClick();
        }

        FixedUpdate();
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }

    public void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            myRigidBody2D.velocity = new Vector2(xPush, yPush);
        }
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Vector2 velocityTweak = new Vector2(Random.Range(0f, randomFactor), Random.Range(0f, randomFactor));

        if (hasStarted)
        {
            GetComponent<AudioSource>().Play();
            myRigidBody2D.velocity += velocityTweak;
            Vector2 v = myRigidBody2D.velocity;
            v = v.normalized;
            v *= maxSpeed;
            myRigidBody2D.velocity = v;

            /*var dot = Vector2.Dot(myRigidBody2D.velocity.normalized, Vector2.up);
            if (dot > 0.98 || dot < -0.98)
            {
                var vv= Random.insideUnitCircle * 1.5f;
                myRigidBody2D.velocity += vv;
            }*/

            if (collision.gameObject.CompareTag("Paddle"))
            {
                float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);

                Vector2 dir = new Vector2(x, 1).normalized;

                myRigidBody2D.velocity = dir * 10f;
            }
        }
    }

    public void DestroyBall()
    {
        AudioSource.PlayClipAtPoint(ballExplodeSound, Camera.main.transform.position, 0.5f);
        Destroy(gameObject);
        TriggerSparklesVFX();
    }

    private void TriggerSparklesVFX()
    {
        GameObject sparkles = Instantiate(ballExplode, transform.position, transform.rotation);
        Destroy(sparkles, 1f);
    }

    public void AdjustSpeed(float newspeed)
    {
        maxSpeed = newspeed;
    }
}
