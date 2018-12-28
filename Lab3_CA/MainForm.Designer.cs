namespace Lab3_CA
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LVIn = new System.Windows.Forms.ListView();
            this.Name_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVOut = new System.Windows.Forms.ListView();
            this.Name_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.btBF = new System.Windows.Forms.Button();
            this.btGenetic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LVIn
            // 
            this.LVIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_1,
            this.Weight_1,
            this.Cost_1});
            this.LVIn.Location = new System.Drawing.Point(46, 106);
            this.LVIn.Name = "LVIn";
            this.LVIn.Size = new System.Drawing.Size(337, 288);
            this.LVIn.TabIndex = 0;
            this.LVIn.UseCompatibleStateImageBehavior = false;
            this.LVIn.View = System.Windows.Forms.View.Details;
            // 
            // Name_1
            // 
            this.Name_1.Text = "Название";
            this.Name_1.Width = 100;
            // 
            // Weight_1
            // 
            this.Weight_1.Text = "Вес";
            this.Weight_1.Width = 122;
            // 
            // Cost_1
            // 
            this.Cost_1.Text = "Стоимость";
            this.Cost_1.Width = 146;
            // 
            // LVOut
            // 
            this.LVOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_2,
            this.Weight_2,
            this.Cost_2});
            this.LVOut.Location = new System.Drawing.Point(473, 106);
            this.LVOut.Name = "LVOut";
            this.LVOut.Size = new System.Drawing.Size(295, 288);
            this.LVOut.TabIndex = 1;
            this.LVOut.UseCompatibleStateImageBehavior = false;
            this.LVOut.View = System.Windows.Forms.View.Details;
            // 
            // Name_2
            // 
            this.Name_2.Text = "Название";
            this.Name_2.Width = 84;
            // 
            // Weight_2
            // 
            this.Weight_2.Text = "Вес";
            this.Weight_2.Width = 100;
            // 
            // Cost_2
            // 
            this.Cost_2.Text = "Стоимость";
            this.Cost_2.Width = 125;
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(235, 80);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(148, 20);
            this.tbCapacity.TabIndex = 2;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(46, 54);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(106, 46);
            this.btGenerate.TabIndex = 3;
            this.btGenerate.Text = "Сгенерировать набор элементов";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // btBF
            // 
            this.btBF.Location = new System.Drawing.Point(473, 66);
            this.btBF.Name = "btBF";
            this.btBF.Size = new System.Drawing.Size(75, 23);
            this.btBF.TabIndex = 4;
            this.btBF.Text = "Перебор";
            this.btBF.UseVisualStyleBackColor = true;
            this.btBF.Click += new System.EventHandler(this.btBF_Click);
            // 
            // btGenetic
            // 
            this.btGenetic.Location = new System.Drawing.Point(610, 66);
            this.btGenetic.Name = "btGenetic";
            this.btGenetic.Size = new System.Drawing.Size(158, 23);
            this.btGenetic.TabIndex = 5;
            this.btGenetic.Text = "Генетический алгоритм";
            this.btGenetic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вместимость рюкзака";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(693, 415);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGenetic);
            this.Controls.Add(this.btBF);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.tbCapacity);
            this.Controls.Add(this.LVOut);
            this.Controls.Add(this.LVIn);
            this.Name = "MainForm";
            this.Text = "Задача о рюкзаке. Генетический алгоритм";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVIn;
        private System.Windows.Forms.ColumnHeader Name_1;
        private System.Windows.Forms.ColumnHeader Weight_1;
        private System.Windows.Forms.ColumnHeader Cost_1;
        private System.Windows.Forms.ListView LVOut;
        private System.Windows.Forms.ColumnHeader Name_2;
        private System.Windows.Forms.ColumnHeader Weight_2;
        private System.Windows.Forms.ColumnHeader Cost_2;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Button btBF;
        private System.Windows.Forms.Button btGenetic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClear;
    }
}

