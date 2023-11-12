
namespace TP_Socket
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            this.buttonRecevoir = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(69, 161);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(119, 23);
            this.buttonCreer.TabIndex = 2;
            this.buttonCreer.Text = "Créer socket udp";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.Location = new System.Drawing.Point(192, 161);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnvoyer.TabIndex = 3;
            this.buttonEnvoyer.Text = "Envoyer";
            this.buttonEnvoyer.UseVisualStyleBackColor = true;
            this.buttonEnvoyer.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRecevoir
            // 
            this.buttonRecevoir.Location = new System.Drawing.Point(273, 161);
            this.buttonRecevoir.Name = "buttonRecevoir";
            this.buttonRecevoir.Size = new System.Drawing.Size(75, 23);
            this.buttonRecevoir.TabIndex = 4;
            this.buttonRecevoir.Text = "Recevoir";
            this.buttonRecevoir.UseVisualStyleBackColor = true;
            this.buttonRecevoir.Click += new System.EventHandler(this.buttonRecevoir_Click);
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(366, 161);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(100, 23);
            this.buttonFermer.TabIndex = 5;
            this.buttonFermer.Text = "Fermer socket";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(571, 89);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 205);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonRecevoir);
            this.Controls.Add(this.buttonEnvoyer);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Communication par socket UDP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonEnvoyer;
        private System.Windows.Forms.Button buttonRecevoir;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}

