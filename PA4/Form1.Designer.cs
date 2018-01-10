namespace PA4
{
    partial class Form1
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
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRhyme = new System.Windows.Forms.Button();
            this.listBoxFinal = new System.Windows.Forms.ListBox();
            this.btnScrabble = new System.Windows.Forms.Button();
            this.btnMorph = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxWords
            // 
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.Location = new System.Drawing.Point(25, 60);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(156, 277);
            this.listBoxWords.TabIndex = 0;
            this.listBoxWords.DoubleClick += new System.EventHandler(this.listBoxWords_DoubleClick);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.Location = new System.Drawing.Point(25, 22);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 1;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(106, 22);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(19, 32);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(122, 20);
            this.textBoxUser.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnFind.Location = new System.Drawing.Point(19, 58);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRhyme
            // 
            this.btnRhyme.AutoSize = true;
            this.btnRhyme.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnRhyme.Location = new System.Drawing.Point(119, 58);
            this.btnRhyme.Name = "btnRhyme";
            this.btnRhyme.Size = new System.Drawing.Size(75, 23);
            this.btnRhyme.TabIndex = 5;
            this.btnRhyme.Text = "Rhyme";
            this.btnRhyme.UseVisualStyleBackColor = false;
            this.btnRhyme.Click += new System.EventHandler(this.btnRhyme_Click);
            // 
            // listBoxFinal
            // 
            this.listBoxFinal.FormattingEnabled = true;
            this.listBoxFinal.Location = new System.Drawing.Point(203, 216);
            this.listBoxFinal.Name = "listBoxFinal";
            this.listBoxFinal.Size = new System.Drawing.Size(188, 121);
            this.listBoxFinal.TabIndex = 6;
            // 
            // btnScrabble
            // 
            this.btnScrabble.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnScrabble.Location = new System.Drawing.Point(19, 87);
            this.btnScrabble.Name = "btnScrabble";
            this.btnScrabble.Size = new System.Drawing.Size(75, 23);
            this.btnScrabble.TabIndex = 7;
            this.btnScrabble.Text = "Scrabble";
            this.btnScrabble.UseVisualStyleBackColor = false;
            this.btnScrabble.Click += new System.EventHandler(this.btnScrabble_Click);
            // 
            // btnMorph
            // 
            this.btnMorph.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnMorph.Location = new System.Drawing.Point(119, 87);
            this.btnMorph.Name = "btnMorph";
            this.btnMorph.Size = new System.Drawing.Size(75, 23);
            this.btnMorph.TabIndex = 9;
            this.btnMorph.Text = "Morph";
            this.btnMorph.UseVisualStyleBackColor = false;
            this.btnMorph.Click += new System.EventHandler(this.btnMorph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.textBoxUser);
            this.groupBox1.Controls.Add(this.btnMorph);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.btnScrabble);
            this.groupBox1.Controls.Add(this.btnRhyme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(203, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 129);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter a word and select a command";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(328, 22);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.ForeColor = System.Drawing.Color.Yellow;
            this.labelList.Location = new System.Drawing.Point(274, 200);
            this.labelList.Name = "labelList";
            this.labelList.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelList.Size = new System.Drawing.Size(33, 13);
            this.labelList.TabIndex = 12;
            this.labelList.Text = "List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(438, 385);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxFinal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.listBoxWords);
            this.MaximumSize = new System.Drawing.Size(454, 424);
            this.MinimumSize = new System.Drawing.Size(454, 424);
            this.Name = "Form1";
            this.Text = "Programming Assignment 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRhyme;
        private System.Windows.Forms.ListBox listBoxFinal;
        private System.Windows.Forms.Button btnScrabble;
        private System.Windows.Forms.Button btnMorph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label labelList;
    }
}

