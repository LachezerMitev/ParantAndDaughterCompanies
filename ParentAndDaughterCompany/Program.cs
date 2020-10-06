using System;
using System.Collections.Generic;

namespace ParentAndDaughterCompany
{
    class Program
    {
        public static void CreateConnection(Company company1, Company company2)
        {
            company1.Companies.Add(company2);
            company2.Companies.Add(company1);
        }
        static void Main(string[] args)
        {
            BreadthFirstAlgorithm b = new BreadthFirstAlgorithm();

            Company company1 = new Company("company1");
            Company company2 = new Company("company2");
            Company company3 = new Company("company3");
            Company company4 = new Company("company4");
            Company company5 = new Company("company5");
            Company company6= new Company("company6");
            Company company7= new Company("company7");
            Company company8= new Company("company8");
            Company company9= new Company("company9");
            Company company10 = new Company("company10");
            Company company11 = new Company("company11");
            Company company12 = new Company("company12");
            Company company13 = new Company("company13");
            Company company14 = new Company("company14");
            Company company15 = new Company("company15");
            Company company20 = new Company("company20");

            CreateConnection(company1, company2);
            CreateConnection(company1, company3);
            CreateConnection(company2, company3);
            CreateConnection(company3, company4);
            CreateConnection(company4, company5);
            CreateConnection(company4, company6);
            CreateConnection(company5, company3);
            CreateConnection(company5, company8);
            CreateConnection(company5, company7);
            CreateConnection(company6, company7);
            CreateConnection(company6, company11);
            CreateConnection(company7, company9);
            CreateConnection(company8, company10);
            CreateConnection(company9, company10);
            CreateConnection(company11, company12);
            CreateConnection(company12, company13);
            CreateConnection(company13, company14);
            CreateConnection(company14, company12);

            Console.WriteLine("\nBegin Iterrative Search\n------\n");

            b.SearchIterrative(company3, company10);      //yes
            b.SearchIterrative(company7, company10);      //yes
            b.SearchIterrative(company1, company15);      //no
            b.SearchIterrative(company4, company9);      //yes
            b.SearchIterrative(company3, company4);      //yes
            b.SearchIterrative(company10, company1);      //yes
            b.SearchIterrative(company1, company11);      //yes
            b.SearchIterrative(company10, company14);      //yes
            b.SearchIterrative(company12, company20);      //no

            Console.WriteLine("\nBegin Recursive Search\n------\n");

            b.SearchRecursive(company3, company10, true);      //yes
            b.SearchRecursive(company7, company10, true);      //yes
            b.SearchRecursive(company4, company9, true);      //yes
            b.SearchRecursive(company3, company4, true);      //yes
            b.SearchRecursive(company3, company15, true);        //no
            b.SearchRecursive(company10, company1, true);      //yes
            b.SearchRecursive(company1, company11, true);      //yes
            b.SearchRecursive(company10, company14, true);      //yes
            b.SearchRecursive(company12, company20, true);      //no
        }
    }
}
