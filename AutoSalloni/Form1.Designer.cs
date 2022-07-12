
namespace AutoSalloni
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
            this.cbFirma = new System.Windows.Forms.ComboBox();
            this.cbColour = new System.Windows.Forms.ComboBox();
            this.lbCarDetails = new System.Windows.Forms.ListBox();
            this.cbTransmission = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtDoors = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.lblDateOfSale = new System.Windows.Forms.Label();
            this.lblDoors = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbFirma
            // 
            this.cbFirma.FormattingEnabled = true;
            this.cbFirma.Items.AddRange(new object[] {
            "AUDI",
            "BMW",
            "OPEL",
            "MERCEDES",
            "TOYOTA",
            "VOLVO",
            "VOLKWAGEN"});
            this.cbFirma.Location = new System.Drawing.Point(470, 22);
            this.cbFirma.Name = "cbFirma";
            this.cbFirma.Size = new System.Drawing.Size(201, 23);
            this.cbFirma.TabIndex = 0;
            // 
            // cbColour
            // 
            this.cbColour.FormattingEnabled = true;
            this.cbColour.Items.AddRange(new object[] {
            "RED",
            "WHITE",
            "BLACK",
            "ORANGE",
            "BLUE",
            "GRAY"});
            this.cbColour.Location = new System.Drawing.Point(470, 254);
            this.cbColour.Name = "cbColour";
            this.cbColour.Size = new System.Drawing.Size(201, 23);
            this.cbColour.TabIndex = 1;
            this.cbColour.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lbCarDetails
            // 
            this.lbCarDetails.FormattingEnabled = true;
            this.lbCarDetails.ItemHeight = 15;
            this.lbCarDetails.Location = new System.Drawing.Point(68, 41);
            this.lbCarDetails.Name = "lbCarDetails";
            this.lbCarDetails.Size = new System.Drawing.Size(218, 364);
            this.lbCarDetails.TabIndex = 2;
            this.lbCarDetails.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cbTransmission
            // 
            this.cbTransmission.FormattingEnabled = true;
            this.cbTransmission.Items.AddRange(new object[] {
            "AUTOMATIC",
            "MANUAL"});
            this.cbTransmission.Location = new System.Drawing.Point(470, 109);
            this.cbTransmission.Name = "cbTransmission";
            this.cbTransmission.Size = new System.Drawing.Size(201, 23);
            this.cbTransmission.TabIndex = 3;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000"});
            this.cbYear.Location = new System.Drawing.Point(470, 80);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(201, 23);
            this.cbYear.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(470, 51);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(201, 23);
            this.txtModel.TabIndex = 7;
            // 
            // txtDoors
            // 
            this.txtDoors.Location = new System.Drawing.Point(470, 167);
            this.txtDoors.Name = "txtDoors";
            this.txtDoors.Size = new System.Drawing.Size(201, 23);
            this.txtDoors.TabIndex = 9;
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(470, 196);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(201, 23);
            this.txtSeats.TabIndex = 10;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(470, 225);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(201, 23);
            this.txtKm.TabIndex = 11;
            // 
            // lblDateOfSale
            // 
            this.lblDateOfSale.AutoSize = true;
            this.lblDateOfSale.Location = new System.Drawing.Point(389, 143);
            this.lblDateOfSale.Name = "lblDateOfSale";
            this.lblDateOfSale.Size = new System.Drawing.Size(68, 15);
            this.lblDateOfSale.TabIndex = 12;
            this.lblDateOfSale.Text = "Date of sale";
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Location = new System.Drawing.Point(419, 170);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(38, 15);
            this.lblDoors.TabIndex = 13;
            this.lblDoors.Text = "Doors";
            this.lblDoors.Click += new System.EventHandler(this.lblDoors_Click);
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(423, 199);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(34, 15);
            this.lblSeats.TabIndex = 14;
            this.lblSeats.Text = "Seats";
            this.lblSeats.Click += new System.EventHandler(this.lblSeats_Click);
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(432, 228);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(25, 15);
            this.lblKm.TabIndex = 15;
            this.lblKm.Text = "Km";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(414, 257);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(43, 15);
            this.lblColour.TabIndex = 18;
            this.lblColour.Text = "Colour";
            this.lblColour.Click += new System.EventHandler(this.lblColour_Click);
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(420, 25);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(37, 15);
            this.lblFirma.TabIndex = 20;
            this.lblFirma.Text = "Firma";
            this.lblFirma.Click += new System.EventHandler(this.lblFirma_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(428, 83);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 15);
            this.lblYear.TabIndex = 21;
            this.lblYear.Text = "Year";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Location = new System.Drawing.Point(382, 112);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(75, 15);
            this.lblTransmission.TabIndex = 22;
            this.lblTransmission.Text = "Transmission";
            this.lblTransmission.Click += new System.EventHandler(this.lblTransmission_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(416, 54);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(41, 15);
            this.lblModel.TabIndex = 23;
            this.lblModel.Text = "Model";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(211, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(470, 315);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(201, 23);
            this.btnClean.TabIndex = 25;
            this.btnClean.Text = "Clean up";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(470, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add / Edit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(471, 137);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.lblDoors);
            this.Controls.Add(this.lblDateOfSale);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.txtDoors);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbTransmission);
            this.Controls.Add(this.lbCarDetails);
            this.Controls.Add(this.cbColour);
            this.Controls.Add(this.cbFirma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFirma;
        private System.Windows.Forms.ComboBox cbColour;
        private System.Windows.Forms.ListBox lbCarDetails;
        private System.Windows.Forms.ComboBox cbTransmission;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label lblDateOfSale;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDoors;
    }
}

