using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht01
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        // Let's make a "Clear"-button work
        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            int nolla = 0;
            textBlockTulokset.Text = nolla.ToString("0");

        }

        private void buttonDraw_Click(object sender, RoutedEventArgs e)
        {
            Lotto kone = new Lotto();
            int kymppi = 10;
            textBlockTulokset.Text = textBlockTulokset.Text + "  " + kymppi.ToString("0");
            
            
            /*  OHJELMA KAATUU KUN OTTAA kone.Arvonta(); methodin mukaan
           kone.Arvonta();

          List<int> lista;
          int number = kone.numero;
          lista = kone.valmislista;
          int abba;
          int kymppi = 10;
          string merkkijono;

          merkkijono = lista[0].ToString("0.0");

          // abba = lista[0];

          //    textBoxDraws.Text = merkkijono;







          /*
           * 
           *  lista.ForEachRow(textBlockTulokset + lista.ToString(row));
             foreach (int int kone.valmislista)

              kone.valmislista.ForEach(row => textBlockTulokset + ToString(row));

          int i = 0;
          for (i = 0; i < kone.valmislista.Length; i++)     // For-silmukka
          {

               *  foreach (Person person in persons)
          {
              Console.WriteLine(person.ToString());
          }
              textBlockTulokset = kone.valmislista;
              list.ForEach(item => Console.Write(item + ","));

      */



        }
    }
}
