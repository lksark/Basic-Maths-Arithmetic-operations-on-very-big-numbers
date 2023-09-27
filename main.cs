﻿using DiffieHellman_KeyExchange;
using System;
using System.Numerics;

namespace namespace_DiffieHellman_KeyExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            //class_DiffieHellman_KeyExchange obj_DiffieHellman_KeyExchange_Alice = new class_DiffieHellman_KeyExchange();
            //class_DiffieHellman_KeyExchange obj_DiffieHellman_KeyExchange_Bob = new class_DiffieHellman_KeyExchange();

            //Console.WriteLine("Alice PrivateKey             = " + obj_DiffieHellman_KeyExchange_Alice.set_PrivateKey_multithreaded());
            //Console.WriteLine("Alice P_PrimeModulo          = " + obj_DiffieHellman_KeyExchange_Alice.set_P_PrimeModulo());
            //Console.WriteLine("Alice G_PrimitiveRootModuloP = " + obj_DiffieHellman_KeyExchange_Alice.set_G_PrimitiveRootModuloP());

            //Console.WriteLine("Alice PublicKey              = " + obj_DiffieHellman_KeyExchange_Alice.set_PublicKey_Self_multithreaded());
            //obj_DiffieHellman_KeyExchange_Bob.set_PublicKey_Opponent(obj_DiffieHellman_KeyExchange_Alice.get_PublicKey_Self());

            //Console.WriteLine();
            //Console.WriteLine("Bob PrivateKey               = " + obj_DiffieHellman_KeyExchange_Bob.set_PrivateKey_multithreaded());
            //obj_DiffieHellman_KeyExchange_Bob.set_P_PrimeModulo(obj_DiffieHellman_KeyExchange_Alice.get_P_PrimeModulo());
            //obj_DiffieHellman_KeyExchange_Bob.set_G_PrimitiveRootModuloP(obj_DiffieHellman_KeyExchange_Alice.get_G_PrimitiveRootModuloP());
            //Console.WriteLine("Bob P_PrimeModulo          = " + obj_DiffieHellman_KeyExchange_Alice.set_P_PrimeModulo());
            //Console.WriteLine("Bob PublicKey                = " + obj_DiffieHellman_KeyExchange_Bob.set_PublicKey_Self_multithreaded());
            //obj_DiffieHellman_KeyExchange_Alice.set_PublicKey_Opponent(obj_DiffieHellman_KeyExchange_Bob.get_PublicKey_Self());

            Console.WriteLine();

            /*
            Console.WriteLine("\n999.55 + 0.55 = " + MathArithmetic.Addition_UnlimitedDataSize("999.55", "0.55"));
            Console.WriteLine("\n2365875513654654 + 6555654546684658 = " + MathArithmetic.Addition_UnlimitedDataSize("2365875513654654", "6555654546684658"));
            Console.WriteLine("\n2365875.543654654 + 65556545.466846586 = " + MathArithmetic.Addition_UnlimitedDataSize("2365875.543654654", "65556545.466846586"));
            Console.WriteLine("\n2365875.543654654 + 65556545 = " + MathArithmetic.Addition_UnlimitedDataSize("2365875.543654654", "65556545"));
            Console.WriteLine("\n198 + 22.0435 = " + MathArithmetic.Addition_UnlimitedDataSize("198", "22.0435"));
            Console.WriteLine("\n198 + 822.0435 = " + MathArithmetic.Addition_UnlimitedDataSize("198", "822.0435"));
            Console.WriteLine("\n0.55 + 0.55 = " + MathArithmetic.Addition_UnlimitedDataSize("0.55", "0.55"));
            */

            /*
            Console.WriteLine("\n2365 - 23654 = " + MathArithmetic.Minus_UnlimitedDataSize("2365", "23654"));
            Console.WriteLine("\n23654 - 2365 = " + MathArithmetic.Minus_UnlimitedDataSize("23654", "2365"));
            Console.WriteLine("\n236541 - 23654.56 = " + MathArithmetic.Minus_UnlimitedDataSize("236541", "23654.56"));
            Console.WriteLine("\n1000 - 0.56 = " + MathArithmetic.Minus_UnlimitedDataSize("1000", "0.56"));
            Console.WriteLine("\n23654.32 - 23654.5698 = " + MathArithmetic.Minus_UnlimitedDataSize("23654.32", "23654.5698"));
            Console.WriteLine("\n85464.1468 - 5464.56 = " + MathArithmetic.Minus_UnlimitedDataSize("85464.1468", "5464.56"));
            Console.WriteLine("\n5464.1468 - 85464.56 = " + MathArithmetic.Minus_UnlimitedDataSize("5464.1468", "85464.56"));
            Console.WriteLine("\n0.71468 - 0.56 = " + MathArithmetic.Minus_UnlimitedDataSize("0.71468", "0.56"));
            */

            /*
            Console.WriteLine("34632 * 8432 = " + MathArithmetic.Multiplication_UnlimitedDataSize("34632", "8432"));
            Console.WriteLine("63 * 1 = " + MathArithmetic.Multiplication_UnlimitedDataSize("63", "1"));
            Console.WriteLine("0.015 * 0.2 = " + MathArithmetic.Multiplication_UnlimitedDataSize("0.015", "0.2"));
            Console.WriteLine("21.01 * 135.654 = " + MathArithmetic.Multiplication_UnlimitedDataSize("21.01", "135.654"));
            Console.WriteLine("0.00006843156 * 0.753548655132 = " + MathArithmetic.Multiplication_UnlimitedDataSize("0.00006843156", "0.753548655132"));


            Console.WriteLine("63 / 63 = " + MathArithmetic.Division_UnlimitedDataSize("63", "63"));
            Console.WriteLine("88 / 22 = " + MathArithmetic.Division_UnlimitedDataSize("88", "22"));
            Console.WriteLine("880 / 22 = " + MathArithmetic.Division_UnlimitedDataSize("880", "22"));
            Console.WriteLine("902 / 22 = " + MathArithmetic.Division_UnlimitedDataSize("902", "22"));
            Console.WriteLine("198 / 22 = " + MathArithmetic.Division_UnlimitedDataSize("198", "22"));
            Console.WriteLine("200 / 22 = " + MathArithmetic.Division_UnlimitedDataSize("200", "22"));
            Console.WriteLine("296237062 / 22 = " + MathArithmetic.Division_UnlimitedDataSize("296237062", "22"));
            Console.WriteLine("68432165321 / 9873 = " + MathArithmetic.Division_UnlimitedDataSize("68432165321", "9873"));
            Console.WriteLine("68432165321 / 19873 = " + MathArithmetic.Division_UnlimitedDataSize("68432165321", "19873"));
            Console.WriteLine("684432651321681011 / 71342 = " + MathArithmetic.Division_UnlimitedDataSize("684432651321681011", "71342"));

            Console.WriteLine("4000 / 2 = " + MathArithmetic.Division_UnlimitedDataSize("4000", "2"));
            Console.WriteLine("\n0.4 / 0.002 = " + MathArithmetic.Division_UnlimitedDataSize("0.4", "0.002"));
            Console.WriteLine("\n0.004 / 0.2 = " + MathArithmetic.Division_UnlimitedDataSize("0.004", "0.2"));
            //Console.WriteLine("\n0.006843156464312648686964154844855 / 0.753548655132 = " + MathArithmetic.Division_UnlimitedDataSize("0.006843156464312648686964154844855", "0.753548655132"));
            Console.WriteLine("\n0.00684315646431264868696415484485 / 0.753548655132 = " + MathArithmetic.Division_UnlimitedDataSize("0.00684315646431264868696415484485", "0.753548655132"));
            */
            
            Console.WriteLine();
            Console.WriteLine("200 % 22 = " + MathArithmetic.Modular_UnlimitedDataSize("200", "22"));
            Console.WriteLine("22 % 22 = " + MathArithmetic.Modular_UnlimitedDataSize("22", "22"));
            Console.WriteLine("220 % 22 = " + MathArithmetic.Modular_UnlimitedDataSize("220", "22"));
            Console.WriteLine("296237062 % 22 = " + MathArithmetic.Modular_UnlimitedDataSize("296237062", "22"));
            Console.WriteLine("68432165321 % 9873 = " + MathArithmetic.Modular_UnlimitedDataSize("68432165321", "9873"));
            Console.WriteLine("68432165321 % 19873 = " + MathArithmetic.Modular_UnlimitedDataSize("68432165321", "19873"));
            Console.WriteLine("684432651321681011 % 71342 = " + MathArithmetic.Modular_UnlimitedDataSize("684432651321681011", "71342"));
            Console.WriteLine("4000 % 2 = " + MathArithmetic.Modular_UnlimitedDataSize("4000", "2"));
            Console.WriteLine("0.4 % 0.002 = " + MathArithmetic.Modular_UnlimitedDataSize("0.4", "0.002"));
            Console.WriteLine("0.004 % 0.2 = " + MathArithmetic.Modular_UnlimitedDataSize("0.004", "0.2"));
            Console.WriteLine("0.06543268331545211 % 0.2 = " + MathArithmetic.Modular_UnlimitedDataSize("0.06543268331545211", "0.2"));
            Console.WriteLine("1.46651132 % 0.5 = " + MathArithmetic.Modular_UnlimitedDataSize("1.46651132", "0.5"));
            Console.WriteLine("1.46651132 % 0.03 = " + MathArithmetic.Modular_UnlimitedDataSize("1.46651132", "0.03"));

            /*
            //Console.WriteLine("\n11^11 = " + Math.Pow(11,11));
            Console.WriteLine("\n26^11 = " + Math.Pow(26, 11));

            Console.WriteLine("\n23 ^ 1073 = " + MathArithmetic.Exponent_UnlimitedDataSize("23", "1073"));
            Console.WriteLine("\n11 ^ 11 = " + MathArithmetic.Exponent_UnlimitedDataSize("11", "11"));
            Console.WriteLine("\n26 ^ 11 = " + MathArithmetic.Exponent_UnlimitedDataSize("26", "11"));
            */
        }
    }
}