namespace GymProject
{
    partial class Form9
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.daynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partofbodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareket1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareket2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareket3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareket4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareket5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workoutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet2 = new GymProject.GymDataSet2();
            this.workoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet1 = new GymProject.GymDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gymDataSet = new GymProject.GymDataSet();
            this.gymDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.workoutTableAdapter = new GymProject.GymDataSet1TableAdapters.workoutTableAdapter();
            this.workoutTableAdapter1 = new GymProject.GymDataSet2TableAdapters.workoutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.daynameDataGridViewTextBoxColumn,
            this.partofbodyDataGridViewTextBoxColumn,
            this.hareket1DataGridViewTextBoxColumn,
            this.hareket2DataGridViewTextBoxColumn,
            this.hareket3DataGridViewTextBoxColumn,
            this.hareket4DataGridViewTextBoxColumn,
            this.hareket5DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workoutBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(46, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // daynameDataGridViewTextBoxColumn
            // 
            this.daynameDataGridViewTextBoxColumn.DataPropertyName = "day_name";
            this.daynameDataGridViewTextBoxColumn.HeaderText = "Day";
            this.daynameDataGridViewTextBoxColumn.Name = "daynameDataGridViewTextBoxColumn";
            // 
            // partofbodyDataGridViewTextBoxColumn
            // 
            this.partofbodyDataGridViewTextBoxColumn.DataPropertyName = "part_of_body";
            this.partofbodyDataGridViewTextBoxColumn.HeaderText = "Body Part";
            this.partofbodyDataGridViewTextBoxColumn.Name = "partofbodyDataGridViewTextBoxColumn";
            // 
            // hareket1DataGridViewTextBoxColumn
            // 
            this.hareket1DataGridViewTextBoxColumn.DataPropertyName = "hareket_1";
            this.hareket1DataGridViewTextBoxColumn.HeaderText = "Exercise 1";
            this.hareket1DataGridViewTextBoxColumn.Name = "hareket1DataGridViewTextBoxColumn";
            // 
            // hareket2DataGridViewTextBoxColumn
            // 
            this.hareket2DataGridViewTextBoxColumn.DataPropertyName = "hareket_2";
            this.hareket2DataGridViewTextBoxColumn.HeaderText = "Exercise 2";
            this.hareket2DataGridViewTextBoxColumn.Name = "hareket2DataGridViewTextBoxColumn";
            // 
            // hareket3DataGridViewTextBoxColumn
            // 
            this.hareket3DataGridViewTextBoxColumn.DataPropertyName = "hareket_3";
            this.hareket3DataGridViewTextBoxColumn.HeaderText = "Exercise 3";
            this.hareket3DataGridViewTextBoxColumn.Name = "hareket3DataGridViewTextBoxColumn";
            // 
            // hareket4DataGridViewTextBoxColumn
            // 
            this.hareket4DataGridViewTextBoxColumn.DataPropertyName = "hareket_4";
            this.hareket4DataGridViewTextBoxColumn.HeaderText = "Exercise 4";
            this.hareket4DataGridViewTextBoxColumn.Name = "hareket4DataGridViewTextBoxColumn";
            // 
            // hareket5DataGridViewTextBoxColumn
            // 
            this.hareket5DataGridViewTextBoxColumn.DataPropertyName = "hareket_5";
            this.hareket5DataGridViewTextBoxColumn.HeaderText = "Exercise 5";
            this.hareket5DataGridViewTextBoxColumn.Name = "hareket5DataGridViewTextBoxColumn";
            // 
            // workoutBindingSource1
            // 
            this.workoutBindingSource1.DataMember = "workout";
            this.workoutBindingSource1.DataSource = this.gymDataSet2;
            // 
            // gymDataSet2
            // 
            this.gymDataSet2.DataSetName = "GymDataSet2";
            this.gymDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workoutBindingSource
            // 
            this.workoutBindingSource.DataMember = "workout";
            this.workoutBindingSource.DataSource = this.gymDataSet1BindingSource;
            // 
            // gymDataSet1BindingSource
            // 
            this.gymDataSet1BindingSource.DataSource = this.gymDataSet1;
            this.gymDataSet1BindingSource.Position = 0;
            // 
            // gymDataSet1
            // 
            this.gymDataSet1.DataSetName = "GymDataSet1";
            this.gymDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(286, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Workout Routine";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymDataSetBindingSource
            // 
            this.gymDataSetBindingSource.DataSource = this.gymDataSet;
            this.gymDataSetBindingSource.Position = 0;
            // 
            // gymDataSetBindingSource1
            // 
            this.gymDataSetBindingSource1.DataSource = this.gymDataSet;
            this.gymDataSetBindingSource1.Position = 0;
            // 
            // gymDataSetBindingSource2
            // 
            this.gymDataSetBindingSource2.DataSource = this.gymDataSet;
            this.gymDataSetBindingSource2.Position = 0;
            // 
            // workoutTableAdapter
            // 
            this.workoutTableAdapter.ClearBeforeFill = true;
            // 
            // workoutTableAdapter1
            // 
            this.workoutTableAdapter1.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gymDataSetBindingSource;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource gymDataSetBindingSource1;
        private System.Windows.Forms.BindingSource gymDataSetBindingSource2;
        private GymDataSet1 gymDataSet1;
        private System.Windows.Forms.BindingSource gymDataSet1BindingSource;
        private System.Windows.Forms.BindingSource workoutBindingSource;
        private GymDataSet1TableAdapters.workoutTableAdapter workoutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn daynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partofbodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareket1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareket2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareket3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareket4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareket5DataGridViewTextBoxColumn;
        private GymDataSet2 gymDataSet2;
        private System.Windows.Forms.BindingSource workoutBindingSource1;
        private GymDataSet2TableAdapters.workoutTableAdapter workoutTableAdapter1;
    }
}