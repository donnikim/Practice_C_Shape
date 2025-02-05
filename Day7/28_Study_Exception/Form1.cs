namespace _28_Study_Exception
{
    public partial class Form1 : Form
    {

        Dictionary<string, Color> _dColor = new Dictionary<string, Color>();
        Color oSelectColor = new Color();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dRet = cDialogColor.ShowDialog();
            if (dRet == DialogResult.OK)
            {
                pColor.BackColor = cDialogColor.Color;
            }

            lblColorName.Text = pColor.BackColor.ToString();

        }

        private void tbarAlpha_Scroll(object sender, EventArgs e)
        {
            pColor.BackColor = Color.FromArgb(tbarAlpha.Value, pColor.BackColor);
            lblColorName.Text = pColor.BackColor.ToString();
        }

        private void btnColorSave_Click(object sender, EventArgs e)
        {

            try
            {
                Color oColor = pColor.BackColor;
                _dColor.Add(oColor.ToString(), oColor);
                LBoxRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void LBoxRefresh()
        {

            try
            {
                lboxColor.Items.Clear();
                foreach (string okey in _dColor.Keys)
                {
                    lboxColor.Items.Add(okey);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnColorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //��ųʸ��� �ִ� �ش� ������ ���� �ϰ�

                if (lboxColor.SelectedItem != null && _dColor.ContainsKey(lboxColor.SelectedItem.ToString()))
                {
                    _dColor.Remove(lboxColor.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("������ Item�� ���ų� ������ Ű�� �����ϴ�.");
                }

                // List�� ȭ�鿡 �ٽ� �ѷ��ش�.
                LBoxRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            oSelectColor = _dColor[lboxColor.SelectedItem.ToString()];
        }

        private void Panel_Click(object sender, MouseEventArgs e)
        {
            try 
            { 
                Panel oPanel = sender as Panel;
                oPanel.BackColor = oSelectColor;
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.ToString());  
            }
        }
    }
}
