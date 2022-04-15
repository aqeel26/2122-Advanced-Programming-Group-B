using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TheInformationTechnologyCollege.Data;
namespace TheInformationTechnologyCollege.Models
{
    public class ModuleDataInitializer : DropCreateDatabaseAlways<ModuleContext>
    {
        protected override void Seed(ModuleContext context)
        {
            //add the  value in to the class (database)
            Module Module1 = new Module();
            Module1.ModuleID = 1;
            Module1.ModuleCode = "COS1903";
            Module1.ModulTitle = "Scala Programming";
            Module1.ModuleDescription = "Learn Scala programming langiage";
            Module1.ModuleContents = "3 assignements 1 report and 1 exam";
            context.Modules.Add(Module1);
            //add the  value in to the class (database)
            Module Module2 = new Module();
            Module2.ModuleID = 2;
            Module2.ModuleCode = "COS1920";
            Module2.ModulTitle = "Database Management";
            Module2.ModuleDescription = "Learn database programming";
            Module2.ModuleContents = "3 assignements 2 report ";
            context.Modules.Add(Module2);
           
            //add the  value in to the class (database)
            Module Module3= new Module();
            Module3.ModuleID = 3;
            Module3.ModuleCode = "COS2905";
            Module3.ModulTitle = "Object Oriented Programming (java)";
            Module3.ModuleDescription = "Learn Java programming and object oriented principles";
            Module3.ModuleContents = "4 assignements 2 report ";
            context.Modules.Add(Module3);
           
            //add the  value in to the class (database)
            Module Module4 = new Module();
            Module4.ModuleID = 4;
            Module4.ModuleCode = "COS3911";
            Module4.ModulTitle = "Mobile Application";
            Module4.ModuleDescription = "Learn  programming and create mobile application";
            Module4.ModuleContents = "3 assignements 2 report ";
            context.Modules.Add(Module4);
            base.Seed(context);
            //add the  value in to the class (database)
            Module Module5 = new Module();
            Module5.ModuleID = 5;
            Module5.ModuleCode = "IMAT3611";
            Module5.ModulTitle = "Computer Ethics and Privacy";
            Module5.ModuleDescription = "Learn about computer ethics and privacy";
            Module5.ModuleContents = "1 assignements 3 report ";
            context.Modules.Add(Module5);
            //add the  value in to the class (database)
            Module Module6 = new Module();
            Module6.ModuleID = 6;
            Module6.ModuleCode = "COS3451";
            Module6.ModulTitle = "Development project";
            Module6.ModuleDescription = "Create a sytem using object oriented programming";
            Module6.ModuleContents = "3 assignements 1 report ";
            context.Modules.Add(Module6);
            //add the  value in to the class (database)
            Module Module7 = new Module();
            Module7.ModuleID = 7;
            Module7.ModuleCode = "SE3451";
            Module7.ModulTitle = "Development project";
            Module7.ModuleDescription = "Create a sytem using object oriented programming";
            Module7.ModuleContents = "3 assignements 1 report ";
            context.Modules.Add(Module7);
            //add the  value in to the class (database)
            Module Module8 = new Module();
            Module8.ModuleID = 8;
            Module8.ModuleCode = "SE3906";
            Module8.ModulTitle = "interaction Design";
            Module8.ModuleDescription = "Create a design of a system";
            Module8.ModuleContents = "3 assignements 1 report ";
            context.Modules.Add(Module8);
            //add the  value in to the class (database)
            Module Module9 = new Module();
            Module9.ModuleID = 9;
            Module9.ModuleCode = "SE3410";
            Module9.ModulTitle = "Web application Penetration Testing";
            Module9.ModuleDescription = "Create a sytem using object oriented programming";
            Module9.ModuleContents = "3 assignements 2 report ";
            context.Modules.Add(Module9);
            //add the  value in to the class (database)
            Module Module10 = new Module();
            Module10.ModuleID = 10;
            Module10.ModuleCode = "SE3406";
            Module10.ModulTitle = "Fuzzy Logic & Knowledge Based Systems";
            Module10.ModuleDescription = "Create a sytem using object oriented programming";
            Module10.ModuleContents = "3 assignements 1 report ";
            context.Modules.Add(Module10);
            //add the  value in to the class (database)
            Module Module11 = new Module();
            Module11.ModuleID = 11;
            Module11.ModuleCode = "SE3613";
            Module11.ModulTitle = "Data Mining";
            Module11.ModuleDescription = "Learn about Data Mining";
            Module11.ModuleContents = " 2 report ";
            context.Modules.Add(Module11);
            //add the  value in to the class (database)
            Module Module12 = new Module();
            Module12.ModuleID = 12;
            Module12.ModuleCode = "SE3614";
            Module12.ModulTitle = "Big Data & Business Models";
            Module12.ModuleDescription = "Learn about data and business models ";
            Module12.ModuleContents = " 3 report ";
            context.Modules.Add(Module12);
            //add the  value in to the class (database)
            Module Module13 = new Module();
            Module13.ModuleID = 13;
            Module13.ModuleCode = "SE3901";
            Module13.ModulTitle = "C Programming";
            Module13.ModuleDescription = "Learn  a new programming language: C";
            Module13.ModuleContents = " 4 assignements 1 Phase test ";
            context.Modules.Add(Module13);
            //add the  value in to the class (database)
            Module Module14 = new Module();
            Module14.ModuleID = 14;
            Module14.ModuleCode = "SE3902";
            Module14.ModulTitle = "Computer Law and Cyber Security Management";
            Module14.ModuleDescription = "Learn about Cyber security management";
            Module14.ModuleContents = " 1 assignment 2 report ";
            context.Modules.Add(Module14);
            //add the  value in to the class (database)
            Module Module15 = new Module();
            Module15.ModuleID = 15;
            Module15.ModuleCode = "SE3903";
            Module15.ModulTitle = "Linux Security";
            Module15.ModuleDescription = "Learn about Linux Security";
            Module15.ModuleContents = " 1 assignemtn 2 report ";
            context.Modules.Add(Module15);
            //add the  value in to the class (database)
            Module Module16 = new Module();
            Module16.ModuleID = 16;
            Module16.ModuleCode = "SE3904";
            Module16.ModulTitle = "Cyber Threat Intelligence and Incident Response";
            Module16.ModuleDescription = "Learn about Cyber threats and how to responde to an incident";
            Module16.ModuleContents = " 2 report ";
            context.Modules.Add(Module16);
            //add the  value in to the class (database)
            Module Module17 = new Module();
            Module17.ModuleID = 10;
            Module17.ModuleCode = "SE3905";
            Module17.ModulTitle = "Malware analysis";
            Module17.ModuleDescription = "Learn about malware analysis";
            Module17.ModuleContents = " 2 report ";
            context.Modules.Add(Module17);
            base.Seed(context);
        }
    }
}