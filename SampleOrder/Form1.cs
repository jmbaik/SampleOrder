using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxKHOpenAPILib;

namespace SampleOrder
{
    public partial class Form1 : Form
    {
        List<StockBalance> stockBalances;
        public Form1()
        {
            InitializeComponent();
            loginButton.Click += Button_Clicked;
            requestButton.Click += Button_Clicked;
            axKHOpenAPI1.OnEventConnect += onEventConnect;
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;

        }

 

        private void onEventConnect(object sender, _DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if(e.nErrCode == 0)
            {
                string accountList = axKHOpenAPI1.GetLoginInfo("ACCNO");
                string[] accountArray = accountList.Split(';');
                for(int i=0; i<accountArray.Length; i++)
                {
                    accountComboBox.Items.Add(accountArray[i]);
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender.Equals(loginButton))
            {
                axKHOpenAPI1.CommConnect();
            } else if (sender.Equals(requestButton))
            {
                //opw00018 계좌평가잔고
                string 계좌번호 = accountComboBox.Text;
                axKHOpenAPI1.SetInputValue("계좌번호", 계좌번호);
                axKHOpenAPI1.SetInputValue("비밀번호", "");
                axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
                axKHOpenAPI1.SetInputValue("조회구분", "2");
                axKHOpenAPI1.CommRqData("계좌잔고평가내역", "opw00018", 0, "5000");
                stockBalances = new List<StockBalance>();
            }
        }

        private void onReceiveTrData(object sender, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            //MessageBox.Show("요청 결과가 전달되었습니다.");
            MessageBox.Show(e.sRQName + " ||| " + e.sTrCode);
            if (e.sRQName.Equals("계좌잔고평가내역"))
            {
                int 변수총매입금액 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총매입금액"));
                int 변수추정예탁자산 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "추정예탁자산"));
                int 변수총평가금액 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총평가금액"));
                int 변수총평가손익금액 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총평가손익금액"));

                예수금.Text = String.Format("{0:0,0}", 변수추정예탁자산);
                총매입금.Text = String.Format("{0:0,0}", 변수총매입금액);
                총평가금.Text = String.Format("{0:0,0}", 변수총평가금액);
                총손익금.Text = String.Format("{0:0,0}", 변수총평가손익금액);

                //멀티 데이터 
                int count = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                for (int i = 0; i < count; i++)
                {
                    string 종목번호1 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목번호").TrimStart('0');
                    string 종목명1 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    double 보유수량1 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량"));
                    double 매입가1 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입가"));
                    double 현재가1 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가"));
                    double 평가손익1 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "평가손익"));
                    double 수익률1 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "수익률(%)"));

                    StockBalance stockBalance = new StockBalance(종목번호1, 종목명1, 보유수량1, 매입가1, 현재가1, 평가손익1, 수익률1);
                    stockBalances.Add(stockBalance);
                }
                balanceDataGridView.DataSource = stockBalances;

            }
        }

    }

    class StockBalance
    {
        string itemCode { get; set; }
        string itemName { get; set; }
        double Amount { get; set; }
        double BuyingPrice { get; set; }
        double CurrentPrice { get; set; }
        double EstimatedProfit { get; set; }
        double ProfitRate { get; set; }
        public StockBalance(string 종목번호, string 종목명, double 보유수량, double 매입가, double 현재가, double 평가손익, double 수익률)
        {
            this.itemCode = 종목번호;
            this.itemName = 종목명;
            this.Amount = 보유수량;
            this.BuyingPrice = 매입가;
            this.CurrentPrice = 현재가;
            this.EstimatedProfit = 평가손익;
            this.ProfitRate = 수익률;
        }
    }
}
