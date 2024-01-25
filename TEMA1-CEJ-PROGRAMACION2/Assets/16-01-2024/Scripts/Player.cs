using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Clase jugador base donde se crean variables publicas y protegidas.

    public bool isDead = true;
    protected float health;

    // Se crea una función que obtiene la variable Deeada para devolverla con otro nombre.
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
    // En está clase se crean variables privadas.
    private int HeroeAgil;
    //private float HeroeFuerte;

    // Se crea una función que coloca la variable para acceder a ella.

    public void setHeroeAgil(int damage)
    {
         HeroeAgil= damage;
    }

    // Esta funcion obtendra la información y la devolvera a la variable.
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
    //Está clase contiene variables protegidas.
    protected int hechicero;
    
    protected int explorador;
    protected float arquero;
    protected float caballero;

    //La funcion se usa para colocar nuevamente la variable yt acceder a ella.

    public void sethechicero(int damage)
    {
        hechicero = damage;
    }

    //Se obtiene la información para regresarla a la variable.
    public int getHechicero()
    {
        return hechicero;
    }
}


public class ClaseAjena : MonoBehaviour
{
    // Esta clase se crean variables que acceden al nombre de la clase y su contenido.
    public Player player;
    public Heroe heroe;
    public EnemigoBase enemigo;

    // La funcion se crea para usar las variables creadas y definirlas.
    void Start()
    {
       player = new Player();
       heroe = new Heroe();
       enemigo = new EnemigoBase();

        // Se accede a las variables de las otras clases a traves del nombre que les dimos.
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