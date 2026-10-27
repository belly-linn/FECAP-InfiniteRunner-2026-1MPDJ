using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // SerializeField: permite manipular o valor da variável de campos privados diretamente na Unity
    // O valor da Unity sobrescreve o valor do código
    [SerializeField] private float moveSpeed = 5;
    private float moveX;
    private float moveY;

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        moveY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        print($"Input X: {moveX}, Input Y: {moveY}");

        transform.Translate(moveX, moveY, 0);
    }
}
