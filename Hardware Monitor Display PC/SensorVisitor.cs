using OpenHardwareMonitor.Hardware;

namespace Hardware_Monitor_Display_PC
{
    public class SensorVisitor : IVisitor
    {
        private readonly SensorEventHandler _handler;
       // private readonly HardwareEventHandler _handler_h;

        public SensorVisitor(SensorEventHandler handler) // HardwareEventHandler handler2)
        {
            _handler = handler;
          //  _handler_h = handler2;
        }




        public void VisitComputer(IComputer computer)
        {
            computer.Traverse(this);
        }

        public void VisitHardware(IHardware hardware)
        {
            hardware.Traverse(this);
            //  _handler_h(hardware);
            //hardware.Update();
            //foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
        }

        public void VisitParameter(IParameter parameter)
        {
        }

        public void VisitSensor(ISensor sensor)
        {
            _handler(sensor);
        }
    }
}
