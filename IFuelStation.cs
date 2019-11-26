using System.Collections.Generic;

namespace GenericsExercises
{

    public class IFuelStation<T>
    {
        int capacity { get; set; } = 5;

        public virtual void Refuel(List<T> vehicles)
        {

        }
    }
}