using System;
using System.Windows;
using System.Windows.Controls;

namespace WetterAPI_Client
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string queryString = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Menu_1_Sub_Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Schließen?", "Beenden",
                            MessageBoxButton.YesNo,
                            MessageBoxImage.Question,
                            MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Test erfolgreich :)");
        }

        private void Btn_Datenabfragen_Click(object sender, RoutedEventArgs e)
        {
            if (Cal.SelectedDates.Count > 0)
            {
                DateTime date = Cal.SelectedDate.Value;
                
                int day;
                int month;
                int year;
                day = date.Day;
                month = date.Month;
                year = date.Year;

                queryString = "date" + "/" + year + "/" + month + "/" + day;
                titlechange(CreateRequest(queryString));
            }
        }

        private void titlechange(object urlRequest)
        {
            this.Title = urlRequest.ToString();
        }

        public static string CreateRequest(string queryString)
        {
            string UrlRequest = "http://192.168.178.20:5000/api/" +
                                 queryString;
            return (UrlRequest);
        }

        /*
        public static Response MakeRequest(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format(
                        "Server error (HTTP {0}: {1}).",
                        response.StatusCode,
                        response.StatusDescription));
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    Response jsonResponse
                    = objResponse as Response;
                    return jsonResponse;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        */


        /*
        private void callApi()
        {
            WebClient webClient = new WebClient();
            dynamic result = JsonValue.Parse(webClient.DownloadString("http://192.168.178.20:5000/api/now"));
            Console.WriteLine(result.response);
        }

        */

        private void ComboBox_AuswahlDaten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Calender_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            /* var calendar = sender as Calendar;

            if (calendar.SelectedDate.HasValue)
            {
                // Display SelectedDate in Title
                DateTime date = calendar.SelectedDate.Value;
                this.Title = date.ToShortDateString();
            } 
            */
        }

    }
}
