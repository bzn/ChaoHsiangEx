using UnityEngine;

public class Scroller : MonoBehaviour
{

    public float rollSpeed {
            get { return speed; }
            set { speed = value; }
        }
    private float count = 3;
    [SerializeField, Range(0, 200)] private float speed = 10;
    private float wrapPoint = 400;
    private float position;

    void Start()
    {
        position = Vector3.Dot(this.transform.parent.transform.position, this.transform.parent.transform.forward);
    }

    void Update()
    {
        position += Time.deltaTime * speed;

        if (position > wrapPoint) position -= wrapPoint * count;

        this.transform.parent.transform.position = this.transform.parent.transform.forward * position;
    }
}
