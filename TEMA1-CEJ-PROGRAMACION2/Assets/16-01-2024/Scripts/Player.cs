using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isDead = true;
    protected float health;

    public bool getIsdead()
    {
        return isDead;
    }

    protected float getHealth()
    {
        return health;
    }
}

public class Heroe : Player
{

    private int HeroeAgil;
    //private float HeroeFuerte;

    public void setHeroeAgil(int damage)
    {
         HeroeAgil= damage;
    }

    public int obtenerHeroeAgil()
    {
        if (isDead && health != 0.0f) 
        {
            return 0;
        }
        return HeroeAgil;
    }
}

public class EnemigoBase : Player
{
    protected int hechicero;
    
    protected int explorador;
    protected float arquero;
    protected float caballero;

    public void sethechicero(int damage)
    {
        hechicero = damage;
    }
    public int getHechicero()
    {
        return hechicero;
    }
}


public class ClaseAjena : MonoBehaviour
{
    public Player player;
    public Heroe heroe;
    public EnemigoBase enemigo;

    void Start()
    {
       player = new Player();
       heroe = new Heroe();
       enemigo = new EnemigoBase();

        player.isDead = false;
        heroe.setHeroeAgil(10);
        enemigo.sethechicero(20);

        // ¿Él personaje está muerto?
        if (!player.getIsdead())
        {
            // Imprimimos los puntos de ataque.
            Debug.Log("Puntos de ataque del heroe" + heroe.obtenerHeroeAgil());

            // Si el enemigo no está muerto.
            if (!enemigo.getIsdead())
            {
                int combatR = (heroe.obtenerHeroeAgil() - enemigo.getHechicero());
                Debug.Log("Resultados del combate" + combatR);
            }
        }
    }
}