using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public List<GameObject> prefabs; // El objecto que será instanceado.
    public float tiempoEntreInstancias = 3f; // Tiempo entre cada instancia.
    public float radiospawn = 5f; // Radio alrededor del spawner donde se instanciarán los objetos.

    [Header("DEBUG")]
    public Vector3 SpawnerPosition;
    public Color color;

    // Start is called before the first frame update
    private void Start()
    {
        //inicia un ciclo que instancea objetos repetidamente.
        InvokeRepeating("instanciarObjetoAleatorio", 0f, tiempoEntreInstancias);
    }


    private void instanciarObjetoAleatorio()
    {
        // Genera una posición aleatoria dentro del radio especificado.
        Vector3 posicionAleatoria = Random.insideUnitCircle * radiospawn;

        // instancia el objeto en la poición generada.
        GameObject RandomObj = prefabs[Random.Range(0,prefabs.Count)];
        GameObject nuevoObjeto = Instantiate(RandomObj, SpawnerPosition + posicionAleatoria, Quaternion.identity);

        // Asigna un color aleatorio al material del sprite.
        SpriteRenderer spriteRenderer = nuevoObjeto.GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }

        nuevoObjeto.transform.parent = transform;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(SpawnerPosition, radiospawn);
    }
}
