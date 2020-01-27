namespace Labs_44
{
    partial class Form1
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
            this.button_AddCountry = new System.Windows.Forms.Button();
            this.label_CountryCode = new System.Windows.Forms.Label();
            this.label_CountryName = new System.Windows.Forms.Label();
            this.listCountry = new System.Windows.Forms.ListBox();
            this.textBox_CountryCode = new System.Windows.Forms.TextBox();
            this.textBox_CountryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_CarsType = new System.Windows.Forms.ListBox();
            this.textBox_CarWeight = new System.Windows.Forms.TextBox();
            this.textBox_CarYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_CarsCountry = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_AddCar = new System.Windows.Forms.Button();
            this.listBox_CarsList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_ServiceCarsInService = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ServiceClientName = new System.Windows.Forms.TextBox();
            this.listBox_ServiceCarsQueue = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ServiceStaffName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_AddCarToService = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_AddCountry
            // 
            this.button_AddCountry.Location = new System.Drawing.Point(9, 115);
            this.button_AddCountry.Name = "button_AddCountry";
            this.button_AddCountry.Size = new System.Drawing.Size(75, 23);
            this.button_AddCountry.TabIndex = 0;
            this.button_AddCountry.Text = "Добавить";
            this.button_AddCountry.UseVisualStyleBackColor = true;
            this.button_AddCountry.Click += new System.EventHandler(this.button_AddCountry_Click);
            // 
            // label_CountryCode
            // 
            this.label_CountryCode.AutoSize = true;
            this.label_CountryCode.Location = new System.Drawing.Point(6, 37);
            this.label_CountryCode.Name = "label_CountryCode";
            this.label_CountryCode.Size = new System.Drawing.Size(66, 13);
            this.label_CountryCode.TabIndex = 1;
            this.label_CountryCode.Text = "Код страны";
            // 
            // label_CountryName
            // 
            this.label_CountryName.AutoSize = true;
            this.label_CountryName.Location = new System.Drawing.Point(6, 77);
            this.label_CountryName.Name = "label_CountryName";
            this.label_CountryName.Size = new System.Drawing.Size(97, 13);
            this.label_CountryName.TabIndex = 2;
            this.label_CountryName.Text = "Название страны";
            // 
            // listCountry
            // 
            this.listCountry.FormattingEnabled = true;
            this.listCountry.Location = new System.Drawing.Point(9, 185);
            this.listCountry.Name = "listCountry";
            this.listCountry.Size = new System.Drawing.Size(120, 95);
            this.listCountry.TabIndex = 4;
            this.listCountry.SelectedIndexChanged += new System.EventHandler(this.listCountry_SelectedIndexChanged);
            // 
            // textBox_CountryCode
            // 
            this.textBox_CountryCode.Location = new System.Drawing.Point(118, 30);
            this.textBox_CountryCode.Name = "textBox_CountryCode";
            this.textBox_CountryCode.Size = new System.Drawing.Size(100, 20);
            this.textBox_CountryCode.TabIndex = 5;
            // 
            // textBox_CountryName
            // 
            this.textBox_CountryName.Location = new System.Drawing.Point(118, 70);
            this.textBox_CountryName.Name = "textBox_CountryName";
            this.textBox_CountryName.Size = new System.Drawing.Size(100, 20);
            this.textBox_CountryName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тип автомобиля";
            // 
            // listBox_CarsType
            // 
            this.listBox_CarsType.FormattingEnabled = true;
            this.listBox_CarsType.Location = new System.Drawing.Point(27, 57);
            this.listBox_CarsType.Name = "listBox_CarsType";
            this.listBox_CarsType.Size = new System.Drawing.Size(120, 82);
            this.listBox_CarsType.TabIndex = 8;
            // 
            // textBox_CarWeight
            // 
            this.textBox_CarWeight.Location = new System.Drawing.Point(27, 191);
            this.textBox_CarWeight.Name = "textBox_CarWeight";
            this.textBox_CarWeight.Size = new System.Drawing.Size(100, 20);
            this.textBox_CarWeight.TabIndex = 9;
            // 
            // textBox_CarYear
            // 
            this.textBox_CarYear.Location = new System.Drawing.Point(161, 191);
            this.textBox_CarYear.Name = "textBox_CarYear";
            this.textBox_CarYear.Size = new System.Drawing.Size(100, 20);
            this.textBox_CarYear.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Вес автомобиля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Год выпуска";
            // 
            // listBox_CarsCountry
            // 
            this.listBox_CarsCountry.FormattingEnabled = true;
            this.listBox_CarsCountry.Location = new System.Drawing.Point(161, 57);
            this.listBox_CarsCountry.Name = "listBox_CarsCountry";
            this.listBox_CarsCountry.Size = new System.Drawing.Size(120, 82);
            this.listBox_CarsCountry.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Страна производства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Список стран";
            // 
            // button_AddCar
            // 
            this.button_AddCar.Location = new System.Drawing.Point(27, 232);
            this.button_AddCar.Name = "button_AddCar";
            this.button_AddCar.Size = new System.Drawing.Size(75, 23);
            this.button_AddCar.TabIndex = 16;
            this.button_AddCar.Text = "Добавить";
            this.button_AddCar.UseVisualStyleBackColor = true;
            this.button_AddCar.Click += new System.EventHandler(this.button_AddCar_Click);
            // 
            // listBox_CarsList
            // 
            this.listBox_CarsList.FormattingEnabled = true;
            this.listBox_CarsList.Location = new System.Drawing.Point(27, 312);
            this.listBox_CarsList.Name = "listBox_CarsList";
            this.listBox_CarsList.Size = new System.Drawing.Size(251, 95);
            this.listBox_CarsList.TabIndex = 17;
            this.listBox_CarsList.SelectedIndexChanged += new System.EventHandler(this.listBox_CarsList_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Список автомобилей";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_CarsType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox_CarsCountry);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBox_CarsList);
            this.groupBox1.Controls.Add(this.textBox_CarYear);
            this.groupBox1.Controls.Add(this.textBox_CarWeight);
            this.groupBox1.Controls.Add(this.button_AddCar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(256, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 426);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автомобиль";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_CountryName);
            this.groupBox2.Controls.Add(this.button_AddCountry);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label_CountryCode);
            this.groupBox2.Controls.Add(this.listCountry);
            this.groupBox2.Controls.Add(this.textBox_CountryCode);
            this.groupBox2.Controls.Add(this.textBox_CountryName);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 426);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Страны производства";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_AddCarToService);
            this.groupBox3.Controls.Add(this.listBox_ServiceCarsInService);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox_ServiceClientName);
            this.groupBox3.Controls.Add(this.listBox_ServiceCarsQueue);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_ServiceStaffName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(549, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 425);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Обслуживание";
            // 
            // listBox_ServiceCarsInService
            // 
            this.listBox_ServiceCarsInService.FormattingEnabled = true;
            this.listBox_ServiceCarsInService.Location = new System.Drawing.Point(6, 324);
            this.listBox_ServiceCarsInService.Name = "listBox_ServiceCarsInService";
            this.listBox_ServiceCarsInService.Size = new System.Drawing.Size(229, 95);
            this.listBox_ServiceCarsInService.TabIndex = 7;
            this.listBox_ServiceCarsInService.SelectedIndexChanged += new System.EventHandler(this.listBox_ServiceCarsInService_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Автомобили на обслуживании";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Очередь автомобилей";
            // 
            // textBox_ServiceClientName
            // 
            this.textBox_ServiceClientName.Location = new System.Drawing.Point(96, 69);
            this.textBox_ServiceClientName.Name = "textBox_ServiceClientName";
            this.textBox_ServiceClientName.Size = new System.Drawing.Size(100, 20);
            this.textBox_ServiceClientName.TabIndex = 4;
            // 
            // listBox_ServiceCarsQueue
            // 
            this.listBox_ServiceCarsQueue.FormattingEnabled = true;
            this.listBox_ServiceCarsQueue.Location = new System.Drawing.Point(9, 142);
            this.listBox_ServiceCarsQueue.Name = "listBox_ServiceCarsQueue";
            this.listBox_ServiceCarsQueue.Size = new System.Drawing.Size(229, 95);
            this.listBox_ServiceCarsQueue.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Клиент";
            // 
            // textBox_ServiceStaffName
            // 
            this.textBox_ServiceStaffName.Location = new System.Drawing.Point(96, 33);
            this.textBox_ServiceStaffName.Name = "textBox_ServiceStaffName";
            this.textBox_ServiceStaffName.Size = new System.Drawing.Size(100, 20);
            this.textBox_ServiceStaffName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Мастер";
            // 
            // button_AddCarToService
            // 
            this.button_AddCarToService.Location = new System.Drawing.Point(9, 256);
            this.button_AddCarToService.Name = "button_AddCarToService";
            this.button_AddCarToService.Size = new System.Drawing.Size(75, 23);
            this.button_AddCarToService.TabIndex = 8;
            this.button_AddCarToService.Text = "Добавить";
            this.button_AddCarToService.UseVisualStyleBackColor = true;
            this.button_AddCarToService.Click += new System.EventHandler(this.button_AddCarToService_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Avto Service";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddCountry;
        private System.Windows.Forms.Label label_CountryCode;
        private System.Windows.Forms.Label label_CountryName;
        private System.Windows.Forms.ListBox listCountry;
        private System.Windows.Forms.TextBox textBox_CountryCode;
        private System.Windows.Forms.TextBox textBox_CountryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_CarsType;
        private System.Windows.Forms.TextBox textBox_CarWeight;
        private System.Windows.Forms.TextBox textBox_CarYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_CarsCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_AddCar;
        private System.Windows.Forms.ListBox listBox_CarsList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox_ServiceCarsInService;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ServiceClientName;
        private System.Windows.Forms.ListBox listBox_ServiceCarsQueue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ServiceStaffName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_AddCarToService;
    }
}

