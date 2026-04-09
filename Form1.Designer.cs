namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            grpMenu = new GroupBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            grpOption = new GroupBox();
            grpList = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            lblWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpMenu.SuspendLayout();
            grpOption.SuspendLayout();
            grpList.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("한컴 고딕", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(366, 56);
            label1.TabIndex = 0;
            label1.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(23, 42);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(90, 30);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(23, 149);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(128, 30);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(23, 263);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(109, 30);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(157, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(157, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(157, 264);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 107);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(pictureBox3);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(pictureBox2);
            grpMenu.Controls.Add(pictureBox1);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Font = new Font("한컴 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(50, 115);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(299, 390);
            grpMenu.TabIndex = 1;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(18, 55);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(110, 30);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(18, 104);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(72, 30);
            chkCola.TabIndex = 1;
            chkCola.TabStop = false;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(18, 150);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(115, 30);
            chkSauce.TabIndex = 2;
            chkSauce.TabStop = false;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(18, 199);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(115, 30);
            chkCheese.TabIndex = 3;
            chkCheese.TabStop = false;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkPotato);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkSauce);
            grpOption.Font = new Font("한컴 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(369, 115);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(188, 258);
            grpOption.TabIndex = 0;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // grpList
            // 
            grpList.Controls.Add(lblTotalCost);
            grpList.Controls.Add(lstOrder);
            grpList.Font = new Font("한컴 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpList.ForeColor = Color.Red;
            grpList.Location = new Point(580, 115);
            grpList.Name = "grpList";
            grpList.Size = new Size(304, 320);
            grpList.TabIndex = 0;
            grpList.TabStop = false;
            grpList.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("한컴 고딕", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(19, 273);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(135, 30);
            lblTotalCost.TabIndex = 0;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(19, 46);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(267, 212);
            lstOrder.TabIndex = 0;
            lstOrder.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(0, 192, 0);
            btnOrder.Font = new Font("한컴 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(580, 441);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(170, 53);
            btnOrder.TabIndex = 0;
            btnOrder.TabStop = false;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Font = new Font("한컴 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(756, 441);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(128, 53);
            btnReset.TabIndex = 0;
            btnReset.TabStop = false;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(581, 497);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(169, 26);
            lblWarning.TabIndex = 0;
            lblWarning.Text = "메뉴를 선택하세요";
            lblWarning.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 530);
            Controls.Add(lblWarning);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(grpList);
            Controls.Add(grpOption);
            Controls.Add(label1);
            Controls.Add(grpMenu);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpList.ResumeLayout(false);
            grpList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox grpMenu;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private GroupBox grpOption;
        private GroupBox grpList;
        private ListBox lstOrder;
        private Label lblTotalCost;
        private Button btnOrder;
        private Button btnReset;
        private Label lblWarning;
    }
}
