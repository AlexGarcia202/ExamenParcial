namespace CapaPresentacion
{
    partial class frmGestionPedidos
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpiar = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrar = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoPedido = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dgvGestionPedidos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny6 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPropina = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny7 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPedido = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny8 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txtCantidad = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cboxMenuProducto = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dtpFecha = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxMenuProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.toolStripSeparator1,
            this.btnEditar,
            this.toolStripSeparator4,
            this.btnEliminar,
            this.toolStripSeparator2,
            this.btnLimpiar,
            this.toolStripSeparator3,
            this.btnCerrar,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 90;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 22);
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 90;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 22);
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 90;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 22);
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 90;
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 22);
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 90;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(70, 22);
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 25);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonHeaderGroup2);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonHeaderGroup1);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(795, 481);
            this.kryptonSplitContainer1.SplitterDistance = 265;
            this.kryptonSplitContainer1.TabIndex = 1;
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.dtpFecha);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.cboxMenuProducto);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtCantidad);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label8);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtTotalPedido);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label7);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtPropina);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label6);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtPrecioTotal);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label5);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtPrecio);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label4);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label3);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label2);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.label1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txtCodigoPedido);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(265, 481);
            this.kryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup2.TabIndex = 1;
            this.kryptonHeaderGroup2.ValuesPrimary.Description = "Captura de datos";
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = null;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(11, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menu Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Pedido:";
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtCodigoPedido.Enabled = false;
            this.txtCodigoPedido.Location = new System.Drawing.Point(14, 30);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.ReadOnly = true;
            this.txtCodigoPedido.Size = new System.Drawing.Size(237, 29);
            this.txtCodigoPedido.StateActive.Border.Color1 = System.Drawing.Color.Gray;
            this.txtCodigoPedido.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txtCodigoPedido.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCodigoPedido.StateActive.Border.Rounding = 5;
            this.txtCodigoPedido.TabIndex = 0;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::CapaPresentacion.Properties.Resources.BtnLimpiar__1_;
            this.buttonSpecAny1.UniqueName = "C37CCABCD0714830F88553FA2B074E7F";
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.dgvGestionPedidos);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(525, 481);
            this.kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "Listado de Empleados";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = null;
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "Registros: 0";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "";
            // 
            // dgvGestionPedidos
            // 
            this.dgvGestionPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGestionPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGestionPedidos.Location = new System.Drawing.Point(0, 0);
            this.dgvGestionPedidos.Name = "dgvGestionPedidos";
            this.dgvGestionPedidos.ReadOnly = true;
            this.dgvGestionPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestionPedidos.Size = new System.Drawing.Size(523, 434);
            this.dgvGestionPedidos.TabIndex = 0;
            this.dgvGestionPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGestionPedidos_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(11, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(14, 246);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(237, 29);
            this.txtPrecio.StateActive.Border.Color1 = System.Drawing.Color.Gray;
            this.txtPrecio.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txtPrecio.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrecio.StateActive.Border.Rounding = 5;
            this.txtPrecio.TabIndex = 8;
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Image = global::CapaPresentacion.Properties.Resources.BtnLimpiar__1_;
            this.buttonSpecAny5.UniqueName = "C37CCABCD0714830F88553FA2B074E7F";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(11, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precio Total:";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny6});
            this.txtPrecioTotal.Enabled = false;
            this.txtPrecioTotal.Location = new System.Drawing.Point(14, 302);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(237, 29);
            this.txtPrecioTotal.StateActive.Border.Color1 = System.Drawing.Color.Gray;
            this.txtPrecioTotal.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txtPrecioTotal.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrecioTotal.StateActive.Border.Rounding = 5;
            this.txtPrecioTotal.TabIndex = 10;
            // 
            // buttonSpecAny6
            // 
            this.buttonSpecAny6.Image = global::CapaPresentacion.Properties.Resources.BtnLimpiar__1_;
            this.buttonSpecAny6.UniqueName = "C37CCABCD0714830F88553FA2B074E7F";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(11, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Propina:";
            // 
            // txtPropina
            // 
            this.txtPropina.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny7});
            this.txtPropina.Enabled = false;
            this.txtPropina.Location = new System.Drawing.Point(14, 354);
            this.txtPropina.Name = "txtPropina";
            this.txtPropina.ReadOnly = true;
            this.txtPropina.Size = new System.Drawing.Size(237, 29);
            this.txtPropina.StateActive.Border.Color1 = System.Drawing.Color.Gray;
            this.txtPropina.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txtPropina.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPropina.StateActive.Border.Rounding = 5;
            this.txtPropina.TabIndex = 12;
            // 
            // buttonSpecAny7
            // 
            this.buttonSpecAny7.Image = global::CapaPresentacion.Properties.Resources.BtnLimpiar__1_;
            this.buttonSpecAny7.UniqueName = "C37CCABCD0714830F88553FA2B074E7F";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(11, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Pedido:";
            // 
            // txtTotalPedido
            // 
            this.txtTotalPedido.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny8});
            this.txtTotalPedido.Enabled = false;
            this.txtTotalPedido.Location = new System.Drawing.Point(14, 415);
            this.txtTotalPedido.Name = "txtTotalPedido";
            this.txtTotalPedido.ReadOnly = true;
            this.txtTotalPedido.Size = new System.Drawing.Size(237, 29);
            this.txtTotalPedido.StateActive.Border.Color1 = System.Drawing.Color.Gray;
            this.txtTotalPedido.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txtTotalPedido.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTotalPedido.StateActive.Border.Rounding = 5;
            this.txtTotalPedido.TabIndex = 14;
            // 
            // buttonSpecAny8
            // 
            this.buttonSpecAny8.Image = global::CapaPresentacion.Properties.Resources.BtnLimpiar__1_;
            this.buttonSpecAny8.UniqueName = "C37CCABCD0714830F88553FA2B074E7F";
            // 
            // txtCantidad
            // 
            this.txtCantidad.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txtCantidad.Location = new System.Drawing.Point(14, 143);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(237, 29);
            this.txtCantidad.StateActive.Border.Color1 = System.Drawing.Color.Gray;
            this.txtCantidad.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            this.txtCantidad.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCantidad.StateActive.Border.Rounding = 5;
            this.txtCantidad.TabIndex = 16;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Image = global::CapaPresentacion.Properties.Resources.BtnLimpiar__1_;
            this.buttonSpecAny3.UniqueName = "C37CCABCD0714830F88553FA2B074E7F";
            // 
            // cboxMenuProducto
            // 
            this.cboxMenuProducto.DropDownWidth = 236;
            this.cboxMenuProducto.Items.AddRange(new object[] {
            "1-Personal",
            "2-Mediano",
            "3-Familiar"});
            this.cboxMenuProducto.Location = new System.Drawing.Point(14, 195);
            this.cboxMenuProducto.Name = "cboxMenuProducto";
            this.cboxMenuProducto.Size = new System.Drawing.Size(236, 21);
            this.cboxMenuProducto.TabIndex = 17;
            this.cboxMenuProducto.SelectedIndexChanged += new System.EventHandler(this.cboxMenuProducto_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(14, 90);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(236, 21);
            this.dtpFecha.TabIndex = 18;
            // 
            // frmGestionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 506);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmGestionPedidos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGestionPedidos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxMenuProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton btnAgregar;
        private FontAwesome.Sharp.IconToolStripButton btnEditar;
        private FontAwesome.Sharp.IconToolStripButton btnEliminar;
        private FontAwesome.Sharp.IconToolStripButton btnLimpiar;
        private FontAwesome.Sharp.IconToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCodigoPedido;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvGestionPedidos;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalPedido;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny8;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPropina;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny7;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrecioTotal;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny6;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrecio;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFecha;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboxMenuProducto;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCantidad;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
    }
}

