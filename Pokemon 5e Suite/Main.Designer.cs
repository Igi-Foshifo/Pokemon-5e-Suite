namespace Pokemon_5e_Suite
{
    partial class Main
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
            tableLayoutPanel1 = new TableLayoutPanel();
            mainControl = new TabControl();
            sessionTab = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tabControl1 = new TabControl();
            activeSessionTab = new TabPage();
            manageSessionTab = new TabPage();
            trainerLvlUpTab = new TabPage();
            trainerLevelUpTable2 = new TrainerLevelUpTable();
            pokemonLvlUpTab = new TabPage();
            pokemonLevelUpTable2 = new Controls.Pokemon.PokemonLevelUpTable();
            trainerTab = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            tabControl2 = new TabControl();
            viewTrainersTab = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            label131 = new Label();
            trainerSearchBox = new TextBox();
            trainerListView = new ListView();
            trainerViewButton = new Button();
            addTrainerTab = new TabPage();
            addTrainer1 = new UserControls.Trainer.AddTrainer();
            editTrainerTab = new TabPage();
            pokemonTab = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            tabControl3 = new TabControl();
            viewPokemonTab = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            label137 = new Label();
            pokemonSearchBox = new TextBox();
            pokemonListView = new ListView();
            pokemonViewButton = new Button();
            addPokemonTab = new TabPage();
            editPokemonTab = new TabPage();
            tableLayoutPanel1.SuspendLayout();
            mainControl.SuspendLayout();
            sessionTab.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabControl1.SuspendLayout();
            trainerLvlUpTab.SuspendLayout();
            pokemonLvlUpTab.SuspendLayout();
            trainerTab.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabControl2.SuspendLayout();
            viewTrainersTab.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            addTrainerTab.SuspendLayout();
            pokemonTab.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabControl3.SuspendLayout();
            viewPokemonTab.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(mainControl, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1852, 941);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // mainControl
            // 
            mainControl.Alignment = TabAlignment.Left;
            mainControl.Controls.Add(sessionTab);
            mainControl.Controls.Add(trainerTab);
            mainControl.Controls.Add(pokemonTab);
            mainControl.Dock = DockStyle.Fill;
            mainControl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mainControl.Location = new Point(4, 4);
            mainControl.Margin = new Padding(4);
            mainControl.Multiline = true;
            mainControl.Name = "mainControl";
            mainControl.SelectedIndex = 0;
            mainControl.Size = new Size(1844, 933);
            mainControl.TabIndex = 0;
            // 
            // sessionTab
            // 
            sessionTab.Controls.Add(tableLayoutPanel2);
            sessionTab.Location = new Point(34, 4);
            sessionTab.Margin = new Padding(4);
            sessionTab.Name = "sessionTab";
            sessionTab.Padding = new Padding(4);
            sessionTab.Size = new Size(1806, 925);
            sessionTab.TabIndex = 0;
            sessionTab.Text = "Session";
            sessionTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tabControl1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1798, 917);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1790, 50);
            label1.TabIndex = 0;
            label1.Text = "Session\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(activeSessionTab);
            tabControl1.Controls.Add(manageSessionTab);
            tabControl1.Controls.Add(trainerLvlUpTab);
            tabControl1.Controls.Add(pokemonLvlUpTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(4, 54);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1790, 859);
            tabControl1.TabIndex = 1;
            // 
            // activeSessionTab
            // 
            activeSessionTab.Location = new Point(4, 34);
            activeSessionTab.Margin = new Padding(4);
            activeSessionTab.Name = "activeSessionTab";
            activeSessionTab.Size = new Size(1782, 821);
            activeSessionTab.TabIndex = 0;
            activeSessionTab.Text = "Active Session";
            activeSessionTab.UseVisualStyleBackColor = true;
            // 
            // manageSessionTab
            // 
            manageSessionTab.Location = new Point(4, 34);
            manageSessionTab.Margin = new Padding(4);
            manageSessionTab.Name = "manageSessionTab";
            manageSessionTab.Size = new Size(1782, 821);
            manageSessionTab.TabIndex = 3;
            manageSessionTab.Text = "Manage Sessions";
            manageSessionTab.UseVisualStyleBackColor = true;
            // 
            // trainerLvlUpTab
            // 
            trainerLvlUpTab.Controls.Add(trainerLevelUpTable2);
            trainerLvlUpTab.Location = new Point(4, 34);
            trainerLvlUpTab.Margin = new Padding(4);
            trainerLvlUpTab.Name = "trainerLvlUpTab";
            trainerLvlUpTab.Size = new Size(1782, 821);
            trainerLvlUpTab.TabIndex = 1;
            trainerLvlUpTab.Text = "Trainer Level Up Table";
            trainerLvlUpTab.UseVisualStyleBackColor = true;
            // 
            // trainerLevelUpTable2
            // 
            trainerLevelUpTable2.Dock = DockStyle.Fill;
            trainerLevelUpTable2.Location = new Point(0, 0);
            trainerLevelUpTable2.Margin = new Padding(4, 4, 4, 4);
            trainerLevelUpTable2.Name = "trainerLevelUpTable2";
            trainerLevelUpTable2.Size = new Size(1782, 821);
            trainerLevelUpTable2.TabIndex = 0;
            // 
            // pokemonLvlUpTab
            // 
            pokemonLvlUpTab.Controls.Add(pokemonLevelUpTable2);
            pokemonLvlUpTab.Location = new Point(4, 34);
            pokemonLvlUpTab.Margin = new Padding(4);
            pokemonLvlUpTab.Name = "pokemonLvlUpTab";
            pokemonLvlUpTab.Size = new Size(1782, 821);
            pokemonLvlUpTab.TabIndex = 2;
            pokemonLvlUpTab.Text = "Pokemon Level Up Table";
            pokemonLvlUpTab.UseVisualStyleBackColor = true;
            // 
            // pokemonLevelUpTable2
            // 
            pokemonLevelUpTable2.Dock = DockStyle.Fill;
            pokemonLevelUpTable2.Location = new Point(0, 0);
            pokemonLevelUpTable2.Margin = new Padding(4, 4, 4, 4);
            pokemonLevelUpTable2.Name = "pokemonLevelUpTable2";
            pokemonLevelUpTable2.Size = new Size(1782, 821);
            pokemonLevelUpTable2.TabIndex = 0;
            // 
            // trainerTab
            // 
            trainerTab.Controls.Add(tableLayoutPanel3);
            trainerTab.Location = new Point(64, 4);
            trainerTab.Margin = new Padding(4);
            trainerTab.Name = "trainerTab";
            trainerTab.Padding = new Padding(4);
            trainerTab.Size = new Size(132, 92);
            trainerTab.TabIndex = 1;
            trainerTab.Text = "Trainer";
            trainerTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(tabControl2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 4);
            tableLayoutPanel3.Margin = new Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(124, 84);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 50);
            label3.TabIndex = 0;
            label3.Text = "Trainer Management";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl2
            // 
            tabControl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl2.Controls.Add(viewTrainersTab);
            tabControl2.Controls.Add(addTrainerTab);
            tabControl2.Controls.Add(editTrainerTab);
            tabControl2.Location = new Point(4, 54);
            tabControl2.Margin = new Padding(4);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(116, 26);
            tabControl2.TabIndex = 1;
            // 
            // viewTrainersTab
            // 
            viewTrainersTab.Controls.Add(tableLayoutPanel8);
            viewTrainersTab.Location = new Point(4, 34);
            viewTrainersTab.Margin = new Padding(4);
            viewTrainersTab.Name = "viewTrainersTab";
            viewTrainersTab.Padding = new Padding(4);
            viewTrainersTab.Size = new Size(108, 0);
            viewTrainersTab.TabIndex = 0;
            viewTrainersTab.Text = "View Trainers";
            viewTrainersTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel8.Controls.Add(label131, 0, 0);
            tableLayoutPanel8.Controls.Add(trainerSearchBox, 1, 0);
            tableLayoutPanel8.Controls.Add(trainerListView, 0, 1);
            tableLayoutPanel8.Controls.Add(trainerViewButton, 3, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(4, 4);
            tableLayoutPanel8.Margin = new Padding(4);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel8.Size = new Size(100, 0);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // label131
            // 
            label131.AutoSize = true;
            label131.Dock = DockStyle.Fill;
            label131.Location = new Point(4, 0);
            label131.Margin = new Padding(4, 0, 4, 0);
            label131.Name = "label131";
            label131.Size = new Size(2, 1);
            label131.TabIndex = 0;
            label131.Text = "Search";
            label131.TextAlign = ContentAlignment.MiddleRight;
            // 
            // trainerSearchBox
            // 
            trainerSearchBox.Dock = DockStyle.Fill;
            trainerSearchBox.Location = new Point(14, 4);
            trainerSearchBox.Margin = new Padding(4);
            trainerSearchBox.Name = "trainerSearchBox";
            trainerSearchBox.Size = new Size(12, 31);
            trainerSearchBox.TabIndex = 1;
            // 
            // trainerListView
            // 
            tableLayoutPanel8.SetColumnSpan(trainerListView, 4);
            trainerListView.Dock = DockStyle.Fill;
            trainerListView.Location = new Point(4, 4);
            trainerListView.Margin = new Padding(4);
            trainerListView.Name = "trainerListView";
            trainerListView.Size = new Size(92, 1);
            trainerListView.TabIndex = 2;
            trainerListView.UseCompatibleStateImageBehavior = false;
            // 
            // trainerViewButton
            // 
            trainerViewButton.Dock = DockStyle.Fill;
            trainerViewButton.Location = new Point(89, 4);
            trainerViewButton.Margin = new Padding(4);
            trainerViewButton.Name = "trainerViewButton";
            trainerViewButton.Size = new Size(7, 1);
            trainerViewButton.TabIndex = 3;
            trainerViewButton.Text = "View";
            trainerViewButton.UseVisualStyleBackColor = true;
            // 
            // addTrainerTab
            // 
            addTrainerTab.AutoScroll = true;
            addTrainerTab.AutoScrollMinSize = new Size(1400, 1000);
            addTrainerTab.Controls.Add(addTrainer1);
            addTrainerTab.Location = new Point(4, 34);
            addTrainerTab.Margin = new Padding(4);
            addTrainerTab.Name = "addTrainerTab";
            addTrainerTab.Padding = new Padding(4);
            addTrainerTab.Size = new Size(192, 62);
            addTrainerTab.TabIndex = 1;
            addTrainerTab.Text = "Add Trainer";
            addTrainerTab.UseVisualStyleBackColor = true;
            // 
            // addTrainer1
            // 
            addTrainer1.Dock = DockStyle.Top;
            addTrainer1.Location = new Point(4, 4);
            addTrainer1.Margin = new Padding(5);
            addTrainer1.MinimumSize = new Size(1750, 1250);
            addTrainer1.Name = "addTrainer1";
            addTrainer1.Size = new Size(1750, 1250);
            addTrainer1.TabIndex = 0;
            // 
            // editTrainerTab
            // 
            editTrainerTab.AutoScroll = true;
            editTrainerTab.Location = new Point(4, 34);
            editTrainerTab.Margin = new Padding(4);
            editTrainerTab.Name = "editTrainerTab";
            editTrainerTab.Size = new Size(192, 62);
            editTrainerTab.TabIndex = 2;
            editTrainerTab.Text = "Edit Trainer";
            editTrainerTab.UseVisualStyleBackColor = true;
            // 
            // pokemonTab
            // 
            pokemonTab.Controls.Add(tableLayoutPanel4);
            pokemonTab.Location = new Point(94, 4);
            pokemonTab.Margin = new Padding(4);
            pokemonTab.Name = "pokemonTab";
            pokemonTab.Padding = new Padding(4);
            pokemonTab.Size = new Size(102, 92);
            pokemonTab.TabIndex = 2;
            pokemonTab.Text = "Pokemon";
            pokemonTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(tabControl3, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(4, 4);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(94, 84);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(4, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 50);
            label4.TabIndex = 0;
            label4.Text = "Pokemon Management";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(viewPokemonTab);
            tabControl3.Controls.Add(addPokemonTab);
            tabControl3.Controls.Add(editPokemonTab);
            tabControl3.Dock = DockStyle.Fill;
            tabControl3.Location = new Point(4, 54);
            tabControl3.Margin = new Padding(4);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(86, 26);
            tabControl3.TabIndex = 1;
            // 
            // viewPokemonTab
            // 
            viewPokemonTab.Controls.Add(tableLayoutPanel9);
            viewPokemonTab.Location = new Point(4, 34);
            viewPokemonTab.Margin = new Padding(4);
            viewPokemonTab.Name = "viewPokemonTab";
            viewPokemonTab.Padding = new Padding(4);
            viewPokemonTab.Size = new Size(78, 0);
            viewPokemonTab.TabIndex = 0;
            viewPokemonTab.Text = "View Pokemon";
            viewPokemonTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 4;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel9.Controls.Add(label137, 0, 0);
            tableLayoutPanel9.Controls.Add(pokemonSearchBox, 1, 0);
            tableLayoutPanel9.Controls.Add(pokemonListView, 0, 1);
            tableLayoutPanel9.Controls.Add(pokemonViewButton, 3, 2);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(4, 4);
            tableLayoutPanel9.Margin = new Padding(4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel9.Size = new Size(70, 0);
            tableLayoutPanel9.TabIndex = 1;
            // 
            // label137
            // 
            label137.AutoSize = true;
            label137.Dock = DockStyle.Fill;
            label137.Location = new Point(4, 0);
            label137.Margin = new Padding(4, 0, 4, 0);
            label137.Name = "label137";
            label137.Size = new Size(1, 1);
            label137.TabIndex = 0;
            label137.Text = "Search";
            label137.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pokemonSearchBox
            // 
            pokemonSearchBox.Dock = DockStyle.Fill;
            pokemonSearchBox.Location = new Point(11, 4);
            pokemonSearchBox.Margin = new Padding(4);
            pokemonSearchBox.Name = "pokemonSearchBox";
            pokemonSearchBox.Size = new Size(6, 31);
            pokemonSearchBox.TabIndex = 1;
            // 
            // pokemonListView
            // 
            tableLayoutPanel9.SetColumnSpan(pokemonListView, 4);
            pokemonListView.Dock = DockStyle.Fill;
            pokemonListView.Location = new Point(4, 4);
            pokemonListView.Margin = new Padding(4);
            pokemonListView.Name = "pokemonListView";
            pokemonListView.Size = new Size(62, 1);
            pokemonListView.TabIndex = 2;
            pokemonListView.UseCompatibleStateImageBehavior = false;
            // 
            // pokemonViewButton
            // 
            pokemonViewButton.Dock = DockStyle.Fill;
            pokemonViewButton.Location = new Point(63, 4);
            pokemonViewButton.Margin = new Padding(4);
            pokemonViewButton.Name = "pokemonViewButton";
            pokemonViewButton.Size = new Size(3, 1);
            pokemonViewButton.TabIndex = 3;
            pokemonViewButton.Text = "View";
            pokemonViewButton.UseVisualStyleBackColor = true;
            // 
            // addPokemonTab
            // 
            addPokemonTab.AutoScroll = true;
            addPokemonTab.Location = new Point(4, 34);
            addPokemonTab.Margin = new Padding(4);
            addPokemonTab.Name = "addPokemonTab";
            addPokemonTab.Padding = new Padding(4);
            addPokemonTab.Size = new Size(1783, 822);
            addPokemonTab.TabIndex = 1;
            addPokemonTab.Text = "Add Pokemon";
            addPokemonTab.UseVisualStyleBackColor = true;
            // 
            // editPokemonTab
            // 
            editPokemonTab.AutoScroll = true;
            editPokemonTab.Location = new Point(4, 34);
            editPokemonTab.Margin = new Padding(4);
            editPokemonTab.Name = "editPokemonTab";
            editPokemonTab.Size = new Size(1783, 822);
            editPokemonTab.TabIndex = 2;
            editPokemonTab.Text = "Edit Pokemon";
            editPokemonTab.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 941);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            Text = "Pokemon 5e Suite";
            Load += OnMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            mainControl.ResumeLayout(false);
            sessionTab.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            trainerLvlUpTab.ResumeLayout(false);
            pokemonLvlUpTab.ResumeLayout(false);
            trainerTab.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tabControl2.ResumeLayout(false);
            viewTrainersTab.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            addTrainerTab.ResumeLayout(false);
            pokemonTab.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tabControl3.ResumeLayout(false);
            viewPokemonTab.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl mainControl;
        private TabPage sessionTab;
        private TabPage trainerTab;
        private TabPage pokemonTab;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private TabControl tabControl1;
        private TabPage activeSessionTab;
        private TabPage trainerLvlUpTab;
        private TabControl tabControl2;
        private TabPage viewTrainersTab;
        private TabPage addTrainerTab;
        private TabPage editTrainerTab;
        private TabControl tabControl3;
        private TabPage viewPokemonTab;
        private TabPage addPokemonTab;
        private TabPage editPokemonTab;
        private TabPage pokemonLvlUpTab;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label131;
        private TextBox trainerSearchBox;
        private ListView trainerListView;
        private Button trainerViewButton;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label137;
        private TextBox pokemonSearchBox;
        private ListView pokemonListView;
        private Button pokemonViewButton;
        private Panel panel1;
        private TrainerLevelUpTable userControl11;
        private TrainerLevelUpTable trainerLevelUpTable1;
        private Controls.Pokemon.PokemonLevelUpTable pokemonLevelUpTable1;
        private TabPage manageSessionTab;
        private UserControls.Trainer.AddTrainer addTrainer1;
        private TrainerLevelUpTable trainerLevelUpTable2;
        private Controls.Pokemon.PokemonLevelUpTable pokemonLevelUpTable2;
    }
}