using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_28._04._24_1
{
    public partial class Form2 : Form
    {
        Product product;
        bool addnew = true;
        public Form2(bool addnew, Product product)
        {
            InitializeComponent();
            this.product = product;
            this.addnew = addnew;
            btnOK.Click += BtnEditAddF2_Click;
            btnCancel.Click += BtnCancelF2_Click;
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!addnew)
            {
                Text = "Редактировать товар";
                tbxName.Text = product.Name;
                tbxSpecification.Text = product.Specification;
                tbxDescription.Text = product.Description;
                tbxPrice.Text = product.Price.ToString();
                addnew = true;
            }
        }

        private void BtnCancelF2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEditAddF2_Click(object sender, EventArgs e)
        {
            if (addnew)
            {
                if (tbxName.Text == "" || tbxSpecification.Text == "" || tbxDescription.Text == "" || tbxPrice.Text == "")
                {
                    MessageBox.Show("Заполните все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                product.Name = tbxName.Text;
                product.Specification = tbxSpecification.Text;
                product.Description = tbxDescription.Text;
                try
                {
                    if (double.Parse(tbxPrice.Text) < 0)
                    {
                        MessageBox.Show("Цена не может быть меньше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    product.Price = double.Parse(tbxPrice.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Цена указана неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
