namespace cancellation_token
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskStatusLabel = new Label();
            taskStatus = new Label();
            startTaskButton = new Button();
            stopTaskButton = new Button();
            checkStatusButton = new Button();
            testConsoleOutButton = new Button();
            SuspendLayout();
            // 
            // taskStatusLabel
            // 
            taskStatusLabel.AutoSize = true;
            taskStatusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskStatusLabel.Location = new Point(153, 320);
            taskStatusLabel.Name = "taskStatusLabel";
            taskStatusLabel.Size = new Size(123, 28);
            taskStatusLabel.TabIndex = 0;
            taskStatusLabel.Text = "Task Status:";
            // 
            // taskStatus
            // 
            taskStatus.AutoSize = true;
            taskStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskStatus.Location = new Point(282, 320);
            taskStatus.Name = "taskStatus";
            taskStatus.Size = new Size(196, 28);
            taskStatus.TabIndex = 1;
            taskStatus.Text = "TASK NOT RUNNING";
            // 
            // startTaskButton
            // 
            startTaskButton.Location = new Point(153, 401);
            startTaskButton.Name = "startTaskButton";
            startTaskButton.Size = new Size(150, 29);
            startTaskButton.TabIndex = 2;
            startTaskButton.Text = "Start Task";
            startTaskButton.UseVisualStyleBackColor = true;
            startTaskButton.Click += startTaskButton_Click;
            // 
            // stopTaskButton
            // 
            stopTaskButton.Location = new Point(465, 401);
            stopTaskButton.Name = "stopTaskButton";
            stopTaskButton.Size = new Size(150, 29);
            stopTaskButton.TabIndex = 3;
            stopTaskButton.Text = "Stop Task";
            stopTaskButton.UseVisualStyleBackColor = true;
            stopTaskButton.Click += stopTaskButton_Click;
            // 
            // checkStatusButton
            // 
            checkStatusButton.Location = new Point(309, 401);
            checkStatusButton.Name = "checkStatusButton";
            checkStatusButton.Size = new Size(150, 29);
            checkStatusButton.TabIndex = 4;
            checkStatusButton.Text = "Check Task Status";
            checkStatusButton.UseVisualStyleBackColor = true;
            checkStatusButton.Click += checkStatusButton_Click;
            // 
            // testConsoleOutButton
            // 
            testConsoleOutButton.Location = new Point(465, 436);
            testConsoleOutButton.Name = "testConsoleOutButton";
            testConsoleOutButton.Size = new Size(150, 29);
            testConsoleOutButton.TabIndex = 5;
            testConsoleOutButton.Text = "Write Console Message";
            testConsoleOutButton.UseVisualStyleBackColor = true;
            testConsoleOutButton.Click += testConsoleOutButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 753);
            Controls.Add(testConsoleOutButton);
            Controls.Add(checkStatusButton);
            Controls.Add(stopTaskButton);
            Controls.Add(startTaskButton);
            Controls.Add(taskStatus);
            Controls.Add(taskStatusLabel);
            Name = "MainForm";
            Text = "Cancellation Token";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taskStatusLabel;
        private Label taskStatus;
        private Button startTaskButton;
        private Button stopTaskButton;
        private Button checkStatusButton;
        private Button testConsoleOutButton;
    }
}
