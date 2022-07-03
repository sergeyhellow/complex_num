using System;

namespace HomeWork03072022
{


    class Program
    {
        static void Main(string[] args)
        {

            complex z = new complex(1, 1);
            complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);


        }

        public class complex 
        {
            public double r_path;
            public double image_path;


            public complex(double r, double i) 
            {
                r_path = r;
                image_path = i; 
            }
            public void show()
            {
                if (image_path > 0) Console.WriteLine("Z=" + r_path + "+" + image_path + "i"); else Console.WriteLine("Z=" + r_path + image_path + "i");
            }

            public static complex operator + (complex r, complex i)
            {
                return new complex(r.r_path+i.r_path,r.image_path+i.image_path);
            }

            public static complex operator - (complex r, complex i)
            {
                return new complex(r.r_path - i.r_path, r.image_path - i.image_path);
            }

            public static complex operator *(complex r, complex i)
            {
                return new complex((r.r_path * i.r_path)+((r.image_path * i.image_path)*(-1)),(r.r_path*i.image_path)+(r.image_path*i.r_path));
            }

            public static complex operator /(complex r, complex i)
            {
                complex i1 =new complex(i.r_path, (-1) * i.image_path);
                complex chis = r * i1;
              //  Z_num znam = new Z_num(i1.r_path * i.r_path, (-1) * i.image_path * i1.image_path);
                double znam1 = i1.r_path * i.r_path - 1 * i.image_path * i1.image_path;

                return new complex(chis.r_path/ znam1, chis.image_path/ znam1);
            }

         
               public override string ToString()
               {

                if (image_path > 0) 
                    return string.Format("{0} + {1}i", r_path, image_path); 
                else 
                    return string.Format("{0} {1}i", r_path, image_path);
               }



            public static complex operator *(int num, complex i)
            {
                return new complex(num*i.r_path, num*i.image_path);
            }
            public static complex operator *( complex i, int num)
            {
                return new complex(num * i.r_path, num * i.image_path);
            }


            public static complex operator -(complex i, int num) // этот код просто фантазия, ка вычесть из комплексеого числа натуральное - это загадка
            {
                return new complex(i.r_path - num, i.image_path- num);
            }



        }



    }


}
