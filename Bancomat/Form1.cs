using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bancomat
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        
        int currentUserId = -1;
        double currentSold = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            mesaj_eroare_d.Visible = false;
            mesaj_confirm_d.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            mesaj_eroare_r.Visible = false;
            mesaj_eroare_r.Visible = false;
            mesaj_fondi.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pin_num.Text == "") pin_num.Text = "1";
            else pin_num.Text = pin_num.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pin_num.Text == "") pin_num.Text = "2";
            else pin_num.Text = pin_num.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pin_num.Text == "") pin_num.Text = "3";
            else pin_num.Text = pin_num.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pin_num.Text == "") pin_num.Text = "4";
            else pin_num.Text = pin_num.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pin_num.Text == "") pin_num.Text = "5";
            else pin_num.Text = pin_num.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pin_num.Text == "") pin_num.Text = "6";
            else pin_num.Text = pin_num.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pin_num.Text == "") pin_num.Text = "7";
            else pin_num.Text = pin_num.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pin_num.Text == "") pin_num.Text = "8";
            else pin_num.Text = pin_num.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (pin_num.Text == "") pin_num.Text = "9";
            else pin_num.Text = pin_num.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (pin_num.Text == "") pin_num.Text = "0";
            else pin_num.Text = pin_num.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tabControl1.Enabled == false)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Id, Sold FROM Users WHERE Pin=@pin", conn);
                cmd.Parameters.AddWithValue("@pin", pin_num.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    currentUserId = reader.GetInt32(0);
                    currentSold = reader.GetDouble(1);

                    sum_tot.Text = currentSold.ToString();

                    mesaj.Visible = false;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    tabControl1.Enabled = true;
                }
                else
                {
                    mesaj.Visible = true;
                    tabControl1.Enabled = false;
                }

                reader.Close();
                conn.Close();
            }
            else if (String.IsNullOrEmpty(suma_dep.Text) == false && String.IsNullOrEmpty(valuta.Text) == false && String.IsNullOrEmpty(cont.Text) == false)
            {
                if (cont.Text == "cont personal")
                {
                    try
                    {
                        double depositAmount = Convert.ToDouble(suma_dep.Text);

                        if (valuta.Text == "USD") depositAmount *= 4.63;
                        else if (valuta.Text == "EUR") depositAmount *= 4.98;

                        conn.Open();
                     
                        SqlCommand cmd = new SqlCommand(
                            "UPDATE Users SET Sold = Sold + @deposit WHERE Id = @id", conn);
                        cmd.Parameters.AddWithValue("@deposit", depositAmount);
                        cmd.Parameters.AddWithValue("@id", currentUserId);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        currentSold += depositAmount;
                        sum_tot.Text = currentSold.ToString();

                        suma_dep.Clear();
                        valuta.SelectedIndex = -1;
                        cont.SelectedIndex = -1;
                        mesaj_eroare_d.Visible = false;
                        mesaj_confirm_d.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
                else if (cont_iban.Text.Length != 24)
                {
                    mesaj_eroare_d.Visible = true;
                    mesaj_confirm_d.Visible = false;
                    cont_iban.ForeColor = Color.Red;
                }
                else if (cont.Text == "alt cont")
                {
                    if (cont_iban.Text.Length != 24)
                    {
                        // IBAN invalid
                        mesaj_eroare_d.Visible = true;
                        mesaj_confirm_d.Visible = false;
                        cont_iban.ForeColor = Color.Red;
                    }
                    else
                    {
                        try
                        {
                            double depositAmount = Convert.ToDouble(suma_dep.Text);

                            // convert currency to local currency
                            if (valuta.Text == "USD") depositAmount *= 4.63;
                            else if (valuta.Text == "EUR") depositAmount *= 4.98;

                            conn.Open();

                            // Check if IBAN exists
                            SqlCommand checkCmd = new SqlCommand(
                                "SELECT Id FROM Users WHERE IBAN=@iban", conn);
                            checkCmd.Parameters.AddWithValue("@iban", cont_iban.Text);
                            object result = checkCmd.ExecuteScalar();

                            if (result != null)
                            {
                                int targetUserId = Convert.ToInt32(result);

                                // Update target user's balance
                                SqlCommand updateCmd = new SqlCommand(
                                    "UPDATE Users SET Sold = Sold + @deposit WHERE Id=@id", conn);
                                updateCmd.Parameters.AddWithValue("@deposit", depositAmount);
                                updateCmd.Parameters.AddWithValue("@id", targetUserId);
                                updateCmd.ExecuteNonQuery();

                                // Show confirmation
                                mesaj_confirm_d.Visible = true;
                                mesaj_eroare_d.Visible = false;

                                // Clear controls
                                cont_iban.Clear();
                                suma_dep.Clear();
                                cont.SelectedIndex = -1;
                                valuta.SelectedIndex = -1;
                            }
                            else
                            {
                                // IBAN not found
                                mesaj_eroare_d.Visible = true;
                                mesaj_confirm_d.Visible = false;
                                cont_iban.ForeColor = Color.Red;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (conn.State == ConnectionState.Open) conn.Close();
                        }
                    }
                }
                else
                {
                    mesaj_eroare_d.Visible = false;
                    mesaj_confirm_d.Visible = true;
                    cont_iban.ForeColor = Color.Black;
                    cont_iban.Clear();
                    suma_dep.Clear();
                    valuta.SelectedIndex = -1;
                    cont.SelectedIndex = -1;
                }
            }
            else if (String.IsNullOrEmpty(sumfix_ret.Text) == false)
            {
                double retragere, sold;
                sold = Convert.ToDouble(sum_tot.Text);
                retragere = sold + 1;
                if (sumfix_ret.Text == "altă sumă")
                {
                    if (String.IsNullOrEmpty(suma_ret.Text) == false) retragere = Convert.ToDouble(suma_ret.Text);
                }
                else
                {
                    retragere = Convert.ToDouble(sumfix_ret.Text);
                }
                if (retragere > sold)
                {
                    if (sumfix_ret.Text == "altă sumă" && String.IsNullOrEmpty(suma_ret.Text) == true)
                    {
                        mesaj_eroare_r.Visible = true;
                        mesaj_confirm_r.Visible = false;
                        mesaj_fondi.Visible = false;
                    }
                    else
                    {
                        mesaj_fondi.Visible = true;
                        mesaj_eroare_r.Visible = false;
                        mesaj_confirm_r.Visible = false;
                    }
                }
                else
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(
                            "UPDATE Users SET Sold = Sold - @withdraw WHERE Id = @id", conn);
                        cmd.Parameters.AddWithValue("@withdraw", retragere);
                        cmd.Parameters.AddWithValue("@id", currentUserId);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        // Update current balance in UI
                        currentSold -= retragere;
                        sum_tot.Text = currentSold.ToString();

                        sumfix_ret.SelectedIndex = -1;
                        suma_ret.Clear();
                        suma_ret.Enabled = false;
                        mesaj_eroare_r.Visible = false;
                        mesaj_confirm_r.Visible = true;
                        mesaj_fondi.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open) conn.Close();
                    }
                }
            }
            else
            {
                mesaj_confirm_d.Visible = false;
                mesaj_confirm_r.Visible = false;
                mesaj_fondi.Visible = false;
                mesaj_eroare_d.Visible = true;
                mesaj_eroare_r.Visible = true;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pin_num.Text = "";
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            tabControl1.Enabled = false;
            currentUserId = -1;
            currentSold = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=AtmDB;Trusted_Connection=True;");

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            mesaj.Visible = false;
        }

        private void sumfix_ret_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sumfix_ret.Text == "altă sumă")
            {
                suma_ret.Enabled = true;
                textBox7.Enabled = true;
            }
            else
            {
                suma_ret.Enabled = false;
                textBox7.Enabled = false;
                suma_ret.Clear();
            }
        }

        private void cont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cont.Text == "alt cont")
            {
                textBox6.Enabled = true;
                cont_iban.Enabled = true;
            }
            else
            {
                cont_iban.Enabled = false;
                textBox6.Enabled = false;
                cont_iban.Clear();
            }
        }

        private void suma_dep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void suma_ret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cont_iban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
