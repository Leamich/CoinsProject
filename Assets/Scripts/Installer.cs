using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<CoinsModel>().To<CoinsModel>().FromInstance(new CoinsModel(PlayerPrefs.GetInt("Coins", 0)));
    }
}
