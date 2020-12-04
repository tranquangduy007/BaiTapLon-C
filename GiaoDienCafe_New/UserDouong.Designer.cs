namespace GiaoDienCafe_New
{
    partial class UserDouong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDouong));
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sss = new Guna.UI.WinForms.GunaPanel();
            this.txbSearchFoodName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchFood = new Guna.UI.WinForms.GunaButton();
            this.btLammoi = new Guna.UI2.WinForms.Guna2Button();
            this.nmFoodPrice = new Guna.UI.WinForms.GunaNumeric();
            this.cbCategory_food = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.btSua = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.btXoa = new Guna.UI2.WinForms.Guna2Button();
            this.txtbFoodName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txbFoodID = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton22 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.sss.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvFood
            // 
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.idCategory,
            this.price});
            this.dtgvFood.Location = new System.Drawing.Point(3, 250);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.Size = new System.Drawing.Size(1263, 310);
            this.dtgvFood.TabIndex = 79;
            this.dtgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDouong_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID đồ uống";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên Đồ uống";
            this.name.Name = "name";
            // 
            // idCategory
            // 
            this.idCategory.DataPropertyName = "idCategory";
            this.idCategory.HeaderText = "Loại đồ uống";
            this.idCategory.Name = "idCategory";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            // 
            // sss
            // 
            this.sss.BackColor = System.Drawing.Color.OldLace;
            this.sss.Controls.Add(this.txbSearchFoodName);
            this.sss.Controls.Add(this.btnSearchFood);
            this.sss.Controls.Add(this.btLammoi);
            this.sss.Controls.Add(this.nmFoodPrice);
            this.sss.Controls.Add(this.cbCategory_food);
            this.sss.Controls.Add(this.gunaButton3);
            this.sss.Controls.Add(this.btSua);
            this.sss.Controls.Add(this.btThem);
            this.sss.Controls.Add(this.btXoa);
            this.sss.Controls.Add(this.txtbFoodName);
            this.sss.Controls.Add(this.gunaLabel7);
            this.sss.Controls.Add(this.txbFoodID);
            this.sss.Controls.Add(this.gunaLabel4);
            this.sss.Controls.Add(this.gunaLabel3);
            this.sss.Controls.Add(this.gunaLabel2);
            this.sss.Controls.Add(this.gunaButton22);
            this.sss.Location = new System.Drawing.Point(2, 2);
            this.sss.Margin = new System.Windows.Forms.Padding(2);
            this.sss.Name = "sss";
            this.sss.Size = new System.Drawing.Size(1264, 261);
            this.sss.TabIndex = 78;
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearchFoodName.DefaultText = "";
            this.txbSearchFoodName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearchFoodName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearchFoodName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchFoodName.DisabledState.Parent = this.txbSearchFoodName;
            this.txbSearchFoodName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchFoodName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchFoodName.FocusedState.Parent = this.txbSearchFoodName;
            this.txbSearchFoodName.ForeColor = System.Drawing.Color.Black;
            this.txbSearchFoodName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchFoodName.HoverState.Parent = this.txbSearchFoodName;
            this.txbSearchFoodName.Location = new System.Drawing.Point(1068, 63);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.PasswordChar = '\0';
            this.txbSearchFoodName.PlaceholderText = "Nhập Thức uống cần tìm";
            this.txbSearchFoodName.SelectedText = "";
            this.txbSearchFoodName.ShadowDecoration.Parent = this.txbSearchFoodName;
            this.txbSearchFoodName.Size = new System.Drawing.Size(169, 37);
            this.txbSearchFoodName.TabIndex = 85;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.AnimationHoverSpeed = 0.07F;
            this.btnSearchFood.AnimationSpeed = 0.03F;
            this.btnSearchFood.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSearchFood.BorderColor = System.Drawing.Color.Black;
            this.btnSearchFood.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearchFood.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearchFood.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFood.ForeColor = System.Drawing.Color.White;
            this.btnSearchFood.Image = null;
            this.btnSearchFood.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearchFood.Location = new System.Drawing.Point(970, 58);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSearchFood.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearchFood.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearchFood.OnHoverImage = null;
            this.btnSearchFood.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearchFood.Size = new System.Drawing.Size(92, 42);
            this.btnSearchFood.TabIndex = 84;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // btLammoi
            // 
            this.btLammoi.BorderRadius = 15;
            this.btLammoi.CheckedState.Parent = this.btLammoi;
            this.btLammoi.CustomImages.Parent = this.btLammoi;
            this.btLammoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btLammoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLammoi.ForeColor = System.Drawing.Color.White;
            this.btLammoi.HoverState.Parent = this.btLammoi;
            this.btLammoi.Location = new System.Drawing.Point(1137, 119);
            this.btLammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btLammoi.Name = "btLammoi";
            this.btLammoi.ShadowDecoration.Parent = this.btLammoi;
            this.btLammoi.Size = new System.Drawing.Size(100, 50);
            this.btLammoi.TabIndex = 82;
            this.btLammoi.Text = "Làm mới";
            this.btLammoi.Click += new System.EventHandler(this.btLammoi_Click);
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.BackColor = System.Drawing.Color.Transparent;
            this.nmFoodPrice.BaseColor = System.Drawing.Color.White;
            this.nmFoodPrice.BorderColor = System.Drawing.Color.Silver;
            this.nmFoodPrice.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nmFoodPrice.ButtonForeColor = System.Drawing.Color.White;
            this.nmFoodPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nmFoodPrice.ForeColor = System.Drawing.Color.Black;
            this.nmFoodPrice.Location = new System.Drawing.Point(586, 145);
            this.nmFoodPrice.Maximum = ((long)(99999999));
            this.nmFoodPrice.Minimum = ((long)(0));
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(140, 30);
            this.nmFoodPrice.TabIndex = 81;
            this.nmFoodPrice.Text = "gunaNumeric1";
            this.nmFoodPrice.Value = ((long)(1));
            this.nmFoodPrice.ValueChanged += new System.EventHandler(this.nmFoodPrice_ValueChanged);
            // 
            // cbCategory_food
            // 
            this.cbCategory_food.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory_food.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory_food.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory_food.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory_food.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory_food.FocusedState.Parent = this.cbCategory_food;
            this.cbCategory_food.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategory_food.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory_food.FormattingEnabled = true;
            this.cbCategory_food.HoverState.Parent = this.cbCategory_food;
            this.cbCategory_food.ItemHeight = 30;
            this.cbCategory_food.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbCategory_food.ItemsAppearance.Parent = this.cbCategory_food;
            this.cbCategory_food.Location = new System.Drawing.Point(218, 139);
            this.cbCategory_food.Name = "cbCategory_food";
            this.cbCategory_food.ShadowDecoration.Parent = this.cbCategory_food;
            this.cbCategory_food.Size = new System.Drawing.Size(140, 36);
            this.cbCategory_food.TabIndex = 80;
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton3.Location = new System.Drawing.Point(970, 6);
            this.gunaButton3.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(267, 34);
            this.gunaButton3.TabIndex = 78;
            this.gunaButton3.Text = "Chức Năng";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSua
            // 
            this.btSua.BorderRadius = 15;
            this.btSua.CheckedState.Parent = this.btSua;
            this.btSua.CustomImages.Parent = this.btSua;
            this.btSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.HoverState.Parent = this.btSua;
            this.btSua.Location = new System.Drawing.Point(970, 178);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.ShadowDecoration.Parent = this.btSua;
            this.btSua.Size = new System.Drawing.Size(100, 50);
            this.btSua.TabIndex = 77;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BorderRadius = 15;
            this.btThem.CheckedState.Parent = this.btThem;
            this.btThem.CustomImages.Parent = this.btThem;
            this.btThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.HoverState.Parent = this.btThem;
            this.btThem.Location = new System.Drawing.Point(970, 119);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(100, 50);
            this.btThem.TabIndex = 76;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Transparent;
            this.btXoa.BorderColor = System.Drawing.Color.Maroon;
            this.btXoa.BorderRadius = 15;
            this.btXoa.CheckedState.Parent = this.btXoa;
            this.btXoa.CustomImages.Parent = this.btXoa;
            this.btXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.HoverState.Parent = this.btXoa;
            this.btXoa.Location = new System.Drawing.Point(1137, 178);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShadowDecoration.Parent = this.btXoa;
            this.btXoa.Size = new System.Drawing.Size(100, 50);
            this.btXoa.TabIndex = 74;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // txtbFoodName
            // 
            this.txtbFoodName.BorderColor = System.Drawing.Color.Black;
            this.txtbFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbFoodName.DefaultText = "";
            this.txtbFoodName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbFoodName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbFoodName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbFoodName.DisabledState.Parent = this.txtbFoodName;
            this.txtbFoodName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbFoodName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbFoodName.FocusedState.Parent = this.txtbFoodName;
            this.txtbFoodName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbFoodName.HoverState.Parent = this.txtbFoodName;
            this.txtbFoodName.Location = new System.Drawing.Point(586, 58);
            this.txtbFoodName.Name = "txtbFoodName";
            this.txtbFoodName.PasswordChar = '\0';
            this.txtbFoodName.PlaceholderText = "NhậpTên Món";
            this.txtbFoodName.SelectedText = "";
            this.txtbFoodName.ShadowDecoration.Parent = this.txtbFoodName;
            this.txtbFoodName.Size = new System.Drawing.Size(160, 34);
            this.txtbFoodName.TabIndex = 68;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gunaLabel7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(457, 125);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(87, 50);
            this.gunaLabel7.TabIndex = 66;
            this.gunaLabel7.Text = "Giá";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFoodID.DefaultText = "";
            this.txbFoodID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbFoodID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbFoodID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbFoodID.DisabledState.Parent = this.txbFoodID;
            this.txbFoodID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbFoodID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbFoodID.FocusedState.Parent = this.txbFoodID;
            this.txbFoodID.ForeColor = System.Drawing.Color.Black;
            this.txbFoodID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbFoodID.HoverState.Parent = this.txbFoodID;
            this.txbFoodID.Location = new System.Drawing.Point(218, 66);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.PasswordChar = '\0';
            this.txbFoodID.PlaceholderText = "Nhập Tên tài khoản";
            this.txbFoodID.SelectedText = "";
            this.txbFoodID.ShadowDecoration.Parent = this.txbFoodID;
            this.txbFoodID.Size = new System.Drawing.Size(140, 34);
            this.txbFoodID.TabIndex = 60;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(61, 125);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(90, 50);
            this.gunaLabel4.TabIndex = 58;
            this.gunaLabel4.Text = "Danh mục";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(61, 58);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(90, 50);
            this.gunaLabel3.TabIndex = 56;
            this.gunaLabel3.Text = "ID";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(454, 58);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(90, 50);
            this.gunaLabel2.TabIndex = 54;
            this.gunaLabel2.Text = "Tên Món";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaButton22
            // 
            this.gunaButton22.AnimationHoverSpeed = 0.07F;
            this.gunaButton22.AnimationSpeed = 0.03F;
            this.gunaButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gunaButton22.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.gunaButton22.BorderColor = System.Drawing.Color.Black;
            this.gunaButton22.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton22.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton22.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton22.ForeColor = System.Drawing.Color.White;
            this.gunaButton22.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton22.Image")));
            this.gunaButton22.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton22.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton22.Location = new System.Drawing.Point(31, 6);
            this.gunaButton22.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton22.Name = "gunaButton22";
            this.gunaButton22.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton22.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton22.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton22.OnHoverImage = null;
            this.gunaButton22.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton22.Size = new System.Drawing.Size(715, 34);
            this.gunaButton22.TabIndex = 30;
            this.gunaButton22.Text = "Thông Tin Hàng";
            this.gunaButton22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserDouong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvFood);
            this.Controls.Add(this.sss);
            this.Name = "UserDouong";
            this.Size = new System.Drawing.Size(1283, 560);
            this.Load += new System.EventHandler(this.UserDouong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.sss.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private Guna.UI.WinForms.GunaPanel sss;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory_food;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private Guna.UI2.WinForms.Guna2TextBox txtbFoodName;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txbFoodID;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton gunaButton22;
        private Guna.UI.WinForms.GunaNumeric nmFoodPrice;
        private Guna.UI2.WinForms.Guna2Button btLammoi;
        private Guna.UI.WinForms.GunaButton btnSearchFood;
        private Guna.UI2.WinForms.Guna2TextBox txbSearchFoodName;
    }
}
