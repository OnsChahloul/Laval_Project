using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    #region members
    public Text NbScore;
    protected int nb;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        nb = 7;
    }

    // Update is called once per frame
    void Update()
    {
        NbScore.text = nb.ToString();
    }
}
