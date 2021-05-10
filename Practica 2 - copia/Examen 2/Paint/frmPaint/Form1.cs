using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace frmPaint
{
    public partial class Form1 : Form
    {
        enum Figuras
        {
            Lapiz,
            Pluma,
            Pincel,
            Cuadrado,
            Circulo,
            Elipse,
            pentagono,
            triangulo,
            Linea,
            Rombo,
            Letra,
            Relleno,
            Borrador
        }

        Figuras figuraActiva;
        Graphics objetoDibujador;
        bool isPainting = false;
        private Point[] puntos;
        Bitmap canvas;
        Dictionary<int, Bitmap> lienzos = new Dictionary<int, Bitmap>();

        private Point primerPunto, segundoPunto;


        ArrayList ListaPestaña = new ArrayList();
        int ContarPestaña = 2;

        ArrayList ListaPictureBox = new ArrayList();
        int ContarPictureBox = 0;


        public Form1()
        {
            InitializeComponent();
            puntos = new Point[0];
            canvas = new Bitmap(pbxImagen1.Width, pbxImagen1.Height);

            Bitmap objBitmap = new Bitmap(pbxImagen1.Width, pbxImagen1.Height);
            lienzos.Add(tbcTab.SelectedIndex, objBitmap);
        }

        public void AgregarPuntos(Point nuevoPunto)
        {
            Point[] temp = new Point[puntos.Length + 1];
            puntos.CopyTo(temp, 0);
            puntos = temp;
            puntos[puntos.Length - 1] = nuevoPunto;
        }
        private void Relleno(Bitmap bmp,Point pt,Color targetColor,Color repracement)
        {
            Stack<Point> pixels = new Stack<Point>();
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            pixels.Push(pt);
            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < bmp.Width && a.X > 0 && a.Y < bmp.Height && a.Y > 0)
                {
                    if (bmp.GetPixel(a.X, a.Y) == targetColor)
                    {
                        bmp.SetPixel(a.X, a.Y, repracement);
                        pixels.Push(new Point(a.X-1, a.Y));
                        pixels.Push(new Point(a.X+1, a.Y));
                        pixels.Push(new Point(a.X, a.Y-1));
                        pixels.Push(new Point(a.X, a.Y+1));
                    }

                }
            }
            pbxImagen1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAcercaDe = new frmAcercaDe();
            formAcercaDe.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordenadas.Text = string.Format("X:{0}, Y:{1}", e.X.ToString(), e.Y.ToString());

            switch (figuraActiva)
            {
                case Figuras.Lapiz:
                    lblCoordenadas.Text += "Funcion: Lapiz";
                    if (isPainting)
                    {

                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            PictureBox canvaslienzo = tbcTab.SelectedTab.Controls[0] as PictureBox;
                            int tabpage = tbcTab.SelectedIndex;
                            Bitmap canvasObtenido;
                            lienzos.TryGetValue(tabpage, out canvasObtenido);
                            canvaslienzo.Image = canvasObtenido;
                            objetoDibujador = Graphics.FromImage(canvasObtenido);
                            lblStatus.Text = "Dibujando";
                            Pen miLapiz = new Pen(btnColores.BackColor, (float)nudGrosor.Value);

                            miLapiz.StartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                            miLapiz.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                            objetoDibujador.DrawLines(miLapiz, puntos);
                        }

                    }

                    break;
                case Figuras.Pluma:
                    lblCoordenadas.Text += "Funcion: Pluma";
                    if (isPainting)
                    {

                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            pbxImagen1.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvas);
                            lblStatus.Text = "Dibujando";
                            Pen miLapiz = new Pen(btnColores.BackColor, (float)nudGrosor.Value);

                            miLapiz.StartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                            miLapiz.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                            objetoDibujador.DrawLines(miLapiz, puntos);

                        }
                    }
                    break;
                case Figuras.Pincel:
                    if (isPainting)
                    {
                        

                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            pbxImagen1.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvas);
                            lblStatus.Text = "Dibujando";
                            Font drawFont = new Font("Arial", (float)nudGrosor.Value);
                            Brush miPincel = new SolidBrush(btnColores.BackColor);
                            objetoDibujador.DrawString("#", drawFont, miPincel, e.X, e.Y);



                        }

                    }

                    break;

                case Figuras.Borrador:
                    lblCoordenadas.Text += "Funcion: Borrador";
                    if (isPainting)
                    {

                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            pbxImagen1.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvas);
                            lblStatus.Text = "Borrando";
                            Pen miLapiz = new Pen(Color.White, (float)nudGrosor.Value);

                            objetoDibujador.DrawLines(miLapiz, puntos);
                        }

                    }
              

                    break;
                case Figuras.Relleno:
                    if (isPainting)
                    {
                        AgregarPuntos(new Point(e.X, e.Y));





                        lblCoordenadas.Text += "|Funcion: Rellenar";
                        if (puntos.Length > 0 && puntos.Length < 2)
                        {
                            pbxImagen1.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvas);
                            SolidBrush miBrush = new SolidBrush(btnColores.BackColor);

                            if (pbxImagen1.BackColor != btnColores.BackColor)
                            {

                            }
                            Relleno(canvas, new Point(e.X, e.Y), pbxImagen1.BackColor, btnColores.BackColor);
                        }
                    }
                    break;
                case Figuras.Letra:
                    if (isPainting)
                    {


                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            pbxImagen1.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvas);
                            lblStatus.Text = "Dibujando";
                            Font drawFont = new Font("Arial", (float)nudGrosor.Value);
                            Brush miPincel = new SolidBrush(btnColores.BackColor);
                            objetoDibujador.DrawString(txtLetra.Text, drawFont, miPincel, e.X, e.Y);



                        }

                    }
                    break;
                default:
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearPictureBoxyTab();
        }


        private void CrearPictureBoxyTab()
        {
            TabPage NuevaPestaña = new TabPage("Nueva Pestaña" + ContarPestaña);

            ListaPestaña.Add(NuevaPestaña);

            tbcTab.TabPages.Add(NuevaPestaña);

            var newPictureBox = new PictureBox
            {
                Location = new Point(0, 0),
                Size = new Size(1070, 548),
                BackColor = Color.White
            };

            NuevaPestaña.Controls.Add(newPictureBox);
            ContarPestaña++;



            tbcTab.SelectedTab = NuevaPestaña;

            newPictureBox.MouseMove += (pictureBox1_MouseMove);
            newPictureBox.MouseDown += (pictureBox1_MouseDown);
            newPictureBox.MouseUp += (pictureBox1_MouseUp);
            Bitmap objBitmap = new Bitmap(newPictureBox.Width, newPictureBox.Height);
            lienzos.Add(tbcTab.SelectedIndex, objBitmap);
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Lapiz;
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Pincel;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPainting = true;
            primerPunto = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            segundoPunto = new Point(e.X, e.Y);
            isPainting = false;
            puntos = new Point[0];
            lblStatus.Text = "No dibujando";
            PictureBox canvaslienzo = tbcTab.SelectedTab.Controls[0] as PictureBox;
            int tabpage = tbcTab.SelectedIndex;
            Bitmap canvasObtenido;
            lienzos.TryGetValue(tabpage, out canvasObtenido);
            canvaslienzo.Image = canvasObtenido;
            objetoDibujador = Graphics.FromImage(canvasObtenido);
            Pen miLapiz = new Pen(btnColores.BackColor, (float)nudGrosor.Value);


            switch (figuraActiva)
            {

                case Figuras.Cuadrado:
                    objetoDibujador.DrawRectangle(miLapiz, primerPunto.X, primerPunto.Y,
                        segundoPunto.X - primerPunto.X, segundoPunto.Y - primerPunto.Y);

                    objetoDibujador.DrawRectangle(miLapiz, segundoPunto.X, primerPunto.Y,
                       primerPunto.X - segundoPunto.X, segundoPunto.Y - primerPunto.Y);

                    objetoDibujador.DrawRectangle(miLapiz, primerPunto.X, segundoPunto.Y,
                       segundoPunto.X - primerPunto.X, primerPunto.Y - segundoPunto.Y);

                    objetoDibujador.DrawRectangle(miLapiz, segundoPunto.X, segundoPunto.Y,
                       primerPunto.X - segundoPunto.X, primerPunto.Y - segundoPunto.Y);




                    break;
                case Figuras.Circulo:


                    break;
                case Figuras.Elipse:
                    objetoDibujador.DrawEllipse(miLapiz, primerPunto.X, primerPunto.Y,
                        segundoPunto.X - primerPunto.X, segundoPunto.Y - primerPunto.Y);

                    objetoDibujador.DrawEllipse(miLapiz, segundoPunto.X, primerPunto.Y,
                       primerPunto.X - segundoPunto.X, segundoPunto.Y - primerPunto.Y);

                    objetoDibujador.DrawEllipse(miLapiz, primerPunto.X, segundoPunto.Y,
                       segundoPunto.X - primerPunto.X, primerPunto.Y - segundoPunto.Y);

                    objetoDibujador.DrawEllipse(miLapiz, segundoPunto.X, segundoPunto.Y,
                       primerPunto.X - segundoPunto.X, primerPunto.Y - segundoPunto.Y);
                    break;
                case Figuras.Linea:
                    objetoDibujador.DrawLine(miLapiz, primerPunto, segundoPunto);
                    break;
                case Figuras.pentagono:
                    lblStatus.Text = "Dibujando Figura";
                    Rectangle pentagono = new Rectangle(primerPunto.X, primerPunto.Y,
                        segundoPunto.X - primerPunto.X, segundoPunto.Y - primerPunto.Y);
                    Point punto0 = new Point(pentagono.Left + (pentagono.Width / 2), pentagono.Top - (pentagono.Height / 3));
                    Point punto1 = new Point(pentagono.Left, pentagono.Bottom);
                    Point punto2 = new Point(pentagono.Right, pentagono.Bottom);
                    Point punto3 = new Point(pentagono.Left - (pentagono.Width / 2), pentagono.Top + (pentagono.Height / 3));
                    Point punto4 = new Point(pentagono.Right + ((pentagono.Right-pentagono.Left) / 2),
                        pentagono.Top + (pentagono.Height / 3));
                    miLapiz = new Pen(btnColores.BackColor);
                    objetoDibujador.DrawPolygon(miLapiz, new Point[] { punto3, punto1, punto2, punto4, punto0 });

                    break;
                case Figuras.triangulo:
                    lblStatus.Text = "Dibujando Figura";
                    Rectangle triangulo = new Rectangle(primerPunto.X, primerPunto.Y,
                        segundoPunto.X - primerPunto.X, segundoPunto.Y - primerPunto.Y);
                   punto0 = new Point(triangulo.Left + (triangulo.Width / 2), triangulo.Top - (triangulo.Height / 3));
                   punto1 = new Point(triangulo.Left, triangulo.Bottom);
                    punto2= new Point(triangulo.Right, triangulo.Bottom);
                    objetoDibujador.DrawPolygon(miLapiz, new Point[] { punto0, punto1, punto2 });
                    break;
               
                default:
                    
                    break;
            }
        }

        private void btnPaleta_Click(object sender, EventArgs e)
        {
            if (cdgPaletaColores.ShowDialog() == DialogResult.OK)
            {
                btnColores.BackColor = cdgPaletaColores.Color;
            }
        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Borrador;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdAbrirImagen.Filter = "Archivo Imagen(*.jpg,*.jpeg.*.png,*.bmp)*.jpg,*.jpeg.*.png,*.bmp|";
            if (ofdAbrirImagen.ShowDialog() == DialogResult.OK)
            {
                pbxImagen1.BackgroundImageLayout = ImageLayout.Stretch;
                pbxImagen1.BackgroundImage = Image.FromFile(ofdAbrirImagen.FileName);
            }
        }

        private void btnFormatoImagen_Click(object sender, EventArgs e)
        {
            if (pbxImagen1.BackgroundImageLayout == ImageLayout.Stretch)
            {
                pbxImagen1.BackgroundImageLayout = ImageLayout.Tile;
                lblFormato.Text = "Tile";
            }
            else
            {
                pbxImagen1.BackgroundImageLayout = ImageLayout.Stretch;
                lblFormato.Text = "Stretch";
            }
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Linea;
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Cuadrado;
        }

        private void btnPluma_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Pluma;
        }

        private void PbxImagen1_SizeChanged(object sender, EventArgs e)
        {
           
            canvas = new Bitmap(pbxImagen1.Width, pbxImagen1.Height);
        }

        private void SfdImagen_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdImagen.Filter = "Archivo Imagen(*.jpg, *.jpeg.*.png, *.bmp)| *.jpg,*.jpeg.*.png,*.bmp ";
            if (sfdImagen.ShowDialog()==DialogResult.OK)
            {
                Bitmap fondo = new Bitmap(pbxImagen1.Width, pbxImagen1.Height);
                var rec = new Rectangle(0, 0, pbxImagen1.Width, pbxImagen1.Height);
                pbxImagen1.DrawToBitmap(fondo, rec);
               
                fondo.Save(sfdImagen.FileName,ImageFormat.Bmp);
            }
           
            
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Elipse;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarToolStripMenuItem_Click(sender, e);
        }

        private void btnPoligono_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.pentagono;
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.triangulo;
        }

        private void btnRombo_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Rombo;
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Relleno;
        }

        private void btnLetra_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Letra;
        }

        private void stsPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblTamaño_Click(object sender, EventArgs e)
        {
            
        }
    }
}
