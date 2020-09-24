using System;

namespace F4calc
{
	public static class Series
	{
		public static double F4Series(
			int a, int b, int c1, int c2,
			double z1, double z2, int m, int n)
		{
			if(m < 0 || n < 0) return 1d;
			double sum = 0d, p1 = 1d, p2;
			for(int i = 0; i <= m; ) {
				p2 = p1;
				for(int j = 0; j <= n; ) {
					sum += p2;
					p2 *= z2 * (a + i + j) * (b + i + j) / ((c1 + j) * ++j);
				}
				p1 *= z1 * (a + i) * (b + i) / ((c1 + i) * ++i);
			}
			return sum;
		}
		public static double F4Series(
			int a, int b, int c1, int c2,
			double z1, double z2, double eps, out int n)
		{
			const int nLimit = 1 << (16 >> 1);
			n = -1;
			double r0, r1 = 0d;
			do {
				r0 = r1;
				r1 = F4Series(a, b, c1, c2, z1, z2, ++n, n);
			} while(Math.Abs(r0 - r1) > eps && n <= nLimit);
			if(n > nLimit || double.IsNaN(r1)) n = -1;
			return r1;
		}
	}
}
