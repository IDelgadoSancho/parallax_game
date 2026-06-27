using UnityEngine;

public class BasicWeapon : Weapon
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireRate = 0.2f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
    }

    public override void Shoot()
    {
        if (timer < fireRate)
            return;

        timer = 0f;

        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}