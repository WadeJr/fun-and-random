#include <iostream>
#include <string>
#include <vector>
#include <map>
#include <math.h>
#include <iomanip>
using namespace std;

int main()
{
    string str, E; vector <string> vec; vector <int> num; int value =0;
    //User input
    //cout << "Enter a Url encoding to decode: "; getline(cin, str);

    //Hard Code
    cout << "Press Enter to decode the hard coded URL encoding...."; getline(cin, E);
    str = "%59%69%70%70%65%68%21%20%59%6F%75%72%20%55%52%4C%20%69%73%20%63%68%61%6C%6C%65%6E%67%65%2F%74%72%61%69%6E%69%6E%67%2F%65%6E%63%6F%64%69%6E%67%73%2F%75%72%6C%2F%73%61%77%5F%6C%6F%74%69%6F%6E%2E%70%68%70%3F%70%3D%69%72%6F%6D%64%6D%62%65%62%6E%6C%66%26%63%69%64%3D%35%32%23%70%61%73%73%77%6F%72%64%3D%66%69%62%72%65%5F%6F%70%74%69%63%73%20%56%65%72%79%20%77%65%6C%6C%20%64%6F%6E%65%21";

    //Put each Hex number in vector 
    while (str.find('%' , value) != string::npos){vec.push_back(str.substr(str.find('%', value) +1, 2));value = str.find('%', value) + 1;}

    //initialize Decimal vector
    for(int x = 0; x < vec.size(); x++){num.push_back(0);}
    
    //Convert each Hex number into a Decimal number
    for(int x = 0; x < vec.size(); x++)
    {   
        int count = 1;
        for(int i = 0; i < vec[x].length(); i++)
        {
          if(vec[x][i] == 'A')
            {
               num[x] += pow(16, count)  * 10;
               count--;
            }
            else if(vec[x][i] == 'B')
            {
               num[x] += pow(16, count)  * 11;
               count--;
            }
            else if(vec[x][i] == 'C')
            {
               num[x] += pow(16, count)  * 12;
               count--;
            }
            else if(vec[x][i] == 'D')
            {
               num[x] += pow(16, count)  * 13;
               count--;
            }
            else if(vec[x][i] == 'E')
            {
               num[x] += pow(16, count)  * 14;
               count--;
            }
            else if(vec[x][i] == 'F')
            {
               num[x] += pow(16, count)  * 15;
               count--;
            }
            else
            {
               num[x] += pow(16, count)  * (int(vec[x][i]) -48);
               count--;
            }
        }
      
    }

    //Display the ACSII code for the vector of Decimal numbers

    for (int i = 0; i < num.size(); i++){cout << char(num[i]);}cout << endl;

    return 0;


}