namespace Sandboxnator_Launcher
{
    partial class SandboxnatorLauncher
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SandboxnatorLauncher));
            this.menus = new System.Windows.Forms.TabControl();
            this.newsMenu = new System.Windows.Forms.TabPage();
            this.gameMenu = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.communityServers = new System.Windows.Forms.TabPage();
            this.playBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menus.SuspendLayout();
            this.gameMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menus
            // 
            this.menus.Controls.Add(this.gameMenu);
            this.menus.Controls.Add(this.newsMenu);
            this.menus.Controls.Add(this.communityServers);
            this.menus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menus.Location = new System.Drawing.Point(0, 0);
            this.menus.Multiline = true;
            this.menus.Name = "menus";
            this.menus.SelectedIndex = 0;
            this.menus.Size = new System.Drawing.Size(800, 450);
            this.menus.TabIndex = 0;
            // 
            // newsMenu
            // 
            this.newsMenu.BackColor = System.Drawing.Color.Lavender;
            this.newsMenu.Location = new System.Drawing.Point(4, 38);
            this.newsMenu.Name = "newsMenu";
            this.newsMenu.Padding = new System.Windows.Forms.Padding(3);
            this.newsMenu.Size = new System.Drawing.Size(792, 408);
            this.newsMenu.TabIndex = 1;
            this.newsMenu.Text = "News - Changelog";
            // 
            // gameMenu
            // 
            this.gameMenu.BackColor = System.Drawing.Color.Gray;
            this.gameMenu.BackgroundImage = global::Sandboxnator_Launcher.Properties.Resources._8snuYNGR_4x1;
            this.gameMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameMenu.Controls.Add(this.panel1);
            this.gameMenu.Location = new System.Drawing.Point(4, 34);
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Padding = new System.Windows.Forms.Padding(3);
            this.gameMenu.Size = new System.Drawing.Size(792, 412);
            this.gameMenu.TabIndex = 0;
            this.gameMenu.Text = "Game";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.playBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 58);
            this.panel1.TabIndex = 0;
            // 
            // communityServers
            // 
            this.communityServers.Location = new System.Drawing.Point(4, 38);
            this.communityServers.Name = "communityServers";
            this.communityServers.Padding = new System.Windows.Forms.Padding(3);
            this.communityServers.Size = new System.Drawing.Size(792, 408);
            this.communityServers.TabIndex = 2;
            this.communityServers.Text = "Servers";
            this.communityServers.UseVisualStyleBackColor = true;
            // 
            // playBtn
            // 
            this.playBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.playBtn.Location = new System.Drawing.Point(0, 0);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(205, 58);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(205, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(581, 58);
            this.progressBar1.TabIndex = 1;
            // 
            // SandboxnatorLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SandboxnatorLauncher";
            this.Text = "Sandboxnator Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menus.ResumeLayout(false);
            this.gameMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menus;
        private System.Windows.Forms.TabPage gameMenu;
        private System.Windows.Forms.TabPage newsMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.TabPage communityServers;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

