using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NotepaD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
      
        

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            DialogResult rezultat = dialog.ShowDialog();
            if (rezultat == System.Windows.Forms.DialogResult.OK)
            {
                string nume = dialog.FileName;
                File.WriteAllText(nume, tbText1.Text);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult rezultat = dialog.ShowDialog();
            if (rezultat == System.Windows.Forms.DialogResult.OK)
            {
                string continutfisier = File.ReadAllText(dialog.FileName);
                tbText1.Text = continutfisier;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbText1.Text.Length > 0)
            {
                DialogResult rezultat = MessageBox.Show("Save your program?", "Intrebare", MessageBoxButtons.YesNo);
                if (rezultat == System.Windows.Forms.DialogResult.No)
                {
                    tbText1.Text = " ";
                }

                else
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    DialogResult rezultatp = dialog.ShowDialog();
                    if (rezultatp == System.Windows.Forms.DialogResult.OK)
                    {
                        string nume = dialog.FileName;
                        File.WriteAllText(nume, tbText1.Text);
                    }


                }
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
         
                }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.ShowDialog();
            tbText1.ForeColor= col.Color;

            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tbText1.Font = fd.Font;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText1.Copy();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tbText1.Text = " ";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText1.Paste();
        }

        private void tbText1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText1.Cut();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0.0/Created by Dinu Ionica");
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            cl.ShowDialog();
            tbText1.BackColor = cl.Color;
        }

        private void fontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tbText1.Font = fd.Font;
            }
        }

        private void cToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.ShowDialog();
            tbText1.ForeColor = col.Color;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            DialogResult rezultatp = dialog.ShowDialog();
            if (rezultatp == System.Windows.Forms.DialogResult.OK)
            {
                string nume = dialog.FileName;
                File.WriteAllText(nume, tbText1.Text);
            }
        } 
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pt = new PrintDialog();
            pt.ShowDialog();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog pg = new PrintPreviewDialog();
            pg.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

            }
        }       
   

           
        

