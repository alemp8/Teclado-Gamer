namespace Teclado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnMayuscula.Click += btnMayuscula_Click;
        }
        private bool mayuscula = false;
        private void btnEspacio_Click(object sender, EventArgs e) { tb.Text += " "; }
        private void btnq_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "Q"; } else { tb.Text += "q"; } }
        private void btnW_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "W"; } else { tb.Text += "w"; } }
        private void btnE_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "E"; } else { tb.Text += "e"; } }
        private void btnR_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "R"; } else { tb.Text += "r"; } }
        private void btnT_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "T"; } else { tb.Text += "t"; } }
        private void btnY_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "Y"; } else { tb.Text += "y"; } }
        private void btnU_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "U"; } else { tb.Text += "u"; } }
        private void btnI_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "I"; } else { tb.Text += "i"; } }
        private void btnO_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "O"; } else { tb.Text += "o"; } }
        private void btnP_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "P"; } else { tb.Text += "p"; } }
        private void btnCorchete_Click(object sender, EventArgs e) { tb.Text += "["; }
        private void btnCorcheteCierre_Click(object sender, EventArgs e) { tb.Text += "]"; }
        private void btnA_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "A"; } else { tb.Text += "a"; } }
        private void btnS_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "S"; } else { tb.Text += "s"; } }
        private void btnD_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "D"; } else { tb.Text += "d"; } }
        private void btnF_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "F"; } else { tb.Text += "f"; } }
        private void btnG_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "G"; } else { tb.Text += "g"; } }
        private void btnH_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "H"; } else { tb.Text += "h"; } }
        private void btnJ_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "J"; } else { tb.Text += "j"; } }
        private void btnK_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "K"; } else { tb.Text += "k"; } }
        private void btnL_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "L"; } else { tb.Text += "l"; } }
        private void btnPuntoyComa_Click(object sender, EventArgs e) { tb.Text += ";"; }
        private void btnVirgulilla_Click(object sender, EventArgs e) { tb.Text += "'"; }
        private void btnZ_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "Z"; } else { tb.Text += "z"; } }
        private void btnX_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "X"; } else { tb.Text += "x"; } }
        private void btnC_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "C"; } else { tb.Text += "c"; } }
        private void btnV_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "V"; } else { tb.Text += "v"; } }
        private void btnB_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "B"; } else { tb.Text += "b"; } }
        private void btnN_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "N"; } else { tb.Text += "n"; } }
        private void btnM_Click(object sender, EventArgs e) { if (mayuscula == true) { tb.Text += "M"; } else { tb.Text += "m"; } }
        private void btnComa_Click(object sender, EventArgs e) { tb.Text += ","; }
        private void btnPunto_Click(object sender, EventArgs e) { tb.Text += "."; }
        private void btnPleca_Click(object sender, EventArgs e) { tb.Text += "/"; }
        private void btnTab_Click(object sender, EventArgs e) { tb.Text += "    "; }
        private void btnSuma_Click(object sender, EventArgs e) { tb.Text += "+"; }
        private void btn1_Click(object sender, EventArgs e) { tb.Text += "1"; }
        private void btn2_Click(object sender, EventArgs e) { tb.Text += "2"; }
        private void btn3_Click(object sender, EventArgs e) { tb.Text += "3"; }
        private void btn4_Click(object sender, EventArgs e) { tb.Text += "4"; }
        private void btn5_Click(object sender, EventArgs e) { tb.Text += "5"; }
        private void btn6_Click(object sender, EventArgs e) { tb.Text += "6"; }
        private void btn7_Click(object sender, EventArgs e) { tb.Text += "7"; }
        private void btn8_Click(object sender, EventArgs e) { tb.Text += "8"; }
        private void btn9_Click(object sender, EventArgs e) { tb.Text += "9"; }
        private void btn0_Click(object sender, EventArgs e) { tb.Text += "0"; }
        private void btnguion_Click(object sender, EventArgs e) { tb.Text += "-"; }
        private void btnIgual_Click(object sender, EventArgs e) { tb.Text += "="; }
        private void btnEnter_Click(object sender, EventArgs e) { tb.Text += "\r\n"; }


        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 49) { btn1.ForeColor = Color.Red; btn1.FlatAppearance.BorderColor = Color.Red; }
            else if (e.KeyCode == Keys.D2) { btn2.ForeColor = Color.Red; btn2.FlatAppearance.BorderColor = Color.Red; }
            else if (e.KeyCode == Keys.D3) { btn3.ForeColor = Color.Red; btn3.FlatAppearance.BorderColor = Color.Red; }
            else if (e.KeyCode == Keys.D4) { btn4.ForeColor = Color.Red; btn4.FlatAppearance.BorderColor = Color.Red; }
            else if (e.KeyCode == Keys.D5) { btn5.ForeColor = Color.Red; btn5.FlatAppearance.BorderColor = Color.Red; }
            else if (e.KeyCode == Keys.D6) { btn6.ForeColor = Color.Red; btn6.FlatAppearance.BorderColor = Color.Red; }
            else if (e.KeyCode == Keys.D7) { btn7.ForeColor = Color.Red; btn7.FlatAppearance.BorderColor = Color.Red; }
            else if (e.KeyCode == Keys.D8) { btn8.ForeColor = Color.Red; btn8.FlatAppearance.BorderColor = Color.Red; }
            else if (e.KeyCode == Keys.D9) { btn9.ForeColor = Color.Red; btn9.FlatAppearance.BorderColor = Color.Red; }
            else if (e.KeyCode == Keys.D0) { btn0.ForeColor = Color.Red; btn0.FlatAppearance.BorderColor = Color.Red; }
            else if (e.KeyValue == 81) { btnq.ForeColor = Color.OrangeRed; btnq.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 87) { btnW.ForeColor = Color.OrangeRed; btnW.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 69) { btnE.ForeColor = Color.OrangeRed; btnE.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 82) { btnR.ForeColor = Color.OrangeRed; btnR.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 84) { btnT.ForeColor = Color.OrangeRed; btnT.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 89) { btnY.ForeColor = Color.OrangeRed; btnY.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 85) { btnU.ForeColor = Color.OrangeRed; btnU.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 86) { btnV.ForeColor = Color.OrangeRed; btnV.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 87) { btnW.ForeColor = Color.OrangeRed; btnW.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 88) { btnX.ForeColor = Color.OrangeRed; btnX.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 90) { btnZ.ForeColor = Color.OrangeRed; btnZ.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 65) { btnA.ForeColor = Color.OrangeRed; btnA.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 66) { btnB.ForeColor = Color.OrangeRed; btnB.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 67) { btnC.ForeColor = Color.OrangeRed; btnC.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 68) { btnD.ForeColor = Color.OrangeRed; btnD.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 70) { btnF.ForeColor = Color.OrangeRed; btnF.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 71) { btnG.ForeColor = Color.OrangeRed; btnG.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 72) { btnH.ForeColor = Color.OrangeRed; btnH.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 73) { btnI.ForeColor = Color.OrangeRed; btnI.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 74) { btnJ.ForeColor = Color.OrangeRed; btnJ.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 75) { btnK.ForeColor = Color.OrangeRed; btnK.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 76) { btnL.ForeColor = Color.OrangeRed; btnL.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 77) { btnM.ForeColor = Color.OrangeRed; btnM.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 78) { btnN.ForeColor = Color.OrangeRed; btnN.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 79) { btnO.ForeColor = Color.OrangeRed; btnO.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 80) { btnP.ForeColor = Color.OrangeRed; btnP.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (e.KeyValue == 83) { btnS.ForeColor = Color.OrangeRed; btnS.FlatAppearance.BorderColor = Color.OrangeRed; }
            else if (Control.IsKeyLocked(Keys.CapsLock)) { btnMayuscula.ForeColor = Color.OrangeRed; btnMayuscula.FlatAppearance.BorderColor = Color.OrangeRed; }
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && Control.IsKeyLocked(Keys.CapsLock))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void tb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 49) { btn1.ForeColor = Color.Lime; btn1.FlatAppearance.BorderColor = Color.Lime; }
            else if (e.KeyCode == Keys.D2) { btn2.ForeColor = Color.Lime; btn2.FlatAppearance.BorderColor = Color.Lime; }
            else if (e.KeyCode == Keys.D3) { btn3.ForeColor = Color.Lime; btn3.FlatAppearance.BorderColor = Color.Lime; }
            else if (e.KeyCode == Keys.D4) { btn4.ForeColor = Color.Lime; btn4.FlatAppearance.BorderColor = Color.Lime; }
            else if (e.KeyCode == Keys.D5) { btn5.ForeColor = Color.Lime; btn5.FlatAppearance.BorderColor = Color.Lime; }
            else if (e.KeyCode == Keys.D6) { btn6.ForeColor = Color.Lime; btn6.FlatAppearance.BorderColor = Color.Lime; }
            else if (e.KeyCode == Keys.D7) { btn7.ForeColor = Color.Lime; btn7.FlatAppearance.BorderColor = Color.Lime; }
            else if (e.KeyCode == Keys.D8) { btn8.ForeColor = Color.Lime; btn8.FlatAppearance.BorderColor = Color.Lime; }
            else if (e.KeyCode == Keys.D9) { btn9.ForeColor = Color.Lime; btn9.FlatAppearance.BorderColor = Color.Lime; }
            else if (e.KeyCode == Keys.D0) { btn0.ForeColor = Color.Lime; btn0.FlatAppearance.BorderColor = Color.Lime; }
            else if (e.KeyValue == 81) { btnq.ForeColor = Color.YellowGreen; btnq.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 87) { btnW.ForeColor = Color.YellowGreen; btnW.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 69) { btnE.ForeColor = Color.YellowGreen; btnE.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 82) { btnR.ForeColor = Color.YellowGreen; btnR.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 84) { btnT.ForeColor = Color.YellowGreen; btnT.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 89) { btnY.ForeColor = Color.YellowGreen; btnY.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 85) { btnU.ForeColor = Color.YellowGreen; btnU.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 86) { btnV.ForeColor = Color.YellowGreen; btnV.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 87) { btnW.ForeColor = Color.YellowGreen; btnW.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 88) { btnX.ForeColor = Color.YellowGreen; btnX.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 90) { btnZ.ForeColor = Color.YellowGreen; btnZ.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 91) { btnCorchete.ForeColor = Color.YellowGreen; btnCorchete.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 93) { btnCorcheteCierre.ForeColor = Color.YellowGreen; btnCorcheteCierre.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 65) { btnA.ForeColor = Color.YellowGreen; btnA.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 66) { btnB.ForeColor = Color.YellowGreen; btnB.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 67) { btnC.ForeColor = Color.YellowGreen; btnC.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 68) { btnD.ForeColor = Color.YellowGreen; btnD.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 70) { btnF.ForeColor = Color.YellowGreen; btnF.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 71) { btnG.ForeColor = Color.YellowGreen; btnG.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 72) { btnH.ForeColor = Color.YellowGreen; btnH.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 73) { btnI.ForeColor = Color.YellowGreen; btnI.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 74) { btnJ.ForeColor = Color.YellowGreen; btnJ.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 75) { btnK.ForeColor = Color.YellowGreen; btnK.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 76) { btnL.ForeColor = Color.YellowGreen; btnL.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 77) { btnM.ForeColor = Color.YellowGreen; btnM.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 78) { btnN.ForeColor = Color.YellowGreen; btnN.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 79) { btnO.ForeColor = Color.YellowGreen; btnO.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 80) { btnP.ForeColor = Color.YellowGreen; btnP.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (e.KeyValue == 83) { btnS.ForeColor = Color.YellowGreen; btnS.FlatAppearance.BorderColor = Color.YellowGreen; }
            else if (Control.IsKeyLocked(Keys.CapsLock)) { btnMayuscula.ForeColor = Color.YellowGreen; btnMayuscula.FlatAppearance.BorderColor = Color.YellowGreen; }
        }

        private void btn1_MouseDown(object sender, MouseEventArgs e) { btn1.ForeColor = Color.Red; btn1.FlatAppearance.BorderColor = Color.Red; }
        private void btn2_MouseDown(object sender, MouseEventArgs e) { btn2.ForeColor = Color.Red; btn2.FlatAppearance.BorderColor = Color.Red; }
        private void btn3_MouseDown(object sender, MouseEventArgs e) { btn3.ForeColor = Color.Red; btn3.FlatAppearance.BorderColor = Color.Red; }
        private void btn4_MouseDown(object sender, MouseEventArgs e) { btn4.ForeColor = Color.Red; btn4.FlatAppearance.BorderColor = Color.Red; }
        private void btn5_MouseDown(object sender, MouseEventArgs e) { btn5.ForeColor = Color.Red; btn5.FlatAppearance.BorderColor = Color.Red; }
        private void btn6_MouseDown(object sender, MouseEventArgs e) { btn6.ForeColor = Color.Red; btn6.FlatAppearance.BorderColor = Color.Red; }
        private void btn7_MouseDown(object sender, MouseEventArgs e) { btn7.ForeColor = Color.Red; btn7.FlatAppearance.BorderColor = Color.Red; }
        private void btn8_MouseDown(object sender, MouseEventArgs e) { btn8.ForeColor = Color.Red; btn8.FlatAppearance.BorderColor = Color.Red; }
        private void btn9_MouseDown(object sender, MouseEventArgs e) { btn9.ForeColor = Color.Red; btn9.FlatAppearance.BorderColor = Color.Red; }
        private void btn0_MouseDown(object sender, MouseEventArgs e) { btn0.ForeColor = Color.Red; btn0.FlatAppearance.BorderColor = Color.Red; }
        private void btnq_MouseDown(object sender, MouseEventArgs e) { btnq.ForeColor = Color.OrangeRed; btnq.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnW_MouseDown(object sender, MouseEventArgs e) { btnW.ForeColor = Color.OrangeRed; btnW.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnE_MouseDown(object sender, MouseEventArgs e) { btnE.ForeColor = Color.OrangeRed; btnE.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnR_MouseDown(object sender, MouseEventArgs e) { btnR.ForeColor = Color.OrangeRed; btnR.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnT_MouseDown(object sender, MouseEventArgs e) { btnT.ForeColor = Color.OrangeRed; btnT.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnY_MouseDown(object sender, MouseEventArgs e) { btnY.ForeColor = Color.OrangeRed; btnY.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnU_MouseDown(object sender, MouseEventArgs e) { btnU.ForeColor = Color.OrangeRed; btnU.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnI_MouseDown(object sender, MouseEventArgs e) { btnI.ForeColor = Color.OrangeRed; btnI.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnO_MouseDown(object sender, MouseEventArgs e) { btnO.ForeColor = Color.OrangeRed; btnO.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnP_MouseDown(object sender, MouseEventArgs e) { btnP.ForeColor = Color.OrangeRed; btnP.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnA_MouseDown(object sender, MouseEventArgs e) { btnA.ForeColor = Color.OrangeRed; btnA.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnS_MouseDown(object sender, MouseEventArgs e) { btnS.ForeColor = Color.OrangeRed; btnS.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnD_MouseDown(object sender, MouseEventArgs e) { btnD.ForeColor = Color.OrangeRed; btnD.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnF_MouseDown(object sender, MouseEventArgs e) { btnF.ForeColor = Color.OrangeRed; btnF.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnG_MouseDown(object sender, MouseEventArgs e) { btnG.ForeColor = Color.OrangeRed; btnG.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnH_MouseDown(object sender, MouseEventArgs e) { btnH.ForeColor = Color.OrangeRed; btnH.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnJ_MouseDown(object sender, MouseEventArgs e) { btnJ.ForeColor = Color.OrangeRed; btnJ.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnK_MouseDown(object sender, MouseEventArgs e) { btnK.ForeColor = Color.OrangeRed; btnK.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnL_MouseDown(object sender, MouseEventArgs e) { btnL.ForeColor = Color.OrangeRed; btnL.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnZ_MouseDown(object sender, MouseEventArgs e) { btnZ.ForeColor = Color.OrangeRed; btnZ.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnX_MouseDown(object sender, MouseEventArgs e) { btnX.ForeColor = Color.OrangeRed; btnX.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnC_MouseDown(object sender, MouseEventArgs e) { btnC.ForeColor = Color.OrangeRed; btnC.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnV_MouseDown(object sender, MouseEventArgs e) { btnV.ForeColor = Color.OrangeRed; btnV.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnB_MouseDown(object sender, MouseEventArgs e) { btnB.ForeColor = Color.OrangeRed; btnB.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnN_MouseDown(object sender, MouseEventArgs e) { btnN.ForeColor = Color.OrangeRed; btnN.FlatAppearance.BorderColor = Color.OrangeRed; }
        private void btnM_MouseDown(object sender, MouseEventArgs e) { btnM.ForeColor = Color.OrangeRed; btnM.FlatAppearance.BorderColor = Color.OrangeRed; }


        private void btn1_MouseUp(object sender, MouseEventArgs e) { btn1.ForeColor = Color.Lime; btn1.FlatAppearance.BorderColor = Color.Lime; }
        private void btn2_MouseUp(object sender, MouseEventArgs e) { btn2.ForeColor = Color.Lime; btn2.FlatAppearance.BorderColor = Color.Lime; }
        private void btn3_MouseUp(object sender, MouseEventArgs e) { btn3.ForeColor = Color.Lime; btn3.FlatAppearance.BorderColor = Color.Lime; }
        private void btn4_MouseUp(object sender, MouseEventArgs e) { btn4.ForeColor = Color.Lime; btn4.FlatAppearance.BorderColor = Color.Lime; }
        private void btn5_MouseUp(object sender, MouseEventArgs e) { btn5.ForeColor = Color.Lime; btn5.FlatAppearance.BorderColor = Color.Lime; }
        private void btn6_MouseUp(object sender, MouseEventArgs e) { btn6.ForeColor = Color.Lime; btn6.FlatAppearance.BorderColor = Color.Lime; }
        private void btn7_MouseUp(object sender, MouseEventArgs e) { btn7.ForeColor = Color.Lime; btn7.FlatAppearance.BorderColor = Color.Lime; }
        private void btn8_MouseUp(object sender, MouseEventArgs e) { btn8.ForeColor = Color.Lime; btn8.FlatAppearance.BorderColor = Color.Lime; }
        private void btn9_MouseUp(object sender, MouseEventArgs e) { btn9.ForeColor = Color.Lime; btn9.FlatAppearance.BorderColor = Color.Lime; }
        private void btn0_MouseUp(object sender, MouseEventArgs e) { btn0.ForeColor = Color.Lime; btn0.FlatAppearance.BorderColor = Color.Lime; }

        private void btnq_MouseUp(object sender, MouseEventArgs e)
        {
            btnq.ForeColor = Color.YellowGreen; btnq.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnW_MouseUp(object sender, MouseEventArgs e)
        {
            btnW.ForeColor = Color.YellowGreen; btnW.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnE_MouseUp(object sender, MouseEventArgs e)
        {
            btnE.ForeColor = Color.YellowGreen; btnE.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnR_MouseUp(object sender, MouseEventArgs e)
        {
            btnR.ForeColor = Color.YellowGreen; btnR.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnT_MouseUp(object sender, MouseEventArgs e)
        {
            btnT.ForeColor = Color.YellowGreen; btnT.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnY_MouseUp(object sender, MouseEventArgs e)
        {
            btnY.ForeColor = Color.YellowGreen; btnY.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnU_MouseUp(object sender, MouseEventArgs e)
        {
            btnU.ForeColor = Color.YellowGreen; btnU.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnI_MouseUp(object sender, MouseEventArgs e)
        {
            btnI.ForeColor = Color.YellowGreen; btnI.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnO_MouseUp(object sender, MouseEventArgs e)
        {
            btnO.ForeColor = Color.YellowGreen; btnO.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnP_MouseUp(object sender, MouseEventArgs e)
        {
            btnP.ForeColor = Color.YellowGreen; btnP.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnA_MouseUp(object sender, MouseEventArgs e)
        {
            btnA.ForeColor = Color.YellowGreen; btnA.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnS_MouseUp(object sender, MouseEventArgs e)
        {
            btnS.ForeColor = Color.YellowGreen; btnS.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnD_MouseUp(object sender, MouseEventArgs e)
        {
            btnD.ForeColor = Color.YellowGreen; btnD.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnF_MouseUp(object sender, MouseEventArgs e)
        {
            btnF.ForeColor = Color.YellowGreen; btnF.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnG_MouseUp(object sender, MouseEventArgs e)
        {
            btnG.ForeColor = Color.YellowGreen; btnG.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnH_MouseUp(object sender, MouseEventArgs e)
        {
            btnH.ForeColor = Color.YellowGreen; btnH.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnJ_MouseUp(object sender, MouseEventArgs e)
        {
            btnJ.ForeColor = Color.YellowGreen; btnJ.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnK_MouseUp(object sender, MouseEventArgs e)
        {
            btnK.ForeColor = Color.YellowGreen; btnK.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnL_MouseUp(object sender, MouseEventArgs e)
        {
            btnL.ForeColor = Color.YellowGreen; btnL.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnZ_MouseUp(object sender, MouseEventArgs e)
        {
            btnZ.ForeColor = Color.YellowGreen; btnZ.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnX_MouseUp(object sender, MouseEventArgs e)
        {
            btnX.ForeColor = Color.YellowGreen; btnX.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnC_MouseUp(object sender, MouseEventArgs e)
        {
            btnC.ForeColor = Color.YellowGreen; btnC.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnV_MouseUp(object sender, MouseEventArgs e)
        {
            btnV.ForeColor = Color.YellowGreen; btnV.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnB_MouseUp(object sender, MouseEventArgs e)
        {
            btnB.ForeColor = Color.YellowGreen; btnB.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnN_MouseUp(object sender, MouseEventArgs e)
        {
            btnN.ForeColor = Color.YellowGreen; btnN.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnM_MouseUp(object sender, MouseEventArgs e)
        {
            btnM.ForeColor = Color.YellowGreen; btnM.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnMayuscula_Click(object sender, EventArgs e)
        {
            mayuscula = true;

        }

        private void btnTab_MouseDown(object sender, MouseEventArgs e)
        {
            btnTab.ForeColor = Color.OrangeRed; btnTab.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnTab_MouseUp(object sender, MouseEventArgs e)
        {
            btnTab.ForeColor = Color.YellowGreen; btnTab.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnMayuscula_MouseDown(object sender, MouseEventArgs e)
        {
            btnMayuscula.ForeColor = Color.OrangeRed; btnMayuscula.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnMayuscula_MouseUp(object sender, MouseEventArgs e)
        {
            btnMayuscula.ForeColor = Color.YellowGreen; btnMayuscula.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnMinuscula_Click(object sender, EventArgs e)
        {
            mayuscula = false;
        }

        private void btnMinuscula_MouseDown(object sender, MouseEventArgs e)
        {
            btnMinuscula.ForeColor = Color.OrangeRed; btnMinuscula.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnMinuscula_MouseUp(object sender, MouseEventArgs e)
        {
            btnMinuscula.ForeColor = Color.YellowGreen; btnMinuscula.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnCorchete_MouseDown(object sender, MouseEventArgs e)
        {
            btnCorchete.ForeColor = Color.OrangeRed; btnCorchete.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnCorchete_MouseUp(object sender, MouseEventArgs e)
        {
            btnCorchete.ForeColor = Color.YellowGreen; btnCorchete.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnCorcheteCierre_MouseDown(object sender, MouseEventArgs e)
        {
            btnCorcheteCierre.ForeColor = Color.OrangeRed; btnCorcheteCierre.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnCorcheteCierre_MouseUp(object sender, MouseEventArgs e)
        {
            btnCorcheteCierre.ForeColor = Color.YellowGreen; btnCorcheteCierre.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnPuntoyComa_MouseDown(object sender, MouseEventArgs e)
        {
            btnPuntoyComa.ForeColor = Color.OrangeRed; btnPuntoyComa.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnPuntoyComa_MouseUp(object sender, MouseEventArgs e)
        {
            btnPuntoyComa.ForeColor = Color.YellowGreen; btnPuntoyComa.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnVirgulilla_MouseDown(object sender, MouseEventArgs e)
        {
            btnVirgulilla.ForeColor = Color.OrangeRed; btnVirgulilla.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnVirgulilla_MouseUp(object sender, MouseEventArgs e)
        {
            btnVirgulilla.ForeColor = Color.YellowGreen; btnVirgulilla.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnComa_MouseDown(object sender, MouseEventArgs e)
        {
            btnComa.ForeColor = Color.OrangeRed; btnComa.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnComa_MouseUp(object sender, MouseEventArgs e)
        {
            btnComa.ForeColor = Color.YellowGreen; btnComa.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnPunto_MouseDown(object sender, MouseEventArgs e)
        {
            btnPunto.ForeColor = Color.OrangeRed; btnPunto.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnPunto_MouseUp(object sender, MouseEventArgs e)
        {
            btnPunto.ForeColor = Color.YellowGreen; btnPunto.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnPleca_MouseDown(object sender, MouseEventArgs e)
        {
            btnPleca.ForeColor = Color.OrangeRed; btnPleca.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnPleca_MouseUp(object sender, MouseEventArgs e)
        {
            btnPleca.ForeColor = Color.YellowGreen; btnPleca.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnEnter_MouseDown(object sender, MouseEventArgs e)
        {
            btnEnter.ForeColor = Color.OrangeRed; btnEnter.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnEnter_MouseUp(object sender, MouseEventArgs e)
        {
            btnEnter.ForeColor = Color.YellowGreen; btnEnter.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnguion_MouseDown(object sender, MouseEventArgs e)
        {
            btnguion.ForeColor = Color.OrangeRed; btnguion.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnguion_MouseUp(object sender, MouseEventArgs e)
        {
            btnguion.ForeColor = Color.YellowGreen; btnguion.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnIgual_MouseDown(object sender, MouseEventArgs e)
        {
            btnIgual.ForeColor = Color.OrangeRed; btnIgual.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnIgual_MouseUp(object sender, MouseEventArgs e)
        {
            btnIgual.ForeColor = Color.YellowGreen; btnIgual.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnEspacio_MouseDown(object sender, MouseEventArgs e)
        {
            btnEspacio.ForeColor = Color.OrangeRed; btnEspacio.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnEspacio_MouseUp(object sender, MouseEventArgs e)
        {
            btnEspacio.ForeColor = Color.YellowGreen; btnEspacio.FlatAppearance.BorderColor = Color.YellowGreen;
        }

        private void btnSuma_MouseDown(object sender, MouseEventArgs e)
        {
            btnSuma.ForeColor = Color.OrangeRed; btnSuma.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        private void btnSuma_MouseUp(object sender, MouseEventArgs e)
        {
            btnSuma.ForeColor = Color.YellowGreen; btnSuma.FlatAppearance.BorderColor = Color.YellowGreen;
        }
    }
}
