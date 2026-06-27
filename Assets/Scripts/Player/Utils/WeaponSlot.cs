using UnityEngine;

public class WeaponSlot : MonoBehaviour
{
    [SerializeField] private Weapon startingWeaponPrefab;

    public Weapon currentWeapon;

    private void Start()
    {
        Equip(startingWeaponPrefab);
    }

    public void Equip(Weapon weaponPrefab)
    {
        if (currentWeapon != null)
            Destroy(currentWeapon.gameObject);

        currentWeapon = Instantiate(weaponPrefab, transform);

        currentWeapon.transform.localPosition = Vector3.zero;
    }
}