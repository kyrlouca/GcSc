Imports System
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.FileIO.FileSystem



Module Program
    Sub Main(args As String())

        'streams are more efficient and they are standard in vb languages.
        'FileStreams deal with bytes, so we need ReadStreams and WriteStreams which use the filestreams
        'dot net stream readers try to guess the encoding, but you could actually specify the encoding

        Const filePath = "C:\Users\kyrlo\OneDrive\Documents\TestFile.txt"
        Console.WriteLine("Hello File Manipulation!")


        'Function from File.IO, reads  text and closes the file
        'you can ommit encoding 
        Console.WriteLine("Read all text")
        Dim fileText = ReadAllText(filePath, Encoding.UTF8)
        Console.WriteLine(fileText)


        'Using a Stream to read line by line
        'this is a static method, which creates a reader, and we do not use new
        Console.WriteLine("Line By Line " + "/n")
        Dim fileReader = File.OpenText(filePath)
        While Not fileReader.EndOfStream
            Dim line = fileReader.ReadLine()
            Console.WriteLine("line " & line)
        End While


        'Using a Stream to read char by char (a char may have more than one bytes in Unicode 1-4 bytes for UTF8 )
        Console.WriteLine("char by char")
        Dim sr = New StreamReader(filePath, Encoding.UTF8)

        While Not sr.EndOfStream
            Dim ch = sr.Read()
            Dim chrx = ChrW(ch)
            Console.Write(chrx)
        End While


        'create a parser using New. the parser has attributes and methods such as ReadFields()
        Using MyReader As New FileIO.TextFieldParser("C:\Users\kyrlo\OneDrive\Documents\TestFile.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        Console.WriteLine(currentField)
                    Next
                Catch ex As FileIO.MalformedLineException
                    Console.WriteLine("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using


        '***********************************************************
        Const filePath2 = "C:\Users\kyrlo\OneDrive\Documents\WriteFile.txt"

        'write an array to a file 
        IO.File.WriteAllLines(filePath2, {"a", "b"})


        'using a streamWriter
        Using fw As New System.IO.StreamWriter(filePath2, False, Encoding.UTF8)
            fw.WriteLine("hello")
        End Using





    End Sub
End Module
