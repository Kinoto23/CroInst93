namespace Cronograma
{
    partial class Materia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materia));
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_terminada = new System.Windows.Forms.Button();
            this.btn_no_terminada = new System.Windows.Forms.Button();
            this.lbl_martes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_notas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_videollamada = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_carpeta = new System.Windows.Forms.PictureBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cmb_materia = new System.Windows.Forms.ComboBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pic_guardar = new System.Windows.Forms.PictureBox();
            this.picb_confirmado = new System.Windows.Forms.PictureBox();
            this.lbl_videollamada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.txt_url_videollamada = new System.Windows.Forms.TextBox();
            this.btn_editar_videollamada = new System.Windows.Forms.Button();
            this.btn_editar_carpeta = new System.Windows.Forms.Button();
            this.btn_ok_videollamada = new System.Windows.Forms.Button();
            this.lbl_notificacion_videollamada = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_ok_carpeta = new System.Windows.Forms.Button();
            this.txt_carpeta = new System.Windows.Forms.TextBox();
            this.lbl_dia_hora = new System.Windows.Forms.Label();
            this.lbl_notificacion_carpeta = new System.Windows.Forms.Label();
            this.txt_items_lista = new System.Windows.Forms.TextBox();
            this.btn_ok_agregar_lista = new System.Windows.Forms.Button();
            this.btn_eliminar_lista = new System.Windows.Forms.Button();
            this.btn_editar_lista = new System.Windows.Forms.Button();
            this.lts_hechas = new System.Windows.Forms.ListBox();
            this.lts_x_hacer = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_videollamada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_carpeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_confirmado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editar
            // 
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(674, 42);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(32, 32);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_terminada
            // 
            this.btn_terminada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_terminada.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terminada.ForeColor = System.Drawing.Color.Green;
            this.btn_terminada.Location = new System.Drawing.Point(362, 218);
            this.btn_terminada.Name = "btn_terminada";
            this.btn_terminada.Size = new System.Drawing.Size(123, 23);
            this.btn_terminada.TabIndex = 6;
            this.btn_terminada.Text = "Terminada >>>";
            this.btn_terminada.UseVisualStyleBackColor = false;
            this.btn_terminada.Click += new System.EventHandler(this.btn_terminada_Click);
            // 
            // btn_no_terminada
            // 
            this.btn_no_terminada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_no_terminada.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no_terminada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_no_terminada.Location = new System.Drawing.Point(362, 247);
            this.btn_no_terminada.Name = "btn_no_terminada";
            this.btn_no_terminada.Size = new System.Drawing.Size(123, 23);
            this.btn_no_terminada.TabIndex = 7;
            this.btn_no_terminada.Text = "<<< No terminada";
            this.btn_no_terminada.UseVisualStyleBackColor = false;
            this.btn_no_terminada.Click += new System.EventHandler(this.btn_no_terminada_Click);
            // 
            // lbl_martes
            // 
            this.lbl_martes.AutoSize = true;
            this.lbl_martes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_martes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_martes.ForeColor = System.Drawing.Color.Black;
            this.lbl_martes.Location = new System.Drawing.Point(120, 122);
            this.lbl_martes.Name = "lbl_martes";
            this.lbl_martes.Size = new System.Drawing.Size(180, 19);
            this.lbl_martes.TabIndex = 52;
            this.lbl_martes.Text = "Actividades x hacer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(547, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Actividades hechas";
            // 
            // txt_notas
            // 
            this.txt_notas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_notas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_notas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_notas.Location = new System.Drawing.Point(491, 407);
            this.txt_notas.MaxLength = 10000;
            this.txt_notas.Multiline = true;
            this.txt_notas.Name = "txt_notas";
            this.txt_notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_notas.Size = new System.Drawing.Size(293, 184);
            this.txt_notas.TabIndex = 54;
            this.txt_notas.TextChanged += new System.EventHandler(this.txt_notas_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(614, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "Notas";
            // 
            // pic_videollamada
            // 
            this.pic_videollamada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_videollamada.Image = ((System.Drawing.Image)(resources.GetObject("pic_videollamada.Image")));
            this.pic_videollamada.Location = new System.Drawing.Point(63, 407);
            this.pic_videollamada.Name = "pic_videollamada";
            this.pic_videollamada.Size = new System.Drawing.Size(50, 50);
            this.pic_videollamada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_videollamada.TabIndex = 56;
            this.pic_videollamada.TabStop = false;
            this.pic_videollamada.Click += new System.EventHandler(this.pic_videollamada_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(63, 550);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pic_carpeta
            // 
            this.pic_carpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_carpeta.Image = ((System.Drawing.Image)(resources.GetObject("pic_carpeta.Image")));
            this.pic_carpeta.Location = new System.Drawing.Point(63, 478);
            this.pic_carpeta.Name = "pic_carpeta";
            this.pic_carpeta.Size = new System.Drawing.Size(50, 50);
            this.pic_carpeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_carpeta.TabIndex = 58;
            this.pic_carpeta.TabStop = false;
            this.pic_carpeta.Click += new System.EventHandler(this.pic_carpeta_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.Location = new System.Drawing.Point(306, 116);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(32, 32);
            this.btn_agregar.TabIndex = 59;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cmb_materia
            // 
            this.cmb_materia.BackColor = System.Drawing.Color.Gray;
            this.cmb_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_materia.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_materia.ForeColor = System.Drawing.Color.Black;
            this.cmb_materia.FormattingEnabled = true;
            this.cmb_materia.Location = new System.Drawing.Point(202, 34);
            this.cmb_materia.Name = "cmb_materia";
            this.cmb_materia.Size = new System.Drawing.Size(466, 46);
            this.cmb_materia.TabIndex = 60;
            this.cmb_materia.SelectedIndexChanged += new System.EventHandler(this.cmb_materia_SelectedIndexChanged);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(801, 602);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(47, 23);
            this.btn_salir.TabIndex = 61;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pic_guardar
            // 
            this.pic_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_guardar.Image = ((System.Drawing.Image)(resources.GetObject("pic_guardar.Image")));
            this.pic_guardar.Location = new System.Drawing.Point(752, 42);
            this.pic_guardar.Name = "pic_guardar";
            this.pic_guardar.Size = new System.Drawing.Size(32, 32);
            this.pic_guardar.TabIndex = 62;
            this.pic_guardar.TabStop = false;
            this.pic_guardar.Click += new System.EventHandler(this.pic_guardar_Click);
            // 
            // picb_confirmado
            // 
            this.picb_confirmado.BackColor = System.Drawing.Color.Transparent;
            this.picb_confirmado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_confirmado.Image = ((System.Drawing.Image)(resources.GetObject("picb_confirmado.Image")));
            this.picb_confirmado.Location = new System.Drawing.Point(790, 47);
            this.picb_confirmado.Name = "picb_confirmado";
            this.picb_confirmado.Size = new System.Drawing.Size(20, 20);
            this.picb_confirmado.TabIndex = 63;
            this.picb_confirmado.TabStop = false;
            // 
            // lbl_videollamada
            // 
            this.lbl_videollamada.AutoSize = true;
            this.lbl_videollamada.BackColor = System.Drawing.Color.White;
            this.lbl_videollamada.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_videollamada.ForeColor = System.Drawing.Color.Black;
            this.lbl_videollamada.Location = new System.Drawing.Point(119, 422);
            this.lbl_videollamada.Name = "lbl_videollamada";
            this.lbl_videollamada.Size = new System.Drawing.Size(126, 19);
            this.lbl_videollamada.TabIndex = 64;
            this.lbl_videollamada.Text = "Video Llamada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(119, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "Carpeta de la Materia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(119, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "Recordatorios";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.Color.Red;
            this.lbl_info.Location = new System.Drawing.Point(251, 566);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(91, 13);
            this.lbl_info.TabIndex = 67;
            this.lbl_info.Text = "Aun no disponible";
            // 
            // txt_url_videollamada
            // 
            this.txt_url_videollamada.Location = new System.Drawing.Point(119, 421);
            this.txt_url_videollamada.Name = "txt_url_videollamada";
            this.txt_url_videollamada.Size = new System.Drawing.Size(126, 20);
            this.txt_url_videollamada.TabIndex = 68;
            this.txt_url_videollamada.Visible = false;
            // 
            // btn_editar_videollamada
            // 
            this.btn_editar_videollamada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_videollamada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_videollamada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editar_videollamada.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar_videollamada.Image")));
            this.btn_editar_videollamada.Location = new System.Drawing.Point(251, 414);
            this.btn_editar_videollamada.Name = "btn_editar_videollamada";
            this.btn_editar_videollamada.Size = new System.Drawing.Size(32, 32);
            this.btn_editar_videollamada.TabIndex = 69;
            this.btn_editar_videollamada.UseVisualStyleBackColor = true;
            this.btn_editar_videollamada.Click += new System.EventHandler(this.btn_editar_videollamada_Click);
            // 
            // btn_editar_carpeta
            // 
            this.btn_editar_carpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_carpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_carpeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editar_carpeta.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar_carpeta.Image")));
            this.btn_editar_carpeta.Location = new System.Drawing.Point(324, 487);
            this.btn_editar_carpeta.Name = "btn_editar_carpeta";
            this.btn_editar_carpeta.Size = new System.Drawing.Size(32, 32);
            this.btn_editar_carpeta.TabIndex = 70;
            this.btn_editar_carpeta.UseVisualStyleBackColor = true;
            this.btn_editar_carpeta.Click += new System.EventHandler(this.btn_editar_carpeta_Click);
            // 
            // btn_ok_videollamada
            // 
            this.btn_ok_videollamada.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_videollamada.Location = new System.Drawing.Point(289, 419);
            this.btn_ok_videollamada.Name = "btn_ok_videollamada";
            this.btn_ok_videollamada.Size = new System.Drawing.Size(28, 23);
            this.btn_ok_videollamada.TabIndex = 71;
            this.btn_ok_videollamada.Text = "Ok";
            this.btn_ok_videollamada.UseVisualStyleBackColor = true;
            this.btn_ok_videollamada.Visible = false;
            this.btn_ok_videollamada.Click += new System.EventHandler(this.btn_ok_videollamada_Click);
            // 
            // lbl_notificacion_videollamada
            // 
            this.lbl_notificacion_videollamada.AutoSize = true;
            this.lbl_notificacion_videollamada.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_notificacion_videollamada.Location = new System.Drawing.Point(116, 444);
            this.lbl_notificacion_videollamada.Name = "lbl_notificacion_videollamada";
            this.lbl_notificacion_videollamada.Size = new System.Drawing.Size(169, 13);
            this.lbl_notificacion_videollamada.TabIndex = 73;
            this.lbl_notificacion_videollamada.Text = "Ingrese la URL de la videollamada";
            this.lbl_notificacion_videollamada.Visible = false;
            // 
            // btn_ok_carpeta
            // 
            this.btn_ok_carpeta.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_carpeta.Location = new System.Drawing.Point(362, 493);
            this.btn_ok_carpeta.Name = "btn_ok_carpeta";
            this.btn_ok_carpeta.Size = new System.Drawing.Size(28, 23);
            this.btn_ok_carpeta.TabIndex = 74;
            this.btn_ok_carpeta.Text = "Ok";
            this.btn_ok_carpeta.UseVisualStyleBackColor = true;
            this.btn_ok_carpeta.Visible = false;
            this.btn_ok_carpeta.Click += new System.EventHandler(this.lbl_ok_carpeta_Click);
            // 
            // txt_carpeta
            // 
            this.txt_carpeta.Location = new System.Drawing.Point(119, 493);
            this.txt_carpeta.Name = "txt_carpeta";
            this.txt_carpeta.Size = new System.Drawing.Size(198, 20);
            this.txt_carpeta.TabIndex = 75;
            this.txt_carpeta.Visible = false;
            // 
            // lbl_dia_hora
            // 
            this.lbl_dia_hora.AutoSize = true;
            this.lbl_dia_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dia_hora.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_dia_hora.Location = new System.Drawing.Point(12, 9);
            this.lbl_dia_hora.Name = "lbl_dia_hora";
            this.lbl_dia_hora.Size = new System.Drawing.Size(50, 23);
            this.lbl_dia_hora.TabIndex = 76;
            this.lbl_dia_hora.Text = "Lunes";
            // 
            // lbl_notificacion_carpeta
            // 
            this.lbl_notificacion_carpeta.AutoSize = true;
            this.lbl_notificacion_carpeta.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_notificacion_carpeta.Location = new System.Drawing.Point(119, 516);
            this.lbl_notificacion_carpeta.Name = "lbl_notificacion_carpeta";
            this.lbl_notificacion_carpeta.Size = new System.Drawing.Size(156, 13);
            this.lbl_notificacion_carpeta.TabIndex = 77;
            this.lbl_notificacion_carpeta.Text = "Ingrese la Carpeta de la materia";
            this.lbl_notificacion_carpeta.Visible = false;
            // 
            // txt_items_lista
            // 
            this.txt_items_lista.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.txt_items_lista.Location = new System.Drawing.Point(63, 355);
            this.txt_items_lista.Name = "txt_items_lista";
            this.txt_items_lista.Size = new System.Drawing.Size(293, 30);
            this.txt_items_lista.TabIndex = 78;
            this.txt_items_lista.Visible = false;
            // 
            // btn_ok_agregar_lista
            // 
            this.btn_ok_agregar_lista.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_agregar_lista.Location = new System.Drawing.Point(362, 358);
            this.btn_ok_agregar_lista.Name = "btn_ok_agregar_lista";
            this.btn_ok_agregar_lista.Size = new System.Drawing.Size(28, 23);
            this.btn_ok_agregar_lista.TabIndex = 79;
            this.btn_ok_agregar_lista.Text = "Ok";
            this.btn_ok_agregar_lista.UseVisualStyleBackColor = true;
            this.btn_ok_agregar_lista.Visible = false;
            this.btn_ok_agregar_lista.Click += new System.EventHandler(this.btn_ok_agregar_lista_Click);
            // 
            // btn_eliminar_lista
            // 
            this.btn_eliminar_lista.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_lista.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar_lista.Image")));
            this.btn_eliminar_lista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar_lista.Location = new System.Drawing.Point(387, 305);
            this.btn_eliminar_lista.Name = "btn_eliminar_lista";
            this.btn_eliminar_lista.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar_lista.TabIndex = 80;
            this.btn_eliminar_lista.Text = "Eliminar";
            this.btn_eliminar_lista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar_lista.UseVisualStyleBackColor = true;
            this.btn_eliminar_lista.Visible = false;
            this.btn_eliminar_lista.Click += new System.EventHandler(this.btn_eliminar_lista_Click);
            // 
            // btn_editar_lista
            // 
            this.btn_editar_lista.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_lista.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar_lista.Image")));
            this.btn_editar_lista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar_lista.Location = new System.Drawing.Point(387, 276);
            this.btn_editar_lista.Name = "btn_editar_lista";
            this.btn_editar_lista.Size = new System.Drawing.Size(75, 23);
            this.btn_editar_lista.TabIndex = 81;
            this.btn_editar_lista.Text = "Editar  ";
            this.btn_editar_lista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar_lista.UseVisualStyleBackColor = true;
            this.btn_editar_lista.Visible = false;
            this.btn_editar_lista.Click += new System.EventHandler(this.btn_editar_lista_Click);
            // 
            // lts_hechas
            // 
            this.lts_hechas.BackColor = System.Drawing.Color.Gray;
            this.lts_hechas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lts_hechas.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lts_hechas.FormattingEnabled = true;
            this.lts_hechas.HorizontalScrollbar = true;
            this.lts_hechas.ItemHeight = 23;
            this.lts_hechas.Location = new System.Drawing.Point(491, 158);
            this.lts_hechas.Name = "lts_hechas";
            this.lts_hechas.Size = new System.Drawing.Size(293, 186);
            this.lts_hechas.TabIndex = 82;
            // 
            // lts_x_hacer
            // 
            this.lts_x_hacer.BackColor = System.Drawing.Color.Gray;
            this.lts_x_hacer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lts_x_hacer.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lts_x_hacer.FormattingEnabled = true;
            this.lts_x_hacer.HorizontalScrollbar = true;
            this.lts_x_hacer.ItemHeight = 23;
            this.lts_x_hacer.Location = new System.Drawing.Point(63, 158);
            this.lts_x_hacer.Name = "lts_x_hacer";
            this.lts_x_hacer.Size = new System.Drawing.Size(293, 186);
            this.lts_x_hacer.TabIndex = 83;
            this.lts_x_hacer.SelectedIndexChanged += new System.EventHandler(this.lts_x_hacer_SelectedIndexChanged);
            // 
            // Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(860, 637);
            this.Controls.Add(this.lts_x_hacer);
            this.Controls.Add(this.lts_hechas);
            this.Controls.Add(this.btn_eliminar_lista);
            this.Controls.Add(this.btn_editar_lista);
            this.Controls.Add(this.btn_ok_agregar_lista);
            this.Controls.Add(this.txt_items_lista);
            this.Controls.Add(this.lbl_notificacion_carpeta);
            this.Controls.Add(this.lbl_dia_hora);
            this.Controls.Add(this.txt_carpeta);
            this.Controls.Add(this.btn_ok_carpeta);
            this.Controls.Add(this.lbl_notificacion_videollamada);
            this.Controls.Add(this.btn_ok_videollamada);
            this.Controls.Add(this.btn_editar_carpeta);
            this.Controls.Add(this.btn_editar_videollamada);
            this.Controls.Add(this.txt_url_videollamada);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_videollamada);
            this.Controls.Add(this.picb_confirmado);
            this.Controls.Add(this.pic_guardar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.cmb_materia);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.pic_carpeta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic_videollamada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_notas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_martes);
            this.Controls.Add(this.btn_no_terminada);
            this.Controls.Add(this.btn_terminada);
            this.Controls.Add(this.btn_editar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Materia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hecho por Roberto Mattio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Materia_FormClosed);
            this.Load += new System.EventHandler(this.Materia_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Materia_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic_videollamada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_carpeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_confirmado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_terminada;
        private System.Windows.Forms.Button btn_no_terminada;
        private System.Windows.Forms.Label lbl_martes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_notas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_videollamada;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_carpeta;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cmb_materia;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pic_guardar;
        private System.Windows.Forms.PictureBox picb_confirmado;
        private System.Windows.Forms.Label lbl_videollamada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox txt_url_videollamada;
        private System.Windows.Forms.Button btn_editar_videollamada;
        private System.Windows.Forms.Button btn_editar_carpeta;
        private System.Windows.Forms.Button btn_ok_videollamada;
        private System.Windows.Forms.Label lbl_notificacion_videollamada;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_ok_carpeta;
        private System.Windows.Forms.TextBox txt_carpeta;
        private System.Windows.Forms.Label lbl_dia_hora;
        private System.Windows.Forms.Label lbl_notificacion_carpeta;
        private System.Windows.Forms.TextBox txt_items_lista;
        private System.Windows.Forms.Button btn_ok_agregar_lista;
        private System.Windows.Forms.Button btn_eliminar_lista;
        private System.Windows.Forms.Button btn_editar_lista;
        private System.Windows.Forms.ListBox lts_hechas;
        private System.Windows.Forms.ListBox lts_x_hacer;
    }
}