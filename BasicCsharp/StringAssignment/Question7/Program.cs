using System;
namespace Question7;
class program{
    public static void Main(string[] args)
    {
        string str;
        string a="bcdfghjklmnpqrstuvwxyz";
        int vowels=0,constant=0;
        System.Console.WriteLine("Enter a string: ");
        str=Console.ReadLine().ToLower();
        for(int i=0;i<=str.Length-1;i++){
            if(str[i]=='a'||str[i]=='e'||str[i]== 'i'||str[i]=='o'||str[i]=='u'){
                vowels++;
            }
        }
        for(int i=0;i<str.Length-1;i++){
            for(int j=0;j<a.Length-1;j++){
                if(str[i]==a[j]){
                    constant++;
                }
            }
        }
        
        System.Console.WriteLine(vowels);
        System.Console.WriteLine(constant);
    }
}