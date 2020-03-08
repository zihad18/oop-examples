using Inheritance.Relationship;
using System;
using System.Collections.Generic;
using ExampleNamespace;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex = new Example();

            var list = new List<int> {
            4, 5 , 6
            };

            var book = new Book
            {
                Id = 1,
                Title = "C programmin",
                Isbn = "1235",
                Authors = new List<Author>
                {
                    new Author{ Id = 2, Age = 50.0f, Name = "Name1"},
                    new Author{ Id = 3, Age = 50.0f, Name = "Name2"},
                }
            };

            foreach (var author in book.Authors)
            {
                Console.WriteLine(author.Name);
            }

            // Console.WriteLine(book.Author.Name);


            //Shape[] shapes = {
            //    new Circle(5.0f),
            //    new Cylinder(5.0f,10),
            //    new Rectangle(2.0f, 3.0f),
            //    new Square(3.0f)
            //};

            //foreach (Shape shape in shapes)
            //{
            //    Console.WriteLine(shape.GetArea());
            //}

            Console.ReadKey();
        }
    }
}
