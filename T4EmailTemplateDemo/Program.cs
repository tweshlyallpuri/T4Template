using System;
using System.Collections.Generic;

namespace T4EmailTemplateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailTemplate e = new EmailTemplate() { ListOfComponents = new List<EmailComponentTemplate>() { 
                new EmailComponentTemplate() { Name = "Header_Twesh" }, 
                new BodyTemplate() { FirstName = "Twesh", LastName = "Lyallpuri" }, 
                new EmailComponentTemplate() { Name = "Footer_Twesh" } 
            } };
            var x = e.TransformText();
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
