using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace RegisterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "VTjLlaN2f7vj9K0T6maoMjmzHQAkxcURJkCa4uFv", BasePath = "https://register-e6a5c-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fbc);
            }
            catch
            {
                MessageBox.Show("문제 발생");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = client.Get("Register_List/" + textBox2.Text);
            Upload upd = result.ResultAs<Upload>();

            Upload upd2 = new Upload()
            {
                name = textBox1.Text, id = textBox2.Text, pw  = textBox3.Text
            };

            var send = client.Set("Register_List/" + textBox2.Text, upd2);
            MessageBox.Show("완료");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Upload upd2 = new Upload()
            {
                name = textBox1.Text,
                id = textBox2.Text,
                pw = textBox3.Text
            };
            var send = client.Set("Register_List/" + textBox2.Text, upd2);
            MessageBox.Show("수정완료");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = client.Get("Register_List/" + textBox2.Text);
            Upload upd = result.ResultAs<Upload>();
            if (textBox2.Text == null)
            {
                MessageBox.Show("정보를 입력하세요.");
            }
            else if (upd == null)
            {
                MessageBox.Show("입력한 정보를 보유하고 있지 않습니다.");
            }
            else
            {
                textBox1.Text = upd.name;
                textBox2.Text = upd.id;
                textBox3.Text = upd.pw;

                MessageBox.Show("Load");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                MessageBox.Show("정보를 기입해주세요");
            }
            else
            {
                var result = client.Delete("Register_List/" + textBox2.Text);
                MessageBox.Show("삭제 완료");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = client.Get("Register_List/" + textBox4.Text); // 파일 경로
            Upload upd = result.ResultAs<Upload>();

            if (upd == null || textBox5.Text != upd.pw) // DB ID정보가 없거나 같지 않다면 
            {
                MessageBox.Show("정보가 다릅니다.");

            }
            else 
            {
                MessageBox.Show("로그인 성공");
            }
            }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    }
