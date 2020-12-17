
namespace LabOOP_6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPaint = new System.Windows.Forms.Panel();
            this.groupBoxChoose = new System.Windows.Forms.GroupBox();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonOrange = new System.Windows.Forms.RadioButton();
            this.radioButtonYellow = new System.Windows.Forms.RadioButton();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelCoords = new System.Windows.Forms.Label();
            this.groupBoxChoose.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPaint
            // 
            this.panelPaint.BackColor = System.Drawing.Color.White;
            this.panelPaint.Location = new System.Drawing.Point(12, 12);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(600, 600);
            this.panelPaint.TabIndex = 0;
            this.panelPaint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseClick);
            this.panelPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseMove);
            // 
            // groupBoxChoose
            // 
            this.groupBoxChoose.Controls.Add(this.radioButtonLine);
            this.groupBoxChoose.Controls.Add(this.radioButtonTriangle);
            this.groupBoxChoose.Controls.Add(this.radioButtonRectangle);
            this.groupBoxChoose.Controls.Add(this.radioButtonEllipse);
            this.groupBoxChoose.Location = new System.Drawing.Point(618, 12);
            this.groupBoxChoose.Name = "groupBoxChoose";
            this.groupBoxChoose.Size = new System.Drawing.Size(252, 134);
            this.groupBoxChoose.TabIndex = 1;
            this.groupBoxChoose.TabStop = false;
            this.groupBoxChoose.Text = "Выбор элемента рисования:";
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(7, 106);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(85, 21);
            this.radioButtonLine.TabIndex = 3;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Отрезок";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(7, 78);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(112, 21);
            this.radioButtonTriangle.TabIndex = 2;
            this.radioButtonTriangle.TabStop = true;
            this.radioButtonTriangle.Text = "Треугольник";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(7, 50);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(84, 21);
            this.radioButtonRectangle.TabIndex = 1;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Квадрат";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(7, 22);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(58, 21);
            this.radioButtonEllipse.TabIndex = 0;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Круг";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxColor.Controls.Add(this.radioButtonRed);
            this.groupBoxColor.Controls.Add(this.radioButtonOrange);
            this.groupBoxColor.Controls.Add(this.radioButtonYellow);
            this.groupBoxColor.Location = new System.Drawing.Point(619, 153);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(251, 131);
            this.groupBoxColor.TabIndex = 2;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвет:";
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.BackColor = System.Drawing.Color.Lime;
            this.radioButtonGreen.Location = new System.Drawing.Point(7, 103);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(88, 21);
            this.radioButtonGreen.TabIndex = 3;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Зелёный";
            this.radioButtonGreen.UseVisualStyleBackColor = false;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.BackColor = System.Drawing.Color.Red;
            this.radioButtonRed.Location = new System.Drawing.Point(7, 22);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(87, 21);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Красный";
            this.radioButtonRed.UseVisualStyleBackColor = false;
            // 
            // radioButtonOrange
            // 
            this.radioButtonOrange.AutoSize = true;
            this.radioButtonOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButtonOrange.Location = new System.Drawing.Point(7, 49);
            this.radioButtonOrange.Name = "radioButtonOrange";
            this.radioButtonOrange.Size = new System.Drawing.Size(106, 21);
            this.radioButtonOrange.TabIndex = 1;
            this.radioButtonOrange.TabStop = true;
            this.radioButtonOrange.Text = "Оранжевый";
            this.radioButtonOrange.UseVisualStyleBackColor = false;
            // 
            // radioButtonYellow
            // 
            this.radioButtonYellow.AutoSize = true;
            this.radioButtonYellow.BackColor = System.Drawing.Color.Yellow;
            this.radioButtonYellow.Location = new System.Drawing.Point(7, 76);
            this.radioButtonYellow.Name = "radioButtonYellow";
            this.radioButtonYellow.Size = new System.Drawing.Size(83, 21);
            this.radioButtonYellow.TabIndex = 2;
            this.radioButtonYellow.TabStop = true;
            this.radioButtonYellow.Text = "Жёлтый";
            this.radioButtonYellow.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(625, 527);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(245, 56);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить полотно";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelCoords
            // 
            this.labelCoords.AutoSize = true;
            this.labelCoords.Location = new System.Drawing.Point(626, 590);
            this.labelCoords.Name = "labelCoords";
            this.labelCoords.Size = new System.Drawing.Size(136, 17);
            this.labelCoords.TabIndex = 4;
            this.labelCoords.Text = "Координаты мыши:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 628);
            this.Controls.Add(this.labelCoords);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxChoose);
            this.Controls.Add(this.panelPaint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBoxChoose.ResumeLayout(false);
            this.groupBoxChoose.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPaint;
        private System.Windows.Forms.GroupBox groupBoxChoose;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonOrange;
        private System.Windows.Forms.RadioButton radioButtonYellow;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelCoords;
    }
}

