using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_Control
{


    public interface IEvents
    {
        void LoadEvents();

    }
    class College
    {
        public IEvents _Events;

        //public College(IEvents Events)
        //{
        //    _Events = Events;

        //}

        public IEvents MyEvents
        {
            set { _Events = value; }
            get { return _Events; }

        }

        public void GetEvents(IEvents e)
        {
            e.LoadEvents();
        }


        static void Main(string[] args)
        {
            //College obj = new College(new SportsEvents());//Constructor Di
            College obj = new College();
            obj.MyEvents = new SportsEvents();//Property Di
            obj.MyEvents.LoadEvents();
            obj.GetEvents(new TechEvents());//Method DI
            Console.ReadLine();
        }
    }

    public class TechEvents : IEvents
    {
        public void LoadEvents()
        {
            Console.WriteLine("Tech Events Started");
        }
    }

    public class SportsEvents : IEvents
    {

        public void LoadEvents()
        {
            Console.WriteLine("Sports Events Started");
        }

    }
}
