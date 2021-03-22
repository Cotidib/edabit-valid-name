using System;
using System.Collections.Generic;
using System.Linq;

bool IsInitial(string name){
    return ( name.Length == 2 && Char.IsUpper(name,0) && name.EndsWith(".") );
}

bool IsWord(string name){
    return ( name.Length > 2 && Char.IsUpper(name,0) && !name.EndsWith(".") );
}

bool ValidName(string name) 
{
    string[] splittedName = name.Split(' ');
    bool isValid = false;

    bool firstElementCondition = IsInitial(splittedName[0]) || IsWord(splittedName[0]) ;
    bool lastElementCondition = IsWord(splittedName[splittedName.Length - 1]);

    if(splittedName.Length == 3){
       bool middleElementCondition = IsInitial(splittedName[1]) || ( IsWord(splittedName[0]) && IsWord(splittedName[1]) );
       if(firstElementCondition && middleElementCondition && lastElementCondition){
           isValid = true;
       }
    }

    else if(splittedName.Length == 2){
        if(firstElementCondition && lastElementCondition){
            isValid = true;
        }
    }
    else{
        isValid = false;
    }

    Console.WriteLine(isValid);
    return isValid;
}

//ValidName("H. Wells"); // True
//ValidName("H. G. Wells"); // True
//ValidName("Herbert G. Wells"); // True
//ValidName("Herbert George Wells"); // True
//ValidName("Herbert"); // False
//ValidName("H Wells"); // False
//ValidName("H. wells"); // False
//ValidName("H. George Wells"); // False
//ValidName("H. G. W."); //False
//ValidName("Herb. G. Wells"); // False
