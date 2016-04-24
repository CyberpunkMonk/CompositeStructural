using System;


namespace CompositeStructural {
	/// <summary>
	/// The 'Leaf' class
	/// </summary>
	/// <seealso cref="CompositeStructural.Component" />
	class Leaf:Component{
		//C'tor
		public Leaf(string name) : base(name) { }
		public override void Add(Component c) {
			Console.WriteLine("Cannot add to a leaf!");	
		}
		public override void Remove(Component c) {
			Console.WriteLine("Cannot remove from a leaf!");
		}
		public override void Display(int depth) {
			Console.WriteLine(new String('-',depth)+name);
		}
	}
}
