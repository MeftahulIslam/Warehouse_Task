
namespace Warehouse_Task
{
    partial class Form1
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
            this.lblNumCont = new System.Windows.Forms.Label();
            this.lblFreeSpace = new System.Windows.Forms.Label();
            this.txtNumCont = new System.Windows.Forms.TextBox();
            this.txtFreeSpace = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.rdoBtnType1 = new System.Windows.Forms.RadioButton();
            this.rdoBtnType2 = new System.Windows.Forms.RadioButton();
            this.rdoBtnType3 = new System.Windows.Forms.RadioButton();
            this.btnRemove = new System.Windows.Forms.Button();
            this.rdoBtnCustom = new System.Windows.Forms.RadioButton();
            this.numUpDwnLength = new System.Windows.Forms.NumericUpDown();
            this.numUpDwnHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDwnBreadth = new System.Windows.Forms.NumericUpDown();
            this.lblCustomHeight = new System.Windows.Forms.Label();
            this.lblCustomBreadth = new System.Windows.Forms.Label();
            this.lblCustomLenght = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnBreadth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumCont
            // 
            this.lblNumCont.AutoSize = true;
            this.lblNumCont.Location = new System.Drawing.Point(30, 51);
            this.lblNumCont.Name = "lblNumCont";
            this.lblNumCont.Size = new System.Drawing.Size(183, 13);
            this.lblNumCont.TabIndex = 0;
            this.lblNumCont.Text = "Number of containers in this shipment";
            this.lblNumCont.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFreeSpace
            // 
            this.lblFreeSpace.AutoSize = true;
            this.lblFreeSpace.Location = new System.Drawing.Point(370, 51);
            this.lblFreeSpace.Name = "lblFreeSpace";
            this.lblFreeSpace.Size = new System.Drawing.Size(77, 13);
            this.lblFreeSpace.TabIndex = 1;
            this.lblFreeSpace.Text = "Free space left";
            // 
            // txtNumCont
            // 
            this.txtNumCont.Location = new System.Drawing.Point(33, 82);
            this.txtNumCont.Name = "txtNumCont";
            this.txtNumCont.Size = new System.Drawing.Size(106, 20);
            this.txtNumCont.TabIndex = 2;
            // 
            // txtFreeSpace
            // 
            this.txtFreeSpace.Cursor = System.Windows.Forms.Cursors.No;
            this.txtFreeSpace.Location = new System.Drawing.Point(373, 82);
            this.txtFreeSpace.Name = "txtFreeSpace";
            this.txtFreeSpace.ReadOnly = true;
            this.txtFreeSpace.Size = new System.Drawing.Size(106, 20);
            this.txtFreeSpace.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(542, 74);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(119, 35);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Add Containers";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(690, 332);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // rdoBtnType1
            // 
            this.rdoBtnType1.AutoSize = true;
            this.rdoBtnType1.Location = new System.Drawing.Point(33, 141);
            this.rdoBtnType1.Name = "rdoBtnType1";
            this.rdoBtnType1.Size = new System.Drawing.Size(58, 17);
            this.rdoBtnType1.TabIndex = 7;
            this.rdoBtnType1.TabStop = true;
            this.rdoBtnType1.Text = "Type 1";
            this.rdoBtnType1.UseVisualStyleBackColor = true;
            this.rdoBtnType1.CheckedChanged += new System.EventHandler(this.rdoBtnType1_CheckedChanged);
            // 
            // rdoBtnType2
            // 
            this.rdoBtnType2.AutoSize = true;
            this.rdoBtnType2.Location = new System.Drawing.Point(33, 190);
            this.rdoBtnType2.Name = "rdoBtnType2";
            this.rdoBtnType2.Size = new System.Drawing.Size(58, 17);
            this.rdoBtnType2.TabIndex = 8;
            this.rdoBtnType2.TabStop = true;
            this.rdoBtnType2.Text = "Type 2";
            this.rdoBtnType2.UseVisualStyleBackColor = true;
            // 
            // rdoBtnType3
            // 
            this.rdoBtnType3.AutoSize = true;
            this.rdoBtnType3.Location = new System.Drawing.Point(33, 238);
            this.rdoBtnType3.Name = "rdoBtnType3";
            this.rdoBtnType3.Size = new System.Drawing.Size(58, 17);
            this.rdoBtnType3.TabIndex = 9;
            this.rdoBtnType3.TabStop = true;
            this.rdoBtnType3.Text = "Type 3";
            this.rdoBtnType3.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(542, 190);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(119, 35);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove Containers";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoBtnCustom
            // 
            this.rdoBtnCustom.AutoSize = true;
            this.rdoBtnCustom.Location = new System.Drawing.Point(33, 285);
            this.rdoBtnCustom.Name = "rdoBtnCustom";
            this.rdoBtnCustom.Size = new System.Drawing.Size(87, 17);
            this.rdoBtnCustom.TabIndex = 11;
            this.rdoBtnCustom.TabStop = true;
            this.rdoBtnCustom.Text = "Type Custom";
            this.rdoBtnCustom.UseVisualStyleBackColor = true;
            this.rdoBtnCustom.CheckedChanged += new System.EventHandler(this.rdoBtnCustom_CheckedChanged);
            // 
            // numUpDwnLength
            // 
            this.numUpDwnLength.Location = new System.Drawing.Point(76, 319);
            this.numUpDwnLength.Name = "numUpDwnLength";
            this.numUpDwnLength.Size = new System.Drawing.Size(120, 20);
            this.numUpDwnLength.TabIndex = 12;
            this.numUpDwnLength.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDwnLength.Visible = false;
            // 
            // numUpDwnHeight
            // 
            this.numUpDwnHeight.Location = new System.Drawing.Point(74, 373);
            this.numUpDwnHeight.Name = "numUpDwnHeight";
            this.numUpDwnHeight.Size = new System.Drawing.Size(120, 20);
            this.numUpDwnHeight.TabIndex = 13;
            this.numUpDwnHeight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUpDwnHeight.Visible = false;
            // 
            // numUpDwnBreadth
            // 
            this.numUpDwnBreadth.Location = new System.Drawing.Point(76, 345);
            this.numUpDwnBreadth.Name = "numUpDwnBreadth";
            this.numUpDwnBreadth.Size = new System.Drawing.Size(120, 20);
            this.numUpDwnBreadth.TabIndex = 14;
            this.numUpDwnBreadth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDwnBreadth.Visible = false;
            // 
            // lblCustomHeight
            // 
            this.lblCustomHeight.AutoSize = true;
            this.lblCustomHeight.Location = new System.Drawing.Point(30, 373);
            this.lblCustomHeight.Name = "lblCustomHeight";
            this.lblCustomHeight.Size = new System.Drawing.Size(38, 13);
            this.lblCustomHeight.TabIndex = 15;
            this.lblCustomHeight.Text = "Height";
            this.lblCustomHeight.Visible = false;
            // 
            // lblCustomBreadth
            // 
            this.lblCustomBreadth.AutoSize = true;
            this.lblCustomBreadth.Location = new System.Drawing.Point(30, 347);
            this.lblCustomBreadth.Name = "lblCustomBreadth";
            this.lblCustomBreadth.Size = new System.Drawing.Size(44, 13);
            this.lblCustomBreadth.TabIndex = 16;
            this.lblCustomBreadth.Text = "Breadth";
            this.lblCustomBreadth.Visible = false;
            // 
            // lblCustomLenght
            // 
            this.lblCustomLenght.AutoSize = true;
            this.lblCustomLenght.Location = new System.Drawing.Point(30, 321);
            this.lblCustomLenght.Name = "lblCustomLenght";
            this.lblCustomLenght.Size = new System.Drawing.Size(40, 13);
            this.lblCustomLenght.TabIndex = 17;
            this.lblCustomLenght.Text = "Length";
            this.lblCustomLenght.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.lblCustomLenght);
            this.Controls.Add(this.lblCustomBreadth);
            this.Controls.Add(this.lblCustomHeight);
            this.Controls.Add(this.numUpDwnBreadth);
            this.Controls.Add(this.numUpDwnHeight);
            this.Controls.Add(this.numUpDwnLength);
            this.Controls.Add(this.rdoBtnCustom);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.rdoBtnType3);
            this.Controls.Add(this.rdoBtnType2);
            this.Controls.Add(this.rdoBtnType1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtFreeSpace);
            this.Controls.Add(this.txtNumCont);
            this.Controls.Add(this.lblFreeSpace);
            this.Controls.Add(this.lblNumCont);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnBreadth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumCont;
        private System.Windows.Forms.Label lblFreeSpace;
        private System.Windows.Forms.TextBox txtNumCont;
        private System.Windows.Forms.TextBox txtFreeSpace;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.RadioButton rdoBtnType1;
        private System.Windows.Forms.RadioButton rdoBtnType2;
        private System.Windows.Forms.RadioButton rdoBtnType3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.RadioButton rdoBtnCustom;
        private System.Windows.Forms.NumericUpDown numUpDwnLength;
        private System.Windows.Forms.NumericUpDown numUpDwnHeight;
        private System.Windows.Forms.NumericUpDown numUpDwnBreadth;
        private System.Windows.Forms.Label lblCustomHeight;
        private System.Windows.Forms.Label lblCustomBreadth;
        private System.Windows.Forms.Label lblCustomLenght;
    }
}

