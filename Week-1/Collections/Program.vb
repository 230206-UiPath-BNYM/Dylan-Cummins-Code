Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello Collections! ")
        'Arrays, List, Dictionaries

        '========Arrays========'
        'Arrays are a homogenenous collection of items stored in a contiguous memory space
        'declare arrays by including () after the variable name
        dim fruits() as String = {"banana", "apple", "mango"}
        dim fruits2(3) as String 
        'arrays in vb are zero based
        fruits2(0) = "Kiwi"
        fruits2(1) = "Strawberry"
        fruits2(2) = "Pineapple"

        'enhanced for loop aka for each that is utilized over collections
        For each fruit As String in fruits2
            Console.WriteLine(fruit)
        Next

        'while arrays are cool and retrieving elemnts take o(1), it's statically sized

        '=========Lists========'
        'Lists are ordered collections of homogenous items
        'Like arrays are also index based, but unlike arrays can dynamically change size

        dim students as New List(of String)
        students.add("Irving")
        students.add("Chase")
        students.add("Gavin")
        students.add("Amol")

        For Each student as String in students  
            Console.WriteLine(student)
        Next
        students(3) = "Amol Apte"
        Console.WriteLine(students(3))

        '=======Dictionary========'
        'Dictionary is a collection of key value pairs
        'access these values based on their keys

        dim gradebook as new dictionary(of string, integer)
        gradebook.Add("justin", 95)
        gradebook.Add("marielle", 100)
        gradebook.Add("coco", 200)

        'accessing diction
        Console.WriteLine("marielle got a grade of {0}", gradebook("marielle"))

        'remove from dictionaries
        gradebook.Remove("marielle")
        For Each grade as KeyValuePair(of String, Integer) in gradebook
            Console.WriteLine("{0} got a grade of {1}", grade.Key, grade.Value )
        Next
        'Look into LINQ
    End Sub
End Module
