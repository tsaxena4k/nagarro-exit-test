// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
using namespace std;

int main() {
	// your code goes here
	int count1 = 0, count2 = 0;
	int arr[4][4];
	int n;
	//cin>>n;
	//cut start
	for (int i = 0; i<4; i++)
		for (int j = 0; j<4; j++)
			arr[i][j] = rand() % 2;
	for (int i = 0; i<4; i++)
	{
		for (int j = 0; j<4; j++)
			cout << arr[i][j] << ' ';
		cout << endl;
	}
	//cut end
	for (int i = 0; i<4; i++)
		for (int j = 0; j<4; j++)
			if (arr[i][j] == 0)
			{
				int flag = 1;
				cout << endl << i << ' ' << j;
				if (i - 1 < 0 || i + 1 > 3 || j - 1< 0 || j + 1 > 3)
					continue; // skip in case invalid position
				if (arr[i][j + 1] == 0 && arr[i][j - 1] == 0 && arr[i + 1][j] == 0 && arr[i - 1][j] == 0)
				{
					count1 += 1;
					cout << endl << i << "..." << j;
				}
				if (arr[i - 1][j + 1] == 0 && arr[i - 1][j - 1] == 0 && arr[i + 1][j - 1] == 0 && arr[i + 1][j + 1] == 0)
					count2 += 1;


			}
	cout << endl << count1 << ' ' << count2;

	return 0;
}
