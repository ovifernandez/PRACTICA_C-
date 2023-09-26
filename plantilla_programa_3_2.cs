namespace Programa3_2
{

    using System;
    using System.IO;
    using System.Numerics;
    using System.Security.Cryptography;
    
using System.Runtime.Intrinsics;

    namespace ConsoleApp1
    {
        abstract class Vectores
        {
            public int Dimensiones {get; set;}
            

            public abstract void ImprimirPorPantalla(double[] vector);
            public abstract double CalcularParametros(double[] vector1, double[] vector2, out double ang);
            public abstract double[] LeerVector(ref double[] vector);

        }

        class Vec2DC : Vectores
        {
            //Constructor vacío
            public Vec2DC(){
             Dimensiones = 2;
            }
            //Constructor parametrizado
            public Vec2DC(int Dimensiones)
        {
            Dimensiones = 2;
            
        }
            
            
            public override double[] LeerVector(ref double[] vector)
            {
                Console.WriteLine("Introduzca la coordenada x del vector: ");
                vector[0] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Introduzca la coordenada y del vector: ");
                vector[1] = Convert.ToDouble(Console.ReadLine());
             return vector;
            }
            public override void ImprimirPorPantalla(double[] vector)
            {
                Console.WriteLine("Coordenada X: %f, Coordenada Y: %f", vector[0], vector[1]);
            }

            public override double CalcularParametros(double[] vector1, double[] vector2, out double acoseno)
            {
                double modulo, magnitud1, magnitud2;
                if(vector1[0]%2 == 0){
                    vector1[0] = vector1[0] - vector1[1];
                }else{
                    vector1[0] = vector1[0] * vector1[1];
                }
                if(vector2[0]%2 == 0){
                    vector2[0] = vector2[0] - vector2[1];
                }else{
                    vector2[0] = vector1[0] * vector2[1];
                }
                
                modulo = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]);
                magnitud1 = Math.Sqrt((vector1[0] * vector1[0]) + (vector1[1] * vector1[1]));
                magnitud2 = Math.Sqrt((vector2[0] * vector2[0]) + (vector2[1] * vector2[1]));
                acoseno = Math.Acos(modulo/(magnitud1 * magnitud2));

                return modulo;
            }



        }

        class Vec3DC : Vectores
        {
            public Vec3DC  (){
                Dimensiones = 3;
            }

            public override double[] LeerVector(ref double[] vector)
            {
                 Console.WriteLine("Introduzca la coordenada x del vector: ");
                vector[0] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Introduzca la coordenada y del vector: ");
                vector[1] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Introduzca la coordenada z del vector: ");
                vector[2] = Convert.ToDouble(Console.ReadLine());

                return vector;
            }
            public override void ImprimirPorPantalla(double[] vector)
            {
                Console.WriteLine("Coordenada X: %f, Coordenada Y: %f, Coordenada Z: %f", vector[0], vector[1], vector[2]);

            }

            public override double CalcularParametros(double[] vector1, double[] vector2, out double ang)
            {
                double modulo, magnitud1, magnitud2;
                if(vector1[0]%2 == 0){
                    vector1[0] = vector1[0] - (vector1[1] * vector1[2]);
                }else{
                    vector1[0] = vector1[0] * (vector1[1] + vector1[2]);
                }

                if(vector2[0]%2 == 0){
                    vector2[0] = vector2[0] - (vector2[1] * vector2[2]);
                }else{
                    vector2[0] = vector1[0] * (vector2[1] + vector2[2]);
                }
                
                
                modulo = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]);
                magnitud1 = Math.Sqrt((vector1[0] * vector1[0]) + (vector1[1] * vector1[1]) + (vector1[2] * vector1[2]));
                magnitud2 = Math.Sqrt((vector2[0] * vector2[0]) + (vector2[1] * vector2[1]) + (vector2[2] * vector2[2]));
                ang = Math.Acos(modulo/(magnitud1 * magnitud2));

                return modulo;
            }
        }

        class Vec2DP : Vectores
        {
            public override void ImprimirPorPantalla(double[] vector)
            {
               Console.WriteLine("Coordenada X: %f, Coordenada Y: %f", vector[0], vector[1]);  
            }



            public override double[] LeerVector(ref double[] vector)
            {
                 Console.WriteLine("Introduzca r: ");
                 double r = Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine("Introduzca el ángulo: ");
                 double angulo = Convert.ToDouble(Console.ReadLine());
                vector[0] = r * Math.Cos(angulo);
                vector[1] = r * Math.Sin(angulo);

                return vector;
            }

            public override double CalcularParametros(double[] vector1, double[] vector2, out double ang)
            {
                double modulo, magnitud1, magnitud2;
                if(vector1[0]%2 == 0){
                    vector1[0] = vector1[0] - vector1[1];
                }else{
                    vector1[0] = vector1[0] * vector1[1];
                }
                if(vector2[0]%2 == 0){
                    vector2[0] = vector2[0] - vector2[1];
                }else{
                    vector2[0] = vector1[0] * vector2[1];
                }
                
                modulo = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]);
                magnitud1 = Math.Sqrt((vector1[0] * vector1[0]) + (vector1[1] * vector1[1]));
                magnitud2 = Math.Sqrt((vector2[0] * vector2[0]) + (vector2[1] * vector2[1]));
                ang = Math.Acos(modulo/(magnitud1 * magnitud2));

                return modulo;
                
            }

        }

        class Vec3DE : Vectores
        {



            public override void ImprimirPorPantalla(double[] vector)
            {
                Console.WriteLine("Coordenada X: %f, Coordenada Y: %f, Coordenada Z: %f", vector[0], vector[1], vector[2]);

            }

            public override double CalcularParametros(double[] vector1, double[] vector2, out double ang)
            {
                
                double modulo, magnitud1, magnitud2;
                if(vector1[0]%2 == 0){
                    vector1[0] = vector1[0] - vector1[1];
                }else{
                    vector1[0] = vector1[0] * vector1[1];
                }
                if(vector2[0]%2 == 0){
                    vector2[0] = vector2[0] - vector2[1];
                }else{
                    vector2[0] = vector1[0] * vector2[1];
                }
                
                modulo = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]);
                magnitud1 = Math.Sqrt((vector1[0] * vector1[0]) + (vector1[1] * vector1[1]));
                magnitud2 = Math.Sqrt((vector2[0] * vector2[0]) + (vector2[1] * vector2[1]));
                ang = Math.Acos(modulo/(magnitud1 * magnitud2));

                return modulo;

            }

            public override double[] LeerVector(ref double[] vector)
            {
                Console.WriteLine("Intro p: ");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Intro angulo: ");
                double angulo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Intro la tercera coordenada: ");
                double omega = Convert.ToDouble(Console.ReadLine());

                double r = p * Math.Sin(angulo);

                vector[0] = r * Math.Cos(angulo);
                vector[1] = r * Math.Sin(angulo);
                vector[2] = p * Math.Cos(angulo);

                return vector;
            }
            
        }

        class Program

        {
            private static double acoseno;

            static void Main(string[] args)
            {
                int opc;
                bool program = true;
                do{
                    Console.WriteLine("ELIJA UNA OPCION:\n  1. 2 vectores cartesianos de 2 dimensiones.\n  2. 2 vectores cartesianos de 3 dimensiones.\n  3. 2 vectores polares.\n  4. 2 vectores esféricos.");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch(opc){
                    case 1:
                    Vec2DC vec2dc1 = new Vec2DC();
                    Vec2DC vec2dc2 = new Vec2DC();
                    double[] vector1 = new double[vec2dc1.Dimensiones];
                    double[] vector2 = new double[vec2dc2.Dimensiones];
                    vec2dc1.LeerVector(ref vector1);
                    vec2dc2.LeerVector(ref vector2);
                    vec2dc1.ImprimirPorPantalla(vector1);
                    vec2dc2.ImprimirPorPantalla(vector2);
                    vec2dc1.CalcularParametros(vector1, vector2, out acoseno);
                    break;
                    
                    case 2:
                    Vec3DC vec3dc1 = new Vec3DC();
                    Vec3DC vec3dc2 = new Vec3DC();
                    double[] vector1_1 = new double[vec3dc1.Dimensiones];
                    double[] vector2_1 = new double[vec3dc2.Dimensiones];

                    vec3dc1.LeerVector(ref vector1_1);
                    vec3dc2.LeerVector(ref vector2_1);
                    vec3dc1.ImprimirPorPantalla(vector1_1);
                    vec3dc2.ImprimirPorPantalla(vector2_1!);
                    vec3dc1.CalcularParametros(vector1_1, vector2_1, out acoseno);
                    break;
                    case 3:
                    Vec2DP vec2dp1 = new Vec2DP();
                    Vec2DP vec2dp2 = new Vec2DP();
                    double[] vector1_2 = new double[vec2dp1.Dimensiones];
                    double[] vector2_2 = new double[vec2dp2.Dimensiones];

                    vec2dp1.LeerVector(ref vector1_2);
                    vec2dp2.LeerVector(ref vector2_2);
                    vec2dp1.ImprimirPorPantalla(vector1_2);
                    vec2dp2.ImprimirPorPantalla(vector2_2);
                    vec2dp1.CalcularParametros(vector1_2, vector2_2, out acoseno);
                    break;
                    case 4:
                    Vec3DE vec3de1 = new Vec3DE();
                    Vec3DE vec3de2 = new Vec3DE();
                    double[] vector1_3 = new double[vec3de1.Dimensiones];
                    double[] vector2_3 = new double[vec3de2.Dimensiones];

                    vec3de1.LeerVector(ref vector1_3);
                    vec3de2.LeerVector(ref vector2_3);
                    vec3de1.ImprimirPorPantalla(vector1_3);
                    vec3de2.ImprimirPorPantalla(vector2_3);
                    vec3de1.CalcularParametros(vector1_3, vector2_3, out acoseno);
                    break;
                    case 5:
                    program = false;
                    break;
                    
                    default:
                    break;
                }
                }while(program);
                

            }


        }



    }


}

