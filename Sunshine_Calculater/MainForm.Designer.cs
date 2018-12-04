namespace Sunshine_Calculater
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_Midtime = new System.Windows.Forms.Button();
            this.button_Direction = new System.Windows.Forms.Button();
            this.button_Timelength = new System.Windows.Forms.Button();
            this.button_Risetime = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Midtime
            // 
            this.button_Midtime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Midtime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Midtime.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Midtime.Location = new System.Drawing.Point(168, 53);
            this.button_Midtime.Name = "button_Midtime";
            this.button_Midtime.Size = new System.Drawing.Size(190, 30);
            this.button_Midtime.TabIndex = 0;
            this.button_Midtime.Text = "查询正午时间";
            this.button_Midtime.UseVisualStyleBackColor = false;
            this.button_Midtime.Click += new System.EventHandler(this.button_Midtime_Click);
            // 
            // button_Direction
            // 
            this.button_Direction.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Direction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Direction.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Direction.Location = new System.Drawing.Point(168, 107);
            this.button_Direction.Name = "button_Direction";
            this.button_Direction.Size = new System.Drawing.Size(190, 30);
            this.button_Direction.TabIndex = 1;
            this.button_Direction.Text = "查询太阳角";
            this.button_Direction.UseVisualStyleBackColor = false;
            this.button_Direction.Click += new System.EventHandler(this.button_Direction_Click);
            // 
            // button_Timelength
            // 
            this.button_Timelength.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Timelength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Timelength.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Timelength.Location = new System.Drawing.Point(168, 160);
            this.button_Timelength.Name = "button_Timelength";
            this.button_Timelength.Size = new System.Drawing.Size(190, 30);
            this.button_Timelength.TabIndex = 2;
            this.button_Timelength.Text = "查询日照时长";
            this.button_Timelength.UseVisualStyleBackColor = false;
            this.button_Timelength.Click += new System.EventHandler(this.button_Timelength_Click);
            // 
            // button_Risetime
            // 
            this.button_Risetime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Risetime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Risetime.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Risetime.Location = new System.Drawing.Point(168, 212);
            this.button_Risetime.Name = "button_Risetime";
            this.button_Risetime.Size = new System.Drawing.Size(190, 30);
            this.button_Risetime.TabIndex = 3;
            this.button_Risetime.Text = "查询日出日落时间";
            this.button_Risetime.UseVisualStyleBackColor = false;
            this.button_Risetime.Click += new System.EventHandler(this.button_Risetime_Click);
            // 
            // button_Help
            // 
            this.button_Help.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Help.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Help.Location = new System.Drawing.Point(168, 264);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(190, 30);
            this.button_Help.TabIndex = 4;
            this.button_Help.Text = "帮助";
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(524, 362);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.button_Risetime);
            this.Controls.Add(this.button_Timelength);
            this.Controls.Add(this.button_Direction);
            this.Controls.Add(this.button_Midtime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunshine Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Midtime;
        private System.Windows.Forms.Button button_Direction;
        private System.Windows.Forms.Button button_Timelength;
        private System.Windows.Forms.Button button_Risetime;
        private System.Windows.Forms.Button button_Help;
    }
}

