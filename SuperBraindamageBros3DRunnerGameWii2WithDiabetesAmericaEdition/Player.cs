namespace SuperBraindamageBros3DRunnerGameWii2WithDiabetesAmericaEdition;

public class Player : Characters
{
    public Weapon currentWeapon = new();
    public Inventory inventory = new();
    //how many percent damage weapons do
    public float damage;
    public Ability ability = new();
}
