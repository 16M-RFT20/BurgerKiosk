namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnOrder;

            // 이벤트 핸들러 연결
            rdoHamBurger.CheckedChanged += UpdateOrder;
            rdoBulgogiBurger.CheckedChanged += UpdateOrder;
            rdoChickenBurger.CheckedChanged += UpdateOrder;
            chkPotato.CheckedChanged += UpdateOrder;
            chkCola.CheckedChanged += UpdateOrder;
            chkCheese.CheckedChanged += UpdateOrder;
            chkSauce.CheckedChanged += UpdateOrder;
        }

        private void UpdateOrder(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
            int totalCost = 0;

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 500원");
            }

            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("N0") + "원";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lstOrder.Items.Count == 0)
            {
                lblWarning.Visible = true;
                return;
            }
            lblWarning.Visible = false;
            MessageBox.Show("주문이 완료되었습니다!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lblWarning.Visible = false;
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : 0원";
        }
    }
}