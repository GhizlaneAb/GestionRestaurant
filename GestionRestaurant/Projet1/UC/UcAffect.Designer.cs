namespace Projet1.UC
{
    partial class UcAffect
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.ucTable2 = new Projet1.UC.UcTable();
            this.ucTable1 = new Projet1.UC.UcTable();
            this.ucTable4 = new Projet1.UC.UcTable();
            this.ucTable5 = new Projet1.UC.UcTable();
            this.ucTable3 = new Projet1.UC.UcTable();
            this.ucTable6 = new Projet1.UC.UcTable();
            this.SuspendLayout();
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // ucTable2
            // 
            this.ucTable2.BackColor = System.Drawing.Color.Gold;
            this.ucTable2.Location = new System.Drawing.Point(237, 4);
            this.ucTable2.Name = "ucTable2";
            this.ucTable2.Num = 2;
            this.ucTable2.Size = new System.Drawing.Size(226, 78);
            this.ucTable2.TabIndex = 2;
            // 
            // ucTable1
            // 
            this.ucTable1.BackColor = System.Drawing.Color.Gold;
            this.ucTable1.Location = new System.Drawing.Point(4, 4);
            this.ucTable1.Name = "ucTable1";
            this.ucTable1.Num = 1;
            this.ucTable1.Size = new System.Drawing.Size(226, 78);
            this.ucTable1.TabIndex = 1;
            // 
            // ucTable4
            // 
            this.ucTable4.BackColor = System.Drawing.Color.Gold;
            this.ucTable4.Location = new System.Drawing.Point(4, 89);
            this.ucTable4.Name = "ucTable4";
            this.ucTable4.Num = 4;
            this.ucTable4.Size = new System.Drawing.Size(226, 78);
            this.ucTable4.TabIndex = 4;
            // 
            // ucTable5
            // 
            this.ucTable5.BackColor = System.Drawing.Color.Gold;
            this.ucTable5.Location = new System.Drawing.Point(237, 89);
            this.ucTable5.Name = "ucTable5";
            this.ucTable5.Num = 5;
            this.ucTable5.Size = new System.Drawing.Size(226, 78);
            this.ucTable5.TabIndex = 5;
            // 
            // ucTable3
            // 
            this.ucTable3.BackColor = System.Drawing.Color.Gold;
            this.ucTable3.Location = new System.Drawing.Point(469, 4);
            this.ucTable3.Name = "ucTable3";
            this.ucTable3.Num = 3;
            this.ucTable3.Size = new System.Drawing.Size(226, 78);
            this.ucTable3.TabIndex = 3;
            this.ucTable3.Load += new System.EventHandler(this.ucTable3_Load);
            // 
            // ucTable6
            // 
            this.ucTable6.BackColor = System.Drawing.Color.Gold;
            this.ucTable6.Location = new System.Drawing.Point(469, 89);
            this.ucTable6.Name = "ucTable6";
            this.ucTable6.Num = 6;
            this.ucTable6.Size = new System.Drawing.Size(226, 78);
            this.ucTable6.TabIndex = 6;
            // 
            // UcAffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucTable6);
            this.Controls.Add(this.ucTable5);
            this.Controls.Add(this.ucTable4);
            this.Controls.Add(this.ucTable3);
            this.Controls.Add(this.ucTable2);
            this.Controls.Add(this.ucTable1);
            this.Name = "UcAffect";
            this.Size = new System.Drawing.Size(698, 178);
            this.ResumeLayout(false);

        }

        #endregion

        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private UcTable ucTable2;
        private UcTable ucTable1;
        private UcTable ucTable4;
        private UcTable ucTable5;
        private UcTable ucTable3;
        private UcTable ucTable6;
    }
}
