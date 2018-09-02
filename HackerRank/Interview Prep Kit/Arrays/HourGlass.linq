<Query Kind="Program" />

// https://www.hackerrank.com/challenges/2d-array/problem

int[][] map = 
new int[][]
{ 
	new int[] { 1, 1, 1, 0, 0, 0 },
	new int[] { 0, 1, 0, 0, 0, 0 },
	new int[] { 1, 1, 1, 0, 0, 0 },
	new int[] { 0, 0, 2, 4, 4, 0 },
	new int[] { 0, 0, 0, 2, 0, 0 },
	new int[] { 0, 0, 1, 2, 4, 0 }
};
int[][] wrongmap = 
new int[][]
{ 
	new int[] { -1, -1, 0, -9, -2, -2 },
	new int[] { -2, -1, -6, -8, -2, -5 },
	new int[] { -1, -1, -1, -2, -3, -4 },
	new int[] { -1, -9, -2, -4, -4, -5 },
	new int[] { -7, -3, -3, -2, -9, -9 },
	new int[] { -1, -3, -1, -2, -4, -5 }
};


void Main()
{
	int largestSum = Int32.MinValue;
	for(int i = 0; i < wrongmap.Length-2; i++) 
	{
		for(int j = 0; j < wrongmap[i].Length-2; j++) 
		{ 
			int hourGlassValue = findHourglassSum(wrongmap, i, j) ;
			if(hourGlassValue > largestSum)
				largestSum = hourGlassValue;			
		}
	}
	
	Console.Write(largestSum);
}

int findHourglassSum(int[][] map, int ypos, int xpos) 
{
	int hourSum = 0;
	for(int i = 0; i < 9; i++) 
	{
		if(i == 3 || i == 5) continue;
		hourSum += map[(ypos + (i / 3))][(xpos + (i % 3))];
	}
	return hourSum;
}