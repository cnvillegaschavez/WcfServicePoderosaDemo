using Topshelf;

namespace ConsoleAppWCFNetTcpDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rc = HostFactory.Run(x =>                                   
            {
                x.Service<ServicesServer>(s =>                              
                {
                    s.ConstructUsing(name => new ServicesServer());         
                    s.WhenStarted(tc => tc.Start());                        
                    s.WhenStopped(tc => tc.Stop());                         
                });
                x.RunAsLocalSystem();

                x.SetDescription("ConsoleAppWCFNetTcpDemo");
                x.SetDisplayName("ConsoleAppWCFNetTcpDemo");                                  //8
                x.SetServiceName("ConsoleAppWCFNetTcpDemo");                                  //9
            });
        }
    }
}
