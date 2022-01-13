
namespace SimpleDataApp
{
    partial class FillOrCancel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
            this.btnFindByOrderID = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFillOrder = new System.Windows.Forms.Button();
            this.btnFinishUpdates = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(153, 13);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(114, 20);
            this.txtOrderID.TabIndex = 1;
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFillDate.Location = new System.Drawing.Point(281, 57);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(93, 20);
            this.dtpFillDate.TabIndex = 3;
            // 
            // dgvCustomerOrders
            // 
            this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrders.Location = new System.Drawing.Point(13, 83);
            this.dgvCustomerOrders.Name = "dgvCustomerOrders";
            this.dgvCustomerOrders.Size = new System.Drawing.Size(405, 83);
            this.dgvCustomerOrders.TabIndex = 4;
            this.dgvCustomerOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnFindByOrderID
            // 
            this.btnFindByOrderID.Location = new System.Drawing.Point(273, 11);
            this.btnFindByOrderID.Name = "btnFindByOrderID";
            this.btnFindByOrderID.Size = new System.Drawing.Size(90, 23);
            this.btnFindByOrderID.TabIndex = 5;
            this.btnFindByOrderID.Text = "Найти заказ";
            this.btnFindByOrderID.UseVisualStyleBackColor = true;
            this.btnFindByOrderID.Click += new System.EventHandler(this.btnFindByOrderID_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(13, 191);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(104, 23);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Отменить заказ";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnFillOrder
            // 
            this.btnFillOrder.Location = new System.Drawing.Point(123, 191);
            this.btnFillOrder.Name = "btnFillOrder";
            this.btnFillOrder.Size = new System.Drawing.Size(102, 23);
            this.btnFillOrder.TabIndex = 7;
            this.btnFillOrder.Text = "Заполнить заказ";
            this.btnFillOrder.UseVisualStyleBackColor = true;
            this.btnFillOrder.Click += new System.EventHandler(this.btnFillOrder_Click);
            // 
            // btnFinishUpdates
            // 
            this.btnFinishUpdates.Location = new System.Drawing.Point(343, 191);
            this.btnFinishUpdates.Name = "btnFinishUpdates";
            this.btnFinishUpdates.Size = new System.Drawing.Size(75, 23);
            this.btnFinishUpdates.TabIndex = 8;
            this.btnFinishUpdates.Text = "Готово";
            this.btnFinishUpdates.UseVisualStyleBackColor = true;
            this.btnFinishUpdates.Click += new System.EventHandler(this.btnFinishUpdates_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Идентификатор заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "При заполнении заказа укажите дату заполнения";
            // 
            // FillOrCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinishUpdates);
            this.Controls.Add(this.btnFillOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnFindByOrderID);
            this.Controls.Add(this.dgvCustomerOrders);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.txtOrderID);
            this.Name = "FillOrCancel";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.DataGridView dgvCustomerOrders;
        private System.Windows.Forms.Button btnFindByOrderID;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnFillOrder;
        private System.Windows.Forms.Button btnFinishUpdates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}