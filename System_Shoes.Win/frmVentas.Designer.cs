
namespace System_Shoes.Win
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.gvVentasDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVentaDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidVenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lupProductos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colcantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldv2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colventa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVentas = new DevExpress.XtraGrid.GridControl();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lupClientes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lupUsuarios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnImpTickect = new DevExpress.XtraBars.BarButtonItem();
            this.btnImpRem = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentasDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVentasDetalle
            // 
            this.gvVentasDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVentasDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVentasDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVentaDetalle,
            this.colidVenta1,
            this.colidProducto,
            this.colcantidad1,
            this.colprecio,
            this.colimporte1,
            this.coldc,
            this.coldv,
            this.coldv2,
            this.coldescuento1,
            this.coltotal1,
            this.colventa});
            this.gvVentasDetalle.GridControl = this.gcVentas;
            this.gvVentasDetalle.Name = "gvVentasDetalle";
            this.gvVentasDetalle.OptionsBehavior.Editable = false;
            this.gvVentasDetalle.OptionsCustomization.AllowColumnMoving = false;
            this.gvVentasDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvVentasDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVentasDetalle.OptionsView.ShowGroupPanel = false;
            this.gvVentasDetalle.ViewCaption = "Detalle Venta";
            // 
            // colidVentaDetalle
            // 
            this.colidVentaDetalle.FieldName = "idVentaDetalle";
            this.colidVentaDetalle.Name = "colidVentaDetalle";
            // 
            // colidVenta1
            // 
            this.colidVenta1.FieldName = "idVenta";
            this.colidVenta1.Name = "colidVenta1";
            // 
            // colidProducto
            // 
            this.colidProducto.Caption = "Producto";
            this.colidProducto.ColumnEdit = this.lupProductos;
            this.colidProducto.FieldName = "idProducto";
            this.colidProducto.Name = "colidProducto";
            this.colidProducto.Visible = true;
            this.colidProducto.VisibleIndex = 0;
            // 
            // lupProductos
            // 
            this.lupProductos.AutoHeight = false;
            this.lupProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupProductos.DataSource = this.productoBindingSource;
            this.lupProductos.DisplayMember = "descripcion";
            this.lupProductos.Name = "lupProductos";
            this.lupProductos.ValueMember = "idProducto";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(System_Shoes.Entities.Producto);
            // 
            // colcantidad1
            // 
            this.colcantidad1.Caption = "Cantidad";
            this.colcantidad1.FieldName = "cantidad";
            this.colcantidad1.Name = "colcantidad1";
            this.colcantidad1.Visible = true;
            this.colcantidad1.VisibleIndex = 1;
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.DisplayFormat.FormatString = "c";
            this.colprecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 2;
            // 
            // colimporte1
            // 
            this.colimporte1.Caption = "Importe";
            this.colimporte1.DisplayFormat.FormatString = "c";
            this.colimporte1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte1.FieldName = "importe";
            this.colimporte1.Name = "colimporte1";
            this.colimporte1.Visible = true;
            this.colimporte1.VisibleIndex = 3;
            // 
            // coldc
            // 
            this.coldc.Caption = "DC";
            this.coldc.DisplayFormat.FormatString = "P2";
            this.coldc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldc.FieldName = "dc";
            this.coldc.Name = "coldc";
            this.coldc.Visible = true;
            this.coldc.VisibleIndex = 4;
            // 
            // coldv
            // 
            this.coldv.Caption = "DV";
            this.coldv.DisplayFormat.FormatString = "P2";
            this.coldv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldv.FieldName = "dv";
            this.coldv.Name = "coldv";
            this.coldv.Visible = true;
            this.coldv.VisibleIndex = 5;
            // 
            // coldv2
            // 
            this.coldv2.Caption = "DV2";
            this.coldv2.DisplayFormat.FormatString = "c";
            this.coldv2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldv2.FieldName = "dv2";
            this.coldv2.Name = "coldv2";
            this.coldv2.Visible = true;
            this.coldv2.VisibleIndex = 6;
            // 
            // coldescuento1
            // 
            this.coldescuento1.Caption = "Descuento";
            this.coldescuento1.DisplayFormat.FormatString = "c";
            this.coldescuento1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldescuento1.FieldName = "descuento";
            this.coldescuento1.Name = "coldescuento1";
            this.coldescuento1.Visible = true;
            this.coldescuento1.VisibleIndex = 7;
            // 
            // coltotal1
            // 
            this.coltotal1.Caption = "Total";
            this.coltotal1.DisplayFormat.FormatString = "c";
            this.coltotal1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal1.FieldName = "total";
            this.coltotal1.Name = "coltotal1";
            this.coltotal1.Visible = true;
            this.coltotal1.VisibleIndex = 8;
            // 
            // colventa
            // 
            this.colventa.FieldName = "venta";
            this.colventa.Name = "colventa";
            // 
            // gcVentas
            // 
            this.gcVentas.DataSource = this.ventaBindingSource;
            this.gcVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gvVentasDetalle;
            gridLevelNode1.RelationName = "ventasDetalle";
            this.gcVentas.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcVentas.Location = new System.Drawing.Point(0, 24);
            this.gcVentas.MainView = this.gvVentas;
            this.gcVentas.MenuManager = this.barManager1;
            this.gcVentas.Name = "gcVentas";
            this.gcVentas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lupClientes,
            this.lupUsuarios,
            this.lupProductos});
            this.gcVentas.Size = new System.Drawing.Size(1184, 337);
            this.gcVentas.TabIndex = 4;
            this.gcVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentas,
            this.gvVentasDetalle});
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(System_Shoes.Entities.Venta);
            // 
            // gvVentas
            // 
            this.gvVentas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVentas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVenta,
            this.colfolio,
            this.colidCliente,
            this.colfecha,
            this.colcantidad,
            this.colimporte,
            this.coldescuento,
            this.coltotal,
            this.colpago,
            this.colstatus,
            this.colidUsuario});
            this.gvVentas.GridControl = this.gcVentas;
            this.gvVentas.Name = "gvVentas";
            this.gvVentas.OptionsBehavior.Editable = false;
            this.gvVentas.OptionsCustomization.AllowColumnMoving = false;
            this.gvVentas.OptionsView.ColumnAutoWidth = false;
            this.gvVentas.OptionsView.ShowGroupPanel = false;
            // 
            // colidVenta
            // 
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.Name = "colidVenta";
            // 
            // colfolio
            // 
            this.colfolio.Caption = "Folio";
            this.colfolio.FieldName = "folio";
            this.colfolio.Name = "colfolio";
            this.colfolio.Visible = true;
            this.colfolio.VisibleIndex = 0;
            // 
            // colidCliente
            // 
            this.colidCliente.Caption = "Cliente";
            this.colidCliente.ColumnEdit = this.lupClientes;
            this.colidCliente.FieldName = "idCliente";
            this.colidCliente.Name = "colidCliente";
            this.colidCliente.Visible = true;
            this.colidCliente.VisibleIndex = 1;
            // 
            // lupClientes
            // 
            this.lupClientes.AutoHeight = false;
            this.lupClientes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupClientes.DataSource = this.clienteBindingSource;
            this.lupClientes.DisplayMember = "nombre";
            this.lupClientes.Name = "lupClientes";
            this.lupClientes.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(System_Shoes.Entities.Cliente);
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.DisplayFormat.FormatString = "c";
            this.colimporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte.FieldName = "importe";
            this.colimporte.Name = "colimporte";
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 4;
            // 
            // coldescuento
            // 
            this.coldescuento.Caption = "Descuento";
            this.coldescuento.DisplayFormat.FormatString = "c";
            this.coldescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.Visible = true;
            this.coldescuento.VisibleIndex = 5;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.DisplayFormat.FormatString = "c";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 6;
            // 
            // colpago
            // 
            this.colpago.Caption = "Pago";
            this.colpago.DisplayFormat.FormatString = "c";
            this.colpago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpago.FieldName = "pago";
            this.colpago.Name = "colpago";
            this.colpago.Visible = true;
            this.colpago.VisibleIndex = 7;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Status";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 8;
            // 
            // colidUsuario
            // 
            this.colidUsuario.Caption = "Usuario";
            this.colidUsuario.ColumnEdit = this.lupUsuarios;
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.Name = "colidUsuario";
            this.colidUsuario.Visible = true;
            this.colidUsuario.VisibleIndex = 9;
            // 
            // lupUsuarios
            // 
            this.lupUsuarios.AutoHeight = false;
            this.lupUsuarios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupUsuarios.DataSource = this.usuarioBindingSource;
            this.lupUsuarios.DisplayMember = "nombre";
            this.lupUsuarios.Name = "lupUsuarios";
            this.lupUsuarios.ValueMember = "idUsuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(System_Shoes.Entities.Usuario);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizar,
            this.btnNuevo,
            this.barButtonItem3,
            this.btnImpTickect,
            this.btnImpRem,
            this.btnCancelar});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnImpTickect, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnImpRem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.LargeImage")));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nueva Venta";
            this.btnNuevo.Id = 1;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnImpTickect
            // 
            this.btnImpTickect.Caption = "Imprimir Tickect";
            this.btnImpTickect.Id = 3;
            this.btnImpTickect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImpTickect.ImageOptions.Image")));
            this.btnImpTickect.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnImpTickect.ImageOptions.LargeImage")));
            this.btnImpTickect.Name = "btnImpTickect";
            this.btnImpTickect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImpTickect_ItemClick);
            // 
            // btnImpRem
            // 
            this.btnImpRem.Caption = "Imprimir Remisión";
            this.btnImpRem.Id = 4;
            this.btnImpRem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImpRem.ImageOptions.Image")));
            this.btnImpRem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnImpRem.ImageOptions.LargeImage")));
            this.btnImpRem.Name = "btnImpRem";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Caption = "Cancelar Venta";
            this.btnCancelar.Id = 5;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.LargeImage")));
            this.btnCancelar.Name = "btnCancelar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1184, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 361);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1184, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 337);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1184, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 337);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 361);
            this.Controls.Add(this.gcVentas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVentasDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnImpTickect;
        private DevExpress.XtraBars.BarButtonItem btnImpRem;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.GridControl gcVentas;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentasDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentas;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colfolio;
        private DevExpress.XtraGrid.Columns.GridColumn colidCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colpago;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lupClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lupUsuarios;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidVentaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lupProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte1;
        private DevExpress.XtraGrid.Columns.GridColumn coldc;
        private DevExpress.XtraGrid.Columns.GridColumn coldv;
        private DevExpress.XtraGrid.Columns.GridColumn coldv2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento1;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal1;
        private DevExpress.XtraGrid.Columns.GridColumn colventa;
    }
}