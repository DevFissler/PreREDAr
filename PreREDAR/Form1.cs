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

            dataGridView1.Columns.Add("FileName", "파일명");

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 주의사항ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("http://rtdown.molit.go.kr/에서 csv파일을 다운 받은 후\n\n다른이름으로 저장에서 txt(탭으로 분리)로 저장합니다.\n\n" +
                "저장된 메모장 파일을 연 뒤\n\n다른 이름으로 저장에서\n\n인코딩을 ANSI에서 UTF-8로 변환하여\n\n" +
                "실행파일과 같은 폴더에 저장한 후\n\n" +
                "이 프로그램으로 로드하시면 한글이 깨지지 않습니다.\n\n\n" +
                "※ 실행파일과 같은 폴더내에 합칠 파일들이 존재해야\n" +
                "   오류가 발생하지 않습니다. 추후 개선하겠습니다.");
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


            // 마지막이 될 때까지 루프
            while (!rd.EndOfStream)
            {
                // 한 라인을 읽는다
                string line = rd.ReadLine();

                // 라인을 콤마로 분리하여 컬럼을 만든다
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

            // 마지막이 될 때까지 루프
            while (!rd.EndOfStream)
            {
                // 한 라인을 읽는다
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

        private void 제작자ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안재형(oruma66@naver.com)에 의해 제작되었습니다");
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