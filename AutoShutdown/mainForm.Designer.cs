﻿namespace AutoShutdown
{
    partial class mainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numericUpDown_value = new System.Windows.Forms.NumericUpDown();
            this.comboBox_actionType = new System.Windows.Forms.ComboBox();
            this.label_actionType = new System.Windows.Forms.Label();
            this.statusStrip_default = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_CurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_AddToList = new System.Windows.Forms.Button();
            this.label_trigger = new System.Windows.Forms.Label();
            this.comboBox_triggerType = new System.Windows.Forms.ComboBox();
            this.label_value = new System.Windows.Forms.Label();
            this.dateTimePicker_time = new System.Windows.Forms.DateTimePicker();
            this.label_firstly_choose_a_trigger = new System.Windows.Forms.Label();
            this.contextMenuStrip_mainGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_taskList = new System.Windows.Forms.DataGridView();
            this.groupBox_actionList = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_value)).BeginInit();
            this.statusStrip_default.SuspendLayout();
            this.contextMenuStrip_mainGrid.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_taskList)).BeginInit();
            this.groupBox_actionList.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown_value
            // 
            this.numericUpDown_value.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_value.Location = new System.Drawing.Point(170, 126);
            this.numericUpDown_value.Name = "numericUpDown_value";
            this.numericUpDown_value.Size = new System.Drawing.Size(257, 25);
            this.numericUpDown_value.TabIndex = 2;
            this.numericUpDown_value.Visible = false;
            // 
            // comboBox_actionType
            // 
            this.comboBox_actionType.BackColor = System.Drawing.Color.White;
            this.comboBox_actionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_actionType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_actionType.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_actionType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox_actionType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_actionType.Location = new System.Drawing.Point(170, 38);
            this.comboBox_actionType.Name = "comboBox_actionType";
            this.comboBox_actionType.Size = new System.Drawing.Size(257, 28);
            this.comboBox_actionType.TabIndex = 5;
            this.comboBox_actionType.SelectedIndexChanged += new System.EventHandler(this.comboBox_actionType_SelectedIndexChanged);
            // 
            // label_actionType
            // 
            this.label_actionType.AutoSize = true;
            this.label_actionType.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_actionType.Location = new System.Drawing.Point(26, 41);
            this.label_actionType.Name = "label_actionType";
            this.label_actionType.Size = new System.Drawing.Size(92, 20);
            this.label_actionType.TabIndex = 7;
            this.label_actionType.Text = "actionType:";
            // 
            // statusStrip_default
            // 
            this.statusStrip_default.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_CurrentTime});
            this.statusStrip_default.Location = new System.Drawing.Point(0, 462);
            this.statusStrip_default.Name = "statusStrip_default";
            this.statusStrip_default.Size = new System.Drawing.Size(529, 22);
            this.statusStrip_default.SizingGrip = false;
            this.statusStrip_default.TabIndex = 8;
            this.statusStrip_default.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_CurrentTime
            // 
            this.toolStripStatusLabel_CurrentTime.Name = "toolStripStatusLabel_CurrentTime";
            this.toolStripStatusLabel_CurrentTime.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel_CurrentTime.Text = "CurrentTime";
            // 
            // button_AddToList
            // 
            this.button_AddToList.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AddToList.Location = new System.Drawing.Point(40, 193);
            this.button_AddToList.Name = "button_AddToList";
            this.button_AddToList.Size = new System.Drawing.Size(448, 28);
            this.button_AddToList.TabIndex = 12;
            this.button_AddToList.Text = "Add Action";
            this.button_AddToList.UseVisualStyleBackColor = true;
            this.button_AddToList.Click += new System.EventHandler(this.button_AddToList_Click);
            // 
            // label_trigger
            // 
            this.label_trigger.AutoSize = true;
            this.label_trigger.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_trigger.Location = new System.Drawing.Point(26, 85);
            this.label_trigger.Name = "label_trigger";
            this.label_trigger.Size = new System.Drawing.Size(67, 20);
            this.label_trigger.TabIndex = 14;
            this.label_trigger.Text = "trigger: ";
            // 
            // comboBox_triggerType
            // 
            this.comboBox_triggerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_triggerType.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_triggerType.FormattingEnabled = true;
            this.comboBox_triggerType.Location = new System.Drawing.Point(170, 82);
            this.comboBox_triggerType.Name = "comboBox_triggerType";
            this.comboBox_triggerType.Size = new System.Drawing.Size(257, 28);
            this.comboBox_triggerType.TabIndex = 13;
            this.comboBox_triggerType.SelectedIndexChanged += new System.EventHandler(this.comboBox_trigger_SelectedIndexChanged);
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_value.Location = new System.Drawing.Point(26, 128);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(59, 20);
            this.label_value.TabIndex = 15;
            this.label_value.Text = "value: ";
            // 
            // dateTimePicker_time
            // 
            this.dateTimePicker_time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_time.CustomFormat = "HH:mm";
            this.dateTimePicker_time.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_time.Location = new System.Drawing.Point(170, 126);
            this.dateTimePicker_time.Name = "dateTimePicker_time";
            this.dateTimePicker_time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker_time.RightToLeftLayout = true;
            this.dateTimePicker_time.ShowUpDown = true;
            this.dateTimePicker_time.Size = new System.Drawing.Size(257, 25);
            this.dateTimePicker_time.TabIndex = 17;
            this.dateTimePicker_time.Visible = false;
            // 
            // label_firstly_choose_a_trigger
            // 
            this.label_firstly_choose_a_trigger.AutoSize = true;
            this.label_firstly_choose_a_trigger.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_firstly_choose_a_trigger.Location = new System.Drawing.Point(166, 128);
            this.label_firstly_choose_a_trigger.Name = "label_firstly_choose_a_trigger";
            this.label_firstly_choose_a_trigger.Size = new System.Drawing.Size(188, 20);
            this.label_firstly_choose_a_trigger.TabIndex = 18;
            this.label_firstly_choose_a_trigger.Text = "Firstly, choose a trigger... ";
            // 
            // contextMenuStrip_mainGrid
            // 
            this.contextMenuStrip_mainGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedTaskToolStripMenuItem});
            this.contextMenuStrip_mainGrid.Name = "contextMenuStrip_mainGrid";
            this.contextMenuStrip_mainGrid.Size = new System.Drawing.Size(180, 26);
            // 
            // deleteSelectedTaskToolStripMenuItem
            // 
            this.deleteSelectedTaskToolStripMenuItem.Name = "deleteSelectedTaskToolStripMenuItem";
            this.deleteSelectedTaskToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteSelectedTaskToolStripMenuItem.Text = "Delete Selected Task";
            this.deleteSelectedTaskToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedTaskToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_actionType);
            this.groupBox2.Controls.Add(this.label_actionType);
            this.groupBox2.Controls.Add(this.label_firstly_choose_a_trigger);
            this.groupBox2.Controls.Add(this.label_trigger);
            this.groupBox2.Controls.Add(this.comboBox_triggerType);
            this.groupBox2.Controls.Add(this.dateTimePicker_time);
            this.groupBox2.Controls.Add(this.label_value);
            this.groupBox2.Controls.Add(this.numericUpDown_value);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(40, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 175);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Action";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_taskList);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 174);
            this.panel2.TabIndex = 19;
            // 
            // dataGridView_taskList
            // 
            this.dataGridView_taskList.AllowUserToAddRows = false;
            this.dataGridView_taskList.AllowUserToDeleteRows = false;
            this.dataGridView_taskList.AllowUserToResizeColumns = false;
            this.dataGridView_taskList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_taskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_taskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_taskList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_taskList.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_taskList.Name = "dataGridView_taskList";
            this.dataGridView_taskList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_taskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_taskList.RowHeadersVisible = false;
            this.dataGridView_taskList.ShowCellErrors = false;
            this.dataGridView_taskList.Size = new System.Drawing.Size(448, 174);
            this.dataGridView_taskList.TabIndex = 9;
            this.dataGridView_taskList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_taskList_CellContentClick);
            this.dataGridView_taskList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_taskList_RowsAdded);
            this.dataGridView_taskList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_taskList_RowsRemoved);
            // 
            // groupBox_actionList
            // 
            this.groupBox_actionList.Controls.Add(this.panel2);
            this.groupBox_actionList.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_actionList.Location = new System.Drawing.Point(40, 245);
            this.groupBox_actionList.Name = "groupBox_actionList";
            this.groupBox_actionList.Size = new System.Drawing.Size(448, 201);
            this.groupBox_actionList.TabIndex = 20;
            this.groupBox_actionList.TabStop = false;
            this.groupBox_actionList.Text = "Action List";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_actionList);
            this.Controls.Add(this.statusStrip_default);
            this.Controls.Add(this.button_AddToList);
            this.Name = "mainForm";
            this.Text = "System Shutdown Manager";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_value)).EndInit();
            this.statusStrip_default.ResumeLayout(false);
            this.statusStrip_default.PerformLayout();
            this.contextMenuStrip_mainGrid.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_taskList)).EndInit();
            this.groupBox_actionList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown_value;
        private System.Windows.Forms.ComboBox comboBox_actionType;
        private System.Windows.Forms.Label label_actionType;
        private System.Windows.Forms.StatusStrip statusStrip_default;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_CurrentTime;
        private System.Windows.Forms.Button button_AddToList;
        private System.Windows.Forms.Label label_trigger;
        private System.Windows.Forms.ComboBox comboBox_triggerType;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.DateTimePicker dateTimePicker_time;
        private System.Windows.Forms.Label label_firstly_choose_a_trigger;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_mainGrid;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedTaskToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_taskList;
        private System.Windows.Forms.GroupBox groupBox_actionList;
    }
}