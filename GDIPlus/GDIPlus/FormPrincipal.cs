﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            // Criar uma folha em branco
            // Criar um desenhador
            // Utilizar o desenho ou imagem
        }

        private void button_Desenhar_Click(object sender, EventArgs e)
        {
            // Folha em branco
            Bitmap folha = new Bitmap(pictureBox_Resultado.Width, pictureBox_Resultado.Height);

            // Criar desenhador
            Graphics desenhador = Graphics.FromImage(folha);

            // Desenhar na folha
            desenhador.Clear(Color.White);

            #region Linhas
            /*
            Brush pincel1 = new SolidBrush(Color.Red);

            Pen lapis1 = new Pen(Color.Black, 2);
            Pen lapis2 = new Pen(pincel1, 2);
            Pen lapis3 = new Pen(Color.Fuchsia, 2);

            Point x1 = new Point(10, 10);
            Point y1 = new Point(100, 100);

            Point x2 = new Point(100, 100);
            Point y2 = new Point(125, 300);

            desenhador.DrawLine(lapis1, x1, y1);
            desenhador.DrawLine(lapis2, x2, y2);

            desenhador.DrawLines(lapis3, new PointF[]
            {
                new Point(250, 390),
                new Point(125, 320),
                new Point(25, 350),
                new Point(85, 440)
            });
            */
            #endregion

            #region Retângulos Vazios e Preenchidos
            /*
            Pen lapis1 = new Pen(Color.Fuchsia, 2);
            Pen lapis2 = new Pen(Color.DarkBlue, 4);

            Point p1 = new Point(100, 100);
            Size size1 = new Size(100, 200);

            Point p2 = new Point(220, 300);
            Size size2 = new Size(75, 150);

            Point p3 = new Point(320, 150);
            Size size3 = new Size(125, 70);

            Rectangle retangulo1 = new Rectangle(p1, size1);

            Rectangle retangulo2 = new Rectangle(p2, size2);
            Rectangle retangulo3 = new Rectangle(p3, size3);

            Rectangle[] retangulos1 = new Rectangle[]
            {
                retangulo2, retangulo3
            };

            // Retângulos Preenchidos

            Point p4 = new Point(400, 200);
            Size size4 = new Size(100, 75);

            Point p5 = new Point(320, 50);
            Size size5 = new Size(75, 75);

            Point p6 = new Point(400, 300);
            Size size6 = new Size(25, 25);

            Rectangle retangulo4 = new Rectangle(p4, size4);
            Rectangle retangulo5 = new Rectangle(p5, size5);
            Rectangle retangulo6 = new Rectangle(p6, size6);

            Rectangle[] retangulos2 = new Rectangle[]
            {
                retangulo5, retangulo6
            };

            desenhador.DrawRectangle(lapis1, retangulo1);
            desenhador.DrawRectangles(lapis2, retangulos1);

            Brush pincel1 = new LinearGradientBrush(retangulo4, Color.Black, Color.Purple, 45);

            desenhador.FillRectangle(pincel1, retangulo4);
            desenhador.FillRectangles(pincel1, retangulos2);
            */
            #endregion

            #region Círculos e Elipses, Vazios e Preenchidos
            /*
            Pen lapis1 = new Pen(Color.DarkBlue, 2);

            Point p1 = new Point(100, 100);
            Size size1 = new Size(100, 100);

            Point p2 = new Point(300, 100);
            Size size2 = new Size(100, 50);

            Point p3 = new Point(100, 300);
            Size size3 = new Size(300, 100);

            Rectangle rect1 = new Rectangle(p1, size1);
            Rectangle rect2 = new Rectangle(p2, size2);
            Rectangle rect3 = new Rectangle(p3, size3);

            desenhador.DrawEllipse(lapis1, rect1);
            desenhador.DrawEllipse(lapis1, rect2);

            Brush pincel = new LinearGradientBrush(rect3, Color.Pink, Color.Purple, 45);
            desenhador.FillEllipse(pincel, rect3);
            */
            #endregion

            #region Polígonos Vazios e Preenchidos
            /*
            Pen lapis = new Pen(Brushes.Purple, 2);
            Point[] pontos1 = new Point[]
            {
                new Point(50, 125),
                new Point(195, 215),
                new Point(145, 330),
                new Point(100, 300)
            };

            Point[] pontos2 = new Point[]
            {
                new Point(350, 225),
                new Point(235, 215),
                new Point(200, 300),
                new Point(245, 330)
            };

            Brush pincel = Brushes.Aquamarine;
            desenhador.DrawPolygon(lapis, pontos1);
            desenhador.FillPolygon(pincel, pontos2);
            */
            #endregion

            #region Curvas Vazias e Preenchidas
            /*
            Pen lapis1 = new Pen(Color.Black, 3);
            Pen lapis2 = new Pen(Color.Fuchsia, 3);

            Point p1 = new Point(100, 300);
            Point p2 = new Point(200, 250);
            Point p3 = new Point(300, 350);
            Point p4 = new Point(225, 135);
            Point p5 = new Point(400, 100);

            Point[] pontos1 = new Point[]
            {
                p1, p2, p3, p4, p5
            };

            Point p6 = new Point(200, 300);
            Point p7 = new Point(300, 350);
            Point p8 = new Point(310, 450);
            Point p9 = new Point(325, 235);
            Point p10 = new Point(135, 200);

            Point[] pontos2 = new Point[]
            {
                p6, p7, p8, p9, p10
            };

            Point p11 = new Point(400, 200);
            Point p12 = new Point(125, 134);
            Point p13 = new Point(103, 150);
            Point p14 = new Point(235, 135);
            Point p15 = new Point(104, 100);

            Point[] pontos3 = new Point[]
            {
                p11, p12, p13, p14, p15
            };

            desenhador.DrawCurve(lapis1, pontos1, 1.5f);
            desenhador.DrawClosedCurve(lapis2, pontos2, 1.5f, FillMode.Alternate);
            desenhador.FillClosedCurve(Brushes.Pink, pontos3);
            */
            #endregion

            #region Arcos

            Pen lapis = new Pen(Color.DarkSlateBlue, 2);

            Point p1 = new Point(100, 100);
            Size size1 = new Size(300, 300);
            Rectangle rect = new Rectangle(p1, size1);

            desenhador.DrawArc(lapis, rect, 90, 180);

            #endregion

            // Exibir no PictureBox
            pictureBox_Resultado.Image = folha;

            // Salvar como arquivo
            folha.Save(@"C:\Users\NSYS-DEV-05\Desktop\Estudos\CSharp-Projetos\GDIPlus\desenho.jpg", ImageFormat.Jpeg);
        }
    }
}