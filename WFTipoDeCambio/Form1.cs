using HtmlAgilityPack;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WFTipoDeCambio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData(string mes, string anio)
        {
            string sUrl = "http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias?mes="+mes+"&anho="+anio;

            Encoding objEncoding = Encoding.GetEncoding("ISO-8859-1");
            //WebProxy objWebProxy = new WebProxy("proxy", 80);
            CookieCollection objCookies = new CookieCollection();

            //USANDO GET
            HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(sUrl);
            //getRequest.Proxy = objWebProxy;
            getRequest.Credentials = CredentialCache.DefaultNetworkCredentials;
            getRequest.ProtocolVersion = HttpVersion.Version11;
            getRequest.UserAgent = ".NET Framework 4.0";
            getRequest.Method = "GET";

            getRequest.CookieContainer = new CookieContainer();
            getRequest.CookieContainer.Add(objCookies);

            string sGetResponse = string.Empty;

            using (HttpWebResponse getResponse = (HttpWebResponse)getRequest.GetResponse())
            {
                objCookies = getResponse.Cookies;

                using (StreamReader srGetResponse = new StreamReader(getResponse.GetResponseStream(), objEncoding))
                {
                    sGetResponse = srGetResponse.ReadToEnd();
                }
            }

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(sGetResponse);

            HtmlNodeCollection NodesTr = document.DocumentNode.SelectNodes("//table[@class='class=\"form-table\"']//tr");
            if (NodesTr != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Día", typeof(String));
                dt.Columns.Add("Compra", typeof(String));
                dt.Columns.Add("Venta", typeof(String));

                int iNumFila = 0;
                foreach (HtmlNode Node in NodesTr)
                {
                    if (iNumFila > 0)
                    {
                        int iNumColumna = 0;
                        DataRow dr = dt.NewRow();
                        foreach (HtmlNode subNode in Node.Elements("td"))
                        {

                            if (iNumColumna == 0) dr = dt.NewRow();

                            string sValue = subNode.InnerHtml.ToString().Trim();
                            sValue = System.Text.RegularExpressions.Regex.Replace(sValue, "<.*?>", " ");
                            dr[iNumColumna] = sValue;

                            iNumColumna++;

                            if (iNumColumna == 3)
                            {
                                dt.Rows.Add(dr);
                                iNumColumna = 0;
                            }
                        }
                    }
                    iNumFila++;
                }

                dt.AcceptChanges();
                this.dgResult.DataSource = dt;
                this.dgResult.ReadOnly = true;

            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoadData(nMes.Value.ToString(), nAnio.Value.ToString());
        }
    }
}
