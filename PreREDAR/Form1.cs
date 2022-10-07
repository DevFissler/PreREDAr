using GroupDocs.Conversion;
using GroupDocs.Conversion.Contracts;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;
using System.Text;
using System.Xml.Linq;
using System.IO;


namespace PreREDAR
{
    public partial class Form1 : Form
    {

        String Filename = null;
        List<String> outputCsv = new();

        int filecount = 0;
        int count = 0;

        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("FileName", "���ϸ�");

        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void Button_Export_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt (*.txt)|*.txt";
                sfd.FileName = "RealEstateData.txt";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {

                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];


                            for (int i = 1; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + "\t";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 1; j < columnCount; j++)
                                {
                                    outputCsv[i + 1] += dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t";
                                }
                            }


                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ���ǻ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("http://rtdown.molit.go.kr/���� csv������ �ٿ� ���� ��\n\n�ٸ��̸����� ���忡�� txt(������ �и�)�� �����մϴ�.\n\n" +
                "����� �޸��� ������ �� ��\n\n�ٸ� �̸����� ���忡��\n\n���ڵ��� ANSI���� UTF-8�� ��ȯ�Ͽ�\n\n" +
                "�������ϰ� ���� ������ ������ ��\n\n" +
                "�� ���α׷����� �ε��Ͻø� �ѱ��� ������ �ʽ��ϴ�.\n\n\n" +
                "�� �������ϰ� ���� �������� ��ĥ ���ϵ��� �����ؾ�\n" +
                "   ������ �߻����� �ʽ��ϴ�. ���� �����ϰڽ��ϴ�.");
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.DefaultExt = "db";
            openFileDlg.Filter = "Files(*.xlsx;*.csv;*.txt)|*.xlsx;*.csv;*.txt";
            openFileDlg.ShowDialog();
            if (openFileDlg.FileName.Length > 0)
            {
                foreach (string filename in openFileDlg.FileNames)
                {
                    // taking full path of a file
                    string strPath = openFileDlg.FileName;

                    // initialize the value of filename

                    
                    // using the method
                    Filename = Path.GetFileName(strPath);
                }
            }
            else
            {
                Application.Restart();
            }


            StreamReader rd = new StreamReader(Filename);

            for (int i = 0; i < 16; i++)
            {

                string firstline = rd.ReadLine();

            }


            // �������� �� ������ ����
            while (!rd.EndOfStream)
            {
                // �� ������ �д´�
                string line = rd.ReadLine();

                // ������ �޸��� �и��Ͽ� �÷��� �����
                string[] cols = line.Split("\t");

                string[] sigudong = cols[0].Split(" ");


                count++;

                dataGridView1.Rows.Add(count, sigudong[0].Replace("\"", ""), sigudong[1].Replace("\"", ""), sigudong[2].Replace("\"", ""), cols[4].Replace("\"", ""), cols[5].Replace("\"", ""), cols[6].Substring(0, 4), cols[6].Substring(4), cols[7], cols[8].Replace("\"", "").Replace(",", ""), cols[9].Replace("\"", ""), cols[10].Replace("\"", ""));

            }

            TextBox_Count.Text = string.Format("{0:#,###}", count);

            MessageBox.Show("Data Added Successfully !!!", "Info");


        }

        private void Button_TestAdd_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openFileDlg = new OpenFileDialog();
                openFileDlg.DefaultExt = "db";
                openFileDlg.Filter = "Files(*.txt)|*.txt";
                openFileDlg.ShowDialog();
                if (openFileDlg.FileName.Length > 0)
                {
                    foreach (string filename in openFileDlg.FileNames)
                    {
                        // taking full path of a file
                        string strPath = openFileDlg.FileName;

                        // initialize the value of filename

                        // using the method
                        Filename = Path.GetFileName(strPath);
                        
                    }
                }
                else
                {
                    Application.Restart();
                }
            }
            catch
            {

            }

            StreamReader rd = new StreamReader(Filename);

            for (int i = 0; i < 16; i++)
            {

                string firstline = rd.ReadLine();



            }

            // �������� �� ������ ����
            while (!rd.EndOfStream)
            {
                // �� ������ �д´�
                string line = rd.ReadLine();

                count++;

                string[] cols = line.Split("\t");

                string[] sigudong = cols[0].Split(" ");

                String data = sigudong[0].Replace("\"", "") + "\t" + sigudong[1].Replace("\"", "") + "\t" + sigudong[2].Replace("\"", "") + "\t" + cols[4].Replace("\"", "") + "\t" + cols[5].Replace("\"", "") + "\t" + cols[6].Substring(0, 4) + "\t" + cols[6].Substring(4) + "\t" + cols[7] + "\t" + cols[8].Replace("\"", "").Replace(",", "") + "\t" + cols[9].Replace("\"", "") + "\t" + cols[10].Replace("\"", "") + "\t";


                outputCsv.Add(data);

            }

            filecount++;

            TextBox_FileCount.Text = filecount.ToString();

            dataGridView1.Rows.Add(Filename);

            TextBox_Count.Text = string.Format("{0:#,###}", count);

            MessageBox.Show("Data Added Successfully !!!", "Info");

        }

        private void Button_TestExport_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt (*.txt)|*.txt";
                sfd.FileName = "test.txt";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {

                        try
                        {


                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������(oruma66@naver.com)�� ���� ���۵Ǿ����ϴ�");
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            outputCsv.Clear();
            count = 0;
            filecount = 0;
            TextBox_FileCount.Text = filecount.ToString(); ;
            TextBox_Count.Clear();

        }

        private void Button_Convert_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.DefaultExt = "db";
            openFileDlg.Filter = "Files(*.csv;*.txt)|*.csv;*.txt";
            openFileDlg.ShowDialog();
            if (openFileDlg.FileName.Length > 0)
            {
                foreach (string filename in openFileDlg.FileNames)
                {
                    // taking full path of a file
                    string strPath = openFileDlg.FileName;

                    // initialize the value of filename

                    // using the method
                    Filename = Path.GetFileName(strPath);
                }
            }
            else
            {
                Application.Restart();
            }

            var reader = new StreamReader(Filename, Encoding.GetEncoding("UTF-8"));

            // Load CSV file
            var converter = new GroupDocs.Conversion.Converter(Filename);
            // Set conversion parameters for TXT format

            var convertOptions = converter.GetPossibleConversions()["tsv"].ConvertOptions;

            // Convert to TXT format
            converter.Convert(Filename + ".txt", convertOptions);

            MessageBox.Show("Conversion Completed", "Info");
        }


    }
}