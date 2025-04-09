using System.Threading.Tasks;

namespace cancellation_token
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public Task<string> ocrTask;
        public Thread testThread;
        public CancellationTokenSource tokenSource;
        public CancellationToken token;

        public async Task<string> ocr(CancellationToken token)
        {
            int count = 0;

            for (int i =0; i<5; i++)
            {
                token.ThrowIfCancellationRequested();
            
                await Task.Delay(15000);
                count++;
                this.Invoke(() =>
                {
                    taskStatus.Text = $"OCR {count} completed";
                });
                Console.WriteLine($"OCR {count} completed");
            }
            return "OCR complete!";
        }
        
        private async void startTaskButton_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;

            ocrTask = ocr(token);
            taskStatus.Text = "ocr Started.";
        }

        private async void checkStatusButton_Click(object sender, EventArgs e)
        {
            if (ocrTask == null)
            {
                taskStatus.Text = "No task is started.";
                Console.WriteLine("No task is started.");
            } else if (!ocrTask.IsCompleted)
            {
                taskStatus.Text = "Task is still running...";
                Console.WriteLine("Task is still running...");
            } else if (ocrTask.IsCanceled)
            {
                taskStatus.Text = "Task canceled.";
                Console.WriteLine("Task canceled.");
            }
            else
            {
                taskStatus.Text = await ocrTask;
            }
        }

        private void stopTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tokenSource != null && !tokenSource.IsCancellationRequested)
                {
                    tokenSource.Cancel();
                    taskStatus.Text = "Task cancelation requested.";
                    Console.WriteLine("Task cancelation requested, job will be canceled after the current job completes.");
                }
                else
                {
                    taskStatus.Text = "No cancelation token source.";
                    Console.WriteLine("No cancelation token source.");
                }
            } catch
            {
                Console.WriteLine("Error cancelling ocr task.");
            }

        }

        private void testConsoleOutButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Message Written to Console.");
        }
    }
}
