namespace Matching_game
{
    partial class Game4X4
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
            this.tblGame = new System.Windows.Forms.TableLayoutPanel();
            this.lblB = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblK2 = new System.Windows.Forms.Label();
            this.lblJ = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblM2 = new System.Windows.Forms.Label();
            this.lblF2 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblB2 = new System.Windows.Forms.Label();
            this.lblW2 = new System.Windows.Forms.Label();
            this.lblJ2 = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblO2 = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.iconTimer = new System.Windows.Forms.Timer(this.components);
            this.msgTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.tblGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblGame
            // 
            this.tblGame.BackColor = System.Drawing.Color.LightYellow;
            this.tblGame.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblGame.ColumnCount = 4;
            this.tblGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGame.Controls.Add(this.lblB, 1, 3);
            this.tblGame.Controls.Add(this.lblO, 0, 3);
            this.tblGame.Controls.Add(this.lblW, 3, 3);
            this.tblGame.Controls.Add(this.lblK2, 2, 3);
            this.tblGame.Controls.Add(this.lblJ, 1, 2);
            this.tblGame.Controls.Add(this.lblT, 0, 2);
            this.tblGame.Controls.Add(this.lblM2, 2, 2);
            this.tblGame.Controls.Add(this.lblF2, 3, 2);
            this.tblGame.Controls.Add(this.lblT2, 3, 1);
            this.tblGame.Controls.Add(this.lblB2, 2, 1);
            this.tblGame.Controls.Add(this.lblW2, 2, 0);
            this.tblGame.Controls.Add(this.lblJ2, 2, 0);
            this.tblGame.Controls.Add(this.lblK, 0, 1);
            this.tblGame.Controls.Add(this.lblF, 1, 1);
            this.tblGame.Controls.Add(this.lblO2, 1, 0);
            this.tblGame.Controls.Add(this.lblM, 0, 0);
            this.tblGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblGame.Location = new System.Drawing.Point(0, 0);
            this.tblGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblGame.Name = "tblGame";
            this.tblGame.RowCount = 4;
            this.tblGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGame.Size = new System.Drawing.Size(532, 498);
            this.tblGame.TabIndex = 0;
            // 
            // lblB
            // 
            this.lblB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblB.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblB.ForeColor = System.Drawing.Color.DimGray;
            this.lblB.Location = new System.Drawing.Point(137, 374);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(124, 122);
            this.lblB.TabIndex = 15;
            this.lblB.Text = "b";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblB.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblO
            // 
            this.lblO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblO.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblO.ForeColor = System.Drawing.Color.DimGray;
            this.lblO.Location = new System.Drawing.Point(5, 374);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(124, 122);
            this.lblO.TabIndex = 14;
            this.lblO.Text = "o";
            this.lblO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblO.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblW
            // 
            this.lblW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblW.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblW.ForeColor = System.Drawing.Color.DimGray;
            this.lblW.Location = new System.Drawing.Point(401, 374);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(126, 122);
            this.lblW.TabIndex = 13;
            this.lblW.Text = "w";
            this.lblW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblW.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblK2
            // 
            this.lblK2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblK2.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblK2.ForeColor = System.Drawing.Color.DimGray;
            this.lblK2.Location = new System.Drawing.Point(269, 374);
            this.lblK2.Name = "lblK2";
            this.lblK2.Size = new System.Drawing.Size(124, 122);
            this.lblK2.TabIndex = 12;
            this.lblK2.Text = "k";
            this.lblK2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblK2.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblJ
            // 
            this.lblJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJ.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblJ.ForeColor = System.Drawing.Color.DimGray;
            this.lblJ.Location = new System.Drawing.Point(137, 250);
            this.lblJ.Name = "lblJ";
            this.lblJ.Size = new System.Drawing.Size(124, 122);
            this.lblJ.TabIndex = 11;
            this.lblJ.Text = "j";
            this.lblJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJ.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblT
            // 
            this.lblT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblT.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblT.ForeColor = System.Drawing.Color.DimGray;
            this.lblT.Location = new System.Drawing.Point(5, 250);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(124, 122);
            this.lblT.TabIndex = 10;
            this.lblT.Text = "t";
            this.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblT.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblM2
            // 
            this.lblM2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblM2.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblM2.ForeColor = System.Drawing.Color.DimGray;
            this.lblM2.Location = new System.Drawing.Point(269, 250);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(124, 122);
            this.lblM2.TabIndex = 9;
            this.lblM2.Text = "m";
            this.lblM2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblM2.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblF2
            // 
            this.lblF2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblF2.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblF2.ForeColor = System.Drawing.Color.DimGray;
            this.lblF2.Location = new System.Drawing.Point(401, 250);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(126, 122);
            this.lblF2.TabIndex = 8;
            this.lblF2.Text = "f";
            this.lblF2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblF2.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblT2
            // 
            this.lblT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblT2.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblT2.ForeColor = System.Drawing.Color.DimGray;
            this.lblT2.Location = new System.Drawing.Point(401, 126);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(126, 122);
            this.lblT2.TabIndex = 7;
            this.lblT2.Text = "t";
            this.lblT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblT2.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblB2
            // 
            this.lblB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblB2.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblB2.ForeColor = System.Drawing.Color.DimGray;
            this.lblB2.Location = new System.Drawing.Point(269, 126);
            this.lblB2.Name = "lblB2";
            this.lblB2.Size = new System.Drawing.Size(124, 122);
            this.lblB2.TabIndex = 6;
            this.lblB2.Text = "b";
            this.lblB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblB2.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblW2
            // 
            this.lblW2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblW2.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblW2.ForeColor = System.Drawing.Color.DimGray;
            this.lblW2.Location = new System.Drawing.Point(269, 2);
            this.lblW2.Name = "lblW2";
            this.lblW2.Size = new System.Drawing.Size(124, 122);
            this.lblW2.TabIndex = 5;
            this.lblW2.Text = "w";
            this.lblW2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblW2.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblJ2
            // 
            this.lblJ2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJ2.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblJ2.ForeColor = System.Drawing.Color.DimGray;
            this.lblJ2.Location = new System.Drawing.Point(401, 2);
            this.lblJ2.Name = "lblJ2";
            this.lblJ2.Size = new System.Drawing.Size(126, 122);
            this.lblJ2.TabIndex = 4;
            this.lblJ2.Text = "j";
            this.lblJ2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJ2.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblK
            // 
            this.lblK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblK.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblK.ForeColor = System.Drawing.Color.DimGray;
            this.lblK.Location = new System.Drawing.Point(5, 126);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(124, 122);
            this.lblK.TabIndex = 3;
            this.lblK.Text = "k";
            this.lblK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblK.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblF
            // 
            this.lblF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblF.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblF.ForeColor = System.Drawing.Color.DimGray;
            this.lblF.Location = new System.Drawing.Point(137, 126);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(124, 122);
            this.lblF.TabIndex = 2;
            this.lblF.Text = "f";
            this.lblF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblF.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblO2
            // 
            this.lblO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblO2.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblO2.ForeColor = System.Drawing.Color.DimGray;
            this.lblO2.Location = new System.Drawing.Point(137, 2);
            this.lblO2.Name = "lblO2";
            this.lblO2.Size = new System.Drawing.Size(124, 122);
            this.lblO2.TabIndex = 1;
            this.lblO2.Text = "o";
            this.lblO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblO2.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblM
            // 
            this.lblM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblM.Font = new System.Drawing.Font("Webdings", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblM.ForeColor = System.Drawing.Color.DimGray;
            this.lblM.Location = new System.Drawing.Point(5, 2);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(124, 122);
            this.lblM.TabIndex = 0;
            this.lblM.Text = "m";
            this.lblM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblM.Click += new System.EventHandler(this.lbl_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Yellow;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Red;
            this.btnReturn.Location = new System.Drawing.Point(151, 508);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 50);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // iconTimer
            // 
            this.iconTimer.Interval = 750;
            this.iconTimer.Tick += new System.EventHandler(this.iconTimer_Tick);
            // 
            // msgTimer
            // 
            this.msgTimer.Interval = 1500;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tag = "";
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Yellow;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Cursor = System.Windows.Forms.Cursors.No;
            this.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimer.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(289, 508);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(125, 50);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game4X4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(532, 567);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tblGame);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game4X4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game4X4_FormClosing);
            this.tblGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblO2;
        private System.Windows.Forms.Label lblJ2;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblW2;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblK2;
        private System.Windows.Forms.Label lblJ;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.Label lblF2;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblB2;
        public System.Windows.Forms.TableLayoutPanel tblGame;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Timer iconTimer;
        private System.Windows.Forms.Timer msgTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblTimer;
    }
}

