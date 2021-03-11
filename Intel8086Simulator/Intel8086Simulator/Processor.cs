using System;
using System.Collections.Generic;
using System.Text;

namespace Intel8086Simulator
{
    class Processor
    {
        private State AX;
        private State BX;
        private State CX;
        private State DX;

        public void Move(State p, State q)
        {
            p.setHigherByte(q.getHigherByte());
            p.setLowerByte(q.getLowerByte());
        }
        public void Move(State p, bool ph, State q, bool qh)
        {
            if (ph && qh)
            {
                p.setHigherByte(q.getHigherByte());
            }
            if (ph && !qh)
            {
                p.setHigherByte(q.getLowerByte());
            }
            if (!ph && qh)
            {
                p.setLowerByte(q.getHigherByte());
            }
            if (!ph && !qh)
            {
                p.setLowerByte(q.getLowerByte());
            }
        }

        public void XChange(State p, State q)
        {
            State tmp = new State();
            tmp = p;
            p = q;
            q = tmp;

        }
        public void XChange(State p, bool ph, State q, bool qh)
        {
            int tmp;
            if (ph && qh)
            {
                tmp = p.getHigherByte();
                p.setHigherByte(q.getHigherByte());
                q.setHigherByte(tmp);
            }
            if (ph && !qh)
            {
                tmp = p.getHigherByte();
                p.setHigherByte(q.getLowerByte());
                q.setLowerByte(tmp);
            }
            if (!ph && qh)
            {
                tmp = p.getLowerByte();
                p.setLowerByte(q.getHigherByte());
                q.setHigherByte(tmp);
            }
            if (!ph && !qh)
            {
                tmp = p.getLowerByte();
                p.setLowerByte(q.getLowerByte());
                q.setLowerByte(tmp);
            }
        }

        public Processor()
        {
            this.AX = new State();
            this.BX = new State();
            this.CX = new State();
            this.DX = new State();
        }
        public Processor(int ah, int al, int bh, int bl, int ch, int cl, int dh, int dl)
        {
            this.AX = new State(ah, al);
            this.BX = new State(bh, bl);
            this.CX = new State(ch, cl);
            this.DX = new State(dh, dl);
        }
    }
}
