#include <iostream>
#include <string>
#include <vector>
#include <iomanip>
using namespace std;

int main()
{
    string str, word; vector <string> vec; int shift =0, value = 0, x = 0, temp = 0;

    cout << "Enter the sentence to be deciphered and press Enter: "; getline(cin, str);
  
    
    cout << endl << "Enter the number of shifts: "; cin >> shift; cout << endl;

	while (str.find(" " , value) != string::npos)
	{  temp = str.find(" " , value) - value; vec.push_back(str.substr(value , temp)); value = str.find(" ", value) + 1;
	} temp = str.find(" " , value) - value; vec.push_back(str.substr(value , temp)); value = str.find(" ", value) + 1;

   for(int i = 0; i < vec.size(); i++)
   {
       for(int a = 0; a < vec[i].length(); a++)
       {
           if(isupper(vec[i][a]) == true)
           {
                vec[i][a] += shift;
                if (vec[i][a] > 'Z')
                {
                    vec [i][a] -= 26;
                }
           }
           if(islower(vec[i][a]) == true)
           {
                vec[i][a] += shift;
                if (vec[i][a] > 'z')
                {
                    vec [i][a] -= 26;
                }
           }

       }
       cout << vec[i] << " " << endl;
   }

    return 0;
}
