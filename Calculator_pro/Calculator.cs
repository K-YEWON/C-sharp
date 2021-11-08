using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_pro
{
    public enum Operators { Add, Sub, Multi, Div } //열거형

    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent(); 
        }

        public int Result = 0;//연산 후 최종 결과 저장 변수
        public bool isNewNum = true;//연산 버튼이 클릭되는 순간 true -> 새로운 숫자로 바꿈, 새로운 숫자의 입력을 의미
        public Operators Opt = Operators.Add;

        private void Numbutton1_Click(object sender, EventArgs e)//sender : 어떤 오브젝트가 본 이벤트를 유발시켰는가??, EventArgs : 이벤트 좌표
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        public void SetNum(string num)
        {
            if (isNewNum) // 숫자입력 - 연산버튼 - 숫자완성 - 변수와 숫자 연산 - 첫번째 변수에 저장
            {
                NumScreen.Text = num;
                isNewNum = false; //들어온 숫자는 이제 새로운 숫자가 아님을 의미
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num; //0일때는 입력한 숫자로 변경
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num; //기존에 숫자가 있을경우엔 num만큼 더함
            }
        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            if (isNewNum == false) //새로운 수가 입력되었을 때만 처리
            {
                int num = int.Parse(NumScreen.Text); //String변수를 int로 변경

                if (Opt == Operators.Add)
                    Result = Result + num;
                else if (Opt == Operators.Sub)
                    Result = Result - num;
                else if (Opt == Operators.Multi)
                    Result = Result * num;
                else if (Opt == Operators.Div)
                    Result = Result / num;

                NumScreen.Text = Result.ToString();
                isNewNum = true; //새로운 숫자를 입력받는다는 의미
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "*")
                Opt = Operators.Multi;
            else if (optButton.Text == "/")
                Opt = Operators.Div;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }
    }
}
