using Arcaedion.DevDasGalaxias;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controle2D))]
public class Movimento2DJogador : MonoBehaviour {

    [SerializeField]
    private float _velocidade = 30f;

    private Controle2D _controle;
    private float _movimentoHorizontal;
    private bool _pulando;

    private void Awake()
    {
        _controle = GetComponent<Controle2D>();
    }

    void Update () {
        _movimentoHorizontal = Input.GetAxisRaw("Horizontal") * _velocidade;
        if (Input.GetButtonDown("Jump"))
            _pulando = true;
	}

    void FixedUpdate()
    {
        _controle.Movimento(_movimentoHorizontal * Time.fixedDeltaTime, _pulando);
        _pulando = false;
    }
}
