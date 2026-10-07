using UnityEngine;

public class person : MonoBehaviour
{
    public float speed = 2.0f;
    public Transform flag;

    private Vector3[] points;
    private int currentPoint = 0;

    void Start()
    {
        Vector3 start = transform.position;

        points = new Vector3[]
        {
            start + new Vector3(3, 0, 0),   // 往前
            start + new Vector3(5, 2, 0),   // 上跳
            start + new Vector3(7, 0, 0),  // 下跳
            flag.position                   // 最後到旗桿
        };
    }

    void Update()
    {
        if (currentPoint < points.Length)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                points[currentPoint],
                speed * Time.deltaTime
            );

            if (Vector3.Distance(transform.position, points[currentPoint]) < 0.01f)
            {
                currentPoint++;
            }
        }
    }
}