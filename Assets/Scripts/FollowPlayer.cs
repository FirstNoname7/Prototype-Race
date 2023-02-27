using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //этот скрипт нужен для того, чтоб камера следовала за игроком (за машиной), когда она начнёт двигаться. Чтобы игрок видел то, что видит машина (только сверху)
    public GameObject player; //нужно, чтобы сюда в инспекторе запихнуть машину, за которую будет играть игрок
    private Vector3 offset; //положение камеры определяется переменной с именем offset. Без указания её игрок будет самим коллайдером (машиной).
    //а в строчке чуть ниже указано, что положение должно сместиться по вертикали (по оси Y) наверх (на 5) и назад (по оси Z) (на -15).
    private Vector3 offsetBack = new Vector3(0,5,-15); //первое положение камеры (когда мы сверху) 
    public Vector3 offsetOn = new Vector3(0, 2, 1); //второе положение камеры (когда мы на месте водителя)
    bool conditions = false; //условие для переключения камеры (тру - мы на месте водителя, фолс - мы сверху)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //вместо Update ставлю LateUpdate, чтобы машина не дрожала, едя по дороге (чтоб 2 жёстких тела rigidbody не тёрлись друг о друга и не создавали эту тупую дрожь, триггеря друг дружку)
    {
        if(Input.GetKeyDown(KeyCode.Q)) //если нажать на кнопку Q, тогда:
        {
            conditions =!conditions; //переменная изменит своё значение с true на false, с false на true
        }
        offset = conditions ? offsetOn : offsetBack; //переключашка камеры (смотрим либо как водитель, либо сверху на автомобиль)
        transform.position = player.transform.position + offset; //позиция объекта, к которому прикреплён этот скрипт = позиции игрока + смещаем камеру 
                                                                 //если используется offsetBack, то наверх (это переменная, указана перед стартом) (по вертикали (по оси Y) на 5 юнитов) и назад (по оси Z на 17 юнитов назад)
    }
}
