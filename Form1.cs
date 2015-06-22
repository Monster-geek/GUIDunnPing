using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.NetworkInformation;

namespace GUIDunnPing
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            txtbox_ip_start_1.Text = "";
            txtbox_ip_start_2.Text = "";
            txtbox_ip_start_3.Text = "";
            txtbox_ip_start_4.Text = "";
        }

        private void btn_reset_end_Click( object sender, EventArgs e )
        {
            txtbox_ip_end_1.Text = "";
            txtbox_ip_end_2.Text = "";
            txtbox_ip_end_3.Text = "";
            txtbox_ip_end_4.Text = "";
        }

        private void btn_scan_Click( object sender, EventArgs e )
        {
            txtboxresult.Text = "Scan en cour patientez svp...";

            string display_txt;
            string ip_start;
            string ip_end;
            int range_start;
            int range_end;
            //int range_sum;

            try
            {

                ip_start = txtbox_ip_start_1.Text + "." + txtbox_ip_start_2.Text + "." + txtbox_ip_start_3.Text + "." + txtbox_ip_start_4.Text;
                ip_end = txtbox_ip_end_1.Text + "." + txtbox_ip_end_2.Text + "." + txtbox_ip_end_3.Text + "." + txtbox_ip_end_4.Text;

                range_start = int.Parse( txtbox_ip_start_4.Text );
                range_end = int.Parse( txtbox_ip_end_4.Text );


                display_txt = String.Format( "Scan de {0} à {1} : \n", ip_start, ip_end );

                while ( range_start < range_end+1 ) 
                {
                    string current = txtbox_ip_start_1.Text +"."+ txtbox_ip_start_2.Text +"."+ txtbox_ip_start_3.Text +"."+ range_start.ToString( );
                    display_txt += this.scan( current ) + "\n";
                    range_start++;
                }

                txtboxresult.Text = display_txt;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "DunnPing™", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            

        }

        private string scan( string ip ) 
        {
            string return_msg = "";

            Ping pingSender = new Ping( );
            PingOptions options = new PingOptions( );

            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes( data );
            int timeout = 120;
            try
            {
                PingReply reply = pingSender.Send( ip, timeout, buffer, options );
                if ( reply.Status == IPStatus.Success )
                {
                    return_msg = String.Format( "\nAddress: {0} : ONLINE\n", reply.Address.ToString( ) );
                }
                if ( reply.Status == IPStatus.TimedOut )
                {
                    return_msg = String.Format( "Address: {0} : OFFLINE", ip );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message, "DunnPing™", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }


            return return_msg;
        }
    }
}
