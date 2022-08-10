namespace EreignisEnter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lbl_help.Text = "Bitte geben Sie Nachname, Vorname ein";
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            lbl_help.Text = "Bitte geben Sie Nachname, Vorname ein";
        }

        private void chk_customer_Enter(object sender, EventArgs e)
        {
            lbl_help.Text = "Kreuzen Sie an, ob Sie bereits Kunde sind";
        }

        private void lst_parcel_service_Enter(object sender, EventArgs e)
        {
            lbl_help.Text = "Wählen Sie den Paketdienst aus";
        }

        private void rbtn_payment_method_CheckedChanged(object sender, EventArgs e)
        {
            lbl_help.Text = "Wählen Sie die Zahlungsform aus";
        }
    }

}