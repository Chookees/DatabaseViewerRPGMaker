namespace GameFileViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CreateWeaponBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ValueWeapon = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DamageWeapon = new System.Windows.Forms.NumericUpDown();
            this.WeaponTypeWeapon = new System.Windows.Forms.ComboBox();
            this.RarityWeapon = new System.Windows.Forms.ComboBox();
            this.NameWeapon = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CreateSkillBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ProbsSkill = new System.Windows.Forms.NumericUpDown();
            this.EffectSkill = new System.Windows.Forms.ComboBox();
            this.TypeOfDamageSkill = new System.Windows.Forms.ComboBox();
            this.DamageSkill = new System.Windows.Forms.NumericUpDown();
            this.NameSkill = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CreateClassBtn = new System.Windows.Forms.Button();
            this.ClassTypeClass = new System.Windows.Forms.ComboBox();
            this.HPHighClass = new System.Windows.Forms.NumericUpDown();
            this.HPLowClass = new System.Windows.Forms.NumericUpDown();
            this.WeaponTypesClass = new System.Windows.Forms.ComboBox();
            this.NameClass = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ShowDatabaseWeapon = new System.Windows.Forms.Button();
            this.ShowDatabaseSkill = new System.Windows.Forms.Button();
            this.ErrorClassTClass = new System.Windows.Forms.PictureBox();
            this.ErrorWTClass = new System.Windows.Forms.PictureBox();
            this.ErrorNameClass = new System.Windows.Forms.PictureBox();
            this.ErrorEffectSkill = new System.Windows.Forms.PictureBox();
            this.ErrorTypeDMGSkill = new System.Windows.Forms.PictureBox();
            this.ErrorSkill = new System.Windows.Forms.PictureBox();
            this.ErrorWTWeapon = new System.Windows.Forms.PictureBox();
            this.ErrorRarityWeapon = new System.Windows.Forms.PictureBox();
            this.Error1 = new System.Windows.Forms.PictureBox();
            this.ShowDatabaseClass = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamageWeapon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProbsSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamageSkill)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPHighClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPLowClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorClassTClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorWTClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNameClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEffectSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTypeDMGSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorWTWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRarityWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateWeaponBtn
            // 
            this.CreateWeaponBtn.Location = new System.Drawing.Point(13, 176);
            this.CreateWeaponBtn.Name = "CreateWeaponBtn";
            this.CreateWeaponBtn.Size = new System.Drawing.Size(106, 23);
            this.CreateWeaponBtn.TabIndex = 0;
            this.CreateWeaponBtn.Text = "Create Weapon";
            this.CreateWeaponBtn.UseVisualStyleBackColor = true;
            this.CreateWeaponBtn.Click += new System.EventHandler(this.CreateWeaponBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Damage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rarity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "WeaponType:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowDatabaseWeapon);
            this.groupBox1.Controls.Add(this.ErrorWTWeapon);
            this.groupBox1.Controls.Add(this.ErrorRarityWeapon);
            this.groupBox1.Controls.Add(this.ValueWeapon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Error1);
            this.groupBox1.Controls.Add(this.DamageWeapon);
            this.groupBox1.Controls.Add(this.CreateWeaponBtn);
            this.groupBox1.Controls.Add(this.WeaponTypeWeapon);
            this.groupBox1.Controls.Add(this.RarityWeapon);
            this.groupBox1.Controls.Add(this.NameWeapon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 221);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Weapon";
            // 
            // ValueWeapon
            // 
            this.ValueWeapon.Location = new System.Drawing.Point(91, 138);
            this.ValueWeapon.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ValueWeapon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ValueWeapon.Name = "ValueWeapon";
            this.ValueWeapon.Size = new System.Drawing.Size(148, 20);
            this.ValueWeapon.TabIndex = 10;
            this.ValueWeapon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Value:";
            // 
            // DamageWeapon
            // 
            this.DamageWeapon.Location = new System.Drawing.Point(91, 58);
            this.DamageWeapon.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.DamageWeapon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DamageWeapon.Name = "DamageWeapon";
            this.DamageWeapon.Size = new System.Drawing.Size(148, 20);
            this.DamageWeapon.TabIndex = 8;
            this.DamageWeapon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WeaponTypeWeapon
            // 
            this.WeaponTypeWeapon.FormattingEnabled = true;
            this.WeaponTypeWeapon.Items.AddRange(new object[] {
            "One Handed Sword",
            "Two Handed Sword",
            "Bow",
            "Speer",
            "Rapier",
            "Dagger"});
            this.WeaponTypeWeapon.Location = new System.Drawing.Point(91, 110);
            this.WeaponTypeWeapon.Name = "WeaponTypeWeapon";
            this.WeaponTypeWeapon.Size = new System.Drawing.Size(148, 21);
            this.WeaponTypeWeapon.TabIndex = 7;
            this.WeaponTypeWeapon.Text = "One Handed Sword";
            this.WeaponTypeWeapon.TextChanged += new System.EventHandler(this.WeaponTypeWeapon_TextChanged);
            // 
            // RarityWeapon
            // 
            this.RarityWeapon.FormattingEnabled = true;
            this.RarityWeapon.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "Legend",
            "Holy Legend"});
            this.RarityWeapon.Location = new System.Drawing.Point(91, 84);
            this.RarityWeapon.Name = "RarityWeapon";
            this.RarityWeapon.Size = new System.Drawing.Size(148, 21);
            this.RarityWeapon.TabIndex = 6;
            this.RarityWeapon.Text = "Common";
            this.RarityWeapon.TextChanged += new System.EventHandler(this.RarityWeapon_TextChanged);
            // 
            // NameWeapon
            // 
            this.NameWeapon.Location = new System.Drawing.Point(91, 32);
            this.NameWeapon.MaxLength = 18;
            this.NameWeapon.Name = "NameWeapon";
            this.NameWeapon.Size = new System.Drawing.Size(148, 20);
            this.NameWeapon.TabIndex = 5;
            this.NameWeapon.Text = "Sword1";
            this.NameWeapon.TextChanged += new System.EventHandler(this.NameWeapon_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShowDatabaseSkill);
            this.groupBox2.Controls.Add(this.ErrorEffectSkill);
            this.groupBox2.Controls.Add(this.ErrorTypeDMGSkill);
            this.groupBox2.Controls.Add(this.CreateSkillBtn);
            this.groupBox2.Controls.Add(this.ErrorSkill);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ProbsSkill);
            this.groupBox2.Controls.Add(this.EffectSkill);
            this.groupBox2.Controls.Add(this.TypeOfDamageSkill);
            this.groupBox2.Controls.Add(this.DamageSkill);
            this.groupBox2.Controls.Add(this.NameSkill);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(293, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 221);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Skill";
            // 
            // CreateSkillBtn
            // 
            this.CreateSkillBtn.Location = new System.Drawing.Point(9, 176);
            this.CreateSkillBtn.Name = "CreateSkillBtn";
            this.CreateSkillBtn.Size = new System.Drawing.Size(115, 23);
            this.CreateSkillBtn.TabIndex = 12;
            this.CreateSkillBtn.Text = "Create Skill";
            this.CreateSkillBtn.UseVisualStyleBackColor = true;
            this.CreateSkillBtn.Click += new System.EventHandler(this.CreateSkillBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(165, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "%";
            // 
            // ProbsSkill
            // 
            this.ProbsSkill.Location = new System.Drawing.Point(116, 138);
            this.ProbsSkill.Name = "ProbsSkill";
            this.ProbsSkill.Size = new System.Drawing.Size(53, 20);
            this.ProbsSkill.TabIndex = 9;
            // 
            // EffectSkill
            // 
            this.EffectSkill.FormattingEnabled = true;
            this.EffectSkill.Items.AddRange(new object[] {
            "Stun",
            "Blindness",
            "Sleep",
            "Knockout",
            "Burn",
            "Poison",
            "Freeze",
            "None"});
            this.EffectSkill.Location = new System.Drawing.Point(116, 111);
            this.EffectSkill.Name = "EffectSkill";
            this.EffectSkill.Size = new System.Drawing.Size(122, 21);
            this.EffectSkill.TabIndex = 8;
            this.EffectSkill.Text = "Stun";
            this.EffectSkill.TextChanged += new System.EventHandler(this.EffectSkill_TextChanged);
            // 
            // TypeOfDamageSkill
            // 
            this.TypeOfDamageSkill.FormattingEnabled = true;
            this.TypeOfDamageSkill.Items.AddRange(new object[] {
            "Physical",
            "Magical"});
            this.TypeOfDamageSkill.Location = new System.Drawing.Point(116, 84);
            this.TypeOfDamageSkill.Name = "TypeOfDamageSkill";
            this.TypeOfDamageSkill.Size = new System.Drawing.Size(122, 21);
            this.TypeOfDamageSkill.TabIndex = 7;
            this.TypeOfDamageSkill.Text = "Physical";
            this.TypeOfDamageSkill.TextChanged += new System.EventHandler(this.TypeOfDamageSkill_TextChanged);
            // 
            // DamageSkill
            // 
            this.DamageSkill.Location = new System.Drawing.Point(116, 58);
            this.DamageSkill.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.DamageSkill.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DamageSkill.Name = "DamageSkill";
            this.DamageSkill.Size = new System.Drawing.Size(122, 20);
            this.DamageSkill.TabIndex = 6;
            this.DamageSkill.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NameSkill
            // 
            this.NameSkill.Location = new System.Drawing.Point(116, 32);
            this.NameSkill.MaxLength = 18;
            this.NameSkill.Name = "NameSkill";
            this.NameSkill.Size = new System.Drawing.Size(122, 20);
            this.NameSkill.TabIndex = 5;
            this.NameSkill.Text = "Skill1";
            this.NameSkill.TextChanged += new System.EventHandler(this.NameSkill_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Probability for Effect:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Effect:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Type of Damage:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Damage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ShowDatabaseClass);
            this.groupBox3.Controls.Add(this.CreateClassBtn);
            this.groupBox3.Controls.Add(this.ErrorClassTClass);
            this.groupBox3.Controls.Add(this.ErrorWTClass);
            this.groupBox3.Controls.Add(this.ErrorNameClass);
            this.groupBox3.Controls.Add(this.ClassTypeClass);
            this.groupBox3.Controls.Add(this.HPHighClass);
            this.groupBox3.Controls.Add(this.HPLowClass);
            this.groupBox3.Controls.Add(this.WeaponTypesClass);
            this.groupBox3.Controls.Add(this.NameClass);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(574, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 221);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Class";
            // 
            // CreateClassBtn
            // 
            this.CreateClassBtn.Location = new System.Drawing.Point(9, 176);
            this.CreateClassBtn.Name = "CreateClassBtn";
            this.CreateClassBtn.Size = new System.Drawing.Size(115, 23);
            this.CreateClassBtn.TabIndex = 13;
            this.CreateClassBtn.Text = "Create Class";
            this.CreateClassBtn.UseVisualStyleBackColor = true;
            this.CreateClassBtn.Click += new System.EventHandler(this.CreateClassBtn_Click);
            // 
            // ClassTypeClass
            // 
            this.ClassTypeClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClassTypeClass.FormattingEnabled = true;
            this.ClassTypeClass.Items.AddRange(new object[] {
            "Tank",
            "Beater",
            "DPS",
            "Healer",
            "Archer"});
            this.ClassTypeClass.Location = new System.Drawing.Point(139, 139);
            this.ClassTypeClass.Name = "ClassTypeClass";
            this.ClassTypeClass.Size = new System.Drawing.Size(108, 21);
            this.ClassTypeClass.TabIndex = 17;
            this.ClassTypeClass.Text = "Beater";
            this.ClassTypeClass.TextChanged += new System.EventHandler(this.ClassTypeClass_TextChanged);
            // 
            // HPHighClass
            // 
            this.HPHighClass.Location = new System.Drawing.Point(139, 112);
            this.HPHighClass.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.HPHighClass.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HPHighClass.Name = "HPHighClass";
            this.HPHighClass.Size = new System.Drawing.Size(108, 20);
            this.HPHighClass.TabIndex = 16;
            this.HPHighClass.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // HPLowClass
            // 
            this.HPLowClass.Location = new System.Drawing.Point(139, 85);
            this.HPLowClass.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HPLowClass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HPLowClass.Name = "HPLowClass";
            this.HPLowClass.Size = new System.Drawing.Size(108, 20);
            this.HPLowClass.TabIndex = 15;
            this.HPLowClass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WeaponTypesClass
            // 
            this.WeaponTypesClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.WeaponTypesClass.FormattingEnabled = true;
            this.WeaponTypesClass.Items.AddRange(new object[] {
            "One Handed Sword",
            "Two Handed Sword",
            "Bow",
            "Speer",
            "Rapier",
            "Dagger",
            "None"});
            this.WeaponTypesClass.Location = new System.Drawing.Point(139, 57);
            this.WeaponTypesClass.Name = "WeaponTypesClass";
            this.WeaponTypesClass.Size = new System.Drawing.Size(108, 21);
            this.WeaponTypesClass.TabIndex = 14;
            this.WeaponTypesClass.Text = "None";
            // 
            // NameClass
            // 
            this.NameClass.Location = new System.Drawing.Point(139, 32);
            this.NameClass.MaxLength = 18;
            this.NameClass.Name = "NameClass";
            this.NameClass.Size = new System.Drawing.Size(108, 20);
            this.NameClass.TabIndex = 13;
            this.NameClass.Text = "Class1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(71, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Class Type:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "HP on max LVL:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "HP on LVL 1:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Avaiable Weapon Types:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(95, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name:";
            // 
            // ShowDatabaseWeapon
            // 
            this.ShowDatabaseWeapon.Location = new System.Drawing.Point(136, 176);
            this.ShowDatabaseWeapon.Name = "ShowDatabaseWeapon";
            this.ShowDatabaseWeapon.Size = new System.Drawing.Size(103, 23);
            this.ShowDatabaseWeapon.TabIndex = 13;
            this.ShowDatabaseWeapon.Text = "Show Database";
            this.ShowDatabaseWeapon.UseVisualStyleBackColor = true;
            this.ShowDatabaseWeapon.Click += new System.EventHandler(this.ShowDatabaseWeapon_Click);
            // 
            // ShowDatabaseSkill
            // 
            this.ShowDatabaseSkill.Location = new System.Drawing.Point(135, 176);
            this.ShowDatabaseSkill.Name = "ShowDatabaseSkill";
            this.ShowDatabaseSkill.Size = new System.Drawing.Size(103, 23);
            this.ShowDatabaseSkill.TabIndex = 16;
            this.ShowDatabaseSkill.Text = "Show Database";
            this.ShowDatabaseSkill.UseVisualStyleBackColor = true;
            this.ShowDatabaseSkill.Click += new System.EventHandler(this.ShowDatabaseSkill_Click);
            // 
            // ErrorClassTClass
            // 
            this.ErrorClassTClass.Image = global::GameFileViewer.Properties.Resources.Error_Wrong3;
            this.ErrorClassTClass.Location = new System.Drawing.Point(253, 138);
            this.ErrorClassTClass.Name = "ErrorClassTClass";
            this.ErrorClassTClass.Size = new System.Drawing.Size(20, 20);
            this.ErrorClassTClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorClassTClass.TabIndex = 21;
            this.ErrorClassTClass.TabStop = false;
            this.ErrorClassTClass.Visible = false;
            this.ErrorClassTClass.MouseHover += new System.EventHandler(this.OnErrorIcon);
            // 
            // ErrorWTClass
            // 
            this.ErrorWTClass.Image = global::GameFileViewer.Properties.Resources.Error_Wrong3;
            this.ErrorWTClass.Location = new System.Drawing.Point(253, 58);
            this.ErrorWTClass.Name = "ErrorWTClass";
            this.ErrorWTClass.Size = new System.Drawing.Size(20, 20);
            this.ErrorWTClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorWTClass.TabIndex = 18;
            this.ErrorWTClass.TabStop = false;
            this.ErrorWTClass.Visible = false;
            this.ErrorWTClass.MouseHover += new System.EventHandler(this.OnErrorIcon);
            // 
            // ErrorNameClass
            // 
            this.ErrorNameClass.Image = global::GameFileViewer.Properties.Resources.Error_Wrong3;
            this.ErrorNameClass.Location = new System.Drawing.Point(253, 32);
            this.ErrorNameClass.Name = "ErrorNameClass";
            this.ErrorNameClass.Size = new System.Drawing.Size(20, 20);
            this.ErrorNameClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorNameClass.TabIndex = 13;
            this.ErrorNameClass.TabStop = false;
            this.ErrorNameClass.Visible = false;
            // 
            // ErrorEffectSkill
            // 
            this.ErrorEffectSkill.Image = global::GameFileViewer.Properties.Resources.Error_Wrong3;
            this.ErrorEffectSkill.Location = new System.Drawing.Point(242, 111);
            this.ErrorEffectSkill.Name = "ErrorEffectSkill";
            this.ErrorEffectSkill.Size = new System.Drawing.Size(20, 20);
            this.ErrorEffectSkill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorEffectSkill.TabIndex = 15;
            this.ErrorEffectSkill.TabStop = false;
            this.ErrorEffectSkill.Visible = false;
            this.ErrorEffectSkill.MouseHover += new System.EventHandler(this.OnErrorIcon);
            // 
            // ErrorTypeDMGSkill
            // 
            this.ErrorTypeDMGSkill.Image = global::GameFileViewer.Properties.Resources.Error_Wrong3;
            this.ErrorTypeDMGSkill.Location = new System.Drawing.Point(242, 85);
            this.ErrorTypeDMGSkill.Name = "ErrorTypeDMGSkill";
            this.ErrorTypeDMGSkill.Size = new System.Drawing.Size(20, 20);
            this.ErrorTypeDMGSkill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorTypeDMGSkill.TabIndex = 14;
            this.ErrorTypeDMGSkill.TabStop = false;
            this.ErrorTypeDMGSkill.Visible = false;
            this.ErrorTypeDMGSkill.MouseHover += new System.EventHandler(this.OnErrorIcon);
            // 
            // ErrorSkill
            // 
            this.ErrorSkill.Image = global::GameFileViewer.Properties.Resources.Error_Wrong3;
            this.ErrorSkill.Location = new System.Drawing.Point(242, 32);
            this.ErrorSkill.Name = "ErrorSkill";
            this.ErrorSkill.Size = new System.Drawing.Size(20, 20);
            this.ErrorSkill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorSkill.TabIndex = 11;
            this.ErrorSkill.TabStop = false;
            this.ErrorSkill.Visible = false;
            // 
            // ErrorWTWeapon
            // 
            this.ErrorWTWeapon.Image = global::GameFileViewer.Properties.Resources.Error_Wrong2;
            this.ErrorWTWeapon.Location = new System.Drawing.Point(245, 112);
            this.ErrorWTWeapon.Name = "ErrorWTWeapon";
            this.ErrorWTWeapon.Size = new System.Drawing.Size(20, 20);
            this.ErrorWTWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorWTWeapon.TabIndex = 12;
            this.ErrorWTWeapon.TabStop = false;
            this.ErrorWTWeapon.Visible = false;
            this.ErrorWTWeapon.MouseHover += new System.EventHandler(this.OnErrorIcon);
            // 
            // ErrorRarityWeapon
            // 
            this.ErrorRarityWeapon.Image = global::GameFileViewer.Properties.Resources.Error_Wrong2;
            this.ErrorRarityWeapon.Location = new System.Drawing.Point(245, 84);
            this.ErrorRarityWeapon.Name = "ErrorRarityWeapon";
            this.ErrorRarityWeapon.Size = new System.Drawing.Size(20, 20);
            this.ErrorRarityWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorRarityWeapon.TabIndex = 11;
            this.ErrorRarityWeapon.TabStop = false;
            this.ErrorRarityWeapon.Visible = false;
            this.ErrorRarityWeapon.MouseHover += new System.EventHandler(this.OnErrorIcon);
            // 
            // Error1
            // 
            this.Error1.Image = global::GameFileViewer.Properties.Resources.Error_Wrong2;
            this.Error1.Location = new System.Drawing.Point(245, 32);
            this.Error1.Name = "Error1";
            this.Error1.Size = new System.Drawing.Size(20, 20);
            this.Error1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Error1.TabIndex = 6;
            this.Error1.TabStop = false;
            this.Error1.Visible = false;
            // 
            // ShowDatabaseClass
            // 
            this.ShowDatabaseClass.Location = new System.Drawing.Point(144, 176);
            this.ShowDatabaseClass.Name = "ShowDatabaseClass";
            this.ShowDatabaseClass.Size = new System.Drawing.Size(103, 23);
            this.ShowDatabaseClass.TabIndex = 17;
            this.ShowDatabaseClass.Text = "Show Database";
            this.ShowDatabaseClass.UseVisualStyleBackColor = true;
            this.ShowDatabaseClass.Click += new System.EventHandler(this.ShowDatabaseClass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 272);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Create Items Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamageWeapon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProbsSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamageSkill)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPHighClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPLowClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorClassTClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorWTClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNameClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEffectSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTypeDMGSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorWTWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRarityWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateWeaponBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown DamageWeapon;
        private System.Windows.Forms.ComboBox WeaponTypeWeapon;
        private System.Windows.Forms.ComboBox RarityWeapon;
        private System.Windows.Forms.TextBox NameWeapon;
        private System.Windows.Forms.PictureBox Error1;
        private System.Windows.Forms.NumericUpDown ValueWeapon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox EffectSkill;
        private System.Windows.Forms.ComboBox TypeOfDamageSkill;
        private System.Windows.Forms.NumericUpDown DamageSkill;
        private System.Windows.Forms.TextBox NameSkill;
        private System.Windows.Forms.NumericUpDown ProbsSkill;
        private System.Windows.Forms.PictureBox ErrorSkill;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CreateSkillBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox WeaponTypesClass;
        private System.Windows.Forms.TextBox NameClass;
        private System.Windows.Forms.ComboBox ClassTypeClass;
        private System.Windows.Forms.NumericUpDown HPHighClass;
        private System.Windows.Forms.NumericUpDown HPLowClass;
        private System.Windows.Forms.PictureBox ErrorEffectSkill;
        private System.Windows.Forms.PictureBox ErrorTypeDMGSkill;
        private System.Windows.Forms.Button CreateClassBtn;
        private System.Windows.Forms.PictureBox ErrorClassTClass;
        private System.Windows.Forms.PictureBox ErrorWTClass;
        private System.Windows.Forms.PictureBox ErrorNameClass;
        private System.Windows.Forms.PictureBox ErrorWTWeapon;
        private System.Windows.Forms.PictureBox ErrorRarityWeapon;
        private System.Windows.Forms.Button ShowDatabaseWeapon;
        private System.Windows.Forms.Button ShowDatabaseSkill;
        private System.Windows.Forms.Button ShowDatabaseClass;
    }
}

