using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class PipedStreamsDemo
{
    static void Main()
    {
        try
        {
            NamedPipeServerStream pipeServer =
                new NamedPipeServerStream("mypipe", PipeDirection.Out);

            NamedPipeClientStream pipeClient =
                new NamedPipeClientStream(".", "mypipe", PipeDirection.In);

            // Writer thread
            Thread writerThread = new Thread(() =>
            {
                pipeServer.WaitForConnection();
                StreamWriter writer = new StreamWriter(pipeServer);
                writer.WriteLine("Hello from Writer Thread Your Friend This Side !");
                writer.Flush();
                pipeServer.Close();
            });

            // Reader thread
            Thread readerThread = new Thread(() =>
            {
                pipeClient.Connect();
                StreamReader reader = new StreamReader(pipeClient);
                string message = reader.ReadLine();
                Console.WriteLine("Reader received: " + message);
                pipeClient.Close();
            });

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
        catch (IOException e)
        {
            Console.WriteLine("IO Error: " + e.Message);
        }
    }
}
