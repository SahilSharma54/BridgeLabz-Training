using NUnit.Framework;
using System;
using System.IO;

[TestFixture]
public class FileProcessorTests
{
    string filePath = "test.txt";
    FileProcessor processor;

    [SetUp]
    public void Setup()
    {
        processor = new FileProcessor();
    }

    [Test]
    public void Write_And_Read_File_Test()
    {
        processor.WriteToFile(filePath, "Hello");
        string result = processor.ReadFromFile(filePath);
        Assert.AreEqual("Hello", result);
    }

    [Test]
    public void File_Not_Found_Exception_Test()
    {
        Assert.Throws<FileNotFoundException>(() => processor.ReadFromFile("nofile.txt"));
    }
}
