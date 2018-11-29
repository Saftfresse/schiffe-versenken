namespace WA_Schiffe_Versenken
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas_player = new System.Windows.Forms.PictureBox();
            this.canvas_enemy = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_enemy_top = new System.Windows.Forms.PictureBox();
            this.pb_enemy_left = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_enemy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_newRound = new System.Windows.Forms.Button();
            this.btn_pick_4 = new System.Windows.Forms.Button();
            this.btn_pick_3 = new System.Windows.Forms.Button();
            this.btn_pick_2 = new System.Windows.Forms.Button();
            this.btn_pick_1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas_enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas_player
            // 
            this.canvas_player.BackColor = System.Drawing.Color.White;
            this.canvas_player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas_player.Location = new System.Drawing.Point(45, 88);
            this.canvas_player.Name = "canvas_player";
            this.canvas_player.Size = new System.Drawing.Size(350, 350);
            this.canvas_player.TabIndex = 0;
            this.canvas_player.TabStop = false;
            this.canvas_player.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_player_Paint);
            this.canvas_player.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_player_MouseClick);
            this.canvas_player.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_player_MouseMove);
            // 
            // canvas_enemy
            // 
            this.canvas_enemy.BackColor = System.Drawing.Color.White;
            this.canvas_enemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas_enemy.Location = new System.Drawing.Point(480, 88);
            this.canvas_enemy.Name = "canvas_enemy";
            this.canvas_enemy.Size = new System.Drawing.Size(350, 350);
            this.canvas_enemy.TabIndex = 1;
            this.canvas_enemy.TabStop = false;
            this.canvas_enemy.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.canvas_enemy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_enemy_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spieler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Züge\r\n0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_enemy_top
            // 
            this.pb_enemy_top.Location = new System.Drawing.Point(480, 63);
            this.pb_enemy_top.Name = "pb_enemy_top";
            this.pb_enemy_top.Size = new System.Drawing.Size(350, 25);
            this.pb_enemy_top.TabIndex = 5;
            this.pb_enemy_top.TabStop = false;
            this.pb_enemy_top.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_enemy_top_Paint);
            // 
            // pb_enemy_left
            // 
            this.pb_enemy_left.Location = new System.Drawing.Point(455, 88);
            this.pb_enemy_left.Name = "pb_enemy_left";
            this.pb_enemy_left.Size = new System.Drawing.Size(25, 350);
            this.pb_enemy_left.TabIndex = 6;
            this.pb_enemy_left.TabStop = false;
            this.pb_enemy_left.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_enemy_left_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(20, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 350);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(45, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(350, 25);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // label_enemy
            // 
            this.label_enemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_enemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enemy.Location = new System.Drawing.Point(6, 16);
            this.label_enemy.Name = "label_enemy";
            this.label_enemy.Size = new System.Drawing.Size(171, 75);
            this.label_enemy.TabIndex = 9;
            this.label_enemy.Text = "Schlachtschiffe: 1\r\nKreuzer: 2\r\nZerstörer: 3\r\nU-Boote: 4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_enemy);
            this.groupBox1.Location = new System.Drawing.Point(559, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 98);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verbleibend";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_exit);
            this.groupBox2.Controls.Add(this.btn_newRound);
            this.groupBox2.Controls.Add(this.btn_pick_4);
            this.groupBox2.Controls.Add(this.btn_pick_3);
            this.groupBox2.Controls.Add(this.btn_pick_2);
            this.groupBox2.Controls.Add(this.btn_pick_1);
            this.groupBox2.Location = new System.Drawing.Point(20, 462);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 98);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Platzieren";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(286, 65);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(83, 27);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Beenden";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_newRound
            // 
            this.btn_newRound.Location = new System.Drawing.Point(286, 14);
            this.btn_newRound.Name = "btn_newRound";
            this.btn_newRound.Size = new System.Drawing.Size(83, 27);
            this.btn_newRound.TabIndex = 4;
            this.btn_newRound.Text = "Neue Runde";
            this.btn_newRound.UseVisualStyleBackColor = true;
            this.btn_newRound.Click += new System.EventHandler(this.btn_newRound_Click);
            // 
            // btn_pick_4
            // 
            this.btn_pick_4.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_pick_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pick_4.ForeColor = System.Drawing.Color.Black;
            this.btn_pick_4.Location = new System.Drawing.Point(187, 14);
            this.btn_pick_4.Name = "btn_pick_4";
            this.btn_pick_4.Size = new System.Drawing.Size(70, 35);
            this.btn_pick_4.TabIndex = 3;
            this.btn_pick_4.Text = "U-Boot [4]";
            this.btn_pick_4.UseVisualStyleBackColor = false;
            this.btn_pick_4.Click += new System.EventHandler(this.btn_pick_4_Click);
            // 
            // btn_pick_3
            // 
            this.btn_pick_3.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_pick_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pick_3.ForeColor = System.Drawing.Color.Black;
            this.btn_pick_3.Location = new System.Drawing.Point(152, 55);
            this.btn_pick_3.Name = "btn_pick_3";
            this.btn_pick_3.Size = new System.Drawing.Size(105, 35);
            this.btn_pick_3.TabIndex = 2;
            this.btn_pick_3.Text = "Zerstörer [3]";
            this.btn_pick_3.UseVisualStyleBackColor = false;
            this.btn_pick_3.Click += new System.EventHandler(this.btn_pick_3_Click);
            // 
            // btn_pick_2
            // 
            this.btn_pick_2.BackColor = System.Drawing.Color.IndianRed;
            this.btn_pick_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pick_2.ForeColor = System.Drawing.Color.Black;
            this.btn_pick_2.Location = new System.Drawing.Point(6, 55);
            this.btn_pick_2.Name = "btn_pick_2";
            this.btn_pick_2.Size = new System.Drawing.Size(140, 35);
            this.btn_pick_2.TabIndex = 1;
            this.btn_pick_2.Text = "Kreuzer [2]";
            this.btn_pick_2.UseVisualStyleBackColor = false;
            this.btn_pick_2.Click += new System.EventHandler(this.btn_pick_2_Click);
            // 
            // btn_pick_1
            // 
            this.btn_pick_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_pick_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pick_1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_pick_1.Location = new System.Drawing.Point(6, 14);
            this.btn_pick_1.Name = "btn_pick_1";
            this.btn_pick_1.Size = new System.Drawing.Size(175, 35);
            this.btn_pick_1.TabIndex = 0;
            this.btn_pick_1.Text = "Schlachtschiff [1]";
            this.btn_pick_1.UseVisualStyleBackColor = false;
            this.btn_pick_1.Click += new System.EventHandler(this.btn_pick_1_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 572);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_enemy_left);
            this.Controls.Add(this.pb_enemy_top);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canvas_enemy);
            this.Controls.Add(this.canvas_player);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.canvas_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas_enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas_player;
        private System.Windows.Forms.PictureBox canvas_enemy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_enemy_top;
        private System.Windows.Forms.PictureBox pb_enemy_left;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_enemy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_pick_1;
        private System.Windows.Forms.Button btn_pick_3;
        private System.Windows.Forms.Button btn_pick_2;
        private System.Windows.Forms.Button btn_pick_4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_newRound;
        private System.Windows.Forms.Label label4;
    }
}

