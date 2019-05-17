#include <future>
#include <iostream>
#include <stdio.h>
#include <thread>
#include <chrono>
#include <string>
#include <vector>

using namespace std;

void AsyncMethod(int i)
{
	cout << "Hello"<<i<<endl;
}

int AsyncMethod2(int x)
{
	cout << "Method 2 " << x << endl;
	return x + 2;
}

void MyFunc(int(*func)(string name))
{
	func("jp");
}

struct Function
{
public:
	void(*func)();
};


void main()
{

	MyFunc([](string name)->int { cout << name << endl; return 0;});
	void(*function[3])();

	vector<Function> functions;
	functions.push_back(Function());
	functions.push_back(Function());
	functions.push_back(Function());

	functions[0].func = []() {cout << "HI" << endl;};
	functions[1].func = []() {cout << "HI" << endl;};
	functions[2].func = []() {cout << "HI" << endl;};

	for (vector<Function>::iterator it = functions.begin(); it != functions.end(); it++)
	{
		it->func();
	}
	

	future<void> result(async([]() {for (int i = 0; i < 3; i++) { AsyncMethod(i); this_thread::sleep_for(chrono::seconds(2)); }}));
	cout << "Message from main\n" << endl;
	result.wait();

	future<int> result2; 
	
	cout << "Calm before the storm\n" << endl;

	result2 = future<int>(async([]()->int 
	{
		int temp = 0;
		for (int i = 0; i < 3; i++)
		{
			temp = AsyncMethod2(i);
		}
		return temp;
	}));

	cout << "Storm\n" << endl;
	result2.wait();

	cout << result2.get() << endl;
	getchar();


}
