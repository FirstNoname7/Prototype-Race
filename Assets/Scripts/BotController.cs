using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
    Rigidbody rigidBody; //вызываем компонент жёсткого тела через переменную rigidBody
    private float speed = 20.0f; //скорость движения бота вперёд
    public float timer = 10.0f; //таймер. Нужен для удаления ботов, которые прошли уже мимо игрока, чтоб не уменьшать производительность игры

    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>(); //говорит, что в этом скрипте будет использоваться игровой объект с жёстким телом, то есть с Rigidbody
    }

    // В Update машина будет перемещаться вперёд
    void Update()
    {
        timer -= Time.deltaTime; //таймер предполагает уменьшение времени на равные промежутки
        if (timer < 0) //если таймер закончился, тогда:
        {
            Destroy(gameObject); //игровой объект (бот) удаляется
        }

        rigidBody.velocity = new Vector3(0,0,-1) * speed; //тут устанавливается движение вперёд.
                                                      //rigidBody. - использование жёсткого тела. velocity - говорим, что объект должен двигаться.
                                                      //Vector3.forward - то, что передвигает объект по оси Z (можешь посмотреть, она синей стрелкой выделена в сцене)
                                                      //speed - скорость. Чем больше число, тем больше скорость

    }
}
