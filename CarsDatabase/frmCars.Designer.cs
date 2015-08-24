namespace CarsDatabase
{
    partial class frmCars
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
            this.components = new System.ComponentModel.Container();
            this.labelCompany = new System.Windows.Forms.Label();
            this.textReg = new System.Windows.Forms.TextBox();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet = new CarsDatabase.HireDataSet();
            this.textMake = new System.Windows.Forms.TextBox();
            this.textEngine = new System.Windows.Forms.TextBox();
            this.textRent = new System.Windows.Forms.TextBox();
            this.checkAvailable = new System.Windows.Forms.CheckBox();
            this.labelReg = new System.Windows.Forms.Label();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelEngine = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelRent = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.textCounter = new System.Windows.Forms.TextBox();
            this.tblCarTableAdapter = new CarsDatabase.HireDataSetTableAdapters.tblCarTableAdapter();
            this.tableAdapterManager = new CarsDatabase.HireDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompany.Location = new System.Drawing.Point(132, 36);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(300, 32);
            this.labelCompany.TabIndex = 0;
            this.labelCompany.Text = "Bowman Car Hire";
            // 
            // textReg
            // 
            this.textReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "VehicleRegNo", true));
            this.textReg.Location = new System.Drawing.Point(272, 121);
            this.textReg.Name = "textReg";
            this.textReg.Size = new System.Drawing.Size(161, 20);
            this.textReg.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textReg, "Enter the vehicle registration number");
            // 
            // tblCarBindingSource
            // 
            this.tblCarBindingSource.DataMember = "tblCar";
            this.tblCarBindingSource.DataSource = this.hireDataSet;
            // 
            // hireDataSet
            // 
            this.hireDataSet.DataSetName = "HireDataSet";
            this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textMake
            // 
            this.textMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "Make", true));
            this.textMake.Location = new System.Drawing.Point(272, 157);
            this.textMake.Name = "textMake";
            this.textMake.Size = new System.Drawing.Size(161, 20);
            this.textMake.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textMake, "Enter the make of the vehicle.");
            // 
            // textEngine
            // 
            this.textEngine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "EngineSize", true));
            this.textEngine.Location = new System.Drawing.Point(272, 194);
            this.textEngine.Name = "textEngine";
            this.textEngine.Size = new System.Drawing.Size(161, 20);
            this.textEngine.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textEngine, "Enter the engine size.");
            // 
            // textRent
            // 
            this.textRent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "RentalPerDay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.textRent.Location = new System.Drawing.Point(272, 269);
            this.textRent.Name = "textRent";
            this.textRent.Size = new System.Drawing.Size(161, 20);
            this.textRent.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textRent, "Enter daily rental price.");
            // 
            // checkAvailable
            // 
            this.checkAvailable.AutoSize = true;
            this.checkAvailable.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblCarBindingSource, "Available", true));
            this.checkAvailable.Location = new System.Drawing.Point(272, 307);
            this.checkAvailable.Name = "checkAvailable";
            this.checkAvailable.Size = new System.Drawing.Size(15, 14);
            this.checkAvailable.TabIndex = 5;
            this.toolTip1.SetToolTip(this.checkAvailable, "Check the box if vehicle is available.");
            this.checkAvailable.UseVisualStyleBackColor = true;
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Location = new System.Drawing.Point(102, 121);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(134, 13);
            this.labelReg.TabIndex = 7;
            this.labelReg.Text = "Vehicle registration number";
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Location = new System.Drawing.Point(102, 157);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(34, 13);
            this.labelMake.TabIndex = 8;
            this.labelMake.Text = "Make";
            // 
            // labelEngine
            // 
            this.labelEngine.AutoSize = true;
            this.labelEngine.Location = new System.Drawing.Point(102, 194);
            this.labelEngine.Name = "labelEngine";
            this.labelEngine.Size = new System.Drawing.Size(61, 13);
            this.labelEngine.TabIndex = 9;
            this.labelEngine.Text = "Engine size";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(102, 231);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(79, 13);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Date registered";
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.Location = new System.Drawing.Point(102, 269);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(76, 13);
            this.labelRent.TabIndex = 11;
            this.labelRent.Text = "Rental per day";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Location = new System.Drawing.Point(104, 307);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(50, 13);
            this.labelAvailable.TabIndex = 12;
            this.labelAvailable.Text = "Available";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(515, 68);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 36);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(515, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 36);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(515, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 36);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(515, 215);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 36);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(515, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(515, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 36);
            this.btnExit.TabIndex = 18;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(41, 385);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(102, 36);
            this.btnFirst.TabIndex = 19;
            this.btnFirst.TabStop = false;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(149, 385);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 36);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(407, 385);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 36);
            this.btnNext.TabIndex = 21;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(515, 385);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(102, 36);
            this.btnLast.TabIndex = 22;
            this.btnLast.TabStop = false;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.button10_Click);
            // 
            // textCounter
            // 
            this.textCounter.Location = new System.Drawing.Point(272, 394);
            this.textCounter.Name = "textCounter";
            this.textCounter.ReadOnly = true;
            this.textCounter.Size = new System.Drawing.Size(113, 20);
            this.textCounter.TabIndex = 23;
            this.textCounter.TabStop = false;
            this.textCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tblCarTableAdapter
            // 
            this.tblCarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCarTableAdapter = this.tblCarTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarsDatabase.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "DateRegistered", true));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(272, 231);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dateTimePicker, "Enter the registration date.");
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 459);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textCounter);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelAvailable);
            this.Controls.Add(this.labelRent);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelEngine);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.checkAvailable);
            this.Controls.Add(this.textRent);
            this.Controls.Add(this.textEngine);
            this.Controls.Add(this.textMake);
            this.Controls.Add(this.textReg);
            this.Controls.Add(this.labelCompany);
            this.Name = "frmCars";
            this.Text = "Task A - Joe Marsh - 20/08/2015";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.TextBox textReg;
        private System.Windows.Forms.TextBox textMake;
        private System.Windows.Forms.TextBox textEngine;
        private System.Windows.Forms.TextBox textRent;
        private System.Windows.Forms.CheckBox checkAvailable;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelEngine;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox textCounter;
        private HireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private HireDataSetTableAdapters.tblCarTableAdapter tblCarTableAdapter;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

