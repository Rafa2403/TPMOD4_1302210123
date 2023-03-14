using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4_1302210123
{
    internal class Program
    {
        public class Kodebuah
        {
            public enum namaBuah { 
                Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung  
            }
            public static string getKodeBuah(namaBuah kode)
            {
                string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
                return kodeBuah[(int)kode];
            }
        }
        public enum State { JONGKOK, BERDIRI, TENGKURAP, TERBANG };
        public enum Trigger { TombolS, TombolW, TombolX };

        class transition
        {
            public State prevState;
            public State nextState;
            public Trigger trigger;
            public transition(State prevState, State nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }
        transition[] transitions =
        {
        new transition(State.JONGKOK, State.TENGKURAP, Trigger.TombolS),
        new transition(State.TENGKURAP, State.JONGKOK, Trigger.TombolW),
        new transition(State.BERDIRI, State.JONGKOK, Trigger.TombolS),
        new transition(State.JONGKOK, State.BERDIRI, Trigger.TombolW),
        new transition(State.BERDIRI, State.TERBANG, Trigger.TombolW),
        new transition(State.TERBANG, State.BERDIRI, Trigger.TombolS),
        new transition(State.TERBANG, State.JONGKOK, Trigger.TombolX)
        };

        public State currentState;

        public State getNextState(State prevState, Trigger trigger)
        {
            State nextState = prevState;
            for (int i = 0; i < transitions.Length; i++)
            {
                if (transitions[i].prevState == prevState && transitions[i].trigger == trigger)
                    nextState = transitions[i].nextState;
            }
            return nextState;
        }

        static void Main(string[] args)
        {

        }
    }
}
