using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Colisão
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			//carro
			
			picBox_Carro.Parent = picBox_Estrada;
			picBox_Carro.Left = 0;
			picBox_Carro.Top = 5;
			picBox_Carro.BackColor = Color.Transparent;
			timer1.Interval = 25;
			
			//arvore
			
			picBox_Arvore.Parent = picBox_Estrada;
			picBox_Arvore.Left = 400;
			picBox_Arvore.Top = 0;
			picBox_Arvore.BackColor = Color.Transparent;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			picBox_Carro.Left = 0;
			picBox_Carro.Load("Lamborghini2.png");
			timer1.Enabled = true;
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			picBox_Carro.Left += 10;
			
			if(picBox_Carro.Left >= 530)
			
				timer1.Enabled =false;
			
			
			//teste de colisão
			
			if (picBox_Carro.Bounds.IntersectsWith(picBox_Arvore.Bounds))
			{
			    	timer1.Enabled = false;
			    	picBox_Carro.Load("carroAmassado2.png");
			    	picBox_Carro.Left -= 5;
			    	
			    	MessageBox.Show("O carro bateu","Colisão",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			    
			}
		}
		
	}
}
