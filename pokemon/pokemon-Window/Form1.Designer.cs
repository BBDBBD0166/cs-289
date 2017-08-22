namespace pokemon_Window
{
    partial class pokemongo
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pokeName = new System.Windows.Forms.TextBox();
            this.pokeHeight = new System.Windows.Forms.TextBox();
            this.pokeWeight = new System.Windows.Forms.TextBox();
            this.pokeCategory = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(250, 127);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 0;
            this.Login.Text = "登錄";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "神奇寶貝名稱:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "身高:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "體重:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "屬性:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 136);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pokeName
            // 
            this.pokeName.Location = new System.Drawing.Point(110, 19);
            this.pokeName.Name = "pokeName";
            this.pokeName.Size = new System.Drawing.Size(99, 22);
            this.pokeName.TabIndex = 7;
            // 
            // pokeHeight
            // 
            this.pokeHeight.Location = new System.Drawing.Point(110, 55);
            this.pokeHeight.Name = "pokeHeight";
            this.pokeHeight.Size = new System.Drawing.Size(99, 22);
            this.pokeHeight.TabIndex = 8;
            // 
            // pokeWeight
            // 
            this.pokeWeight.Location = new System.Drawing.Point(110, 89);
            this.pokeWeight.Name = "pokeWeight";
            this.pokeWeight.Size = new System.Drawing.Size(99, 22);
            this.pokeWeight.TabIndex = 9;
            // 
            // pokeCategory
            // 
            this.pokeCategory.Location = new System.Drawing.Point(110, 127);
            this.pokeCategory.Name = "pokeCategory";
            this.pokeCategory.Size = new System.Drawing.Size(99, 22);
            this.pokeCategory.TabIndex = 10;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(60, 162);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 12);
            this.message.TabIndex = 11;
            // 
            // pokemongo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 350);
            this.Controls.Add(this.message);
            this.Controls.Add(this.pokeCategory);
            this.Controls.Add(this.pokeWeight);
            this.Controls.Add(this.pokeHeight);
            this.Controls.Add(this.pokeName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Name = "pokemongo";
            this.Text = "一起成為神奇寶貝大師吧!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox pokeName;
        private System.Windows.Forms.TextBox pokeHeight;
        private System.Windows.Forms.TextBox pokeWeight;
        private System.Windows.Forms.TextBox pokeCategory;
        private System.Windows.Forms.Label message;
    }
}

