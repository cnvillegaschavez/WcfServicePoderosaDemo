using ConsoleAppWCFNetTcpDemo.Services;
using System.ServiceModel;

namespace ConsoleAppWCFNetTcpDemo
{
    public class ServicesServer
    {
        private ServiceHost PersonService;
        public void Start()
        {
            if (PersonService != null)
                PersonService.Close();
            PersonService = new ServiceHost(typeof(PersonService));            
            PersonService.Open();
        }

        public void Stop()
        {
            if (PersonService != null)
            {
                if (PersonService.State != CommunicationState.Faulted)
                {
                    PersonService.Close();
                }
                PersonService = null;
            }
        }
    }
}
