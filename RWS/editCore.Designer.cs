﻿namespace RWS
{
    partial class editCore
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
            this.title_core = new System.Windows.Forms.Label();
            this.check_isBio = new System.Windows.Forms.CheckBox();
            this.check_isBug = new System.Windows.Forms.CheckBox();
            this.check_isBuilder = new System.Windows.Forms.CheckBox();
            this.group_UnitType = new System.Windows.Forms.GroupBox();
            this.check_Experimental = new System.Windows.Forms.CheckBox();
            this.group_ShieldArmour = new System.Windows.Forms.GroupBox();
            this.label_shieldRegen = new System.Windows.Forms.Label();
            this.num_shieldRegen = new System.Windows.Forms.NumericUpDown();
            this.label_maxShield = new System.Windows.Forms.Label();
            this.num_maxShield = new System.Windows.Forms.NumericUpDown();
            this.check_startShieldAtZero = new System.Windows.Forms.CheckBox();
            this.group_energy = new System.Windows.Forms.GroupBox();
            this.check_Building = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_maxEnergy = new System.Windows.Forms.Label();
            this.num_maxEnergy = new System.Windows.Forms.NumericUpDown();
            this.label_energyRegen = new System.Windows.Forms.Label();
            this.num_energyRegen = new System.Windows.Forms.NumericUpDown();
            this.label_energyStartPercent = new System.Windows.Forms.Label();
            this.num_energyStartPercent = new System.Windows.Forms.NumericUpDown();
            this.label_armourMinDamageToKeep = new System.Windows.Forms.Label();
            this.num_ArmourMinDamageToKeep = new System.Windows.Forms.NumericUpDown();
            this.label_Armour = new System.Windows.Forms.Label();
            this.num_Armour = new System.Windows.Forms.NumericUpDown();
            this.group_resources = new System.Windows.Forms.GroupBox();
            this.group_Sound = new System.Windows.Forms.GroupBox();
            this.sel_SoundDeath = new System.Windows.Forms.Button();
            this.sel_SoundNewSelect = new System.Windows.Forms.Button();
            this.sel_SoundMove = new System.Windows.Forms.Button();
            this.sel_SoundAttack = new System.Windows.Forms.Button();
            this.group_transport = new System.Windows.Forms.GroupBox();
            this.label_tport_slotsNeeded = new System.Windows.Forms.Label();
            this.num_tport_slotsNeeded = new System.Windows.Forms.NumericUpDown();
            this.label_tport_maxUnits = new System.Windows.Forms.Label();
            this.num_tport_maxUnits = new System.Windows.Forms.NumericUpDown();
            this.check_blockAirandWaterUnits = new System.Windows.Forms.CheckBox();
            this.check_KeepBuiltUnits = new System.Windows.Forms.CheckBox();
            this.check_addUnloadOption = new System.Windows.Forms.CheckBox();
            this.label_unloadDelay = new System.Windows.Forms.Label();
            this.num_tport_unloadDelay = new System.Windows.Forms.NumericUpDown();
            this.label_healBy = new System.Windows.Forms.Label();
            this.num_tport_UnitHealBy = new System.Windows.Forms.NumericUpDown();
            this.check_tport_BlockOtherTport = new System.Windows.Forms.CheckBox();
            this.group_deathOptions = new System.Windows.Forms.GroupBox();
            this.group_BuildingOptions = new System.Windows.Forms.GroupBox();
            this.group_construction = new System.Windows.Forms.GroupBox();
            this.group_UiGraphics = new System.Windows.Forms.GroupBox();
            this.group_misc = new System.Windows.Forms.GroupBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.group_UnitType.SuspendLayout();
            this.group_ShieldArmour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_shieldRegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maxShield)).BeginInit();
            this.group_energy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_maxEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_energyRegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_energyStartPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ArmourMinDamageToKeep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Armour)).BeginInit();
            this.group_Sound.SuspendLayout();
            this.group_transport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tport_slotsNeeded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tport_maxUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tport_unloadDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tport_UnitHealBy)).BeginInit();
            this.SuspendLayout();
            // 
            // title_core
            // 
            this.title_core.AutoSize = true;
            this.title_core.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_core.Location = new System.Drawing.Point(18, 9);
            this.title_core.Name = "title_core";
            this.title_core.Size = new System.Drawing.Size(92, 39);
            this.title_core.TabIndex = 0;
            this.title_core.Text = "Core";
            // 
            // check_isBio
            // 
            this.check_isBio.AutoSize = true;
            this.check_isBio.Location = new System.Drawing.Point(6, 19);
            this.check_isBio.Name = "check_isBio";
            this.check_isBio.Size = new System.Drawing.Size(41, 17);
            this.check_isBio.TabIndex = 1;
            this.check_isBio.Text = "Bio";
            this.check_isBio.UseVisualStyleBackColor = true;
            // 
            // check_isBug
            // 
            this.check_isBug.AutoSize = true;
            this.check_isBug.Location = new System.Drawing.Point(6, 42);
            this.check_isBug.Name = "check_isBug";
            this.check_isBug.Size = new System.Drawing.Size(45, 17);
            this.check_isBug.TabIndex = 2;
            this.check_isBug.Text = "Bug";
            this.check_isBug.UseVisualStyleBackColor = true;
            // 
            // check_isBuilder
            // 
            this.check_isBuilder.AutoSize = true;
            this.check_isBuilder.Location = new System.Drawing.Point(5, 65);
            this.check_isBuilder.Name = "check_isBuilder";
            this.check_isBuilder.Size = new System.Drawing.Size(58, 17);
            this.check_isBuilder.TabIndex = 3;
            this.check_isBuilder.Text = "Builder";
            this.check_isBuilder.UseVisualStyleBackColor = true;
            this.check_isBuilder.CheckedChanged += new System.EventHandler(this.check_isBuilder_CheckedChanged);
            // 
            // group_UnitType
            // 
            this.group_UnitType.Controls.Add(this.check_Building);
            this.group_UnitType.Controls.Add(this.check_Experimental);
            this.group_UnitType.Controls.Add(this.check_isBug);
            this.group_UnitType.Controls.Add(this.check_isBuilder);
            this.group_UnitType.Controls.Add(this.check_isBio);
            this.group_UnitType.Location = new System.Drawing.Point(19, 51);
            this.group_UnitType.Name = "group_UnitType";
            this.group_UnitType.Size = new System.Drawing.Size(100, 136);
            this.group_UnitType.TabIndex = 4;
            this.group_UnitType.TabStop = false;
            this.group_UnitType.Text = "Select unit type";
            // 
            // check_Experimental
            // 
            this.check_Experimental.AutoSize = true;
            this.check_Experimental.Location = new System.Drawing.Point(5, 111);
            this.check_Experimental.Name = "check_Experimental";
            this.check_Experimental.Size = new System.Drawing.Size(86, 17);
            this.check_Experimental.TabIndex = 4;
            this.check_Experimental.Text = "Experimental";
            this.check_Experimental.UseVisualStyleBackColor = true;
            this.check_Experimental.CheckedChanged += new System.EventHandler(this.check_Experimental_CheckedChanged);
            // 
            // group_ShieldArmour
            // 
            this.group_ShieldArmour.Controls.Add(this.label_armourMinDamageToKeep);
            this.group_ShieldArmour.Controls.Add(this.num_ArmourMinDamageToKeep);
            this.group_ShieldArmour.Controls.Add(this.label_Armour);
            this.group_ShieldArmour.Controls.Add(this.num_Armour);
            this.group_ShieldArmour.Controls.Add(this.label_shieldRegen);
            this.group_ShieldArmour.Controls.Add(this.num_shieldRegen);
            this.group_ShieldArmour.Controls.Add(this.label_maxShield);
            this.group_ShieldArmour.Controls.Add(this.num_maxShield);
            this.group_ShieldArmour.Controls.Add(this.check_startShieldAtZero);
            this.group_ShieldArmour.Location = new System.Drawing.Point(319, 51);
            this.group_ShieldArmour.Name = "group_ShieldArmour";
            this.group_ShieldArmour.Size = new System.Drawing.Size(188, 136);
            this.group_ShieldArmour.TabIndex = 5;
            this.group_ShieldArmour.TabStop = false;
            this.group_ShieldArmour.Text = "Shield/Armour";
            // 
            // label_shieldRegen
            // 
            this.label_shieldRegen.AutoSize = true;
            this.label_shieldRegen.Location = new System.Drawing.Point(54, 64);
            this.label_shieldRegen.Name = "label_shieldRegen";
            this.label_shieldRegen.Size = new System.Drawing.Size(66, 13);
            this.label_shieldRegen.TabIndex = 4;
            this.label_shieldRegen.Text = "shieldRegen";
            // 
            // num_shieldRegen
            // 
            this.num_shieldRegen.Location = new System.Drawing.Point(6, 64);
            this.num_shieldRegen.Name = "num_shieldRegen";
            this.num_shieldRegen.Size = new System.Drawing.Size(42, 20);
            this.num_shieldRegen.TabIndex = 3;
            // 
            // label_maxShield
            // 
            this.label_maxShield.AutoSize = true;
            this.label_maxShield.Location = new System.Drawing.Point(54, 39);
            this.label_maxShield.Name = "label_maxShield";
            this.label_maxShield.Size = new System.Drawing.Size(55, 13);
            this.label_maxShield.TabIndex = 2;
            this.label_maxShield.Text = "maxShield";
            // 
            // num_maxShield
            // 
            this.num_maxShield.Location = new System.Drawing.Point(6, 39);
            this.num_maxShield.Name = "num_maxShield";
            this.num_maxShield.Size = new System.Drawing.Size(42, 20);
            this.num_maxShield.TabIndex = 1;
            // 
            // check_startShieldAtZero
            // 
            this.check_startShieldAtZero.AutoSize = true;
            this.check_startShieldAtZero.Location = new System.Drawing.Point(7, 20);
            this.check_startShieldAtZero.Name = "check_startShieldAtZero";
            this.check_startShieldAtZero.Size = new System.Drawing.Size(107, 17);
            this.check_startShieldAtZero.TabIndex = 0;
            this.check_startShieldAtZero.Text = "startShieldAtZero";
            this.check_startShieldAtZero.UseVisualStyleBackColor = true;
            // 
            // group_energy
            // 
            this.group_energy.Controls.Add(this.label_energyStartPercent);
            this.group_energy.Controls.Add(this.num_energyStartPercent);
            this.group_energy.Controls.Add(this.label_energyRegen);
            this.group_energy.Controls.Add(this.num_energyRegen);
            this.group_energy.Controls.Add(this.label_maxEnergy);
            this.group_energy.Controls.Add(this.num_maxEnergy);
            this.group_energy.Controls.Add(this.checkBox1);
            this.group_energy.Location = new System.Drawing.Point(125, 51);
            this.group_energy.Name = "group_energy";
            this.group_energy.Size = new System.Drawing.Size(188, 136);
            this.group_energy.TabIndex = 6;
            this.group_energy.TabStop = false;
            this.group_energy.Text = "Energy";
            // 
            // check_Building
            // 
            this.check_Building.AutoSize = true;
            this.check_Building.Location = new System.Drawing.Point(5, 88);
            this.check_Building.Name = "check_Building";
            this.check_Building.Size = new System.Drawing.Size(63, 17);
            this.check_Building.TabIndex = 5;
            this.check_Building.Text = "Building";
            this.check_Building.UseVisualStyleBackColor = true;
            this.check_Building.CheckedChanged += new System.EventHandler(this.check_Building_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "EnergyNeedsToRechargeToFull";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label_maxEnergy
            // 
            this.label_maxEnergy.AutoSize = true;
            this.label_maxEnergy.Location = new System.Drawing.Point(54, 41);
            this.label_maxEnergy.Name = "label_maxEnergy";
            this.label_maxEnergy.Size = new System.Drawing.Size(59, 13);
            this.label_maxEnergy.TabIndex = 6;
            this.label_maxEnergy.Text = "maxEnergy";
            // 
            // num_maxEnergy
            // 
            this.num_maxEnergy.Location = new System.Drawing.Point(6, 41);
            this.num_maxEnergy.Name = "num_maxEnergy";
            this.num_maxEnergy.Size = new System.Drawing.Size(42, 20);
            this.num_maxEnergy.TabIndex = 5;
            // 
            // label_energyRegen
            // 
            this.label_energyRegen.AutoSize = true;
            this.label_energyRegen.Location = new System.Drawing.Point(54, 64);
            this.label_energyRegen.Name = "label_energyRegen";
            this.label_energyRegen.Size = new System.Drawing.Size(71, 13);
            this.label_energyRegen.TabIndex = 8;
            this.label_energyRegen.Text = "energyRegen";
            // 
            // num_energyRegen
            // 
            this.num_energyRegen.Location = new System.Drawing.Point(6, 64);
            this.num_energyRegen.Name = "num_energyRegen";
            this.num_energyRegen.Size = new System.Drawing.Size(42, 20);
            this.num_energyRegen.TabIndex = 7;
            // 
            // label_energyStartPercent
            // 
            this.label_energyStartPercent.AutoSize = true;
            this.label_energyStartPercent.Location = new System.Drawing.Point(54, 88);
            this.label_energyStartPercent.Name = "label_energyStartPercent";
            this.label_energyStartPercent.Size = new System.Drawing.Size(83, 13);
            this.label_energyStartPercent.TabIndex = 10;
            this.label_energyStartPercent.Text = "energyStarting%";
            // 
            // num_energyStartPercent
            // 
            this.num_energyStartPercent.Location = new System.Drawing.Point(6, 88);
            this.num_energyStartPercent.Name = "num_energyStartPercent";
            this.num_energyStartPercent.Size = new System.Drawing.Size(42, 20);
            this.num_energyStartPercent.TabIndex = 9;
            // 
            // label_armourMinDamageToKeep
            // 
            this.label_armourMinDamageToKeep.AutoSize = true;
            this.label_armourMinDamageToKeep.Location = new System.Drawing.Point(54, 113);
            this.label_armourMinDamageToKeep.Name = "label_armourMinDamageToKeep";
            this.label_armourMinDamageToKeep.Size = new System.Drawing.Size(134, 13);
            this.label_armourMinDamageToKeep.TabIndex = 12;
            this.label_armourMinDamageToKeep.Text = "armourMinDamageToKeep";
            // 
            // num_ArmourMinDamageToKeep
            // 
            this.num_ArmourMinDamageToKeep.Location = new System.Drawing.Point(6, 113);
            this.num_ArmourMinDamageToKeep.Name = "num_ArmourMinDamageToKeep";
            this.num_ArmourMinDamageToKeep.Size = new System.Drawing.Size(42, 20);
            this.num_ArmourMinDamageToKeep.TabIndex = 11;
            // 
            // label_Armour
            // 
            this.label_Armour.AutoSize = true;
            this.label_Armour.Location = new System.Drawing.Point(54, 88);
            this.label_Armour.Name = "label_Armour";
            this.label_Armour.Size = new System.Drawing.Size(40, 13);
            this.label_Armour.TabIndex = 10;
            this.label_Armour.Text = "Armour";
            // 
            // num_Armour
            // 
            this.num_Armour.Location = new System.Drawing.Point(6, 88);
            this.num_Armour.Name = "num_Armour";
            this.num_Armour.Size = new System.Drawing.Size(42, 20);
            this.num_Armour.TabIndex = 9;
            // 
            // group_resources
            // 
            this.group_resources.Location = new System.Drawing.Point(19, 193);
            this.group_resources.Name = "group_resources";
            this.group_resources.Size = new System.Drawing.Size(294, 136);
            this.group_resources.TabIndex = 7;
            this.group_resources.TabStop = false;
            this.group_resources.Text = "Resources";
            // 
            // group_Sound
            // 
            this.group_Sound.Controls.Add(this.sel_SoundAttack);
            this.group_Sound.Controls.Add(this.sel_SoundMove);
            this.group_Sound.Controls.Add(this.sel_SoundNewSelect);
            this.group_Sound.Controls.Add(this.sel_SoundDeath);
            this.group_Sound.Location = new System.Drawing.Point(816, 51);
            this.group_Sound.Name = "group_Sound";
            this.group_Sound.Size = new System.Drawing.Size(110, 136);
            this.group_Sound.TabIndex = 8;
            this.group_Sound.TabStop = false;
            this.group_Sound.Text = "Sound";
            // 
            // sel_SoundDeath
            // 
            this.sel_SoundDeath.Location = new System.Drawing.Point(6, 103);
            this.sel_SoundDeath.Name = "sel_SoundDeath";
            this.sel_SoundDeath.Size = new System.Drawing.Size(97, 23);
            this.sel_SoundDeath.TabIndex = 0;
            this.sel_SoundDeath.Text = "Death";
            this.sel_SoundDeath.UseVisualStyleBackColor = true;
            // 
            // sel_SoundNewSelect
            // 
            this.sel_SoundNewSelect.Location = new System.Drawing.Point(7, 74);
            this.sel_SoundNewSelect.Name = "sel_SoundNewSelect";
            this.sel_SoundNewSelect.Size = new System.Drawing.Size(97, 23);
            this.sel_SoundNewSelect.TabIndex = 1;
            this.sel_SoundNewSelect.Text = "New Selection";
            this.sel_SoundNewSelect.UseVisualStyleBackColor = true;
            // 
            // sel_SoundMove
            // 
            this.sel_SoundMove.Location = new System.Drawing.Point(6, 45);
            this.sel_SoundMove.Name = "sel_SoundMove";
            this.sel_SoundMove.Size = new System.Drawing.Size(97, 23);
            this.sel_SoundMove.TabIndex = 2;
            this.sel_SoundMove.Text = "Move";
            this.sel_SoundMove.UseVisualStyleBackColor = true;
            this.sel_SoundMove.Click += new System.EventHandler(this.button2_Click);
            // 
            // sel_SoundAttack
            // 
            this.sel_SoundAttack.Location = new System.Drawing.Point(6, 16);
            this.sel_SoundAttack.Name = "sel_SoundAttack";
            this.sel_SoundAttack.Size = new System.Drawing.Size(97, 23);
            this.sel_SoundAttack.TabIndex = 3;
            this.sel_SoundAttack.Text = "Attack";
            this.sel_SoundAttack.UseVisualStyleBackColor = true;
            // 
            // group_transport
            // 
            this.group_transport.Controls.Add(this.check_tport_BlockOtherTport);
            this.group_transport.Controls.Add(this.label_healBy);
            this.group_transport.Controls.Add(this.num_tport_UnitHealBy);
            this.group_transport.Controls.Add(this.label_unloadDelay);
            this.group_transport.Controls.Add(this.num_tport_unloadDelay);
            this.group_transport.Controls.Add(this.check_addUnloadOption);
            this.group_transport.Controls.Add(this.check_KeepBuiltUnits);
            this.group_transport.Controls.Add(this.check_blockAirandWaterUnits);
            this.group_transport.Controls.Add(this.label_tport_maxUnits);
            this.group_transport.Controls.Add(this.num_tport_maxUnits);
            this.group_transport.Controls.Add(this.label_tport_slotsNeeded);
            this.group_transport.Controls.Add(this.num_tport_slotsNeeded);
            this.group_transport.ImeMode = System.Windows.Forms.ImeMode.On;
            this.group_transport.Location = new System.Drawing.Point(513, 51);
            this.group_transport.Name = "group_transport";
            this.group_transport.Size = new System.Drawing.Size(295, 136);
            this.group_transport.TabIndex = 8;
            this.group_transport.TabStop = false;
            this.group_transport.Text = "Transport";
            // 
            // label_tport_slotsNeeded
            // 
            this.label_tport_slotsNeeded.AutoSize = true;
            this.label_tport_slotsNeeded.Location = new System.Drawing.Point(54, 19);
            this.label_tport_slotsNeeded.Name = "label_tport_slotsNeeded";
            this.label_tport_slotsNeeded.Size = new System.Drawing.Size(66, 13);
            this.label_tport_slotsNeeded.TabIndex = 14;
            this.label_tport_slotsNeeded.Text = "slotsNeeded";
            // 
            // num_tport_slotsNeeded
            // 
            this.num_tport_slotsNeeded.Location = new System.Drawing.Point(6, 19);
            this.num_tport_slotsNeeded.Name = "num_tport_slotsNeeded";
            this.num_tport_slotsNeeded.Size = new System.Drawing.Size(42, 20);
            this.num_tport_slotsNeeded.TabIndex = 13;
            // 
            // label_tport_maxUnits
            // 
            this.label_tport_maxUnits.AutoSize = true;
            this.label_tport_maxUnits.Location = new System.Drawing.Point(54, 41);
            this.label_tport_maxUnits.Name = "label_tport_maxUnits";
            this.label_tport_maxUnits.Size = new System.Drawing.Size(50, 13);
            this.label_tport_maxUnits.TabIndex = 16;
            this.label_tport_maxUnits.Text = "maxUnits";
            // 
            // num_tport_maxUnits
            // 
            this.num_tport_maxUnits.Location = new System.Drawing.Point(6, 41);
            this.num_tport_maxUnits.Name = "num_tport_maxUnits";
            this.num_tport_maxUnits.Size = new System.Drawing.Size(42, 20);
            this.num_tport_maxUnits.TabIndex = 15;
            // 
            // check_blockAirandWaterUnits
            // 
            this.check_blockAirandWaterUnits.AutoSize = true;
            this.check_blockAirandWaterUnits.Location = new System.Drawing.Point(149, 18);
            this.check_blockAirandWaterUnits.Name = "check_blockAirandWaterUnits";
            this.check_blockAirandWaterUnits.Size = new System.Drawing.Size(148, 17);
            this.check_blockAirandWaterUnits.TabIndex = 13;
            this.check_blockAirandWaterUnits.Text = "Block Air and Water Units";
            this.check_blockAirandWaterUnits.UseVisualStyleBackColor = true;
            // 
            // check_KeepBuiltUnits
            // 
            this.check_KeepBuiltUnits.AutoSize = true;
            this.check_KeepBuiltUnits.Location = new System.Drawing.Point(149, 41);
            this.check_KeepBuiltUnits.Name = "check_KeepBuiltUnits";
            this.check_KeepBuiltUnits.Size = new System.Drawing.Size(99, 17);
            this.check_KeepBuiltUnits.TabIndex = 17;
            this.check_KeepBuiltUnits.Text = "Keep Built units";
            this.check_KeepBuiltUnits.UseVisualStyleBackColor = true;
            // 
            // check_addUnloadOption
            // 
            this.check_addUnloadOption.AutoSize = true;
            this.check_addUnloadOption.Location = new System.Drawing.Point(149, 65);
            this.check_addUnloadOption.Name = "check_addUnloadOption";
            this.check_addUnloadOption.Size = new System.Drawing.Size(112, 17);
            this.check_addUnloadOption.TabIndex = 18;
            this.check_addUnloadOption.Text = "Add unload option";
            this.check_addUnloadOption.UseVisualStyleBackColor = true;
            // 
            // label_unloadDelay
            // 
            this.label_unloadDelay.AutoSize = true;
            this.label_unloadDelay.Location = new System.Drawing.Point(54, 64);
            this.label_unloadDelay.Name = "label_unloadDelay";
            this.label_unloadDelay.Size = new System.Drawing.Size(71, 13);
            this.label_unloadDelay.TabIndex = 20;
            this.label_unloadDelay.Text = "Unload Delay";
            // 
            // num_tport_unloadDelay
            // 
            this.num_tport_unloadDelay.Location = new System.Drawing.Point(6, 64);
            this.num_tport_unloadDelay.Name = "num_tport_unloadDelay";
            this.num_tport_unloadDelay.Size = new System.Drawing.Size(42, 20);
            this.num_tport_unloadDelay.TabIndex = 19;
            // 
            // label_healBy
            // 
            this.label_healBy.AutoSize = true;
            this.label_healBy.Location = new System.Drawing.Point(54, 88);
            this.label_healBy.Name = "label_healBy";
            this.label_healBy.Size = new System.Drawing.Size(71, 13);
            this.label_healBy.TabIndex = 22;
            this.label_healBy.Text = "Units Heal By";
            // 
            // num_tport_UnitHealBy
            // 
            this.num_tport_UnitHealBy.Location = new System.Drawing.Point(7, 86);
            this.num_tport_UnitHealBy.Name = "num_tport_UnitHealBy";
            this.num_tport_UnitHealBy.Size = new System.Drawing.Size(42, 20);
            this.num_tport_UnitHealBy.TabIndex = 21;
            // 
            // check_tport_BlockOtherTport
            // 
            this.check_tport_BlockOtherTport.AutoSize = true;
            this.check_tport_BlockOtherTport.Location = new System.Drawing.Point(149, 89);
            this.check_tport_BlockOtherTport.Name = "check_tport_BlockOtherTport";
            this.check_tport_BlockOtherTport.Size = new System.Drawing.Size(135, 17);
            this.check_tport_BlockOtherTport.TabIndex = 23;
            this.check_tport_BlockOtherTport.Text = "Block Other Transports";
            this.check_tport_BlockOtherTport.UseVisualStyleBackColor = true;
            // 
            // group_deathOptions
            // 
            this.group_deathOptions.Location = new System.Drawing.Point(319, 193);
            this.group_deathOptions.Name = "group_deathOptions";
            this.group_deathOptions.Size = new System.Drawing.Size(307, 136);
            this.group_deathOptions.TabIndex = 8;
            this.group_deathOptions.TabStop = false;
            this.group_deathOptions.Text = "Death";
            // 
            // group_BuildingOptions
            // 
            this.group_BuildingOptions.Location = new System.Drawing.Point(19, 335);
            this.group_BuildingOptions.Name = "group_BuildingOptions";
            this.group_BuildingOptions.Size = new System.Drawing.Size(294, 149);
            this.group_BuildingOptions.TabIndex = 9;
            this.group_BuildingOptions.TabStop = false;
            this.group_BuildingOptions.Text = "Building";
            // 
            // group_construction
            // 
            this.group_construction.Location = new System.Drawing.Point(319, 335);
            this.group_construction.Name = "group_construction";
            this.group_construction.Size = new System.Drawing.Size(307, 149);
            this.group_construction.TabIndex = 10;
            this.group_construction.TabStop = false;
            this.group_construction.Text = "Construction";
            // 
            // group_UiGraphics
            // 
            this.group_UiGraphics.Location = new System.Drawing.Point(632, 193);
            this.group_UiGraphics.Name = "group_UiGraphics";
            this.group_UiGraphics.Size = new System.Drawing.Size(294, 136);
            this.group_UiGraphics.TabIndex = 9;
            this.group_UiGraphics.TabStop = false;
            this.group_UiGraphics.Text = "UI/Graphics";
            // 
            // group_misc
            // 
            this.group_misc.Location = new System.Drawing.Point(632, 335);
            this.group_misc.Name = "group_misc";
            this.group_misc.Size = new System.Drawing.Size(294, 149);
            this.group_misc.TabIndex = 10;
            this.group_misc.TabStop = false;
            this.group_misc.Text = "Misc";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(851, 490);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 29);
            this.button_save.TabIndex = 11;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(770, 490);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 29);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // editCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 531);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.group_misc);
            this.Controls.Add(this.group_UiGraphics);
            this.Controls.Add(this.group_construction);
            this.Controls.Add(this.group_BuildingOptions);
            this.Controls.Add(this.group_deathOptions);
            this.Controls.Add(this.group_transport);
            this.Controls.Add(this.group_Sound);
            this.Controls.Add(this.group_resources);
            this.Controls.Add(this.group_energy);
            this.Controls.Add(this.group_ShieldArmour);
            this.Controls.Add(this.group_UnitType);
            this.Controls.Add(this.title_core);
            this.Name = "editCore";
            this.Text = "editCore";
            this.group_UnitType.ResumeLayout(false);
            this.group_UnitType.PerformLayout();
            this.group_ShieldArmour.ResumeLayout(false);
            this.group_ShieldArmour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_shieldRegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_maxShield)).EndInit();
            this.group_energy.ResumeLayout(false);
            this.group_energy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_maxEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_energyRegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_energyStartPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ArmourMinDamageToKeep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Armour)).EndInit();
            this.group_Sound.ResumeLayout(false);
            this.group_transport.ResumeLayout(false);
            this.group_transport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tport_slotsNeeded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tport_maxUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tport_unloadDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tport_UnitHealBy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_core;
        private System.Windows.Forms.CheckBox check_isBio;
        private System.Windows.Forms.CheckBox check_isBug;
        private System.Windows.Forms.CheckBox check_isBuilder;
        private System.Windows.Forms.GroupBox group_UnitType;
        private System.Windows.Forms.CheckBox check_Experimental;
        private System.Windows.Forms.GroupBox group_ShieldArmour;
        private System.Windows.Forms.Label label_shieldRegen;
        private System.Windows.Forms.NumericUpDown num_shieldRegen;
        private System.Windows.Forms.Label label_maxShield;
        private System.Windows.Forms.NumericUpDown num_maxShield;
        private System.Windows.Forms.CheckBox check_startShieldAtZero;
        private System.Windows.Forms.GroupBox group_energy;
        private System.Windows.Forms.CheckBox check_Building;
        private System.Windows.Forms.Label label_energyStartPercent;
        private System.Windows.Forms.NumericUpDown num_energyStartPercent;
        private System.Windows.Forms.Label label_energyRegen;
        private System.Windows.Forms.NumericUpDown num_energyRegen;
        private System.Windows.Forms.Label label_maxEnergy;
        private System.Windows.Forms.NumericUpDown num_maxEnergy;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_armourMinDamageToKeep;
        private System.Windows.Forms.NumericUpDown num_ArmourMinDamageToKeep;
        private System.Windows.Forms.Label label_Armour;
        private System.Windows.Forms.NumericUpDown num_Armour;
        private System.Windows.Forms.GroupBox group_resources;
        private System.Windows.Forms.GroupBox group_Sound;
        private System.Windows.Forms.Button sel_SoundAttack;
        private System.Windows.Forms.Button sel_SoundMove;
        private System.Windows.Forms.Button sel_SoundNewSelect;
        private System.Windows.Forms.Button sel_SoundDeath;
        private System.Windows.Forms.GroupBox group_transport;
        private System.Windows.Forms.CheckBox check_tport_BlockOtherTport;
        private System.Windows.Forms.Label label_healBy;
        private System.Windows.Forms.NumericUpDown num_tport_UnitHealBy;
        private System.Windows.Forms.Label label_unloadDelay;
        private System.Windows.Forms.NumericUpDown num_tport_unloadDelay;
        private System.Windows.Forms.CheckBox check_addUnloadOption;
        private System.Windows.Forms.CheckBox check_KeepBuiltUnits;
        private System.Windows.Forms.CheckBox check_blockAirandWaterUnits;
        private System.Windows.Forms.Label label_tport_maxUnits;
        private System.Windows.Forms.NumericUpDown num_tport_maxUnits;
        private System.Windows.Forms.Label label_tport_slotsNeeded;
        private System.Windows.Forms.NumericUpDown num_tport_slotsNeeded;
        private System.Windows.Forms.GroupBox group_deathOptions;
        private System.Windows.Forms.GroupBox group_BuildingOptions;
        private System.Windows.Forms.GroupBox group_construction;
        private System.Windows.Forms.GroupBox group_UiGraphics;
        private System.Windows.Forms.GroupBox group_misc;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
    }
}