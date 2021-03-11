using System;
using System.Collections.Generic;
using System.Text;

namespace Intel8086Simulator
{
    class State
    {
        private int higherByte;
        private int lowerByte;

        public int getHigherByte()
        {
            return higherByte;
        }
        public int getLowerByte()
        {
            return lowerByte;
        }
        public void setHigherByte(int pbyte)
        {
            higherByte = pbyte;
        }
        public void setLowerByte(int pbyte)
        {
            lowerByte = pbyte;
        }

        public State(int h, int l)
        {
            if (h < 0 || h > 255)
                this.higherByte = 0;
            else
                this.higherByte = h;
            if (l < 0 || l > 255)
                this.lowerByte = 0;
            else
                this.lowerByte = l;
        }
        public State()
        {
            this.higherByte = 0;
            this.lowerByte = 0;
        }
    }
}
