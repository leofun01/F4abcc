using System;

namespace F4calc
{
	public static class Fraction
	{
		public static int GCD(int a, int b)
		{
			while(a != 0 && b != 0)
				if(a > b) a %= b;
				else b %= a;
			return a | b;
		}
		public static double F4Frac_a_c1(
			int a, int b, int c1, int c2,
			double z1, double z2, int depth)
		{
			if(depth <= 0) return 1d;
			return 1d
				- z1 * (c1 - a) * b / ((c1 - 1) * c1)
					/ F4Frac_a_c1(b + 1, a, c1 + 1, c2, z1, z2, depth - 1)
				- z2 * b / c2
					/ F4Frac_a_c1(b + 1, a, c2 + 1, c1, z2, z1, depth - 1);
		}
		public static double F4Frac_a_c1(
			int a, int b, int c1, int c2,
			double z1, double z2, double eps,
			int depthLimit, out int depth)
		{
			depth = -1;
			double r0, r1 = 0d;
			do {
				r0 = r1;
				r1 = F4Frac_a_c1(a, b, c1, c2, z1, z2, ++depth);
			} while(Math.Abs(1d / r0 - 1d / r1) > eps && depth <= depthLimit);
			if(depth > depthLimit || double.IsNaN(r1)) depth = -1;
			return r1;
		}
		public static void F4Frac_a_c1_tree(
			int a, int b, int c1, int c2,
			string z1, string z2, int depth, Node parent)
		{
			Console.WriteLine("{0,4} :  {1} / {2} * {3}", depth,
				parent.CoefNumerator, parent.CoefDenominator, parent.VarName);
			if(depth <= 0) return;
			int compare = string.Compare(z1, z2);
			if(compare == 0) throw new Exception();
			else if(compare < 0) {
				if(b != 0 && c1 != a) {
					parent.Left = new Node(-b * (c1 - a), ((c1 - 1) * c1), z1);
					F4Frac_a_c1_tree(b + 1, a, c1 + 1, c2, z1, z2, depth - 1, parent.Left);
				}
				if(b != 0) {
					parent.Right = new Node(-b, c2, z2);
					F4Frac_a_c1_tree(b + 1, a, c2 + 1, c1, z2, z1, depth - 1, parent.Right);
				}
			}
			else {
				if(b != 0) {
					parent.Right = new Node(-b, c2, z2);
					F4Frac_a_c1_tree(b + 1, a, c2 + 1, c1, z2, z1, depth - 1, parent.Right);
				}
				if(b != 0 && c1 != a) {
					parent.Left = new Node(-b * (c1 - a), ((c1 - 1) * c1), z1);
					F4Frac_a_c1_tree(b + 1, a, c1 + 1, c2, z1, z2, depth - 1, parent.Left);
				}
			}
		}
		public class Node
		{
			public int CoefNumerator { get; set; }
			public int CoefDenominator { get; set; }
			public string VarName { get; set; }
			public Node Left { get; set; }
			public Node Right { get; set; }

			public Node(int num, int den, string var)
			{
				int gcd = GCD(
					num < 0 ? -num : num,
					den < 0 ? -den : den);
				CoefNumerator = num / gcd;
				CoefDenominator = den / gcd;
				VarName = var;
			}
			public Node(int num, int den, string var, Node left, Node right) : this(num, den, var)
			{
				Left = left;
				Right = right;
			}
		}
	}
}
