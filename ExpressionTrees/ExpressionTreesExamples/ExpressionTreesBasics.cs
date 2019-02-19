using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressionTreesExamples
{
    /// <summary>
    /// Based on https://www.codeproject.com/Articles/17575/Lambda-Expressions-and-Expression-Trees-An-Introdu
    /// </summary>
    public class ExpressionTreesBasics
    {
        private readonly List<int> _numbers = new List<int>(new int[]{1,2,3,4,5,6});

        public ExpressionTreesBasics()
        {

        }

        private void _lambdaExpressions()
        {
            // using anonymous method (
            int result = this._numbers.Find(delegate (int n) { return n < 3; });

            // The basic form for a lambda expression is: argument-list => expression

            // gets the first number smaller than 10 in the list
            result = this._numbers.Find(n => n < 3);

            // anonymous method
            this._numbers.Sort(delegate (int x, int y) { return y - x; });

            // lambda expression
            this._numbers.Sort((x, y) => y - x);

            // You can include multiple statements if you enclose them inside a statement block
            Action<Customer> action =
                cust =>
                {
                    cust.Name = "Jacek";
                    cust.Description = "Placek";
                };
        }

        private void _expressionTrees()
        {
            // To make a lambda expression be treated as an expression tree, 
            // assign or cast it to the type Expression<T>, where T is the type of the delegate that defines the expression's signature.

            Expression<Predicate<int>> expressionByCode = n => n < 3;

            // Parameters:
            Console.WriteLine(expressionByCode.Parameters[0].Name);
            Console.WriteLine(expressionByCode.Parameters[0].Type);

            // Body:
            Console.WriteLine(expressionByCode.Body.NodeType);
            Console.WriteLine(((BinaryExpression)expressionByCode.Body).Left);
            Console.WriteLine(((BinaryExpression)expressionByCode.Body).Right);

            // This expression tree can also be created manually like this:

            Expression<Predicate<int>> expressionByApi = Expression.Lambda<Predicate<int>>(
                Expression.LessThan(
                    Expression.Parameter(typeof(int), "n"),
                    Expression.Constant(3)
                ),
                Expression.Parameter(typeof(int), "n")
            );

            // Get a compiled version of the expression, wrapped in a delegate
            Predicate<int> predicate = expressionByApi.Compile();
            // use the compiled expression
            bool isMatch = predicate(2); //isMatch will be set to true
        }

        public void Run()
        {
            this._lambdaExpressions();
            this._expressionTrees();

        }

    }
}
