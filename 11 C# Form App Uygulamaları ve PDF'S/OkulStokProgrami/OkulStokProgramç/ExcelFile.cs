using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulStokProgramı
{
    public class YazdırılacakData
    {
        public string Tasinırınbulunduguyer { get; set; }
        public List<MalzemeListesi> MelzemeListesi { get; set; }


    }

    public class MalzemeListesi
    {
        public string Tanım { get; set; }
        public int Adet { get; set; }

    }




    public static class ExcelFile
    {
        public static void ExcelFileOkul(string source, string folder, string filename, YazdırılacakData yazdıracak)
        {
            var fi = new FileInfo(source);
            using (ExcelPackage objExcelPackage = new ExcelPackage(fi))
            {
                var first = objExcelPackage.Workbook.Worksheets[1];
                ExcelRange chosen = first.SelectedRange;
                first.Cells["D4"].Value = yazdıracak.Tasinırınbulunduguyer;
                int row = 7;
                foreach (var item in yazdıracak.MelzemeListesi)
                {
                    first.Cells[row, 2].Value = item.Tanım;
                    first.Cells[row, 6].Value = item.Adet;
                    row++;
                }

                var dest = getPath(folder);

                dest = $"{dest}\\{filename}";



                if (File.Exists(dest))
                    File.Delete(dest);

                //Create excel file on physical disk    
                FileStream objFileStrm = File.Create(dest);
                objFileStrm.Close();

                //Write content to excel file    
                File.WriteAllBytes(dest, objExcelPackage.GetAsByteArray());
            }
        }

        public static string getPath(string folder)

        {
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),folder);

            if (!System.IO.Directory.Exists(path))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                catch (IOException ie)
                {
                    Console.WriteLine("IO Error: " + ie.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("General Error: " + e.Message);
                }
            }

            return path;
        }
   
        public static void DatasetToExcelFile(string folder, string filename, DataSet p_dsSrc)
        {
            using (ExcelPackage objExcelPackage = new ExcelPackage())
            {
                foreach (DataTable dtSrc in p_dsSrc.Tables)
                {
                    //Create the worksheet    
                    ExcelWorksheet objWorksheet = objExcelPackage.Workbook.Worksheets.Add(dtSrc.TableName);
                    //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1    
                    objWorksheet.Cells["A1"].LoadFromDataTable(dtSrc, true);
                    objWorksheet.Cells.Style.Font.SetFromFont(new Font("Calibri", 10));
                    objWorksheet.Cells.AutoFitColumns();
                    //Format the header    
                    using (ExcelRange objRange = objWorksheet.Cells["A1:XFD1"])
                    {
                        objRange.Style.Font.Bold = true;
                        objRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        objRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        objRange.Style.Fill.BackgroundColor.SetColor(Color.Red);
                    }
                }

                var path = getPath(folder);

                path = $"{path}\\{filename}";


                //Write it back to the client    
                if (File.Exists(path))
                    File.Delete(path);

                //Create excel file on physical disk    
                FileStream objFileStrm = File.Create(path);
                objFileStrm.Close();

                //Write content to excel file    
                File.WriteAllBytes(path, objExcelPackage.GetAsByteArray());
            }
        }

        public static void OpenExcelFile(string p_strPath)
        {
            if (System.IO.File.Exists(p_strPath))
            {
                Process.Start(new ProcessStartInfo("excel.exe", " /select, " + p_strPath.Replace("\\\\", "\\")));
            }
        }


        public static void AddPictures(ExcelWorksheet ws, Image image,string name, int top, int left)
        {
            
            OfficeOpenXml.Drawing.ExcelPicture pic = ws.Drawings.AddPicture(name, image);
            //Set the postion of drawing picture  
            pic.SetPosition(top,left);
            pic.Border.LineStyle = eLineStyle.Solid;
            pic.Border.Fill.Color = Color.DarkCyan;
            //pic.Fill.Style = eFillStyle.SolidFill;
            //pic.Fill.Color = Color.White;
            //pic.Fill.Transparancy = 50;
            
        }
    }

}
