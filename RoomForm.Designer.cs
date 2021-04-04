namespace TeacherAttendanceDB
{
    partial class RoomForm
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
            this.deleteRoom = new System.Windows.Forms.Button();
            this.modifyRoom = new System.Windows.Forms.Button();
            this.addRoom = new System.Windows.Forms.Button();
            this.roomNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVRoom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteRoom
            // 
            this.deleteRoom.Enabled = false;
            this.deleteRoom.Location = new System.Drawing.Point(266, 98);
            this.deleteRoom.Name = "deleteRoom";
            this.deleteRoom.Size = new System.Drawing.Size(58, 23);
            this.deleteRoom.TabIndex = 11;
            this.deleteRoom.Text = "Delete";
            this.deleteRoom.UseVisualStyleBackColor = true;
            this.deleteRoom.Click += new System.EventHandler(this.deleteRoom_Click);
            // 
            // modifyRoom
            // 
            this.modifyRoom.Enabled = false;
            this.modifyRoom.Location = new System.Drawing.Point(202, 98);
            this.modifyRoom.Name = "modifyRoom";
            this.modifyRoom.Size = new System.Drawing.Size(58, 23);
            this.modifyRoom.TabIndex = 10;
            this.modifyRoom.Text = "Modify";
            this.modifyRoom.UseVisualStyleBackColor = true;
            this.modifyRoom.Click += new System.EventHandler(this.modifyRoom_Click);
            // 
            // addRoom
            // 
            this.addRoom.Location = new System.Drawing.Point(138, 98);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(58, 23);
            this.addRoom.TabIndex = 9;
            this.addRoom.Text = "Add";
            this.addRoom.UseVisualStyleBackColor = true;
            this.addRoom.Click += new System.EventHandler(this.addRoom_Click);
            // 
            // roomNameTB
            // 
            this.roomNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameTB.Location = new System.Drawing.Point(145, 57);
            this.roomNameTB.Name = "roomNameTB";
            this.roomNameTB.Size = new System.Drawing.Size(144, 24);
            this.roomNameTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Room Name";
            // 
            // dGVRoom
            // 
            this.dGVRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVRoom.Location = new System.Drawing.Point(34, 127);
            this.dGVRoom.Name = "dGVRoom";
            this.dGVRoom.Size = new System.Drawing.Size(290, 175);
            this.dGVRoom.TabIndex = 6;
            this.dGVRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVRoom_CellClick);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 314);
            this.Controls.Add(this.deleteRoom);
            this.Controls.Add(this.modifyRoom);
            this.Controls.Add(this.addRoom);
            this.Controls.Add(this.roomNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVRoom);
            this.Name = "RoomForm";
            this.Text = "Room Form";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteRoom;
        private System.Windows.Forms.Button modifyRoom;
        private System.Windows.Forms.Button addRoom;
        private System.Windows.Forms.TextBox roomNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVRoom;
    }
}