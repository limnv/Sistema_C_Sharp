using System;
using System.Windows.Forms;

namespace Sistema_Limnv.View
{
    public partial class frmProtetor : Form
    {
        private Timer dataHoraAtual;
        private Timer TimerImagemMarketing;
        public frmProtetor()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            dataHoraAtual = new Timer
            {
                Interval = 1000
            };
            dataHoraAtual.Tick += AlterarLabelDataHora;
            dataHoraAtual.Start();

            TimerImagemMarketing = new Timer
            {
                Interval = 30000
            };
            TimerImagemMarketing.Tick += TimerImagemMarketingExecucao;
            TimerImagemMarketing.Start();

            int larguraTotal = pnlRodape.Size.Width;
            int largura = larguraTotal / 2;
            pnlInformacoes.Width = largura - 5;

            AleatorizarImagemMarketing();

        }

        private void AlterarLabelDataHora(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void TimerImagemMarketingExecucao(object sender, EventArgs e)
        {
            AleatorizarImagemMarketing();
        }

        private void AleatorizarImagemMarketing()
        {
            Random random = new Random();
            int num = random.Next(1,4);

            switch (num)
            {
                case 1:
                    pnlMarketing.BackgroundImage = ImgMarketing.Compras;
                    break;
                case 2:
                    pnlMarketing.BackgroundImage = ImgMarketing.Emprestimo;
                    break;
                case 3:
                    pnlMarketing.BackgroundImage = ImgMarketing.Exterior;
                    break;
                default:
                    pnlMarketing.BackgroundImage = ImgMarketing.Emprestimo;
                    break;
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                
            }
        }
    }
}
