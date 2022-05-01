using MySql.Data.MySqlClient;
using OfficeOpenXml;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulStokProgramı
{
    public partial class TreeView : Form
    {
        public TreeView()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TreeView_Load(object sender, EventArgs e)
        {
            #region MainNode Oluşturma
            MySqlConnection baglanti = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand komut = new MySqlCommand("SELECT Ana_Yer_ID, Ana_Yer_Adi FROM ana_yer_tablosu", baglanti);
            try
            {
                baglanti.Open();
                MySqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TreeNode mainNode = new TreeNode(dr[1].ToString());
                    mainNode.Name = dr[0].ToString();
                    mainNode.Tag = dr[0].ToString();
                    treeView1.Nodes.Add(mainNode);
                }
                baglanti.Close();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            #region ChildNode Oluşturma
            MySqlConnection cnn = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            MySqlCommand cmd = new MySqlCommand("SELECT Ana_Yer_ID, Yer_Adi, Yer_ID FROM yer_tablosu", cnn);
            try
            {
                cnn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Name = dr[2].ToString();
                    childNode.Text = dr[1].ToString();
                    childNode.Tag = dr[0].ToString();
                    foreach (TreeNode item in treeView1.Nodes)
                    {
                        for (int i = 0; i < treeView1.Nodes.Count; i++)
                        {
                            if (childNode.Tag.ToString() == item.Tag.ToString())
                            {
                                treeView1.Nodes[int.Parse(item.Tag.ToString()) - 1].Nodes.Add(childNode);
                                break;
                            }
                        }
                    }
                }
                dr.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

        }

        int secilenAnaYerID;
        List<string> barkodString = new List<string>();
        List<string> adetler = new List<string>();
        TreeNode secilenChildNode;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            List_Malzeme.Items.Clear();
            try
            {
                secilenChildNode = treeView1.SelectedNode;
                secilenAnaYerID = Convert.ToInt32(treeView1.SelectedNode.Parent.Tag);
                MySqlConnection connect = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
                MySqlCommand command = new MySqlCommand("SELECT Malzeme_Adi, Malzeme_Adedi, BarkodString FROM okul_malzeme_tablosu WHERE Ana_Yer_ID = @AnaYerID AND Yer_ID = @yerID", connect);
                command.Parameters.AddWithValue("@AnaYerID", secilenAnaYerID);
                command.Parameters.AddWithValue("@yerID", Convert.ToInt32(secilenChildNode.Name));
                try
                {
                    connect.Open();
                    MySqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        List_Malzeme.Items.Add(dr[0].ToString());
                        barkodString.Add(dr[2].ToString());
                        adetler.Add(dr[1].ToString());
                    }
                    dr.Close();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception)
            {
                // BOŞ
            }
        }

        string resimAd;
        private void List_Malzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pic_Qr.Image = QrBuilder.QrYap(secilenChildNode.Parent.Text, secilenChildNode.Text, List_Malzeme.SelectedItem.ToString(), adetler[List_Malzeme.SelectedIndex]);
            Lbl_Adet.Text = "Adet: " + adetler[List_Malzeme.SelectedIndex];
            resimAd = secilenChildNode.Parent.Text + "_" + secilenChildNode.Text + "_" + List_Malzeme.SelectedItem.ToString() + ".jpg";
        }

        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            if (secilenChildNode.Parent != null && secilenChildNode != null)
            {
                try
                {
                    progressBar.Value += 25;
                    MySqlConnection connection = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
                    DataTable dt = new DataTable();
                    MySqlDataAdapter sorgu = new MySqlDataAdapter($"select * from okul_malzeme_tablosu WHERE Ana_Yer_ID = {int.Parse(secilenChildNode.Parent.Tag.ToString())} AND Yer_ID = {int.Parse(secilenChildNode.Name.ToString())}", connection);
                    sorgu.Fill(dt);
                    var yazdır = new YazdırılacakData();
                    progressBar.Value += 25;
                    yazdır.Tasinırınbulunduguyer = secilenChildNode.Parent.Text + " " + secilenChildNode.Text;

                    var list = new List<MalzemeListesi>();
                    foreach (DataRow item in dt.Rows)
                    {

                        var r = new MalzemeListesi();
                        r.Tanım = item["Malzeme_Adi"].ToString();
                        r.Adet = Convert.ToInt32(item["Malzeme_Adedi"]);
                        list.Add(r);

                    }
                    progressBar.Value += 25;
                    yazdır.MelzemeListesi = list;
                    try
                    {
                        progressBar.Value += 25;
                        ExcelFile.ExcelFileOkul(Application.StartupPath + @"\sablon.xlsx", "Okul Stoklar", secilenChildNode.Parent.Text + "_" + secilenChildNode.Text + ".xlsx", yazdır);
                        MessageBox.Show("Excel Masaüstündeki 'Okul Stoklar' Klasörüne Kayıt Edildi!");
                        progressBar.Value = 0;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Excel Kayıt Edilemedi!");
                    }
                    list.Clear();
                    dt.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            else if (secilenChildNode.Parent == null)
            {
                MessageBox.Show("Herhangi Bir 'Ana Yer' Seçmediniz!");
            }
            else if (secilenChildNode == null)
            {
                MessageBox.Show("Herhangi Bir 'Bölüm' Seçmediniz!");
            }
        }


        private void Btn_Qr_Yazdır_Click(object sender, EventArgs e)
        {
            string dest = Application.StartupPath + "\\qr_kodlar.xlsx";
            string pdfdest = ExcelFile.getPath("Okul Stoklar") + "\\qr_kodlar.pdf";
            MySqlConnection connection = new MySqlConnection(@"Server=94.73.148.47;Database=u8412932_bahadir;Uid=u8412932_bahadir;Pwd='RPqz76F2';");
            DataTable dt = new DataTable();
            if (secilenChildNode.Parent != null && secilenChildNode != null)
            {
                MySqlDataAdapter sorgu = new MySqlDataAdapter($"select okul_malzeme_tablosu.Malzeme_Adi, okul_malzeme_tablosu.Malzeme_Adedi, ana_yer_tablosu.Ana_Yer_Adi, yer_tablosu.Yer_Adi from okul_malzeme_tablosu inner join ana_yer_tablosu ON ana_yer_tablosu.Ana_Yer_ID = okul_malzeme_tablosu.Ana_Yer_ID inner join yer_tablosu ON yer_tablosu.Yer_ID = okul_malzeme_tablosu.Yer_ID  WHERE okul_malzeme_tablosu.Ana_Yer_ID = {int.Parse(secilenChildNode.Parent.Tag.ToString())} AND okul_malzeme_tablosu.Yer_ID = {int.Parse(secilenChildNode.Name.ToString())}", connection);
                sorgu.Fill(dt);
                progressBar.Value += 20;

                using (ExcelPackage objExcelPackage = new ExcelPackage())
                {
                    int top = 10;
                    int left = 10;
                    int sayac = 0;

                    //Create the worksheet    
                    ExcelWorksheet objWorksheet = objExcelPackage.Workbook.Worksheets.Add("Stoklar");
                    progressBar.Value += 20;

                    foreach (DataRow item in dt.Rows)
                    {
                        Image img = QrBuilder.QrYap(item["Ana_Yer_Adi"].ToString(), item["Yer_Adi"].ToString(), item["Malzeme_Adi"].ToString(), item["Malzeme_Adedi"].ToString());
                        ExcelFile.AddPictures(objWorksheet, img, $"{item["Ana_Yer_Adi"]}_{item["Yer_Adi"]}_{item["Malzeme_Adi"]}", top, left);
                        left += 200;
                        sayac++;
                        if (sayac == 5)
                        {
                            sayac = 0;
                            left = 10;
                            top += 200;
                        }
                        objWorksheet.Cells.AutoFitColumns();
                    }
                    progressBar.Value += 20;
                    if (File.Exists(dest))
                        File.Delete(dest);

                    //Create excel file on physical disk    
                    FileStream objFileStrm = File.Create(dest);
                    objFileStrm.Close();

                    //Write content to excel file    
                    File.WriteAllBytes(dest, objExcelPackage.GetAsByteArray());
                    progressBar.Value += 20;
                }
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(dest);
                workbook.SaveToFile(pdfdest, Spire.Xls.FileFormat.PDF);
                progressBar.Value += 20;
                if (progressBar.Value == 100)
                {
                    MessageBox.Show("QR Kodlar Masaüstündeki 'Okul Stoklar' Klasörüne PDF Olarak Kayıt Edildi!");
                    progressBar.Value = 0;
                }
            }
            else if (secilenChildNode.Parent == null)
            {
                MessageBox.Show("Herhangi Bir 'Ana Yer' Seçmediniz!");
            }
            else if (secilenChildNode == null)
            {
                MessageBox.Show("Herhangi Bir 'Bölüm' Seçmediniz!");
            }
        }
    }
}
