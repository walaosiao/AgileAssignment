using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Assignment1.ServiceReference2;
using System.Windows.Browser;


namespace Assignment1
{
    public partial class MainPage : UserControl
    {
        
        
       
        public MainPage()
        {
            InitializeComponent();
           
        }
        //private void LoadData()
        //{
        //  // ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();


        //  // client.LoadAllCompleted += new EventHandler<ServiceReference2.LoadAllCompletedEventArgs>(client_LoadAllCompleted);

        //    //client.LoadAllAsync(txtSearch.Text);

        //}
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();

            client.InsertCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(client_InsertCompleted);

            ServiceReference2.Payment pd = new ServiceReference2.Payment();


            //pd.Name = TextBox1.Text;
           // pd.Age = short.Parse(TextBox2.Text);
            pd.ReservationID = txtID.Text;
           pd.ReservationDate = txtDate.Text;
           pd.ReservationTime = txtTime.Text;
           pd.ReservationFrom = txtOrigin.Text;
           pd.ReservationTo = txtDestination.Text;
           pd.ReservationSeatNumber = txtSeatNo.Text;
           pd.ReservationTotalSeat = int.Parse(txtTotalSeat.Text);
           pd.ReservationTotalFare = Decimal.Parse(txtTotalFare.Text);
           pd.ReservationBusNumber = txtBusNo.Text;
           pd.ReservationName = txtName.Text;
           pd.ReservationPhoneNo = txtNo.Text;
           pd.ReservationIC = txtIC.Text;
           pd.PaymentAmount = txtAmt.Text;
            
            
            

           

            client.InsertAsync(pd);

        }



        void client_InsertCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

            //LoadData(); // load the data again

            System.Windows.Browser.HtmlPage.Window.Alert("Payment Successfully Made!");
            HtmlPage.Window.Navigate(new Uri("PaymentReceipt.aspx", UriKind.Relative)); 
        }


        //private void btnSearch_Click(object sender, RoutedEventArgs e)
        //{
        //    Service1Client client = new Service1Client();
        //    client.LoadAllCompleted += new EventHandler<LoadAllCompletedEventArgs>(client_LoadAllCompleted);
        //    client.LoadAllAsync(txtSearch.Text.Trim());
            


        //}
        //void client_LoadAllCompleted(object sender, ServiceReference2.LoadAllCompletedEventArgs e)
        //{

        //    label1.Content = "Loading ...";

        //    IEnumerable<ServiceReference2.Detail> list = e.Result as IEnumerable<ServiceReference2.Detail>;


        //    dataGrid1.ItemsSource = list;
        //    //TextBox1.Text = e.Result.ToString();

        //    label1.Content = "";

        //}

    
    private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
             ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
             client.LoadAllCompleted += new EventHandler<LoadAllCompletedEventArgs>(client_LoadAllCompleted);
            client.LoadAllAsync(txtSearch.Text);

        }
    void client_LoadAllCompleted(object sender, LoadAllCompletedEventArgs e)
        {

            dataGrid1.ItemsSource = e.Result;
       
        
        }

   

    
        }
}
