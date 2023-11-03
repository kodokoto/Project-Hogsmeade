using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.UIElements;
// import IAutoMove interface from Assets/Scripts/Systems/IAutoMove.cs
public class MovingPlatform : Platform, IAutoMove
{
    [SerializeField] public AutoMoveType AutoMoveType { get; set; }
    public Vector3[] Path { get; set;}
    public int TargetPointIndex { get; set; }
    public bool IsMoving { get; set; }
    public Color color;
    public float Speed { get; set; }
    
    void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, Path[TargetPointIndex], Time.deltaTime * Speed);
    }

    void Awake()
    {
        Debug.Log("Awake");
        gameObject.layer = LayerMask.NameToLayer("Ground");
        Path = new Vector3[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            Path[i] = transform.GetChild(i).position;
        }
        ((IAutoMove)this).CheckPath();
        transform.position = Path[0];

    }

    void Start()
    {
        AutoMoveType = AutoMoveType.Loop;
        Speed = 5f;
        ((IAutoMove)this).AdvanceTarget();
        IsMoving = true;
    }

    void FixedUpdate()
    {
        if (IsMoving)
        {
            if (transform.position == ((IAutoMove)this).GetCurrentPoint())
            {
                ((IAutoMove)this).AdvanceTarget();
            }
            else
            {
                MoveToTarget();
            }
        }
    }

    void OnDrawGizmos()
    {
        ((IAutoMove)this).DrawGizmos(color);
    }
}
