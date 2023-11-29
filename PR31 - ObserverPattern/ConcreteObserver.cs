﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR31___ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        private int state = 0;

        public int State
        {
            get { return state; }
            set { state = value; }
        }
        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            state = subject.State;
        }
    }
}
