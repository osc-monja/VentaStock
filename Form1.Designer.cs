namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boton_usuario = new System.Windows.Forms.Button();
            this.boton_productos = new System.Windows.Forms.Button();
            this.boton_categorias = new System.Windows.Forms.Button();
            this.boton_clientes = new System.Windows.Forms.Button();
            this.boton_proveedores = new System.Windows.Forms.Button();
            this.boton_unidades = new System.Windows.Forms.Button();
            this.label_principal = new System.Windows.Forms.Label();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.tabUsuario = new System.Windows.Forms.TabControl();
            this.tab_mostrarU = new System.Windows.Forms.TabPage();
            this.gridview_usuario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_agregarU = new System.Windows.Forms.TabPage();
            this.label_nuevoUsuario = new System.Windows.Forms.Label();
            this.box_rol = new System.Windows.Forms.TextBox();
            this.box_correo = new System.Windows.Forms.TextBox();
            this.box_contrasena = new System.Windows.Forms.TextBox();
            this.box_usuario = new System.Windows.Forms.TextBox();
            this.label_rol = new System.Windows.Forms.Label();
            this.label_correo = new System.Windows.Forms.Label();
            this.label_con = new System.Windows.Forms.Label();
            this.labe_usu = new System.Windows.Forms.Label();
            this.agregar_usuario = new System.Windows.Forms.Button();
            this.boton_ventas = new System.Windows.Forms.Button();
            this.boton_ayuda = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabProductos = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabCategorias = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabProveedor = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabUnidades = new System.Windows.Forms.TabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.panel_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.tabUsuario.SuspendLayout();
            this.tab_mostrarU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_usuario)).BeginInit();
            this.tab_agregarU.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.tabCategorias.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabProveedor.SuspendLayout();
            this.tabUnidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_usuario
            // 
            this.boton_usuario.Location = new System.Drawing.Point(12, 101);
            this.boton_usuario.Name = "boton_usuario";
            this.boton_usuario.Size = new System.Drawing.Size(103, 52);
            this.boton_usuario.TabIndex = 1;
            this.boton_usuario.Text = "USUARIOS";
            this.boton_usuario.UseVisualStyleBackColor = true;
            this.boton_usuario.Click += new System.EventHandler(this.boton_usuario_Click);
            // 
            // boton_productos
            // 
            this.boton_productos.Location = new System.Drawing.Point(12, 159);
            this.boton_productos.Name = "boton_productos";
            this.boton_productos.Size = new System.Drawing.Size(103, 52);
            this.boton_productos.TabIndex = 2;
            this.boton_productos.Text = "PRODUCTOS";
            this.boton_productos.UseVisualStyleBackColor = true;
            this.boton_productos.Click += new System.EventHandler(this.boton_productos_Click);
            // 
            // boton_categorias
            // 
            this.boton_categorias.Location = new System.Drawing.Point(12, 217);
            this.boton_categorias.Name = "boton_categorias";
            this.boton_categorias.Size = new System.Drawing.Size(103, 52);
            this.boton_categorias.TabIndex = 3;
            this.boton_categorias.Text = "CATEGORÍAS";
            this.boton_categorias.UseVisualStyleBackColor = true;
            // 
            // boton_clientes
            // 
            this.boton_clientes.Location = new System.Drawing.Point(12, 275);
            this.boton_clientes.Name = "boton_clientes";
            this.boton_clientes.Size = new System.Drawing.Size(103, 52);
            this.boton_clientes.TabIndex = 4;
            this.boton_clientes.Text = "CLIENTES";
            this.boton_clientes.UseVisualStyleBackColor = true;
            // 
            // boton_proveedores
            // 
            this.boton_proveedores.Location = new System.Drawing.Point(12, 333);
            this.boton_proveedores.Name = "boton_proveedores";
            this.boton_proveedores.Size = new System.Drawing.Size(103, 52);
            this.boton_proveedores.TabIndex = 5;
            this.boton_proveedores.Text = "PROVEEDORES";
            this.boton_proveedores.UseVisualStyleBackColor = true;
            // 
            // boton_unidades
            // 
            this.boton_unidades.Location = new System.Drawing.Point(12, 391);
            this.boton_unidades.Name = "boton_unidades";
            this.boton_unidades.Size = new System.Drawing.Size(103, 52);
            this.boton_unidades.TabIndex = 6;
            this.boton_unidades.Text = "UNIDADES";
            this.boton_unidades.UseVisualStyleBackColor = true;
            // 
            // label_principal
            // 
            this.label_principal.AutoSize = true;
            this.label_principal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_principal.Location = new System.Drawing.Point(383, 18);
            this.label_principal.Name = "label_principal";
            this.label_principal.Size = new System.Drawing.Size(217, 27);
            this.label_principal.TabIndex = 7;
            this.label_principal.Text = "PUNTO DE VENTA";
            // 
            // panel_principal
            // 
            this.panel_principal.Controls.Add(this.logo);
            this.panel_principal.Controls.Add(this.fecha);
            this.panel_principal.Controls.Add(this.label_principal);
            this.panel_principal.Location = new System.Drawing.Point(2, 7);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(927, 81);
            this.panel_principal.TabIndex = 8;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(10, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(93, 81);
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(694, 22);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(211, 20);
            this.fecha.TabIndex = 8;
            this.fecha.ValueChanged += new System.EventHandler(this.fecha_ValueChanged);
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.tab_mostrarU);
            this.tabUsuario.Controls.Add(this.tab_agregarU);
            this.tabUsuario.Location = new System.Drawing.Point(120, 95);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Drawing.Point(6, 6);
            this.tabUsuario.SelectedIndex = 0;
            this.tabUsuario.Size = new System.Drawing.Size(808, 484);
            this.tabUsuario.TabIndex = 9;
            // 
            // tab_mostrarU
            // 
            this.tab_mostrarU.Controls.Add(this.gridview_usuario);
            this.tab_mostrarU.Controls.Add(this.label2);
            this.tab_mostrarU.Location = new System.Drawing.Point(4, 28);
            this.tab_mostrarU.Name = "tab_mostrarU";
            this.tab_mostrarU.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mostrarU.Size = new System.Drawing.Size(800, 452);
            this.tab_mostrarU.TabIndex = 0;
            this.tab_mostrarU.Text = "Mostrar";
            this.tab_mostrarU.UseVisualStyleBackColor = true;
            // 
            // gridview_usuario
            // 
            this.gridview_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_usuario.Location = new System.Drawing.Point(22, 33);
            this.gridview_usuario.Name = "gridview_usuario";
            this.gridview_usuario.Size = new System.Drawing.Size(760, 409);
            this.gridview_usuario.TabIndex = 1;
            this.gridview_usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_usuario_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mostrar usuarios";
            // 
            // tab_agregarU
            // 
            this.tab_agregarU.Controls.Add(this.label_nuevoUsuario);
            this.tab_agregarU.Controls.Add(this.box_rol);
            this.tab_agregarU.Controls.Add(this.box_correo);
            this.tab_agregarU.Controls.Add(this.box_contrasena);
            this.tab_agregarU.Controls.Add(this.box_usuario);
            this.tab_agregarU.Controls.Add(this.label_rol);
            this.tab_agregarU.Controls.Add(this.label_correo);
            this.tab_agregarU.Controls.Add(this.label_con);
            this.tab_agregarU.Controls.Add(this.labe_usu);
            this.tab_agregarU.Controls.Add(this.agregar_usuario);
            this.tab_agregarU.Location = new System.Drawing.Point(4, 28);
            this.tab_agregarU.Name = "tab_agregarU";
            this.tab_agregarU.Padding = new System.Windows.Forms.Padding(3);
            this.tab_agregarU.Size = new System.Drawing.Size(800, 452);
            this.tab_agregarU.TabIndex = 1;
            this.tab_agregarU.Text = "Agregar";
            this.tab_agregarU.UseVisualStyleBackColor = true;
            // 
            // label_nuevoUsuario
            // 
            this.label_nuevoUsuario.AutoSize = true;
            this.label_nuevoUsuario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nuevoUsuario.Location = new System.Drawing.Point(309, 36);
            this.label_nuevoUsuario.Name = "label_nuevoUsuario";
            this.label_nuevoUsuario.Size = new System.Drawing.Size(148, 24);
            this.label_nuevoUsuario.TabIndex = 10;
            this.label_nuevoUsuario.Text = "Nuevo Usuario";
            // 
            // box_rol
            // 
            this.box_rol.Location = new System.Drawing.Point(281, 249);
            this.box_rol.Name = "box_rol";
            this.box_rol.Size = new System.Drawing.Size(210, 20);
            this.box_rol.TabIndex = 9;
            // 
            // box_correo
            // 
            this.box_correo.Location = new System.Drawing.Point(281, 206);
            this.box_correo.Name = "box_correo";
            this.box_correo.Size = new System.Drawing.Size(210, 20);
            this.box_correo.TabIndex = 8;
            // 
            // box_contrasena
            // 
            this.box_contrasena.Location = new System.Drawing.Point(281, 157);
            this.box_contrasena.Name = "box_contrasena";
            this.box_contrasena.Size = new System.Drawing.Size(210, 20);
            this.box_contrasena.TabIndex = 7;
            this.box_contrasena.UseSystemPasswordChar = true;
            // 
            // box_usuario
            // 
            this.box_usuario.Location = new System.Drawing.Point(281, 109);
            this.box_usuario.Name = "box_usuario";
            this.box_usuario.Size = new System.Drawing.Size(210, 20);
            this.box_usuario.TabIndex = 6;
            this.box_usuario.TextChanged += new System.EventHandler(this.box_usuario_TextChanged);
            // 
            // label_rol
            // 
            this.label_rol.AutoSize = true;
            this.label_rol.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rol.Location = new System.Drawing.Point(241, 249);
            this.label_rol.Name = "label_rol";
            this.label_rol.Size = new System.Drawing.Size(31, 18);
            this.label_rol.TabIndex = 4;
            this.label_rol.Text = "Rol";
            // 
            // label_correo
            // 
            this.label_correo.AutoSize = true;
            this.label_correo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correo.Location = new System.Drawing.Point(135, 208);
            this.label_correo.Name = "label_correo";
            this.label_correo.Size = new System.Drawing.Size(137, 18);
            this.label_correo.TabIndex = 3;
            this.label_correo.Text = "Correo electrónico";
            // 
            // label_con
            // 
            this.label_con.AutoSize = true;
            this.label_con.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_con.Location = new System.Drawing.Point(188, 159);
            this.label_con.Name = "label_con";
            this.label_con.Size = new System.Drawing.Size(84, 18);
            this.label_con.TabIndex = 2;
            this.label_con.Text = "Contaseña";
            // 
            // labe_usu
            // 
            this.labe_usu.AutoSize = true;
            this.labe_usu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_usu.Location = new System.Drawing.Point(210, 111);
            this.labe_usu.Name = "labe_usu";
            this.labe_usu.Size = new System.Drawing.Size(62, 18);
            this.labe_usu.TabIndex = 1;
            this.labe_usu.Text = "Usuario";
            // 
            // agregar_usuario
            // 
            this.agregar_usuario.BackColor = System.Drawing.Color.White;
            this.agregar_usuario.Location = new System.Drawing.Point(343, 300);
            this.agregar_usuario.Name = "agregar_usuario";
            this.agregar_usuario.Size = new System.Drawing.Size(100, 35);
            this.agregar_usuario.TabIndex = 0;
            this.agregar_usuario.Text = "Agregar";
            this.agregar_usuario.UseVisualStyleBackColor = false;
            this.agregar_usuario.Click += new System.EventHandler(this.agregar_usuario_Click);
            // 
            // boton_ventas
            // 
            this.boton_ventas.Location = new System.Drawing.Point(12, 449);
            this.boton_ventas.Name = "boton_ventas";
            this.boton_ventas.Size = new System.Drawing.Size(103, 52);
            this.boton_ventas.TabIndex = 10;
            this.boton_ventas.Text = "VENTAS";
            this.boton_ventas.UseVisualStyleBackColor = true;
            this.boton_ventas.Click += new System.EventHandler(this.boton_ventas_Click);
            // 
            // boton_ayuda
            // 
            this.boton_ayuda.Location = new System.Drawing.Point(12, 543);
            this.boton_ayuda.Name = "boton_ayuda";
            this.boton_ayuda.Size = new System.Drawing.Size(103, 31);
            this.boton_ayuda.TabIndex = 11;
            this.boton_ayuda.Text = "AYUDA";
            this.boton_ayuda.UseVisualStyleBackColor = true;
            this.boton_ayuda.Click += new System.EventHandler(this.boton_ayuda_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Logotipo.png");
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.tabPage4);
            this.tabProductos.Controls.Add(this.tabPage3);
            this.tabProductos.Location = new System.Drawing.Point(120, 95);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Drawing.Point(6, 6);
            this.tabProductos.SelectedIndex = 0;
            this.tabProductos.Size = new System.Drawing.Size(800, 480);
            this.tabProductos.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 448);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Mostrar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Agregar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabCategorias
            // 
            this.tabCategorias.Controls.Add(this.tabPage5);
            this.tabCategorias.Controls.Add(this.tabPage6);
            this.tabCategorias.Location = new System.Drawing.Point(120, 95);
            this.tabCategorias.Name = "tabCategorias";
            this.tabCategorias.Padding = new System.Drawing.Point(6, 6);
            this.tabCategorias.SelectedIndex = 0;
            this.tabCategorias.Size = new System.Drawing.Size(800, 480);
            this.tabCategorias.TabIndex = 14;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 448);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Mostrar";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(792, 448);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Agregar";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabPage7);
            this.tabClientes.Controls.Add(this.tabPage8);
            this.tabClientes.Location = new System.Drawing.Point(120, 95);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Drawing.Point(6, 6);
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(800, 480);
            this.tabClientes.TabIndex = 15;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 28);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(792, 448);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Mostrar";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 28);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(792, 448);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Agregar";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabProveedor
            // 
            this.tabProveedor.Controls.Add(this.tabPage9);
            this.tabProveedor.Controls.Add(this.tabPage10);
            this.tabProveedor.Location = new System.Drawing.Point(120, 95);
            this.tabProveedor.Name = "tabProveedor";
            this.tabProveedor.Padding = new System.Drawing.Point(6, 6);
            this.tabProveedor.SelectedIndex = 0;
            this.tabProveedor.Size = new System.Drawing.Size(800, 480);
            this.tabProveedor.TabIndex = 16;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 28);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(792, 448);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Mostrar";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 28);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(792, 448);
            this.tabPage10.TabIndex = 2;
            this.tabPage10.Text = "Agregar";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabUnidades
            // 
            this.tabUnidades.Controls.Add(this.tabPage11);
            this.tabUnidades.Controls.Add(this.tabPage12);
            this.tabUnidades.Location = new System.Drawing.Point(120, 95);
            this.tabUnidades.Name = "tabUnidades";
            this.tabUnidades.Padding = new System.Drawing.Point(6, 6);
            this.tabUnidades.SelectedIndex = 0;
            this.tabUnidades.Size = new System.Drawing.Size(800, 480);
            this.tabUnidades.TabIndex = 17;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 28);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(792, 448);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Mostrar";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 28);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(792, 448);
            this.tabPage12.TabIndex = 2;
            this.tabPage12.Text = "Agregar";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 590);
            this.Controls.Add(this.boton_ayuda);
            this.Controls.Add(this.boton_ventas);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.boton_unidades);
            this.Controls.Add(this.boton_proveedores);
            this.Controls.Add(this.boton_clientes);
            this.Controls.Add(this.boton_categorias);
            this.Controls.Add(this.boton_productos);
            this.Controls.Add(this.boton_usuario);
            this.Controls.Add(this.tabUsuario);
            this.Controls.Add(this.tabUnidades);
            this.Controls.Add(this.tabProveedor);
            this.Controls.Add(this.tabClientes);
            this.Controls.Add(this.tabCategorias);
            this.Controls.Add(this.tabProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentaStock - Punto de Venta";
            this.panel_principal.ResumeLayout(false);
            this.panel_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.tabUsuario.ResumeLayout(false);
            this.tab_mostrarU.ResumeLayout(false);
            this.tab_mostrarU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_usuario)).EndInit();
            this.tab_agregarU.ResumeLayout(false);
            this.tab_agregarU.PerformLayout();
            this.tabProductos.ResumeLayout(false);
            this.tabCategorias.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabProveedor.ResumeLayout(false);
            this.tabUnidades.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_usuario;
        private System.Windows.Forms.Button boton_productos;
        private System.Windows.Forms.Button boton_categorias;
        private System.Windows.Forms.Button boton_clientes;
        private System.Windows.Forms.Button boton_proveedores;
        private System.Windows.Forms.Button boton_unidades;
        private System.Windows.Forms.Label label_principal;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TabControl tabUsuario;
        private System.Windows.Forms.TabPage tab_mostrarU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tab_agregarU;
        private System.Windows.Forms.DataGridView gridview_usuario;
        private System.Windows.Forms.Button boton_ventas;
        private System.Windows.Forms.Button boton_ayuda;
        private System.Windows.Forms.Label label_nuevoUsuario;
        private System.Windows.Forms.TextBox box_rol;
        private System.Windows.Forms.TextBox box_correo;
        private System.Windows.Forms.TextBox box_contrasena;
        private System.Windows.Forms.TextBox box_usuario;
        private System.Windows.Forms.Label label_rol;
        private System.Windows.Forms.Label label_correo;
        private System.Windows.Forms.Label label_con;
        private System.Windows.Forms.Label labe_usu;
        private System.Windows.Forms.Button agregar_usuario;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TabControl tabProductos;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabCategorias;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabClientes;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabControl tabProveedor;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabControl tabUnidades;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
    }
}

