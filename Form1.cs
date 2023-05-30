using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace Practice
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();         

        }
      
        public void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Target_WC_Combobox.Items.Add("ERICSSON");
            Target_WC_Combobox.Items.Add("GRASSVALL");
        }




        private void button1_Click(object sender, EventArgs e)
        {
            String target_WC;
            try {           
            target_WC = Target_WC_Combobox.SelectedItem.ToString();
            }
            catch { MessageBox.Show("Nem adtál meg Workcellt!"); return; }

          


            String Aging_file_location;          
            openFileDialog1.Title = "Select Aging file";
            openFileDialog1.InitialDirectory = @"G:\!JOS\MRB\2023\Raktár\Aging";
            openFileDialog1.ShowDialog();
            Aging_file_location = openFileDialog1.FileName;
            // Init reserves

            double MRB_No_reserve = 0;
            double RTC_No_reserve = 0;
            double RTV_No_reserve = 0;

            double MRB_100 = 0;

            double RTV_50 = 0;
            double RTV_100 = 0;

            double RTC_30 = 0;
            double RTC_50 = 0;
            double RTC_100 = 0;


            Loaded_file_label.Text = Aging_file_location;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorksheet;
          
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(Aging_file_location,Type.Missing,true,Type.Missing,Type.Missing,Type.Missing,true,Type.Missing,Type.Missing,Type.Missing,true);
            xlWorksheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item("Sheet1");

            int Progress_counter_max = 1;
     
            while (xlWorksheet.Cells[Progress_counter_max, 2].Value2 != null)
            {
                Progress_counter_max = Progress_counter_max + 1;
            }

            //MessageBox.Show( Convert.ToString(Progress_counter_max));

            progressBar1.Minimum = 0;
            progressBar1.Maximum = Progress_counter_max;
            progressBar1.Step = 1;

            //RAWDATA datagrid
            RAWDATA.ColumnCount = 10;
            RAWDATA.Columns[0].Name = "Material Group";
            RAWDATA.Columns[1].Name = "Material";
            RAWDATA.Columns[2].Name = "Material description";
            RAWDATA.Columns[3].Name = "Notification";
            RAWDATA.Columns[4].Name = "Description";
            RAWDATA.Columns[5].Name = "Days open";
            RAWDATA.Columns[6].Name = "Qty";
            RAWDATA.Columns[7].Name = "Value";
            RAWDATA.Columns[8].Name = "Aging end of month";
            RAWDATA.Columns[9].Name = "Type";

            //MRB 100% datagrid
            MRB100.ColumnCount = 10;
            MRB100.Columns[0].Name = "Material Group";
            MRB100.Columns[1].Name = "Material";
            MRB100.Columns[2].Name = "Material description";
            MRB100.Columns[3].Name = "Notification";
            MRB100.Columns[4].Name = "Description";
            MRB100.Columns[5].Name = "Days open";
            MRB100.Columns[6].Name = "Qty";
            MRB100.Columns[7].Name = "Value";
            MRB100.Columns[8].Name = "Aging end of month";
            MRB100.Columns[9].Name = "Type";

            //RTV 50 % datagrid
            RTV50.ColumnCount = 10;
            RTV50.Columns[0].Name = "Material Group";
            RTV50.Columns[1].Name = "Material";
            RTV50.Columns[2].Name = "Material description";
            RTV50.Columns[3].Name = "Notification";
            RTV50.Columns[4].Name = "Description";
            RTV50.Columns[5].Name = "Days open";
            RTV50.Columns[6].Name = "Qty";
            RTV50.Columns[7].Name = "Value";
            RTV50.Columns[8].Name = "Aging end of month";
            RTV50.Columns[9].Name = "Type";

            //RTV 100 % datagrid
            RTV100.ColumnCount = 10;
            RTV100.Columns[0].Name = "Material Group";
            RTV100.Columns[1].Name = "Material";
            RTV100.Columns[2].Name = "Material description";
            RTV100.Columns[3].Name = "Notification";
            RTV100.Columns[4].Name = "Description";
            RTV100.Columns[5].Name = "Days open";
            RTV100.Columns[6].Name = "Qty";
            RTV100.Columns[7].Name = "Value";
            RTV100.Columns[8].Name = "Aging end of month";
            RTV100.Columns[9].Name = "Type";

            //RTC 30 % datagrid
            RTC30.ColumnCount = 10;
            RTC30.Columns[0].Name = "Material Group";
            RTC30.Columns[1].Name = "Material";
            RTC30.Columns[2].Name = "Material description";
            RTC30.Columns[3].Name = "Notification";
            RTC30.Columns[4].Name = "Description";
            RTC30.Columns[5].Name = "Days open";
            RTC30.Columns[6].Name = "Qty";
            RTC30.Columns[7].Name = "Value";
            RTC30.Columns[8].Name = "Aging end of month";
            RTC30.Columns[9].Name = "Type";

            //RTC 50 % datagrid
            RTC50.ColumnCount = 10;
            RTC50.Columns[0].Name = "Material Group";
            RTC50.Columns[1].Name = "Material";
            RTC50.Columns[2].Name = "Material description";
            RTC50.Columns[3].Name = "Notification";
            RTC50.Columns[4].Name = "Description";
            RTC50.Columns[5].Name = "Days open";
            RTC50.Columns[6].Name = "Qty";
            RTC50.Columns[7].Name = "Value";
            RTC50.Columns[8].Name = "Aging end of month";
            RTC50.Columns[9].Name = "Type";

            //RTC 100 % datagrid

            RTC100.ColumnCount = 10;
            RTC100.Columns[0].Name = "Material Group";
            RTC100.Columns[1].Name = "Material";
            RTC100.Columns[2].Name = "Material description";
            RTC100.Columns[3].Name = "Notification";
            RTC100.Columns[4].Name = "Description";
            RTC100.Columns[5].Name = "Days open";
            RTC100.Columns[6].Name = "Qty";
            RTC100.Columns[7].Name = "Value";
            RTC100.Columns[8].Name = "Aging end of month";
            RTC100.Columns[9].Name = "Type";

            // Create Summary sheet
            Summary.ColumnCount = 6;
            Summary.Columns[0].Name = "Storage type";
            Summary.Columns[1].Name = "No reserve";
            Summary.Columns[2].Name = "3 month";
            Summary.Columns[3].Name = "6 month";
            Summary.Columns[4].Name = "9 month";
            Summary.Columns[5].Name = "SUM";

            int count = 2;
            
            
        
            string current_day= DateTime.Today.ToString("dd");
            int Remaining_day_int = 31-Convert.ToInt32(current_day);

            // Get column indexes
            int colpos = 1;
            int pos_Matl_group = 0;
            int pos_Material = 0;
            int pos_Material_description = 0;
            int pos_Notification = 0;
            int pos_Decription = 0;
            int pos_Days_Open = 0;
            int pos_Value = 0;
            int pos_qty = 0;


            while (xlWorksheet.Cells[1, colpos].Value2 != null || colpos <= 20)
            {
                if(xlWorksheet.Cells[1, colpos].Value2 == "Matl group")
                {
                    pos_Matl_group = colpos;
                }

                if (xlWorksheet.Cells[1, colpos].Value2 == "Material")
                {
                    pos_Material = colpos;
                }

                if (xlWorksheet.Cells[1, colpos].Value2 == "Material description")
                {
                    pos_Material_description = colpos;
                }

                if (xlWorksheet.Cells[1, colpos].Value2 == "Notification")
                {
                    pos_Notification = colpos;
                }

                if (xlWorksheet.Cells[1, colpos].Value2 == "Description")
                {
                    pos_Decription = colpos;
                }

                if (xlWorksheet.Cells[1, colpos].Value2 == "DAYS OPEN")
                {
                    pos_Days_Open = colpos;
                }

                if (xlWorksheet.Cells[1, colpos].Value2 == "Value")
                {
                    pos_Value = colpos;
                }

                if (xlWorksheet.Cells[1, colpos].Value2 == "Cmplnt Qty" )
                {
                    int x;
                    bool check_num = Int32.TryParse(Convert.ToString(xlWorksheet.Cells[2, colpos].Value2), out x);
                    if (check_num)
                    {
                        pos_qty = colpos;
                    }
                }

                colpos++;
            }
     
            // Loop through the blocked stock lines
            while (xlWorksheet.Cells[count, pos_Matl_group].Value2 != null)
            {
                progressBar1.PerformStep();

                if (xlWorksheet.Cells[count, pos_Matl_group].Value2== target_WC) {

                  
                    string Desc_field = Convert.ToString(xlWorksheet.Cells[count, pos_Decription].Value2);
                    char Last_char_of_desc_field = Desc_field.ElementAt(Desc_field.Length-1);

                   
                RAWDATA.Rows.Add(
                    Convert.ToString(xlWorksheet.Cells[count, pos_Matl_group].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material_description].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Notification].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Decription].Value2),
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Days_Open].Value2), // Days Open oszlop
                    Convert.ToString(xlWorksheet.Cells[count, pos_qty].Value2), //Cmplnt qty
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Value].Value2),
                    Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2)+ Remaining_day_int+1),
                    Last_char_of_desc_field);


                    //Fill MRB 100 % 

                    if ((Last_char_of_desc_field == Convert.ToChar("D") || Last_char_of_desc_field == Convert.ToChar("S") || Last_char_of_desc_field == Convert.ToChar("L")) && (Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) > 90))
                    {
                        MRB100.Rows.Add(
                   Convert.ToString(xlWorksheet.Cells[count, pos_Matl_group].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material_description].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Notification].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Decription].Value2),
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Days_Open].Value2), // Days Open oszlop
                    Convert.ToString(xlWorksheet.Cells[count, pos_qty].Value2), //Cmplnt qty
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Value].Value2),
                    Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1),
                    Last_char_of_desc_field);

                        MRB_100 = MRB_100 + Convert.ToDouble(xlWorksheet.Cells[count, pos_Value].Value2);
                    }


                    //RTV 50 % ( > 90 de <= 270

                    if (Last_char_of_desc_field == Convert.ToChar("V") & ((Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) > 90) & 
                        Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) <= 270))
                    {
                        RTV50.Rows.Add(
                    Convert.ToString(xlWorksheet.Cells[count, pos_Matl_group].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material_description].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Notification].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Decription].Value2),
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Days_Open].Value2), // Days Open oszlop
                    Convert.ToString(xlWorksheet.Cells[count, pos_qty].Value2), //Cmplnt qty
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Value].Value2),
                    Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1),
                    Last_char_of_desc_field);

                        RTV_50 = RTV_50 + Convert.ToDouble(xlWorksheet.Cells[count, pos_Value].Value2);
                    }


                    // RTV 100%

                    if (Last_char_of_desc_field == Convert.ToChar("V") & (Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) > 270))
                    {
                        RTV100.Rows.Add(
                    Convert.ToString(xlWorksheet.Cells[count, pos_Matl_group].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material_description].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Notification].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Decription].Value2),
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Days_Open].Value2), // Days Open oszlop
                    Convert.ToString(xlWorksheet.Cells[count, pos_qty].Value2), //Cmplnt qty
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Value].Value2),
                    Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1),
                    Last_char_of_desc_field);

                        RTV_100 = RTV_100 + Convert.ToDouble(xlWorksheet.Cells[count, pos_Value].Value2);

                    }


                    // RTC 30%

                    if (Last_char_of_desc_field == Convert.ToChar("C") & ((Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) > 90) &
                        Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) <= 180))
                    {
                        RTC30.Rows.Add(
                  Convert.ToString(xlWorksheet.Cells[count, pos_Matl_group].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material_description].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Notification].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Decription].Value2),
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Days_Open].Value2), // Days Open oszlop
                    Convert.ToString(xlWorksheet.Cells[count, pos_qty].Value2), //Cmplnt qty
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Value].Value2),
                    Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1),
                    Last_char_of_desc_field);

                        RTC_30 = RTC_30 + Convert.ToDouble(xlWorksheet.Cells[count, pos_Value].Value2);
                    }



                    // RTC 50% 

                    if (Last_char_of_desc_field == Convert.ToChar("C") & ((Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) > 180) &
                           Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) <= 270))
                    {
                        RTC50.Rows.Add(
                  Convert.ToString(xlWorksheet.Cells[count, pos_Matl_group].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material_description].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Notification].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Decription].Value2),
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Days_Open].Value2), // Days Open oszlop
                    Convert.ToString(xlWorksheet.Cells[count, pos_qty].Value2), //Cmplnt qty
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Value].Value2),
                    Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1),
                    Last_char_of_desc_field);

                        RTC_50 = RTC_50 + Convert.ToDouble(xlWorksheet.Cells[count, pos_Value].Value2);
                    }


                    // RTC 100 % 
                    if (Last_char_of_desc_field == Convert.ToChar("C") & ((Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) > 270)))
                    {
                        RTC100.Rows.Add(
                    Convert.ToString(xlWorksheet.Cells[count, pos_Matl_group].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Material_description].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Notification].Value2),
                    Convert.ToString(xlWorksheet.Cells[count, pos_Decription].Value2),
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Days_Open].Value2), // Days Open oszlop
                    Convert.ToString(xlWorksheet.Cells[count, pos_qty].Value2), //Cmplnt qty
                    Convert.ToInt32(xlWorksheet.Cells[count, pos_Value].Value2),
                    Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1),
                    Last_char_of_desc_field);

                        RTC_100 = RTC_100 + Convert.ToDouble(xlWorksheet.Cells[count, pos_Value].Value2);
                    }


                    // Fill_No_reserves

                    if ((Last_char_of_desc_field == Convert.ToChar("D") || Last_char_of_desc_field == Convert.ToChar("S") || Last_char_of_desc_field == Convert.ToChar("L")) && ((Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) <= 90)))
                    { 
                        MRB_No_reserve = MRB_No_reserve + Convert.ToDouble(xlWorksheet.Cells[count, pos_Value].Value2);
                    }


                    if (Last_char_of_desc_field == Convert.ToChar("V") & ((Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) <= 90)))
                    {

                        RTV_No_reserve = RTV_No_reserve + Convert.ToDouble(xlWorksheet.Cells[count, pos_Value].Value2);
                    }

                    if (Last_char_of_desc_field == Convert.ToChar("C") & ((Convert.ToInt32((xlWorksheet.Cells[count, pos_Days_Open].Value2) + Remaining_day_int + 1) <= 90)))
                    {
                        RTC_No_reserve = RTC_No_reserve + Convert.ToDouble(xlWorksheet.Cells[count, pos_Value].Value2);

                    }
                }

                count =count+1;                                          
            }

            // Add summary results

            Summary.Rows.Add("MRB", MRB_No_reserve, MRB_100,"","", MRB_100);

            Summary.Rows.Add("RTC", RTC_No_reserve, RTC_30, RTC_50, RTC_100, ((RTC_30*0.3)+ (RTC_50*0.5)+ RTC_100));

            Summary.Rows.Add("RTV", RTV_No_reserve, RTV_50,"3 hónapos tartalmazza",RTV_100, ((RTV_50*0.5)+ RTV_100));

            Summary.Rows.Add("SUM", "", "", "", "",  MRB_100+ RTC_100+ (RTC_30 * 0.3) + (RTC_50 * 0.5) + (RTV_50 * 0.5) + RTV_100);


            

            xlWorkBook.Close(true);
            xlApp.Quit();

          //  x: 

        }
    }
}
