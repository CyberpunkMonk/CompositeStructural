using System;
using System.Collections.Generic;

namespace CompositeStructural {
	/// <summary>
	/// The 'Composite' class
	/// </summary>
	/// <seealso cref="CompositeStructural.Component" />
	class Composite:Component{
		private List<Component> _children = new List<Component>();
		//C'tor
		public Composite(string name) : base(name) { }
		public override void Add(Component c) {
			_children.Add(c);
		}
		public override void Remove(Component c) {
			_children.Remove(c);
		}
		public override void Display(int depth) {
			Console.WriteLine(new String('-',depth)+name);
			//Recursively display child nodes
			foreach (Component c in _children) c.Display(depth + 2);
		}
	}
}
