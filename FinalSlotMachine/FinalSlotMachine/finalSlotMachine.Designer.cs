namespace FinalSlotMachine
{
    partial class finalSlotMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finalSlotMachine));
            this.infoLabel = new System.Windows.Forms.Label();
            this.betBox = new System.Windows.Forms.TextBox();
            this.SpinButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.slotImageList = new System.Windows.Forms.ImageList(this.components);
            this.winLabel = new System.Windows.Forms.Label();
            this.totalWinLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.winOutputLabel = new System.Windows.Forms.Label();
            this.totalWinOutputLabel = new System.Windows.Forms.Label();
            this.spentOutputLabel = new System.Windows.Forms.Label();
            this.WinLbl = new System.Windows.Forms.Label();
            this.winLossOutputLabel = new System.Windows.Forms.Label();
            this.LossLbl = new System.Windows.Forms.Label();
            this.lossOutputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Gold;
            this.infoLabel.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(245, 221);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(307, 33);
            this.infoLabel.TabIndex = 13;
            this.infoLabel.Text = "Make your bet!   $$$";
            // 
            // betBox
            // 
            this.betBox.BackColor = System.Drawing.Color.Gold;
            this.betBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.betBox.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betBox.Location = new System.Drawing.Point(585, 213);
            this.betBox.Margin = new System.Windows.Forms.Padding(6);
            this.betBox.Name = "betBox";
            this.betBox.Size = new System.Drawing.Size(110, 41);
            this.betBox.TabIndex = 0;
            // 
            // SpinButton
            // 
            this.SpinButton.BackColor = System.Drawing.Color.Gold;
            this.SpinButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpinButton.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinButton.Location = new System.Drawing.Point(273, 277);
            this.SpinButton.Margin = new System.Windows.Forms.Padding(6);
            this.SpinButton.Name = "SpinButton";
            this.SpinButton.Size = new System.Drawing.Size(346, 71);
            this.SpinButton.TabIndex = 1;
            this.SpinButton.Text = "&Spin!!";
            this.SpinButton.UseVisualStyleBackColor = false;
            this.SpinButton.Click += new System.EventHandler(this.SpinButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Gold;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(685, 306);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(74, 42);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // slot3
            // 
            this.slot3.BackColor = System.Drawing.Color.Gold;
            this.slot3.Location = new System.Drawing.Point(524, 22);
            this.slot3.Margin = new System.Windows.Forms.Padding(6);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(224, 179);
            this.slot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slot3.TabIndex = 2;
            this.slot3.TabStop = false;
            // 
            // slot2
            // 
            this.slot2.BackColor = System.Drawing.Color.Gold;
            this.slot2.Location = new System.Drawing.Point(273, 22);
            this.slot2.Margin = new System.Windows.Forms.Padding(6);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(224, 179);
            this.slot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slot2.TabIndex = 1;
            this.slot2.TabStop = false;
            // 
            // slot1
            // 
            this.slot1.BackColor = System.Drawing.Color.Gold;
            this.slot1.Location = new System.Drawing.Point(22, 22);
            this.slot1.Margin = new System.Windows.Forms.Padding(6);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(224, 179);
            this.slot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slot1.TabIndex = 0;
            this.slot1.TabStop = false;
            // 
            // slotImageList
            // 
            this.slotImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("slotImageList.ImageStream")));
            this.slotImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.slotImageList.Images.SetKeyName(0, "7.png");
            this.slotImageList.Images.SetKeyName(1, "bar.png");
            this.slotImageList.Images.SetKeyName(2, "gem.png");
            this.slotImageList.Images.SetKeyName(3, "cherry.png");
            this.slotImageList.Images.SetKeyName(4, "lemon.png");
            this.slotImageList.Images.SetKeyName(5, "orange.png");
            this.slotImageList.Images.SetKeyName(6, "apple.png");
            this.slotImageList.Images.SetKeyName(7, "grapes.png");
            this.slotImageList.Images.SetKeyName(8, "watermelon.png");
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Location = new System.Drawing.Point(57, 221);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(96, 24);
            this.winLabel.TabIndex = 8;
            this.winLabel.Text = "Spin Win!!";
            // 
            // totalWinLabel
            // 
            this.totalWinLabel.AutoSize = true;
            this.totalWinLabel.Location = new System.Drawing.Point(8, 256);
            this.totalWinLabel.Name = "totalWinLabel";
            this.totalWinLabel.Size = new System.Drawing.Size(145, 24);
            this.totalWinLabel.TabIndex = 9;
            this.totalWinLabel.Text = "Total Winnings!!";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(43, 289);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(110, 24);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total Spent:";
            // 
            // winOutputLabel
            // 
            this.winOutputLabel.Location = new System.Drawing.Point(159, 221);
            this.winOutputLabel.Name = "winOutputLabel";
            this.winOutputLabel.Size = new System.Drawing.Size(77, 24);
            this.winOutputLabel.TabIndex = 3;
            // 
            // totalWinOutputLabel
            // 
            this.totalWinOutputLabel.Location = new System.Drawing.Point(159, 256);
            this.totalWinOutputLabel.Name = "totalWinOutputLabel";
            this.totalWinOutputLabel.Size = new System.Drawing.Size(105, 24);
            this.totalWinOutputLabel.TabIndex = 4;
            // 
            // spentOutputLabel
            // 
            this.spentOutputLabel.Location = new System.Drawing.Point(159, 289);
            this.spentOutputLabel.Name = "spentOutputLabel";
            this.spentOutputLabel.Size = new System.Drawing.Size(105, 24);
            this.spentOutputLabel.TabIndex = 5;
            // 
            // WinLbl
            // 
            this.WinLbl.AutoSize = true;
            this.WinLbl.Location = new System.Drawing.Point(21, 323);
            this.WinLbl.Name = "WinLbl";
            this.WinLbl.Size = new System.Drawing.Size(62, 24);
            this.WinLbl.TabIndex = 11;
            this.WinLbl.Text = "Wins :";
            // 
            // winLossOutputLabel
            // 
            this.winLossOutputLabel.Location = new System.Drawing.Point(89, 323);
            this.winLossOutputLabel.Name = "winLossOutputLabel";
            this.winLossOutputLabel.Size = new System.Drawing.Size(46, 25);
            this.winLossOutputLabel.TabIndex = 6;
            // 
            // LossLbl
            // 
            this.LossLbl.AutoSize = true;
            this.LossLbl.Location = new System.Drawing.Point(141, 324);
            this.LossLbl.Name = "LossLbl";
            this.LossLbl.Size = new System.Drawing.Size(79, 24);
            this.LossLbl.TabIndex = 12;
            this.LossLbl.Text = "Losses :";
            // 
            // lossOutputLabel
            // 
            this.lossOutputLabel.Location = new System.Drawing.Point(226, 324);
            this.lossOutputLabel.Name = "lossOutputLabel";
            this.lossOutputLabel.Size = new System.Drawing.Size(38, 25);
            this.lossOutputLabel.TabIndex = 7;
            // 
            // finalSlotMachine
            // 
            this.AcceptButton = this.SpinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::FinalSlotMachine.Properties.Resources.coins;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(774, 356);
            this.Controls.Add(this.lossOutputLabel);
            this.Controls.Add(this.LossLbl);
            this.Controls.Add(this.winLossOutputLabel);
            this.Controls.Add(this.WinLbl);
            this.Controls.Add(this.spentOutputLabel);
            this.Controls.Add(this.totalWinOutputLabel);
            this.Controls.Add(this.winOutputLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalWinLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.SpinButton);
            this.Controls.Add(this.betBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "finalSlotMachine";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slot1;
        private System.Windows.Forms.PictureBox slot2;
        private System.Windows.Forms.PictureBox slot3;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox betBox;
        private System.Windows.Forms.Button SpinButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ImageList slotImageList;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label totalWinLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label winOutputLabel;
        private System.Windows.Forms.Label totalWinOutputLabel;
        private System.Windows.Forms.Label spentOutputLabel;
        private System.Windows.Forms.Label WinLbl;
        private System.Windows.Forms.Label winLossOutputLabel;
        private System.Windows.Forms.Label LossLbl;
        private System.Windows.Forms.Label lossOutputLabel;
    }
}

