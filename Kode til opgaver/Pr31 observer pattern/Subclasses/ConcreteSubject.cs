using Pr31_observer_pattern.Superclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr31_observer_pattern.Subclasses
{
    public class ConcreteSubject : Subject
    {
		private int state = 0;

		public int State
		{
			get { return state; }
			set 
			{ 
				state = value;
				Notify();
			}
		}

	}
}
