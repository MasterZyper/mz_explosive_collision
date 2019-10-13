using CitizenFX.Core;
using System.Threading.Tasks;

namespace mz_explosive_collison
{
    public class Main : BaseScript
    {
        public Main() 
        {
            Tick += CheckVehHasCollided;  
        }
        private async Task CheckVehHasCollided() 
        {
            foreach (Vehicle veh in World.GetAllVehicles()) 
            {
                if (veh.IsDamaged && !veh.IsExplosionProof && veh.IsAlive) 
                {
                    World.AddExplosion(veh.Position, ExplosionType.Plane, 100, 0.1f);
                }      
            }
            await Delay(42);
        }
    }
}
