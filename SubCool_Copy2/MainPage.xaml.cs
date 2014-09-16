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
using Microsoft.Phone.Controls;

namespace SubCool
{



    public partial class MainPage : PhoneApplicationPage
    {        
        
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
     
         
           
        
        
        
        
        }

       
        Decimal Rfactor;
        
        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();

            }
        }  
        
        

     
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            Decimal answer;
             Decimal high , low , gas;
          try  {
            high = Convert.ToInt32(textBox1.Text);
            low = Convert.ToInt32(textBox2.Text);
            gas = Rfactor;
           answer   = (high - low - (gas));

            
           textBox3.Text = (answer.ToString());
        }
        catch (FormatException )
          {
              MessageBox.Show("The input details are invalid!");
        
        
        }
          catch (OverflowException )
            {



                MessageBox.Show("The input details are invalid!");
            }



        }
        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {





            Rfactor = (int) 39.332; //if true assigns it's text to a variable.



        }
        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {





            Rfactor = (int) 4.333; //if true assigns it's text to a variable.



        }
        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {



            
            
                Rfactor = (int) 3.325; //if true assigns it's text to a variable.



            }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal width, length, area, smallW, largeW, btusW, btus;
            largeW = Convert.ToInt32(textBox7.Text);


            try
            {
                smallW = Convert.ToInt32(textBox6.Text);
                length = Convert.ToInt32(lengthTF.Text);
                width = Convert.ToInt32(widthTF.Text);
                area = length * width;
                btusW = ((smallW * 500) + largeW * 1500);
                btus = area * 100 + btusW;

                btusTF.Text = (btus.ToString());
            }
            catch (FormatException )
            {
               
              MessageBox.Show("The input details are invalid!");

            }
            catch (Exception )
            {



                MessageBox.Show("The input details are invalid!");
            }


        }


    
      

        private void Temperaturetohigh_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox4.Text = ("1.Controls temp to high                   2.Blocked return air                3.Improper cooling coil                    4.Wrong size expansion valve");

            textBox5.Text = ("1.Reset controls                         2.Unblock or add air to return                        3.Resize cooling coil                4.Resize expansion valve");

        }

        private void noisySystem_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox4.Text = ("");
            textBox4.Text = ("1.Unfasened bolts and screws                        2.Bent or Loose fan blade                  3.Loose Tubing                             4.Worn out fan motor");
            textBox5.Text = ("");
            textBox5.Text = ("1.locate and secure                  2.Replace or tighten                    3.Secure or reform tubing                       4.Replace motor ");
        }

        private void Compresorstart_GotFocus(object sender, RoutedEventArgs e)
        {       
            textBox4.Text = ("1.Wired incorrectly                             2.Low voltage                                     3.Faulty relay                              4.Faulty capacitor                          5.Excess suction pressure                                 6.Shorted or open winding                          7.Compressor mechanical trouble ");

            textBox5.Text = ("1. Check wiring                                2.Check wiring to system                           3.Replace relay                               4.Replace Capacitor                                5.Check air flow to cooling coil or valve placement and refrigerant levels                          6.Check wiring to compressor                 7.Replace compressor ");
        }

        private void Compshort_GotFocus(object sender, RoutedEventArgs e)
        {
        
         textBox4.Text = ("1.Cross current overload before protector                                     2.Incorect voltage or phase to unit                               3.Defective parts  protector /capacitor or start windings                         4.Low side presser to high                          5.Compressor to hot  ");

            textBox5.Text = ("1.Check wiring Diagram for changes or added equipment                          2.Check wiring to system                          3. Replace protector /capacitor or start windings                                      4.Check for restrictions on refrigerant and inside air system                       5.Check for leak and fix / clean unit.");
        }

        private void Frostylowside_GotFocus(object sender, RoutedEventArgs e)
        { textBox4.Text = ("1.TX valve oversized or passing refrigerant                                         2.Evap fan not running                                  3. too much refrigerant");

            textBox5.Text = ("1.Replace or a just valve                              2.Replace fan                              3.Bleed excess refrigerant into a qualifide container");
        }

        private void FrostyLiquidLine_GotFocus(object sender, RoutedEventArgs e)
        {
        
        
            textBox4.Text = ("1.Restriction in filter                           2.King valve stuck closed");

            textBox5.Text = ("1.Replace filter                           2.Open valve");
        }

        private void Compresornostop_GotFocus(object sender, RoutedEventArgs e)
        {                  textBox4.Text = ("1.Misswired                                    2.Low voltage                                             3.Relay stuck                                                             4.Faulty capacitor                                                              5.Excessive high side pressure                                6.Short in windings                            7.Internal compressor problems");


            textBox5.Text = ("1.Check diagram                              2.Check wiring to unit                                 3.Replace relay                              4.Replace capacitor                               5.Bleed refrigerant into a qualified container                                     6.Replace compressor           7.Replace compressor");



        }

        private void Compresornostart_GotFocus(object sender, RoutedEventArgs e)
        {
         textBox4.Text = ("1.Line disconnect switch open                                             2.Fautly wiring/blown fuse                            3.Start capacitor defective                            4. Controls stuck                                                        5. Relay defective                                      6.Compressor internal problems                             7.liqud in compressor                            8.Too cold location ");

            textBox5.Text = ("1.Close disconnect                            2.Check diagram                            3.Replace Start capacitor                            4.Replace control                            5.Replace relay                            6.Replace compressor                             7.Add accumulator                            8.Add crank case heater or relocate unit");
       
        }
        
        }

        }
 
    
    
    
    
    
    
    
    
