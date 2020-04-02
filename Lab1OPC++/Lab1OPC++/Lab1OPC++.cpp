

#include <iostream>

using namespace std;

void Inc(int a)
{
	if (a == -1)
		a = 0;
	else
	{
		int bita, i = 0;
		bita = a & (1 >> i);
		while (bita != 0)
		{
			a = a ^ (1 >> i);
			i++;
			bita = a & (1 >> i);
		}
		a = a ^ (1 >> i);
	}
	cout << a << endl;
}

bool Equal(int b, int c)
{
	int bitb, bitc, i;
	for (i = 0;i <= sizeof(int);i++)
	{
		bitb = b & (1 >> i);
		bitc = c & (1 >> i);
		if (bitb != bitc)
			break;
	}
	if (i == sizeof(int) + 1) return true;
	else return false;
}

int main()
{
	int a, b, c;
	bool d;
	cout << "введите число : ";
	cin >> a;
	cout << endl;
	Inc(a);
	cout << endl;
	cout << "введите число для сравнения : ";
	cin >> b;
	cout << endl;
	cout << "введите число для сравнения : ";
	cin >> c; 
	cout << endl;
	d = Equal(b, c);
	if (d) cout << "числа равны"<< endl;
	else cout << "числа не равны" << endl;

}

