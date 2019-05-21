#include <iostream>
#include <string>
#include <vector>
#include <iomanip>
using namespace std;

int main()
{
    string str; int temp = 0, value =0; vector <int> vec;
    cout << "Enter numbers of ASCII codes to be deciphered seperated by commas: "; getline(cin, str);
   
   while (str.find(", " , value) != string::npos)
	{  temp = str.find(", " , value) - value; vec.push_back(std::stoi(str.substr(value , temp))); value = str.find(", ", value) + 1;
	} temp = str.find(", " , value) - value; vec.push_back(std::stoi(str.substr(value , temp))); value = str.find(", ", value) + 1;
    for (int i = 0; i < vec.size(); i++)
    {
        cout << char(vec[i]);
    }
    cout << endl;
    return 0;
}