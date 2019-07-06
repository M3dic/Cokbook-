using MySql.Data.MySqlClient;
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

namespace Cokbook
{
    public partial class Cokbook : Form
    {
        private string chef;
        private string password;
        private string age;
        private string gender;
        private string email;

        public Cokbook(string text1, string text2, string v1, string v2, string v3)
        {
            this.chef = text1;
            this.password = text2;
            this.age = v1;
            this.gender = v2;
            this.email = v3;
            InitializeComponent();
            label2.Text = chef;
            pictureBox2.AllowDrop = true;
        }
        private void HomeBTN_Click(object sender, EventArgs e)
        {
            Hidepanels();
        }
        /// <summary>
        /// hiding panels
        /// </summary>
        public void Hidepanels()
        {
            forumpanel.Visible = false;
            recipepanel.Visible = false;
            advprodpanel.Visible = false;
            addrecipePanel.Visible = false;
            librarypanel.Visible = false;
        }
        /// <summary>
        /// getting recipe information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LibraryBTN_Click(object sender, EventArgs e)
        {
            Hidepanels();
            librarypanel.Visible = true;
            string query = "datasource=35.224.20.143;port=3306;username=cokbook;password=\"cokbook\"";
            MySqlConnection conDataBase = new MySqlConnection(query);
            MySqlCommand cmdDataBase = new MySqlCommand($"select topic as `Product Name`, instructions as `Instructions` from cokbook.recipe where name = '{this.chef}'", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter
                {
                    SelectCommand = cmdDataBase
                };
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSorce = new BindingSource
                {
                    DataSource = dbdataset
                };
                librarygrid.DataSource = bSorce;
                sda.Update(dbdataset);
            }
            catch (Exception)
            {
                MessageBox.Show("Database error, please contact support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// all recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForumBTN_Click(object sender, EventArgs e)
        {
            Hidepanels();
            forumpanel.Visible = true;
            textBox4.Text = null;
            textBox3.Text = null;
            string query = "datasource=35.224.20.143;port=3306;username=cokbook;password=\"cokbook\"";
            MySqlConnection conDataBase = new MySqlConnection(query);
            MySqlCommand cmdDataBase = new MySqlCommand($"select topic as `Product Name`, instructions as `Instructions` from cokbook.recipe where place = 'f' order by id desc", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter
                {
                    SelectCommand = cmdDataBase
                };
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSorce = new BindingSource
                {
                    DataSource = dbdataset
                };
                forumgrid.DataSource = bSorce;
                sda.Update(dbdataset);
            }
            catch (Exception)
            {
                MessageBox.Show("Database error, please contact support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Sorcing top recipes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopRecipeBTN_Click(object sender, EventArgs e)
        {
            Hidepanels();
            recipepanel.Visible = true;
            textBox8.Text = null;
            textBox9.Text = null;
            textBox10.Text = null;
            string query = "datasource=35.224.20.143;port=3306;username=cokbook;password=\"cokbook\"";
            MySqlConnection conDataBase = new MySqlConnection(query);
            MySqlCommand cmdDataBase = new MySqlCommand($"select num as 'Number',topic as `Product Name`, instructions as `Instructions`,datetill as 'Date posted' from cokbook.toprecipes where curdate() - str_to_date(datetill, '%d/%m/%Y') <=5 order by num desc", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter
                {
                    SelectCommand = cmdDataBase
                };
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSorce = new BindingSource
                {
                    DataSource = dbdataset
                };
                toprecipegrid.DataSource = bSorce;
                sda.Update(dbdataset);
            }
            catch (Exception)
            {
                MessageBox.Show("Database error, please contact support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdvProductBTN_Click(object sender, EventArgs e)
        {
            Hidepanels();
            advprodpanel.Visible = true;
        }

        private void AddRecipeBTN_Click(object sender, EventArgs e)
        {
            Hidepanels();
            addrecipePanel.Visible = true;
            Rname.Text = null;
            RInstruction.Text = null;
            addtoforum.Checked = false;

        }

        private void WriteNewRecipe_Click(object sender, EventArgs e)
        {
            Recipe addrecipe = new Recipe();
            char forum;
            if (addtoforum.Checked) forum = 'f';
            else forum = 'l';
            try
            {
                addrecipe.Addnewrecipe(this.chef, Rname.Text, RInstruction.Text, forum);
                MessageBox.Show("Successfully added new recipe", "New recipe added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Please contact admin to resolve problem", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Librarygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (librarygrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    librarygrid.CurrentRow.Selected = true;
                    textBox1.Text = librarygrid.Rows[e.RowIndex].Cells["Product Name"].FormattedValue.ToString();
                    textBox2.Text = librarygrid.Rows[e.RowIndex].Cells["Instructions"].FormattedValue.ToString();
                }

            }
            catch (Exception)
            {

            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Recipe updaterecipe = new Recipe();
                updaterecipe.UpdateRecipe(this.chef, textBox1.Text, textBox2.Text);
                MessageBox.Show("Successfully updated recipe information", "Successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string query = "datasource=35.224.20.143;port=3306;username=cokbook;password=\"cokbook\"";
                MySqlConnection conDataBase = new MySqlConnection(query);
                MySqlCommand cmdDataBase = new MySqlCommand($"select topic as `Product Name`, instructions as `Instructions` from cokbook.recipe where name = '{this.chef}'", conDataBase);
                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter
                    {
                        SelectCommand = cmdDataBase
                    };
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSorce = new BindingSource
                    {
                        DataSource = dbdataset
                    };
                    librarygrid.DataSource = bSorce;
                    sda.Update(dbdataset);
                }
                catch (Exception)
                {
                    MessageBox.Show("Database error, please contact support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Recipe updaterecipe = new Recipe();
                updaterecipe.Deleterecipe(this.chef, textBox1.Text);
                MessageBox.Show("Successfully deleted recipe information", "Successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string query = "datasource=35.224.20.143;port=3306;username=cokbook;password=\"cokbook\"";
                MySqlConnection conDataBase = new MySqlConnection(query);
                MySqlCommand cmdDataBase = new MySqlCommand($"select topic as `Product Name`, instructions as `Instructions` from cokbook.recipe where name = '{this.chef}'", conDataBase);
                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter
                    {
                        SelectCommand = cmdDataBase
                    };
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSorce = new BindingSource
                    {
                        DataSource = dbdataset
                    };
                    librarygrid.DataSource = bSorce;
                    sda.Update(dbdataset);
                }
                catch (Exception)
                {
                    MessageBox.Show("Database error, please contact support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Forumgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (forumgrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    forumgrid.CurrentRow.Selected = true;
                    textBox4.Text = forumgrid.Rows[e.RowIndex].Cells["Product Name"].FormattedValue.ToString();
                    textBox3.Text = forumgrid.Rows[e.RowIndex].Cells["Instructions"].FormattedValue.ToString();
                }

            }
            catch (Exception)
            {

            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string query = "datasource=35.224.20.143;port=3306;username=cokbook;password=\"cokbook\"";
            MySqlConnection conDataBase = new MySqlConnection(query);
            MySqlCommand cmdDataBase = new MySqlCommand($"select topic as `Product Name`, instructions as `Instructions` from cokbook.recipe where topic = '{textBox5.Text}'", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter
                {
                    SelectCommand = cmdDataBase
                };
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSorce = new BindingSource
                {
                    DataSource = dbdataset
                };
                forumgrid.DataSource = bSorce;
                sda.Update(dbdataset);
            }
            catch (Exception)
            {
                MessageBox.Show("Database error, please contact support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            string query = "datasource=35.224.20.143;port=3306;username=cokbook;password=\"cokbook\"";
            MySqlConnection conDataBase = new MySqlConnection(query);
            MySqlCommand cmdDataBase = new MySqlCommand($"select topic as `Product Name`, instructions as `Instructions` from cokbook.recipe where topic like('%{textBox5.Text}%') and place = 'f'", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter
                {
                    SelectCommand = cmdDataBase
                };
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSorce = new BindingSource
                {
                    DataSource = dbdataset
                };
                forumgrid.DataSource = bSorce;
                sda.Update(dbdataset);
            }
            catch (Exception)
            {
                MessageBox.Show("Database error, please contact support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                pictureBox2.Image = img;
            }
        }

        private void Advertise_productBTN_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "" && textBox6.Text != "")
            {
                try
                {
                    Recipe addADV = new Recipe();
                    addADV.Addadvertisementproduct(textBox7.Text, textBox6.Text, DateTime.Today.Date, pictureBox2);
                    MessageBox.Show("Successfully added new recipe", "Added successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please contact support", "Error adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please check input information", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TextBox8_KeyDown(object sender, KeyEventArgs e)
        {
            string query = "datasource=35.224.20.143;port=3306;username=cokbook;password=\"cokbook\"";
            MySqlConnection conDataBase = new MySqlConnection(query);
            MySqlCommand cmdDataBase = new MySqlCommand($"select topic as `Product Name`, instructions as `Instructions`,datetill as 'Date posted' from cokbook.toprecipes where topic like('%{textBox8.Text}%') and curdate() - str_to_date(datetill, '%d/%m/%Y') <=5 order by num desc", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter
                {
                    SelectCommand = cmdDataBase
                };
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSorce = new BindingSource
                {
                    DataSource = dbdataset
                };
                toprecipegrid.DataSource = bSorce;
                sda.Update(dbdataset);
            }
            catch (Exception)
            {
                MessageBox.Show("Database error, please contact support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Toprecipegrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (toprecipegrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    toprecipegrid.CurrentRow.Selected = true;
                    textBox10.Text = toprecipegrid.Rows[e.RowIndex].Cells["Product Name"].FormattedValue.ToString();
                    textBox9.Text = toprecipegrid.Rows[e.RowIndex].Cells["Instructions"].FormattedValue.ToString();
                    label23.Text = toprecipegrid.Rows[e.RowIndex].Cells["Number"].FormattedValue.ToString();
                    VoteRecipe takevotes = new VoteRecipe();
                    int positive = takevotes.Takepositivevotes(label23.Text);
                    int negative = takevotes.Takenegativevotes(label23.Text);
                    label24.Text = positive.ToString();
                    label25.Text = negative.ToString();
                }

            }
            catch (Exception)
            {

            }
        }

        private void Good_Click(object sender, EventArgs e)//vote for like 
        {
            if (label23.Text != "-")
            {
                if (!CheckifChefisalreadyvoted(this.chef, this.label23.Text))
                {
                    VoteRecipe GiveVote = new VoteRecipe();
                    GiveVote.VotePositive(this.chef, this.label23.Text);
                    MessageBox.Show("Successfully voted for this recipe", "Voted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label24.Text = (int.Parse(label24.Text) + 1).ToString();
                }
                else MessageBox.Show("You have already voted for this recipe", "Already voted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckifChefisalreadyvoted(string chef, string text)
        {
            VoteRecipe checkforVote = new VoteRecipe();
            return checkforVote.AlreadyVoted(chef, text);
        }

        private void Bad_Click(object sender, EventArgs e)//vote for disike
        {
            if (label23.Text != "-")
            {
                if (!CheckifChefisalreadyvoted(this.chef, this.label23.Text))
                {
                    VoteRecipe GiveVote = new VoteRecipe();
                    GiveVote.VoteNegative(this.chef, this.label23.Text);
                    MessageBox.Show("Successfully voted for this recipe", "Voted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label25.Text = (int.Parse(label25.Text) + 1).ToString();

                }
                else MessageBox.Show("You have already voted for this recipe", "Already voted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Eexit_Click(object sender, EventArgs e)
        {
            Form1 child = new Form1(); //create new isntance of form
            child.FormClosed += new FormClosedEventHandler(Child_FormClosed); //add handler to catch when child form is closed
            child.Show(); //show child
            this.Hide(); //hide parent
        }
        private void Child_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
