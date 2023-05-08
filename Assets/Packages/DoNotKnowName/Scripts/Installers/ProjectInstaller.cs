using Packages.Scripts.Components.InputData;
using UnityEngine;
using Zenject;

namespace Packages.DoNotKnowName.Scripts.Installers
{
    [CreateAssetMenu(fileName = "ProjectInstaller", menuName = "Installers/ProjectInstaller")]
    public class ProjectInstaller : ScriptableObjectInstaller<ProjectInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<KeyboardAndMouseInputHardware>().AsSingle();
        }
    }
}