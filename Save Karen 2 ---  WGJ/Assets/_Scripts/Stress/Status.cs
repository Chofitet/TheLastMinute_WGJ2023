using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Status2 : MonoBehaviour
{
    public Gatito gatito;
    
    public Stress estress;

    public float timer;
    
    [SerializeField] Image gatoEstresado;
    [SerializeField] Sprite [] gatoSprite;
    
    [SerializeField] int estressss;
    void Start()
    {
        estress.ChangeMaxValue(Gatito.MAX_Stress);
    }

    // Update is called once per frame
    void Update ()
    {
        if(Time.time > timer){
            timer =Time.time+1f;
            gatito.AddStress(1);

        }
        estress.UpdateInfo(gatito.estres);


        if (gatito.estres<13){
        gatoEstresado.sprite=gatoSprite[0];
        }else  if (gatito.estres<26){
        gatoEstresado.sprite=gatoSprite[1];
        }else  if (gatito.estres<39){
        gatoEstresado.sprite=gatoSprite[2];
        }else  if (gatito.estres<52){
        gatoEstresado.sprite=gatoSprite[3];
        }else  if (gatito.estres<64){
        gatoEstresado.sprite=gatoSprite[4];
        }else  if (gatito.estres<76){
        gatoEstresado.sprite=gatoSprite[5];
        }else if (gatito.estres<90){
        gatoEstresado.sprite=gatoSprite[6];
        }else
        {
            gatoEstresado.sprite = gatoSprite[7];
            
            if(gatito.estres <= 120)
            {
                Invoke("GameOver", 1);
            }
        }
        
        
    }

    void GameOver()
    {
        SceneManager.LoadScene("Perdida");
        
    }

}
