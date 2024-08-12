using System;


namespace KiemTraSoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            int i;
            
            Console.Write("Cac so nguyen to be hon 100 la: ");
            for(num=0;num<=100;num++)
            {
                int count=0;
                if (num>=2)
                {
                    for (i=2;i<num;i++)
                    {
                        if(num%i==0)
                        {
                            count++;
                        }
                    }
                    if(count==0)
                    {
                        Console.Write("{0,3}",num);
                    }
                }
                
            }
            
           
        }
    }
}