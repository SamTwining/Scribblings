<Query Kind="Program" />

void Main()
{
	Console.WriteLine(rotLeft(test, 10));
}

static int[] test = new int[] {
41,73,89,7,10,1,59,58,84,77,77,97,58,1,86,58,26,10,86,51
};

static int[] rotLeft(int[] a, int d) {
	IEnumerable<int> successor = a.Take(d);
	IEnumerable<int> predecessor = a.Skip(d);
	
	return predecessor.Concat(successor).ToArray();
}
