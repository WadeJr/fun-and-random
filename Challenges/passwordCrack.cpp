#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
    string pass, crack("");
    cout << "Enter a password: "; cin >> pass;
    int num = pass.length(), i(0);


    //initialize crack to the same length as the password
    for(int i = 0; i < num; i++)
    {
        crack.append("@");
    }

    if(num = 3)
    {
        for(int a = 0; a < 3; a++)
        {
            crack[num -2] += a;
            for(int b = 0; b < 3; b++)
            {
                crack[num-1] += b;
                for(int c = 0; c < 3; c++)
                {  
                    crack[num] += c;
                    cout << crack << endl;
                }
            
            }
        }
    }
















/* 
    for(int i = 0; i < 57; i++)
    {
        //33
        if(i == 26)
        {

        }
        //36
        if(i = 27)
        {

        }
        //45
        if(i = 28)
        {

        }
        //95
        if(i = 29)
        {

        }
       
    }





    if(crack == pass)
    {
        cout << "The cracked password is: " << crack << endl;
            
    }
 */
    return 0;
}
/* 
33
36
45
64-90
95
97-122

 */






//definition of big o
