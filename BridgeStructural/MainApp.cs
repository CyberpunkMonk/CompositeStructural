using System;

namespace CompositeStructural {
	/// <summary>
	/// Start up class
	/// </summary>
	class MainApp {
		static void Main() {
			//Create a tree structure
			Composite root = new Composite("Root");
			root.Add(new Leaf("Leaf A"));
			root.Add(new Leaf("Leaf B"));
			Composite comp = new Composite("Composite X");
			comp.Add(new Leaf("Leaf XA"));
			comp.Add(new Leaf("Leaf XB"));
			root.Add(comp);
			root.Add(new Leaf("Leaf C"));
			//Add and remove a leaf
			Leaf leaf = new Leaf("Leaf D");
			root.Add(leaf);
			root.Remove(leaf);
			//Recursively display tree
			root.Display(1);
			//Wiat for user
			Console.ReadKey();
		}
	}
}
