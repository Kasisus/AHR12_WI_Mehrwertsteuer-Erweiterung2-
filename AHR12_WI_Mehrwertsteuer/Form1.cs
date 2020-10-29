using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHR12_WI_Mehrwertsteuer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            double bruttobetrag19Eingabe = 0.0, mwstbetrag19Eingabe = 0.0, nettobetragEingabe = 0.0, bruttobetrag16Eingabe = 0.0, mwstbetrag16Eingabe = 0.0;
            if (txtBruttobetrag19.Text != "") bruttobetrag19Eingabe = Convert.ToDouble(txtBruttobetrag19.Text);
            double bruttobetrag19Ausgabe = 0.0;
            if (txtMwStBetrag19.Text != "") mwstbetrag19Eingabe = Convert.ToDouble(txtMwStBetrag19.Text);
            double mwstbetrag19Ausgabe = 0.0;
            if (txtNettobetrag.Text != "") nettobetragEingabe = Convert.ToDouble(txtNettobetrag.Text);
            double nettobetrag19Ausgabe = 0.0;
            if (txtBruttobetrag16.Text != "") bruttobetrag16Eingabe = Convert.ToDouble(txtBruttobetrag16.Text);
            double bruttobetrag16Ausgabe = 0.0;
            if (txtMwStBetrag16.Text != "") mwstbetrag16Eingabe = Convert.ToDouble(txtMwStBetrag16.Text);
            double mwstbetrag16Ausgabe = 0.0;
            string artikel = txtArtikel.Text, ausgabe = "";
         
            if (bruttobetrag19Eingabe != 0)

            {
               
                bruttobetrag19Ausgabe = bruttobetrag19Eingabe;
                bruttobetrag16Ausgabe = bruttobetrag19Eingabe / 119 * 116;
                mwstbetrag19Ausgabe = bruttobetrag19Eingabe / 119 * 19;
                nettobetrag19Ausgabe = bruttobetrag19Eingabe / 119 * 100;
                mwstbetrag16Ausgabe = bruttobetrag19Eingabe / 119 * 16;
                ausgabe = "Der Netto Preis für den Artikel " + artikel + " beträgt " + Math.Round(nettobetrag19Ausgabe) + "EUR." + "\n" + "\n" + "Der neue Bruttobetrag mit 16% MwSt beträgt " + Math.Round(bruttobetrag16Ausgabe, 2) + "EUR.";


                txtMwStBetrag19.Text = Convert.ToString(Math.Round(mwstbetrag19Ausgabe, 2));
                txtNettobetrag.Text = Convert.ToString(Math.Round(nettobetrag19Ausgabe, 2));
                txtMwStBetrag16.Text = Convert.ToString(Math.Round(mwstbetrag16Ausgabe, 2));
                txtBruttobetrag16.Text = Convert.ToString(Math.Round(bruttobetrag16Ausgabe, 2));
                txtBruttobetrag19.Text = Convert.ToString(Math.Round(bruttobetrag19Ausgabe, 2));

                rtbAusgabe.Text = ausgabe;


            }
            else
            {
                if (bruttobetrag16Eingabe != 0)

                {
                    bruttobetrag16Ausgabe = bruttobetrag16Eingabe;
                    bruttobetrag19Ausgabe = bruttobetrag16Eingabe / 116 * 119;
                    mwstbetrag19Ausgabe = bruttobetrag16Eingabe / 116 * 19;
                    nettobetrag19Ausgabe = bruttobetrag16Eingabe / 116 * 100;
                    mwstbetrag16Ausgabe = bruttobetrag16Eingabe / 116 * 16;
                    ausgabe = "Der Netto Preis für den Artikel " + artikel + " beträgt " + Math.Round(nettobetrag19Ausgabe) + "EUR." + "\n" + "\n" + "Der neue Bruttobetrag mit 16% MwSt beträgt " + Math.Round(bruttobetrag16Ausgabe, 2) + "EUR.";


                    txtMwStBetrag19.Text = Convert.ToString(Math.Round(mwstbetrag19Ausgabe, 2));
                    txtNettobetrag.Text = Convert.ToString(Math.Round(nettobetrag19Ausgabe, 2));
                    txtMwStBetrag16.Text = Convert.ToString(Math.Round(mwstbetrag16Ausgabe, 2));
                    txtBruttobetrag16.Text = Convert.ToString(Math.Round(bruttobetrag16Ausgabe, 2));
                    txtBruttobetrag19.Text = Convert.ToString(Math.Round(bruttobetrag19Ausgabe, 2));

                    rtbAusgabe.Text = ausgabe;

                 
                }
                else
                {
                    if (mwstbetrag19Eingabe != 0)

                    {
                        mwstbetrag19Ausgabe = mwstbetrag19Eingabe;
                        bruttobetrag19Ausgabe = mwstbetrag19Eingabe / 19 * 119;
                        bruttobetrag16Ausgabe = mwstbetrag19Eingabe / 19 * 116;
                        nettobetrag19Ausgabe = mwstbetrag19Eingabe / 19 * 100;
                        mwstbetrag16Ausgabe = mwstbetrag19Eingabe / 19 * 16;
                        ausgabe = "Der Netto Preis für den Artikel " + artikel + " beträgt " + Math.Round(nettobetrag19Ausgabe) + "EUR." + "\n" + "\n" + "Der neue Bruttobetrag mit 16% MwSt beträgt " + Math.Round(bruttobetrag16Ausgabe, 2) + "EUR.";


                        txtMwStBetrag19.Text = Convert.ToString(Math.Round(mwstbetrag19Ausgabe, 2));
                        txtNettobetrag.Text = Convert.ToString(Math.Round(nettobetrag19Ausgabe, 2));
                        txtMwStBetrag16.Text = Convert.ToString(Math.Round(mwstbetrag16Ausgabe, 2));
                        txtBruttobetrag16.Text = Convert.ToString(Math.Round(bruttobetrag16Ausgabe, 2));
                        txtBruttobetrag19.Text = Convert.ToString(Math.Round(bruttobetrag19Ausgabe, 2));

                        rtbAusgabe.Text = ausgabe;


                    }
                    else
                    {
                        if (mwstbetrag16Eingabe != 0)

                        {
                            mwstbetrag16Ausgabe = mwstbetrag16Eingabe;
                            bruttobetrag19Ausgabe = mwstbetrag16Eingabe / 16 * 119;
                            bruttobetrag16Ausgabe = mwstbetrag16Eingabe / 16 * 116;
                            nettobetrag19Ausgabe = mwstbetrag16Eingabe / 16 * 100;
                            mwstbetrag19Ausgabe = mwstbetrag16Eingabe / 16 * 19;
                            ausgabe = "Der Netto Preis für den Artikel " + artikel + " beträgt " + Math.Round(nettobetrag19Ausgabe) + "EUR." + "\n" + "\n" + "Der neue Bruttobetrag mit 16% MwSt beträgt " + Math.Round(bruttobetrag16Ausgabe, 2) + "EUR.";


                            txtMwStBetrag19.Text = Convert.ToString(Math.Round(mwstbetrag19Ausgabe, 2));
                            txtNettobetrag.Text = Convert.ToString(Math.Round(nettobetrag19Ausgabe, 2));
                            txtMwStBetrag16.Text = Convert.ToString(Math.Round(mwstbetrag16Ausgabe, 2));
                            txtBruttobetrag16.Text = Convert.ToString(Math.Round(bruttobetrag16Ausgabe, 2));
                            txtBruttobetrag19.Text = Convert.ToString(Math.Round(bruttobetrag19Ausgabe, 2));

                            rtbAusgabe.Text = ausgabe;

                            

                        }
                        else
                        {
                            if (nettobetragEingabe != 0)

                            {
                                nettobetrag19Ausgabe = nettobetragEingabe;
                                bruttobetrag19Ausgabe = nettobetragEingabe * 1.19;
                                bruttobetrag16Ausgabe = nettobetragEingabe * 1.16;
                                mwstbetrag19Ausgabe = nettobetragEingabe * 0.19;
                                mwstbetrag16Ausgabe = nettobetragEingabe * 0.16;
                                ausgabe = "Der Netto Preis für den Artikel " + artikel + " beträgt " + Math.Round(nettobetrag19Ausgabe, 2) + "EUR." + "\n" + "\n" + "Der neue Bruttobetrag mit 16% MwSt beträgt " + Math.Round(bruttobetrag16Ausgabe, 2) + "EUR.";


                                txtMwStBetrag19.Text = Convert.ToString(Math.Round(mwstbetrag19Ausgabe, 2));
                                txtNettobetrag.Text = Convert.ToString(Math.Round(nettobetrag19Ausgabe, 2));
                                txtMwStBetrag16.Text = Convert.ToString(Math.Round(mwstbetrag16Ausgabe, 2));
                                txtBruttobetrag16.Text = Convert.ToString(Math.Round(bruttobetrag16Ausgabe, 2));
                                txtBruttobetrag19.Text = Convert.ToString(Math.Round(bruttobetrag19Ausgabe, 2));

                                rtbAusgabe.Text = ausgabe;

                              

                            }
                        }
                    }
                }
            }
            rtbAusgabe.Select(32, artikel.Length);
            rtbAusgabe.SelectionColor = Color.LightGoldenrodYellow;
            rtbAusgabe.SelectionBackColor = Color.Black;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtMwStBetrag19.Text = "";
            txtNettobetrag.Text = "";
            txtMwStBetrag16.Text = "";
            txtBruttobetrag16.Text = "";
            txtBruttobetrag19.Text = "";
            txtArtikel.Text = "";
            rtbAusgabe.Text = "";
        }
    }
}