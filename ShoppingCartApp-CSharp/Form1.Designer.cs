namespace ShoppingCartApp_CSharp
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
            cmbProducts = new ComboBox();
            btnAdd = new Button();
            lblTotal = new Label();
            btnClear = new Button();
            lstCart = new ListBox();
            lblCart = new Label();
            lblProduct = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // cmbProducts
            // 
            cmbProducts.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(35, 107);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(151, 31);
            cmbProducts.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(35, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(209, 328);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 24);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total:";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(35, 193);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(151, 43);
            btnClear.TabIndex = 3;
            btnClear.Text = "LImpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lstCart
            // 
            lstCart.BorderStyle = BorderStyle.None;
            lstCart.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCart.FormattingEnabled = true;
            lstCart.Location = new Point(210, 107);
            lstCart.Name = "lstCart";
            lstCart.Size = new Size(220, 207);
            lstCart.TabIndex = 4;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCart.Location = new Point(209, 68);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(67, 24);
            lblCart.TabIndex = 5;
            lblCart.Text = "Carito";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduct.Location = new Point(35, 68);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(97, 24);
            lblProduct.TabIndex = 6;
            lblProduct.Text = "Producto";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(35, 242);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(151, 43);
            btnClose.TabIndex = 7;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 450);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(lblProduct);
            Controls.Add(lblCart);
            Controls.Add(lstCart);
            Controls.Add(btnClear);
            Controls.Add(lblTotal);
            Controls.Add(btnAdd);
            Controls.Add(cmbProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniStore";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProducts;
        private Button btnAdd;
        private Label lblTotal;
        private Button btnClear;
        private ListBox lstCart;
        private Label lblCart;
        private Label lblProduct;
        private Button btnClose;
    }
}
