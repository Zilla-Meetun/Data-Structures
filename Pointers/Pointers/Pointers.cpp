// Pointers.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <algorithm>
#include <string>

using namespace std;


char *s ;
char cha1 = 'a';
char cha2 = 'b';

int  replace(char *str, char c1, char c2) {
	int change = 0;
	while (*str != '\0') {

	}
	return ;
}

int main(char* argv[], int argc)
{
	cout << "input a string \n";
	cin >> s;
	cout << "input a char you want to replace \n";
	cin >> cha1;
	cout << "input a char you want to replace it with \n";
	cin >> cha2;
	s = replace(s, cha1, cha2);

	cout << s;

}
// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
