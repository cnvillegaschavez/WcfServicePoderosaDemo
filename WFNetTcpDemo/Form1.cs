using System;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace WFNetTcpDemo
{
    public partial class Form1 : Form
    {
        WCFPersonService.PersonServiceClient personServiceClient;
        public Form1()
        {
            InitializeComponent();
            personServiceClient = new WCFPersonService.PersonServiceClient();
        }

        private void BtnGetPerson_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtPersonId.Text, out int personId);
            var person = personServiceClient.GetPersonById(personId);
            if (person != null)
            {
                LblName.Text = person.Name;
            }
            else
                MessageBox.Show("No existe un registro con Id:" + personId);
        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            TransactionScope scope;
            scope = new TransactionScope(TransactionScopeOption.Required, TimeSpan.FromSeconds(60));

            var origin = new WCFPersonService.Account() { Number = "501114444" };
            var destination = new WCFPersonService.Account() { Number = "601114444" };
            var response = personServiceClient.Transfer1(origin, destination, 1200);

            origin.Number = "701114444";
            destination.Number = "801114444";
            response = personServiceClient.Transfer2(origin, destination, 5000);

            scope.Complete();
            
        }
    }
}
