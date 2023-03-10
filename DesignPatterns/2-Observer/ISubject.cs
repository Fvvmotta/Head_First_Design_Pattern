using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2_Observer
{
    public interface ISubject
    {
       public void RegisterObserver(IObserver observer);
       public void RemoveObserver(IObserver observer);
       public void NotifyObserver();

    }

}
