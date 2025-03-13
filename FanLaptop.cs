using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table_driven_and_state_based
{
    public enum Trigger
    {
        MODE_UP, MODE_DOWN, TURBO_SHORCUT
    }
    internal class FanLaptop
    {
        public enum Mode
        {
            QUITE, BALANCE, PERFORMANCE, TURBO
        }

        private Mode state;
        public FanLaptop()
        {
           state = Mode. QUITE;
           Console.WriteLine("Fan In Quite Mode");
        }

        public void setBalanceMode(Mode mode)
        {
            state = mode;
            if (state == Mode.BALANCE)
            {
                Console.WriteLine("Fan turn into balance Mode");
            }
            else if (state == Mode.TURBO)
            {
                Console.WriteLine("Fan turn into Turbo Mode");
            }
            else if (state == Mode.QUITE)
            {
                Console.WriteLine("Fan Stay in Quite Mode");
            }
        }

        public void setPerformanceMode(Mode mode)
        {
            state = mode;
            if (state == Mode.PERFORMANCE)
            {
                Console.WriteLine("Fan turn into Performance Mode");
            }
            else if (state == Mode.TURBO)
            {
                Console.WriteLine("Fan turn into Turbo Mode");
            }
            else if (state == Mode.BALANCE)
            {
                Console.WriteLine("Fan Stay in Balance Mode");
            }
        }

        public void setTurboMode(Mode mode)
        {
            state = mode;
            if (state == Mode.PERFORMANCE)
            {
                Console.WriteLine("Fan turn back into Performance Mode");
            }
            else if (state == Mode.QUITE)
            {
                Console.WriteLine("Fan turn back into Quite Mode");
            }
        }
    }
}
