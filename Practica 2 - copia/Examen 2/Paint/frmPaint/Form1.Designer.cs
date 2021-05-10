namespace frmPaint
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.btnFormatoImagen = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.nudGrosor = new System.Windows.Forms.NumericUpDown();
            this.btnColores = new System.Windows.Forms.Button();
            this.btnPaleta = new System.Windows.Forms.Button();
            this.tbcTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbxImagen1 = new System.Windows.Forms.PictureBox();
            this.stsPrincipal = new System.Windows.Forms.StatusStrip();
            this.lblCoordenadas = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.cdgPaletaColores = new System.Windows.Forms.ColorDialog();
            this.ofdAbrirImagen = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLetra = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnPoligono = new System.Windows.Forms.Button();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.btnPluma = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnBorrador = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnBrush = new System.Windows.Forms.Button();
            this.btnElipse = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.sfdImagen = new System.Windows.Forms.SaveFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).BeginInit();
            this.tbcTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen1)).BeginInit();
            this.stsPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.propiedadesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1432, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::frmPaint.Properties.Resources.file;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::frmPaint.Properties.Resources.open_folder;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::frmPaint.Properties.Resources.save;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Image = global::frmPaint.Properties.Resources.save;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = global::frmPaint.Properties.Resources.printer;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(218, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::frmPaint.Properties.Resources.logout;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem});
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(197, 31);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 82);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(299, 31);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 82);
            this.button5.TabIndex = 3;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(400, 31);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 82);
            this.button6.TabIndex = 4;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtLetra);
            this.panel1.Controls.Add(this.lblFormato);
            this.panel1.Controls.Add(this.btnFormatoImagen);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.lblTamaño);
            this.panel1.Controls.Add(this.nudGrosor);
            this.panel1.Controls.Add(this.btnColores);
            this.panel1.Controls.Add(this.btnPaleta);
            this.panel1.Controls.Add(this.tbcTab);
            this.panel1.Location = new System.Drawing.Point(157, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 601);
            this.panel1.TabIndex = 5;
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(1087, 370);
            this.txtLetra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(132, 22);
            this.txtLetra.TabIndex = 12;
            // 
            // lblFormato
            // 
            this.lblFormato.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(1100, 327);
            this.lblFormato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(53, 17);
            this.lblFormato.TabIndex = 11;
            this.lblFormato.Text = "Stretch";
            // 
            // btnFormatoImagen
            // 
            this.btnFormatoImagen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFormatoImagen.Location = new System.Drawing.Point(1100, 263);
            this.btnFormatoImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFormatoImagen.Name = "btnFormatoImagen";
            this.btnFormatoImagen.Size = new System.Drawing.Size(100, 28);
            this.btnFormatoImagen.TabIndex = 7;
            this.btnFormatoImagen.Text = "Imagen";
            this.btnFormatoImagen.UseVisualStyleBackColor = true;
            this.btnFormatoImagen.Click += new System.EventHandler(this.btnFormatoImagen_Click);
            // 
            // lblColor
            // 
            this.lblColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(1132, 18);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 17);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            // 
            // lblTamaño
            // 
            this.lblTamaño.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(1132, 153);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(60, 17);
            this.lblTamaño.TabIndex = 1;
            this.lblTamaño.Text = "Tamaño";
            this.lblTamaño.Click += new System.EventHandler(this.lblTamaño_Click);
            // 
            // nudGrosor
            // 
            this.nudGrosor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudGrosor.Location = new System.Drawing.Point(1100, 190);
            this.nudGrosor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGrosor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrosor.Name = "nudGrosor";
            this.nudGrosor.Size = new System.Drawing.Size(120, 22);
            this.nudGrosor.TabIndex = 9;
            this.nudGrosor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnColores
            // 
            this.btnColores.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnColores.BackColor = System.Drawing.Color.Black;
            this.btnColores.Location = new System.Drawing.Point(1173, 55);
            this.btnColores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(69, 71);
            this.btnColores.TabIndex = 8;
            this.btnColores.UseVisualStyleBackColor = false;
            // 
            // btnPaleta
            // 
            this.btnPaleta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPaleta.Image = global::frmPaint.Properties.Resources.pallet_and_brushes;
            this.btnPaleta.Location = new System.Drawing.Point(1087, 55);
            this.btnPaleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaleta.Name = "btnPaleta";
            this.btnPaleta.Size = new System.Drawing.Size(85, 71);
            this.btnPaleta.TabIndex = 7;
            this.btnPaleta.UseVisualStyleBackColor = true;
            this.btnPaleta.Click += new System.EventHandler(this.btnPaleta_Click);
            // 
            // tbcTab
            // 
            this.tbcTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcTab.Controls.Add(this.tabPage1);
            this.tbcTab.Location = new System.Drawing.Point(0, 2);
            this.tbcTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcTab.Name = "tbcTab";
            this.tbcTab.SelectedIndex = 0;
            this.tbcTab.Size = new System.Drawing.Size(1077, 594);
            this.tbcTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbxImagen1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1069, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbxImagen1
            // 
            this.pbxImagen1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagen1.Location = new System.Drawing.Point(0, 0);
            this.pbxImagen1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxImagen1.Name = "pbxImagen1";
            this.pbxImagen1.Size = new System.Drawing.Size(802, 389);
            this.pbxImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxImagen1.TabIndex = 0;
            this.pbxImagen1.TabStop = false;
            this.pbxImagen1.SizeChanged += new System.EventHandler(this.PbxImagen1_SizeChanged);
            this.pbxImagen1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbxImagen1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbxImagen1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbxImagen1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // stsPrincipal
            // 
            this.stsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCoordenadas,
            this.lblStatus});
            this.stsPrincipal.Location = new System.Drawing.Point(0, 615);
            this.stsPrincipal.Name = "stsPrincipal";
            this.stsPrincipal.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.stsPrincipal.Size = new System.Drawing.Size(1432, 26);
            this.stsPrincipal.TabIndex = 6;
            this.stsPrincipal.Text = "statusStrip1";
            this.stsPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.stsPrincipal_ItemClicked);
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(95, 20);
            this.lblCoordenadas.Text = "X: null, Y: null";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            // 
            // ofdAbrirImagen
            // 
            this.ofdAbrirImagen.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLetra);
            this.panel2.Controls.Add(this.btnTriangulo);
            this.panel2.Controls.Add(this.btnPoligono);
            this.panel2.Controls.Add(this.btnRellenar);
            this.panel2.Controls.Add(this.btnPluma);
            this.panel2.Controls.Add(this.btnCuadrado);
            this.panel2.Controls.Add(this.btnBorrador);
            this.panel2.Controls.Add(this.btnPencil);
            this.panel2.Controls.Add(this.btnBrush);
            this.panel2.Controls.Add(this.btnElipse);
            this.panel2.Controls.Add(this.btnLinea);
            this.panel2.Location = new System.Drawing.Point(4, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 601);
            this.panel2.TabIndex = 0;
            // 
            // btnLetra
            // 
            this.btnLetra.Location = new System.Drawing.Point(69, 412);
            this.btnLetra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLetra.Name = "btnLetra";
            this.btnLetra.Size = new System.Drawing.Size(53, 47);
            this.btnLetra.TabIndex = 11;
            this.btnLetra.UseVisualStyleBackColor = true;
            this.btnLetra.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(69, 348);
            this.btnTriangulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(53, 47);
            this.btnTriangulo.TabIndex = 9;
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnPoligono
            // 
            this.btnPoligono.Location = new System.Drawing.Point(11, 348);
            this.btnPoligono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoligono.Name = "btnPoligono";
            this.btnPoligono.Size = new System.Drawing.Size(53, 47);
            this.btnPoligono.TabIndex = 8;
            this.btnPoligono.UseVisualStyleBackColor = true;
            this.btnPoligono.Click += new System.EventHandler(this.btnPoligono_Click);
            // 
            // btnRellenar
            // 
            this.btnRellenar.Location = new System.Drawing.Point(68, 297);
            this.btnRellenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(53, 47);
            this.btnRellenar.TabIndex = 7;
            this.btnRellenar.UseVisualStyleBackColor = true;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // btnPluma
            // 
            this.btnPluma.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPluma.Image = global::frmPaint.Properties.Resources.pluma;
            this.btnPluma.Location = new System.Drawing.Point(9, 297);
            this.btnPluma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPluma.Name = "btnPluma";
            this.btnPluma.Size = new System.Drawing.Size(53, 47);
            this.btnPluma.TabIndex = 6;
            this.btnPluma.UseVisualStyleBackColor = false;
            this.btnPluma.Click += new System.EventHandler(this.btnPluma_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackColor = System.Drawing.Color.Lime;
            this.btnCuadrado.Image = global::frmPaint.Properties.Resources.casilla_de_verificacion_vacia;
            this.btnCuadrado.Location = new System.Drawing.Point(9, 217);
            this.btnCuadrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(53, 47);
            this.btnCuadrado.TabIndex = 5;
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnBorrador
            // 
            this.btnBorrador.Image = global::frmPaint.Properties.Resources.goma_de_borrar;
            this.btnBorrador.Location = new System.Drawing.Point(9, 122);
            this.btnBorrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(53, 47);
            this.btnBorrador.TabIndex = 4;
            this.btnBorrador.UseVisualStyleBackColor = true;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Image = global::frmPaint.Properties.Resources.pencil_edit_button;
            this.btnPencil.Location = new System.Drawing.Point(9, 28);
            this.btnPencil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(53, 47);
            this.btnPencil.TabIndex = 3;
            this.btnPencil.Text = " ";
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnBrush
            // 
            this.btnBrush.Image = global::frmPaint.Properties.Resources.paint_brush;
            this.btnBrush.Location = new System.Drawing.Point(69, 28);
            this.btnBrush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(53, 47);
            this.btnBrush.TabIndex = 0;
            this.btnBrush.Text = " ";
            this.btnBrush.UseVisualStyleBackColor = true;
            this.btnBrush.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.BackColor = System.Drawing.Color.Brown;
            this.btnElipse.Image = global::frmPaint.Properties.Resources.contorno_de_forma_de_circulo;
            this.btnElipse.Location = new System.Drawing.Point(69, 217);
            this.btnElipse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(53, 47);
            this.btnElipse.TabIndex = 2;
            this.btnElipse.UseVisualStyleBackColor = false;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnLinea
            // 
            this.btnLinea.Image = global::frmPaint.Properties.Resources.restar;
            this.btnLinea.Location = new System.Drawing.Point(69, 122);
            this.btnLinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(53, 47);
            this.btnLinea.TabIndex = 1;
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // sfdImagen
            // 
            this.sfdImagen.FileOk += new System.ComponentModel.CancelEventHandler(this.SfdImagen_FileOk);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::frmPaint.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(97, 31);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 82);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::frmPaint.Properties.Resources.add_file1;
            this.btnNuevo.Location = new System.Drawing.Point(4, 31);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 82);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = " ";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 641);
            this.Controls.Add(this.stsPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Paint ITH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).EndInit();
            this.tbcTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen1)).EndInit();
            this.stsPrincipal.ResumeLayout(false);
            this.stsPrincipal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbcTab;
        private System.Windows.Forms.StatusStrip stsPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblCoordenadas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pbxImagen1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnPaleta;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.NumericUpDown nudGrosor;
        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.ColorDialog cdgPaletaColores;
        private System.Windows.Forms.OpenFileDialog ofdAbrirImagen;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Button btnFormatoImagen;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnBorrador;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button btnPluma;
        private System.Windows.Forms.SaveFileDialog sfdImagen;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnPoligono;
        private System.Windows.Forms.Button btnLetra;
        private System.Windows.Forms.TextBox txtLetra;
    }
}

