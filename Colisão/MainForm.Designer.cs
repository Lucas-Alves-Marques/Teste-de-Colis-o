/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 10/10/2024
 * Time: 22:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Colisão
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox picBox_Estrada;
		private System.Windows.Forms.PictureBox picBox_Carro;
		private System.Windows.Forms.PictureBox picBox_Arvore;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.picBox_Estrada = new System.Windows.Forms.PictureBox();
			this.picBox_Carro = new System.Windows.Forms.PictureBox();
			this.picBox_Arvore = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.picBox_Estrada)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox_Carro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox_Arvore)).BeginInit();
			this.SuspendLayout();
			// 
			// picBox_Estrada
			// 
			this.picBox_Estrada.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Estrada.Image")));
			this.picBox_Estrada.Location = new System.Drawing.Point(0, 352);
			this.picBox_Estrada.Name = "picBox_Estrada";
			this.picBox_Estrada.Size = new System.Drawing.Size(944, 74);
			this.picBox_Estrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBox_Estrada.TabIndex = 0;
			this.picBox_Estrada.TabStop = false;
			// 
			// picBox_Carro
			// 
			this.picBox_Carro.BackColor = System.Drawing.Color.Transparent;
			this.picBox_Carro.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Carro.Image")));
			this.picBox_Carro.Location = new System.Drawing.Point(14, 352);
			this.picBox_Carro.Name = "picBox_Carro";
			this.picBox_Carro.Size = new System.Drawing.Size(165, 57);
			this.picBox_Carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBox_Carro.TabIndex = 1;
			this.picBox_Carro.TabStop = false;
			// 
			// picBox_Arvore
			// 
			this.picBox_Arvore.BackColor = System.Drawing.Color.Transparent;
			this.picBox_Arvore.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Arvore.Image")));
			this.picBox_Arvore.Location = new System.Drawing.Point(619, 335);
			this.picBox_Arvore.Name = "picBox_Arvore";
			this.picBox_Arvore.Size = new System.Drawing.Size(141, 74);
			this.picBox_Arvore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBox_Arvore.TabIndex = 2;
			this.picBox_Arvore.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(362, 37);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(130, 47);
			this.button1.TabIndex = 3;
			this.button1.Text = "Mover";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(927, 422);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.picBox_Arvore);
			this.Controls.Add(this.picBox_Carro);
			this.Controls.Add(this.picBox_Estrada);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "Colisão";
			((System.ComponentModel.ISupportInitialize)(this.picBox_Estrada)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox_Carro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox_Arvore)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
