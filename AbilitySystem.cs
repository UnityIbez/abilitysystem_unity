using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilitySystem : MonoBehaviour
{
    //DRAG THIS SCRIPT INTO YOUR CANVAS OBJECT!
    [Header("Ability1")]
    public Image abilityImage1;
    public float cooldown1 = 3f;
    bool isCooldown = false;

    [Header("Ability2")]
    public Image abilityImage2;
    public float cooldown2 = 5f;
    bool isCooldown2 = false;

    [Header("Ability3")]
    public Image abilityImage3;
    public float cooldown3 = 10f;
    bool isCooldown3 = false;

    void Start()
    {
        abilityImage1.fillAmount = 1;
        abilityImage2.fillAmount = 1;
        abilityImage3.fillAmount = 1;
    }

    void Update()
    {
        //Ability1
        if(isCooldown == true)
        {
            abilityImage1.fillAmount += 1 / cooldown1 * Time.deltaTime;
        }

        if(abilityImage1.fillAmount == 1)
        {
            isCooldown = false;
        }

        //Ability2
        if (isCooldown2 == true)
        {
            abilityImage2.fillAmount += 1 / cooldown2 * Time.deltaTime;
        }

        if (abilityImage2.fillAmount == 1)
        {
            isCooldown2 = false;
        }

        //Ability3
        if (isCooldown3 == true)
        {
            abilityImage3.fillAmount += 1 / cooldown3 * Time.deltaTime;
        }

        if (abilityImage3.fillAmount == 1)
        {
            isCooldown3 = false;
        }
    }

    public void Ability1()
    {
        if(isCooldown == true)
        {
            Debug.Log("Cooldown!")
        }
        else
        {
            Debug.Log("Ability 1 USED!")    //You can replace this with any ability you want :)
            isCooldown = true;
            abilityImage1.fillAmount = 0;
        }
    }

    public void Ability2()
    {
        if (isCooldown2 == true)
        {
            Debug.Log("Cooldown!")
        }
        else
        {
            Debug.Log("Ability 2 USED!")    //You can replace this with any ability you want :)
            isCooldown2 = true;
            abilityImage2.fillAmount = 0;
        }
    }

    public void Ability3()
    {
        if (isCooldown3 == true)
        {
            Debug.Log("Cooldown!")
        }
        else
        {
            Debug.Log("Ability 3 USED!")    //You can replace this with any ability you want :)
            isCooldown3 = true;
            abilityImage3.fillAmount = 0;
        }
    }
}
