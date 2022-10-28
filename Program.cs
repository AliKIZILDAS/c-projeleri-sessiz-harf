using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s="Merhaba Umut Arya";
            string[] s1=s.Split(" ");            
            bool SONUC=false;
            int a=0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s1[i].Length; j++)
                {                                       
                    if ((s1[i][j]=='a')||(s1[i][j]=='e')||(s1[i][j]=='ı')||(s1[i][j]=='i')||(s1[i][j]=='o')||(s1[i][j]=='ö')||(s1[i][j]=='u')||(s1[i][j]=='ü')||(s1[i][j]=='A')||(s1[i][j]=='E')||(s1[i][j]=='I')||(s1[i][j]=='İ')||(s1[i][j]=='O')||(s1[i][j]=='Ö')||(s1[i][j]=='U')||(s1[i][j]=='Ü'))
                    {
                        a=0;                        
                    }
                    else
                    {
                        a++;
                        if (a==2)
                        {
                            Console.Write("True ");
                            SONUC=true;
                            break;
                        }                        
                    }
                    if (j==0)
                    {
                        SONUC=false;
                    }   
                    if (s1[i].Length==(j+1)&&SONUC==false)
                        {
                            Console.Write("False ");   
                        }                                   
                }                
            }
        }
    }
}
