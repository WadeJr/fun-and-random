#include <iostream>
#include <string>
#include <vector>
#include <math.h>
#include <iomanip>
using namespace std;

int main()
{
    string str, word =""; int bits; vector <string> words; vector <int> ascii;
    //User input
    //cout << "Enter an encoded Binary number to be decoded: "; getline(cin, str);

    //Hard code
    str = "101010011010001101001111001101000001110100110010111110001110100010000011010011110011010000001101110101101110001011010011110100010000011001011101110110001111011111100100110010111001000100000110000111100111100011110100111010010101110010000010110011101111111010111100100100000111000011000011110011111001111101111101111111001011001000100000110100111100110100000110010111000011110011111100111100111110100110000111100101110100110010111100100101110";
    cout << "How many bits is each letter to be converted (geuss): "; cin >> bits;

    //Put words in a vector
    for(int i = 0; i < str.length(); i++)
    {
        if(word.length() == bits)
        {
            words.push_back(word);
            word = "";
        }
       word += str[i];  
       if (i == (str.length() -1))
       {
           words.push_back(word);
       }
    }
    //initialize ascii vector
    for(int i = 0; i < words.size(); i++){ascii.push_back(0);}

    //Add up bits
    for(int i = 0; i < words.size(); i++)
    {
        for(int x = 0, num = words[i].length() - 1; x < words[i].length(); x++, num--)
        {
            if(words[i][x] == '1')
            {
                ascii[i] += pow(2, num);
            }
        }
    }

    //Display decoded message
    for (int i = 0; i < ascii.size(); i++)
    {
        cout << char(ascii[i]);
    }
    cout << endl;
   
    return 0;
}