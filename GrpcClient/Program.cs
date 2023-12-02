using Grpc.Net.Client;
using GrpcServer;
using System;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var input = new HelloRequest { Name = "Magnus"};

            //var channel = GrpcChannel.ForAddress("https://localhost:7098");
            //var client = new Greeter.GreeterClient(channel);

            //var reply = await client.SayHelloAsync(input);

            //Console.WriteLine(reply.Message);

            var channel = GrpcChannel.ForAddress("https://localhost:7098");
            var customerClient = new Customer.CustomerClient(channel);

            var reply = await customerClient.GetCustomerInfoAsync();

            Console.ReadLine();
        }
    }
}






