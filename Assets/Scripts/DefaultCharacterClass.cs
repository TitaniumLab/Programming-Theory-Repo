using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.WSA;

public class DefaultCharacterClass : MainCharacterClass //INHERITANCE
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }


    protected override void Attack() // POLYMORPHISM
    {
        StartCoroutine(WeaponSwing());
    }

    private IEnumerator WeaponSwing() // ABSTRACTION
    {
        player.isAttacking = true;
        weapon.SetActive(true);
        Quaternion startRotation = weapon.transform.rotation;
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseToWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, Camera.main.transform.position.y));
        mouseToWorld.y = transform.position.y;
        weapon.transform.LookAt(mouseToWorld);
        for (int i = 0; i < 20; i++)
        {
            weapon.transform.Rotate(Vector3.right, 5);
            Quaternion keepDirection = weapon.transform.rotation;
            yield return new WaitForSeconds(0.02f);
            weapon.transform.rotation = keepDirection;
        }
        weapon.transform.rotation = startRotation;
        weapon.SetActive(false);
        player.isAttacking = false;
    }

}
