using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ClassLibrary")]
public class Piece : MonoBehaviour {

    private Transform baseTfm;
    private Vector3 m_pos;

    [SerializeField]
    private bool active;
    public bool Active
    {
        get { return active; }
        set { active = value; }
    }

    // Use this for initialization
    private void Start () {
        active = false;
        baseTfm = GetComponent<Transform>();
        m_pos = baseTfm.position;

    }

    // Update is called once per frame
    private void Update () {
        float h = Input.GetAxis("Horizontal");
        float w = Input.GetAxis("Vertical");
        m_pos.x += h * 0.1f;
        m_pos.y += w * 0.1f;
        baseTfm.position = m_pos;
    }

    public int TestMan(int val)
    {
        return val * 2;
    }
}
