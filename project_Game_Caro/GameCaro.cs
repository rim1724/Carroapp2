using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Game_Caro
{
    public partial class GameCaro : Form
    {
        #region Properties
        GameBoard board;
        SocketManager socket;
        string ipAddress;
        string PlayerName;
        int game;


        public GameCaro(int game, string ipAddress = "")
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.game = game;
            this.ipAddress = ipAddress;
            board = new GameBoard(pn_GameBoard, txt_PlayerName, pb_Avatar, game);
            board.PlayerClicked += Board_PlayerClicked;
            board.GameOver += Board_GameOver;

            pgb_CountDown.Step = Constance.CountDownStep;
            pgb_CountDown.Maximum = Constance.CountDownTime;

            tm_CountDown.Interval = Constance.CountDownInterval;
            socket = new SocketManager();

            txt_Chat.Text = "";



        }
        #endregion

        #region Methods

        void NewGame()
        {
            pgb_CountDown.Value = 0;
            tm_CountDown.Stop();

            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = true;

            btn_Undo.Enabled = true;
            btn_Redo.Enabled = true;

            board.DrawGameBoard();
        }

        void EndGame()
        {
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;

            btn_Undo.Enabled = false;
            btn_Redo.Enabled = false;

            tm_CountDown.Stop();
            pn_GameBoard.Enabled = false;


        }

        private void GameCaro_Load(object sender, EventArgs e)
        {
            lbl_About.Text = "Lập trình mạng Nhóm 5";
            tm_About.Enabled = true;
            if (game == 1)
            {
                Btn_AI_Click(this, EventArgs.Empty);
            }
            else if (game == 2)
            {
                Btn_LAN_Click(this, EventArgs.Empty);
            }
            else if (game == 3)
            {
                Btn_SameCom_Click(this, EventArgs.Empty);
            }

        }

        private void GameCaro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
                Close();
            }
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch (Exception ex)
                {
                    // Log or handle exception
                    Console.WriteLine(ex.Message);
                }
            }
        }


        private void Board_PlayerClicked(object sender, BtnClickEvent e)
        {
            tm_CountDown.Start();
            pgb_CountDown.Value = 0;

            if (board.PlayMode == 1)
            {
                try
                {
                    pn_GameBoard.Enabled = false;
                    socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));

                    undoToolStripMenuItem.Enabled = false;
                    redoToolStripMenuItem.Enabled = false;

                    btn_Undo.Enabled = false;
                    btn_Redo.Enabled = false;

                    Listen();
                }
                catch
                {
                    EndGame();
                    MessageBox.Show("Không có kết nối nào tới máy đối thủ", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Board_GameOver(object sender, EventArgs e)
        {
            EndGame();

            if (board.PlayMode == 1)
                socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
            MessageBox.Show("Kết thúc trận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //private void Board_GameOver(object sender, EventArgs e)
        //{
        //    EndGame();

        //    if (board.PlayMode == 1)
        //    {
        //        socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        //    }
        //    else if (board.PlayMode == 3) // Kiểm tra nếu đang chơi với AI
        //    {
        //        if (board.CurrentPlayer == 1)
        //        {
        //            MessageBox.Show("AI đã thắng!", "Kết thúc trận", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Bạn đã thắng!", "Kết thúc trận", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //}

        private void Tm_CountDown_Tick(object sender, EventArgs e)
        {
            pgb_CountDown.PerformStep();

            if (pgb_CountDown.Value >= pgb_CountDown.Maximum)
            {
                EndGame();

                if (board.PlayMode == 1)
                    socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
            }
        }

        private void Tm_About_Tick(object sender, EventArgs e)
        {
            lbl_About.Location = new Point(lbl_About.Location.X, lbl_About.Location.Y - 2);

            if (lbl_About.Location.Y + lbl_About.Height < 0)
                lbl_About.Location = new Point(lbl_About.Location.X, Grb_About.Height - 10);
        }

        #region MenuStrip
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();

            if (board.PlayMode == 1)
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
                }
                catch { }
            }

            pn_GameBoard.Enabled = true;
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgb_CountDown.Value = 0;
            board.Undo();

            if (board.PlayMode == 1)
                socket.Send(new SocketData((int)SocketCommand.UNDO, "", new Point()));
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // pgb_CountDown.Value = 0;
            board.Redo();

            if (board.PlayMode == 1)
                socket.Send(new SocketData((int)SocketCommand.REDO, "", new Point()));
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViaLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            board.PlayMode = 1;
            NewGame();

            socket.IP = ipAddress;

            if (!socket.ConnectServer())
            {
                socket.IsServer = true;
                pn_GameBoard.Enabled = true;
                socket.CreateServer();
                MessageBox.Show("Bạn đang là Server. Bạn là Player1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                socket.IsServer = false;
                pn_GameBoard.Enabled = false;
                Listen();
                MessageBox.Show("Kết nối thành công! Bạn là Player2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SameComToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (board.PlayMode == 1)
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }

                socket.CloseConnect();
                MessageBox.Show("Đã ngắt kết nối mạng LAN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            board.PlayMode = 2;
            NewGame();
        }

        private void PlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (board.PlayMode == 1)
            {
                if (board.PlayMode == 1)
                {
                    try
                    {
                        socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                    }
                    catch { }

                    socket.CloseConnect();
                    MessageBox.Show("Đã ngắt kết nối mạng LAN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            board.PlayMode = 3;
            NewGame();
            board.StartAI();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HowToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string instructions = "Hướng dẫn chơi:\n\n" +
                         "1. Trò chơi Caro là trò chơi trên bàn cờ 2 người chơi. Có thể chọn chơi với máy hoặc chơi 2 người.\n" +
                         "2. Mỗi người lần lượt đánh dấu của mình vào một ô trống trên bàn cờ.\n" +
                         "3. Lưu ý phải canh thời gian ở thanh bên phải. Nếu để hết giờ sẽ thua.\n" +
                         "4. Người chơi đầu tiên có 5 dấu liên tiếp theo hàng ngang, hàng dọc, hoặc đường chéo mà không bị chặn ở 2 đầu sẽ chiến thắng.";

            MessageBox.Show(instructions, "Hướng dẫn chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ContactMeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutThisGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Trò chơi:\n\n" +
                   "Đây là dự án Lập trình Game Caro do nhóm 5 thực hiện trong học phần Lập trình mạng " +
                   "do thầy Vũ Quốc Hưng hướng dẫn. Cảm ơn bạn đã truy cập!";

            MessageBox.Show(about, "Giới thiệu về trò chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Button Settings

        private void Btn_LAN_Click(object sender, EventArgs e)
        {
            ViaLANToolStripMenuItem_Click(sender, e);
        }

        private void Btn_SameCom_Click(object sender, EventArgs e)
        {
            SameComToolStripMenuItem_Click(sender, e);
        }

        private void Btn_AI_Click(object sender, EventArgs e)
        {
            PlayerToolStripMenuItem1_Click(sender, e);
        }

        private void Btn_Undo_Click(object sender, EventArgs e)
        {
            UndoToolStripMenuItem_Click(sender, e);
        }

        private void Btn_Redo_Click(object sender, EventArgs e)
        {
            RedoToolStripMenuItem_Click(sender, e);
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            if (board.PlayMode != 1)
                return;

            PlayerName = board.ListPlayers[socket.IsServer ? 0 : 1].Name;
            txt_Chat.Text += "- " + PlayerName + ": " + txt_Message.Text + "\r\n";
            txt_Message.Text = "";
            socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE, txt_Chat.Text, new Point()));
            Listen();
        }
        #endregion

        #region LAN settings
        private void GameCaro_Shown(object sender, EventArgs e)
        {
            txt_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(txt_IP.Text))
                txt_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
        }

        private void Listen()
        {
            Thread ListenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive<SocketData>();
                    ProcessData(data);
                }
                catch { }
            });

            ListenThread.IsBackground = true;
            ListenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            // Cập nhật tên người chơi hiện tại
            PlayerName = board.ListPlayers[board.CurrentPlayer == 1 ? 0 : 1].Name;

            switch (data.Command)
            {
                case (int)SocketCommand.SEND_POINT:
                    // Thực hiện nước đi từ đối thủ
                    this.Invoke((MethodInvoker)(() =>
                    {
                        board.OtherPlayerClicked(data.Point);
                        pn_GameBoard.Enabled = true;

                        // Khởi động lại đồng hồ đếm ngược
                        pgb_CountDown.Value = 0;
                        tm_CountDown.Start();

                        // Kích hoạt các chức năng Undo và Redo
                        undoToolStripMenuItem.Enabled = true;
                        redoToolStripMenuItem.Enabled = true;
                        btn_Undo.Enabled = true;
                        btn_Redo.Enabled = true;
                    }));
                    break;

                case (int)SocketCommand.SEND_MESSAGE:
                    // Hiển thị tin nhắn từ đối thủ
                    txt_Chat.Text = data.Message;
                    break;

                case (int)SocketCommand.NEW_GAME:
                    // Bắt đầu trò chơi mới và vô hiệu hóa bảng
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pn_GameBoard.Enabled = false;
                    }));
                    break;

                case (int)SocketCommand.UNDO:
                    // Thực hiện Undo từ đối thủ
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pgb_CountDown.Value = 0;
                        board.Undo();
                    }));
                    break;

                case (int)SocketCommand.REDO:
                    // Thực hiện Redo từ đối thủ
                    this.Invoke((MethodInvoker)(() =>
                    {
                        board.Redo();
                    }));
                    break;

                case (int)SocketCommand.END_GAME:
                    //Kết thúc trò chơi và hiển thị thông báo chiến thắng
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                        MessageBox.Show(PlayerName + " đã chiến thắng ♥ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));

                    break;

                case (int)SocketCommand.TIME_OUT:
                    // Thông báo hết giờ và kết thúc trò chơi
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                        MessageBox.Show("Hết giờ rồi !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;

                case (int)SocketCommand.QUIT:
                    // Xử lý khi đối thủ bỏ trận
                    this.Invoke((MethodInvoker)(() =>
                    {
                        tm_CountDown.Stop();
                        EndGame();

                        board.PlayMode = 2;  // Đặt lại chế độ chơi
                        socket.CloseConnect();

                        MessageBox.Show("Đối thủ đã bỏ trận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;

                default:
                    break;
            }

            // Lắng nghe tiếp các dữ liệu mới từ đối thủ
            Listen();
        }

        #endregion

        #endregion

        private void pn_GameBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Chat_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_About_Click(object sender, EventArgs e)
        {

        }

        private void Grb_About_Enter(object sender, EventArgs e)
        {

        }
    }
}
