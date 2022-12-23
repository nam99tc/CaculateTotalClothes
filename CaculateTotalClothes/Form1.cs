﻿using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CaculateTotalClothes
{
    public partial class Form1 : Form
    {
        public BindingSource mBindingSource;
        public List<Result> dataFilter = new List<Result>();

        public Form1()
        {
            InitializeComponent();
        }
        private void chooseFIle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file
            if (file.ShowDialog() == DialogResult.OK) //if there is a file chosen by the user
            {
                string fileExt = Path.GetExtension(file.FileName); //get the file extension
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        List<Products> products = new List<Products>();
                        Type typeOfObject = typeof(Products);
                        using (IXLWorkbook workbook = new XLWorkbook(file.FileName))
                        {
                            var workShaeet = workbook.Worksheets.Select(x => x.Name).ToList();
                            //var workSheet = workbook.Worksheets.Where(x => x.Name == "VNKS (1.11)").First();
                            var workSheet = workbook.Worksheets.Skip(1).First();
                            var properties = typeOfObject.GetProperties();
                            var columns = workSheet.Row(3).Cells().Select((v, i) => new { Value = v.Value, Index = i + 1 });

                            foreach (IXLRow row in workSheet.RowsUsed().Skip(13))
                            {
                                try
                                {
                                    Products obj = (Products)Activator.CreateInstance(typeOfObject);
                                    foreach (var prop in properties)
                                    {
                                        if (prop.Name.ToString() == "Size")
                                        {
                                            int colIndexSize = columns.SingleOrDefault(x => x.Value.ToString().ToLower().Contains(prop.Name.ToString().ToLower())).Index;
                                            Size size = new Size();
                                            size.XXXS = string.IsNullOrEmpty(row.Cell(colIndexSize).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize).Value);
                                            size.XXS = string.IsNullOrEmpty(row.Cell(colIndexSize + 1).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 1).Value);
                                            size.XS = string.IsNullOrEmpty(row.Cell(colIndexSize + 2).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 2).Value);
                                            size.S = string.IsNullOrEmpty(row.Cell(colIndexSize + 3).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 3).Value);
                                            size.M = string.IsNullOrEmpty(row.Cell(colIndexSize + 4).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 4).Value);
                                            size.L = string.IsNullOrEmpty(row.Cell(colIndexSize + 5).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 5).Value);
                                            size.XL = string.IsNullOrEmpty(row.Cell(colIndexSize + 6).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 6).Value);
                                            size.XXL = string.IsNullOrEmpty(row.Cell(colIndexSize + 7).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 7).Value);
                                            size.XXXSP = string.IsNullOrEmpty(row.Cell(colIndexSize + 8).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 8).Value);
                                            size.P = string.IsNullOrEmpty(row.Cell(colIndexSize + 9).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 9).Value);
                                            size.XXSP = string.IsNullOrEmpty(row.Cell(colIndexSize + 10).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 10).Value);
                                            size.XSP = string.IsNullOrEmpty(row.Cell(colIndexSize + 11).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 11).Value);
                                            size.SP = string.IsNullOrEmpty(row.Cell(colIndexSize + 12).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 12).Value);
                                            size.MP = string.IsNullOrEmpty(row.Cell(colIndexSize + 13).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 13).Value);
                                            size.LP = string.IsNullOrEmpty(row.Cell(colIndexSize + 14).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 14).Value);
                                            size.XLP = string.IsNullOrEmpty(row.Cell(colIndexSize + 15).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 15).Value);
                                            size.XXLP = string.IsNullOrEmpty(row.Cell(colIndexSize + 16).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 16).Value);
                                            size.XSS = string.IsNullOrEmpty(row.Cell(colIndexSize + 17).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 17).Value);
                                            size.SM = string.IsNullOrEmpty(row.Cell(colIndexSize + 18).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 18).Value);
                                            size.ML = string.IsNullOrEmpty(row.Cell(colIndexSize + 19).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 19).Value);
                                            size.LXL = string.IsNullOrEmpty(row.Cell(colIndexSize + 20).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 20).Value);
                                            size.NoSize = string.IsNullOrEmpty(row.Cell(colIndexSize + 21).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndexSize + 21).Value);
                                            prop.SetValue(obj, size);
                                        }
                                        else if (prop.Name.ToString() == "Type")
                                        {
                                            int colIndex = columns.SingleOrDefault(x => x.Value.ToString() == "TTL").Index + 1;
                                            var val = string.IsNullOrEmpty(row.Cell(colIndex).Value.ToString()) ? "1" : row.Cell(colIndex).Value;
                                            var type = prop.PropertyType;
                                            prop.SetValue(obj, Convert.ChangeType(val, type));
                                        }
                                        else
                                        {
                                            if (prop.PropertyType.Name == "String")
                                            {
                                                int colIndex = columns.SingleOrDefault(x => x.Value.ToString().ToLower().Contains(prop.Name.ToString().ToLower())).Index;
                                                var val = row.Cell(colIndex).Value.ToString().ToUpper();
                                                var type = prop.PropertyType;
                                                prop.SetValue(obj, Convert.ChangeType(val, type));
                                            }
                                            else
                                            {
                                                int colIndex = columns.SingleOrDefault(x => x.Value.ToString().ToLower().Contains(prop.Name.ToString().ToLower())).Index;
                                                var val = string.IsNullOrEmpty(row.Cell(colIndex).Value.ToString()) ? 0 : Convert.ToInt32(row.Cell(colIndex).Value);
                                                var type = prop.PropertyType;
                                                prop.SetValue(obj, Convert.ChangeType(val, type));
                                            }
                                        }
                                    }
                                    products.Add(obj);
                                }
                                catch (Exception ex)
                                {
                                    throw;
                                }
                            }
                        }

                        dataFilter = RenderData(products);
                        mBindingSource = new BindingSource();
                        mBindingSource.DataSource = RenderData(products);
                        dataGrdView.DataSource = mBindingSource;
                        dataGrdView.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).Width = 350;
                        dataGrdView.Columns[0].Width = 200;
                        dataGrdView.Columns[1].Width = 130;
                        dataGrdView.Columns[2].Width = 200;
                        dataGrdView.Columns[3].Width = 50;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error
                }
            }
        }
        public List<Result> RenderData(List<Products> products)
        {
            var _bindType2 = from a in products
                             where a.Type == "2"
                             group a by new
                             {
                                 a.Buyer,
                                 a.Style,
                                 a.Color
                             } into val
                             orderby val.Key.Style, val.Key.Color
                             select new Result()
                             {
                                 Buyer = val.Key.Buyer,
                                 Style = val.Key.Style,
                                 Color = val.Key.Color,
                                 Type = val.FirstOrDefault()?.Type,
                                 Data = val.Key.Color + ": "
                                     + (val.Sum(x => x.Size.XXXS + x.Size.XSP) > 0 ? val.Sum(x => x.Size.XXXS + x.Size.XSP) + " (sz00), " : "")
                                     + (val.Sum(x => x.Size.XXS + x.Size.SP) > 0 ? val.Sum(x => x.Size.XXS + x.Size.SP) + " (sz0), " : "")
                                     + (val.Sum(x => x.Size.XS + x.Size.MP) > 0 ? val.Sum(x => x.Size.XS + x.Size.MP) + " (sz2), " : "")
                                     + (val.Sum(x => x.Size.S + x.Size.LP) > 0 ? val.Sum(x => x.Size.S + x.Size.LP) + " (sz4), " : "")
                                     + (val.Sum(x => x.Size.M + x.Size.XLP) > 0 ? val.Sum(x => x.Size.M + x.Size.XLP) + " (sz6), " : "")
                                     + (val.Sum(x => x.Size.L + x.Size.XXLP) > 0 ? val.Sum(x => x.Size.L + x.Size.XXLP) + " (sz8), " : "")
                                     + (val.Sum(x => x.Size.XL + x.Size.XSS) > 0 ? val.Sum(x => x.Size.XL + x.Size.XSS) + " (sz10), " : "")
                                     + (val.Sum(x => x.Size.XXL + x.Size.SM) > 0 ? val.Sum(x => x.Size.XXL + x.Size.SM) + " (sz12), " : "")
                                     + (val.Sum(x => x.Size.XXXSP + x.Size.ML) > 0 ? val.Sum(x => x.Size.XXXSP + x.Size.ML) + " (sz14), " : "")
                                     + (val.Sum(x => x.Size.P + x.Size.LXL) > 0 ? val.Sum(x => x.Size.P + x.Size.LXL) + " (sz16), " : "")
                                     + (val.Sum(x => x.Size.XXSP + x.Size.NoSize) > 0 ? val.Sum(x => x.Size.XXSP + x.Size.NoSize) + " (sz18)." : "")
                             };
            var _bindType4 = from a in products
                             where a.Type == "4"
                             group a by new
                             {
                                 a.Buyer,
                                 a.Style,
                                 a.Color
                             } into val
                             orderby val.Key.Style, val.Key.Color
                             select new Result()
                             {
                                 Buyer = val.Key.Buyer,
                                 Style = val.Key.Style,
                                 Color = val.Key.Color,
                                 Type = val.FirstOrDefault()?.Type,
                                 Data = val.Key.Color + ": "
                                     + (val.FirstOrDefault()?.Size.S > 0 ? val.FirstOrDefault()?.Size.S + " (sz2), " : "")
                                     + (val.FirstOrDefault()?.Size.M > 0 ? val.FirstOrDefault()?.Size.M + " (sz3), " : "")
                                     + (val.FirstOrDefault()?.Size.L > 0 ? val.FirstOrDefault()?.Size.L + " (sz4), " : "")
                                     + (val.FirstOrDefault()?.Size.XL > 0 ? val.FirstOrDefault()?.Size.XL + " (sz5), " : "")
                                     + (val.FirstOrDefault()?.Size.XXL > 0 ? val.FirstOrDefault()?.Size.XXL + " (sz6), " : "")
                                     + (val.FirstOrDefault()?.Size.XXXSP > 0 ? val.FirstOrDefault()?.Size.XXXSP + " (sz7), " : "")
                                     + (val.FirstOrDefault()?.Size.P > 0 ? val.FirstOrDefault()?.Size.P + " (sz8), " : "")
                                     + (val.FirstOrDefault()?.Size.XXSP > 0 ? val.FirstOrDefault()?.Size.XXSP + " (sz9), " : "")
                                     + (val.FirstOrDefault()?.Size.XSP > 0 ? val.FirstOrDefault()?.Size.XSP + " (sz10), " : "")
                                     + (val.FirstOrDefault()?.Size.SP > 0 ? val.FirstOrDefault()?.Size.SP + " (sz11), " : "")
                                     + (val.FirstOrDefault()?.Size.MP > 0 ? val.FirstOrDefault()?.Size.MP + " (sz12), " : "")
                                     + (val.FirstOrDefault()?.Size.LP > 0 ? val.FirstOrDefault()?.Size.LP + " (sz13), " : "")
                                     + (val.FirstOrDefault()?.Size.XLP > 0 ? val.FirstOrDefault()?.Size.XLP + " (sz14), " : "")
                                     + (val.FirstOrDefault()?.Size.XXLP > 0 ? val.FirstOrDefault()?.Size.XXLP + " (sz15), " : "")
                                     + (val.FirstOrDefault()?.Size.XSS > 0 ? val.FirstOrDefault()?.Size.XSS + " (sz16)." : "")
                             };
            var _bindType10 = from a in products
                              where a.Type == "10"
                              group a by new
                              {
                                  a.Buyer,
                                  a.Style,
                                  a.Color
                              } into val
                              orderby val.Key.Style, val.Key.Color
                              select new Result()
                              {
                                  Buyer = val.Key.Buyer,
                                  Style = val.Key.Style,
                                  Color = val.Key.Color,
                                  Type = val.FirstOrDefault()?.Type,
                                  Data = val.Key.Color + ": "
                                      + (val.FirstOrDefault()?.Size.SP > 0 ? val.FirstOrDefault()?.Size.SP + " (sz30), " : "")
                                      + (val.FirstOrDefault()?.Size.MP > 0 ? val.FirstOrDefault()?.Size.MP + " (sz32), " : "")
                                      + (val.FirstOrDefault()?.Size.LP > 0 ? val.FirstOrDefault()?.Size.LP + " (sz34), " : "")
                                      + (val.FirstOrDefault()?.Size.XLP > 0 ? val.FirstOrDefault()?.Size.XLP + " (sz36), " : "")
                                      + (val.FirstOrDefault()?.Size.XXLP > 0 ? val.FirstOrDefault()?.Size.XXLP + " (sz38), " : "")
                                      + (val.FirstOrDefault()?.Size.XSS > 0 ? val.FirstOrDefault()?.Size.XSS + " (sz40), " : "")
                                      + (val.FirstOrDefault()?.Size.SM > 0 ? val.FirstOrDefault()?.Size.SM + " (sz42), " : "")
                                      + (val.FirstOrDefault()?.Size.ML > 0 ? val.FirstOrDefault()?.Size.ML + " (sz44), " : "")
                                      + (val.FirstOrDefault()?.Size.LXL > 0 ? val.FirstOrDefault()?.Size.LXL + " (sz46), " : "")
                                      + (val.FirstOrDefault()?.Size.NoSize > 0 ? val.FirstOrDefault()?.Size.NoSize + " (sz48)." : "")
                              };
            var _bindType1 = from a in products
                             where a.Type == "1"
                             group a by new
                             {
                                 a.Buyer,
                                 a.Style,
                                 a.Color
                             } into val
                             orderby val.Key.Style, val.Key.Color
                             select new Result()
                             {
                                 Buyer = val.Key.Buyer,
                                 Style = val.Key.Style,
                                 Color = val.Key.Color,
                                 Type = val.FirstOrDefault()?.Type,
                                 //XXXS = val.Sum(x=>x.Size.XXXS + x.Size.XXXSP),
                                 //XXS = val.Sum(x => x.Size.XXS + x.Size.XXSP),
                                 //XS = val.Sum(x => x.Size.XS + x.Size.XSP),
                                 //S = val.Sum(x => x.Size.S + x.Size.SP),
                                 //M = val.Sum(x => x.Size.M + x.Size.MP),
                                 Data = val.Key.Color + ": "
                                     + (val.Sum(x => x.Size.XXXS + x.Size.XXXSP) > 0 ? val.Sum(x => x.Size.XXXS + x.Size.XXXSP) + " XXXS, " : "")
                                     + (val.Sum(x => x.Size.XXS + x.Size.XXSP) > 0 ? val.Sum(x => x.Size.XXS + x.Size.XXSP) + " XXS, " : "")
                                     + (val.Sum(x => x.Size.XS + x.Size.XSP) > 0 ? val.Sum(x => x.Size.XS + x.Size.XSP) + " XS, " : "")
                                     + (val.Sum(x => x.Size.S + x.Size.SP) > 0 ? val.Sum(x => x.Size.S + x.Size.SP) + " S, " : "")
                                     + (val.Sum(x => x.Size.M + x.Size.MP) > 0 ? val.Sum(x => x.Size.M + x.Size.MP) + " M." : "")
                             };
            //dataGrdView.DataSource = _bind.ToList();
            var _bind = new List<Result>();
            _bind.AddRange(_bindType1);
            _bind.AddRange(_bindType2);
            _bind.AddRange(_bindType4);
            _bind.AddRange(_bindType10);

            return _bind.ToList();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class Result
        {
            public string Buyer { get; set; }
            public string Style { get; set; }
            public string Color { get; set; }
            public string Type { get; set; }
            //public int XXXS { get; set; }
            //public int XXS { get; set; }
            //public int XS { get; set; }
            //public int S { get; set; }
            //public int M { get; set; }
            public string Data { get; set; }
        }
        public class Products
        {
            public string Buyer { get; set; }
            public int Carton { get; set; }
            //public int Ctns { get; set; }
            public string Style { get; set; }
            public string Color { get; set; }
            public Size Size { get; set; }
            public string Type { get; set; }
        }
        public class Size
        {
            public int XXXS { get; set; } = 0;
            public int XXS { get; set; } = 0;
            public int XS { get; set; } = 0;
            public int S { get; set; } = 0;
            public int M { get; set; } = 0;
            public int L { get; set; } = 0;
            public int XL { get; set; } = 0;
            public int XXL { get; set; } = 0;
            public int XXXSP { get; set; } = 0;
            public int P { get; set; } = 0;
            public int XXSP { get; set; } = 0;
            public int XSP { get; set; } = 0;
            public int SP { get; set; } = 0;
            public int MP { get; set; } = 0;
            public int LP { get; set; } = 0;
            public int XLP { get; set; } = 0;
            public int XXLP { get; set; } = 0;
            public int XSS { get; set; } = 0;
            public int SM { get; set; } = 0;
            public int ML { get; set; } = 0;
            public int LXL { get; set; } = 0;
            public int NoSize { get; set; } = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGrdView.DataSource = mBindingSource;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_styleCode.Text == "Buyer")
                {
                    dataGrdView.DataSource = dataFilter.Where(x => x.Buyer.Contains(tb_styleCode.Text.ToUpper())).ToList();
                }
                else if (cbb_styleCode.Text == "Style")
                {
                    dataGrdView.DataSource = dataFilter.Where(x => x.Style.Contains(tb_styleCode.Text.ToUpper())).ToList();
                }
                else if (cbb_styleCode.Text == "Type")
                {
                    dataGrdView.DataSource = dataFilter.Where(x => x.Type.Equals(tb_styleCode.Text.ToUpper())).ToList();
                }
                else
                {
                    dataGrdView.DataSource = dataFilter.Where(x => x.Color.Contains(tb_styleCode.Text.ToUpper())).ToList();
                }
                //if (mBindingSource != null)
                //{
                //    mBindingSource.Filter = string.Format("{0} = '{1}'", cbb_styleCode.Text, tb_styleCode.Text);
                //    dataGrdView.DataSource = mBindingSource;
                //}
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
