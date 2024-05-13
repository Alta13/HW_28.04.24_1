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
   
    //Фирма продает составляющие компьютера.Первая форма отвечает за учет продаж, вторая за добавление и 
    //редактирование составляющих.
    //Первая форма:
    //Список, выпадающий список, текстовое поле, кнопка вызова второй формы.В выпадающем списке появляются наименования
    //всех товаров, которые в наличие в магазине.Пользователь выбирает товар, в текстовом окне, которое нельзя редактировать, 
    //появляется цена. Пользователь нажимает «добавить» и товар добавляется в список продаж. 
    //Также должно быть окошко, которое выводит общую стоимость.
    //Вторая форма:
    //Информация о комплектующих(наименование, характеристика, описание и цена) вводится в текстовые поля; 
    //в список добавляется текстовая строка, содержащая информацию о товаре, кроме цены, цена в списке не видна, 
    //но содержится; также комплектующие можно редактировать.
    public partial class Form1 : Form
    {
        public double AllPrise { get; set; } = 0;
        List<Product> product = null;
        public Form1()
        {
            InitializeComponent();
            product = new List<Product>();
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            cbxProductStock.SelectedIndexChanged += ProductStock_SelectedIndexChanged;
            btnAddList.Click += BtnAddList_Click;
        }

        private void BtnAddList_Click(object sender, EventArgs e)
        {
            try
            {
                lbxProduct.Items.Add(((Product)cbxProductStock.Items[cbxProductStock.SelectedIndex]).ToString());
                AllPrise += ((Product)cbxProductStock.Items[cbxProductStock.SelectedIndex]).Price;
                if (lbxProduct.Items.Count > 0)
                {
                    lblNoProduct.Visible = false;
                    lblAllPriceProduct.Visible = true;
                    tbxPriceProduct.Visible = true;
                    lblCurrency.Visible = true;
                }
                tbxPriceProduct.Text = AllPrise.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали товар!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ProductStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxPriceProduct.Text = ((Product)cbxProductStock.Items[cbxProductStock.SelectedIndex]).Price.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int tempNum = cbxProductStock.SelectedIndex;
                Product tempProduct = (Product)cbxProductStock.Items[tempNum];
                Form2 form2 = new Form2(false, tempProduct);
                form2.ShowDialog();
                cbxProductStock.Items.RemoveAt(tempNum);
                cbxProductStock.Items.Insert(tempNum, tempProduct);
                cbxProductStock.SelectedIndex = tempNum;
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали товар!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            product.Add(new Product());
            Form2 form2 = new Form2(true, product[product.Count - 1]);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                cbxProductStock.Items.Add(product[product.Count - 1]);
                gbxProduct.Text = $"Товары в наличии {cbxProductStock.Items.Count}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
