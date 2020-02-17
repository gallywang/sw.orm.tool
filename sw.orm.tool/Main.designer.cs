namespace sw.orm.tool
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTables = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btnGenerateFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGeneratePath = new System.Windows.Forms.TextBox();
            this.lbViews = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "请选择数据库：";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(17, 39);
            this.cmbDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(239, 23);
            this.cmbDatabase.TabIndex = 2;
            this.cmbDatabase.TextChanged += new System.EventHandler(this.cmbDatabase_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "请选择数据表：";
            // 
            // lbTables
            // 
            this.lbTables.FormattingEnabled = true;
            this.lbTables.ItemHeight = 15;
            this.lbTables.Location = new System.Drawing.Point(19, 94);
            this.lbTables.Margin = new System.Windows.Forms.Padding(4);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(239, 154);
            this.lbTables.TabIndex = 4;
            this.lbTables.Click += new System.EventHandler(this.lbTables_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "命名空间：";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(19, 478);
            this.txtNamespace.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(236, 25);
            this.txtNamespace.TabIndex = 9;
            this.txtNamespace.Text = "DefaultNamespace";
            this.txtNamespace.TextChanged += new System.EventHandler(this.txtNamespace_TextChanged);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(281, 15);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(691, 616);
            this.txtContent.TabIndex = 10;
            this.txtContent.Text = "";
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.Location = new System.Drawing.Point(145, 574);
            this.btnGenerateFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(100, 29);
            this.btnGenerateFile.TabIndex = 11;
            this.btnGenerateFile.Text = "生成类文件";
            this.btnGenerateFile.UseVisualStyleBackColor = true;
            this.btnGenerateFile.Click += new System.EventHandler(this.btnGenerateFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 515);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "生成路径：";
            // 
            // txtGeneratePath
            // 
            this.txtGeneratePath.Location = new System.Drawing.Point(19, 537);
            this.txtGeneratePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneratePath.Name = "txtGeneratePath";
            this.txtGeneratePath.Size = new System.Drawing.Size(239, 25);
            this.txtGeneratePath.TabIndex = 13;
            this.txtGeneratePath.Text = "D:\\EntityModels";
            // 
            // lbViews
            // 
            this.lbViews.FormattingEnabled = true;
            this.lbViews.ItemHeight = 15;
            this.lbViews.Location = new System.Drawing.Point(17, 282);
            this.lbViews.Margin = new System.Windows.Forms.Padding(4);
            this.lbViews.Name = "lbViews";
            this.lbViews.Size = new System.Drawing.Size(241, 154);
            this.lbViews.TabIndex = 15;
            this.lbViews.Click += new System.EventHandler(this.lbViews_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "请选择视图：";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 644);
            this.Controls.Add(this.lbViews);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGeneratePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateFile);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTables);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实体类生成工具";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button btnGenerateFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGeneratePath;
        private System.Windows.Forms.ListBox lbViews;
        private System.Windows.Forms.Label label3;
    }
}

