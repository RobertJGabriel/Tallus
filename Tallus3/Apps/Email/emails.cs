using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;
using System.Threading;

namespace Tallus3.Apps.Email
{
    public partial class emails : Form
    {
        ArrayList attachments;
        ArrayList popAttachmentsIndex;
        bool _lock = false;
        Email_Client.Pop3Client pop = null;
        string email = "";
        int msg_id = 0;
        ArrayList attached_file_names;
        public emails()
        {
       
            this.attachments = new ArrayList();
            this.popAttachmentsIndex = new ArrayList();
            this.attached_file_names = new ArrayList();
            InitializeComponent();
        }

        private void SmtpPort_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {

        }

        private void SmtpClear_Click(object sender, EventArgs e)
        {
            this.SmtpServer.Text = "";
            this.SmtpPort.Text = "";
            this.UserName.Text = "";
            this.Password.Text = "";
            this.From.Text = "";
            this.To.Text = "";
            this.Cc.Text = "";
            this.Bcc.Text = "";
            this.Subject.Text = "";
            this.MailMessage.Text = "";
     
        }

        void smtp_Disconnected(object sender, string Server)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.DisconnectEventHandler discon = new Email_Client.DisconnectEventHandler(this.smtp_Disconnected);
                this.Invoke(discon, new object[] { sender,Server });
            }
            else
            {
                this.ProgressLabel.Text = "Disconnected with the smtp server \"" + Server + "\"";
                Thread.Sleep(500);
                this.Send.Enabled = true;
                this.ProgressLabel.Text = "Email Client";
            }
        }

        void smtp_EndedDataTransfer(object sender)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.DataTransferEventHandler data = new Email_Client.DataTransferEventHandler(this.smtp_EndedDataTransfer);
                this.Invoke(data, new object[] { sender });
            }
            else
            {
                this.ProgressLabel.Text = "Email message has sent";
            }
        }

        void smtp_StartedDataTransfer(object sender)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.DataTransferEventHandler data = new Email_Client.DataTransferEventHandler(this.smtp_StartedDataTransfer);
                this.Invoke(data, new object[] { sender});
            }
            else
            {
                this.ProgressLabel.Text = "Sending email message";
            }
        }

        void smtp_AuthenticationFinished(object sender, string userName)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.AuthenticateEventHandler auth = new Email_Client.AuthenticateEventHandler(this.smtp_AuthenticationFinished);
                this.Invoke(auth, new object[] { sender, userName });
            }
            else
            {
                this.ProgressLabel.Text = "Verification is completed";
            }
        }

        void smtp_AuthenticationBegan(object sender, string userName)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.AuthenticateEventHandler auth = new Email_Client.AuthenticateEventHandler(this.smtp_AuthenticationBegan);
                this.Invoke(auth, new object[] { sender, userName});
            }
            else
            {
                this.ProgressLabel.Text = "Verifying user name and password";
            }
        }

        void smtp_ConnectionEstablishing(object sender, string Server, int Port)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.ConnectEventHandler con = new Email_Client.ConnectEventHandler(this.smtp_ConnectionEstablishing);
                this.Invoke(con, new object[] { sender, Server, Port });
            }
            else
            {
                this.ProgressLabel.Text = "Connecting to smtp server \"" + Server + "\" on port " + Port;
            }
        }

        void smtp_ConnectionEstablished(object sender, string Server, int Port)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.ConnectEventHandler con = new Email_Client.ConnectEventHandler(this.smtp_ConnectionEstablished);
                this.Invoke(con, new object[] { sender, Server, Port });
            }
            else
            {
                this.ProgressLabel.Text = "Connection is established with the smtp server \"" + Server + "\"";
            }
        }

      

        private void MailMessage_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void PopPort_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {

        }

        private void pop_Disconnected(object sender, string Server)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.DisconnectEventHandler discon = new Email_Client.DisconnectEventHandler(this.pop_Disconnected);
                this.Invoke(discon, new object[] { sender, Server });
            }
            else
            {
                this.ProgressLabel.Text = "Disconnected with the pop server \"" + Server + "\"";
                Thread.Sleep(500);
                this.Send.Enabled = true;
                this.ProgressLabel.Text = "Email Client";
            }
        }

        private void pop_EndedDataReceiving(object sender)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.DataReceivingEventHandler data = new Email_Client.DataReceivingEventHandler(this.pop_EndedDataReceiving);
                this.Invoke(data, new object[] { sender });
            }
            else
            {
                this.ProgressLabel.Text = "Email message has received";
            }
        }

        private void pop_StartedDataReceiving(object sender)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.DataReceivingEventHandler data = new Email_Client.DataReceivingEventHandler(this.pop_StartedDataReceiving);
                this.Invoke(data, new object[] { sender });
            }
            else
            {
                this.ProgressLabel.Text = "Receiving email message"; 
            }
        }

        private void pop_AuthenticationFinished(object sender, string userName)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.AuthenticateEventHandler auth = new Email_Client.AuthenticateEventHandler(this.pop_AuthenticationFinished);
                this.Invoke(auth, new object[] { sender, userName });
            }
            else
            {
                this.ProgressLabel.Text = "Verification is completed";
            }
        }

        private void pop_AuthenticationBegan(object sender, string userName)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.AuthenticateEventHandler auth = new Email_Client.AuthenticateEventHandler(this.pop_AuthenticationBegan);
                this.Invoke(auth, new object[] { sender, userName });
            }
            else
            {
                this.ProgressLabel.Text = "Verifying user name and password";
            }
        }

        private void pop_ConnectionEstablished(object sender, string Server, int Port)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.ConnectEventHandler con = new Email_Client.ConnectEventHandler(this.pop_ConnectionEstablished);
                this.Invoke(con, new object[] { sender, Server, Port });
            }
            else
            {
                this.ProgressLabel.Text = "Connection is established with the pop server \"" + Server + "\"";
            }
        }

        private void pop_ConnectionEstablishing(object sender, string Server, int Port)
        {
            if (this.statusStrip.InvokeRequired)
            {
                Email_Client.ConnectEventHandler con = new Email_Client.ConnectEventHandler(this.pop_ConnectionEstablishing);
                this.Invoke(con, new object[] { sender, Server, Port });
            }
            else
            { 
                this.ProgressLabel.Text = "Connecting to pop server \"" + Server + "\" on port " + Port;
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {

        }

        private void MailMessages_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Do you want to delete the selected message?", "Email Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int index = this.MailMessages.SelectedItems[0].Index;
                index = index + 1;
                try
                {
                    this.pop.DeleteEmail(index);
                    this.MailMessages.SelectedItems[0].Remove();

                    if (this.msg_id == index)
                    {
                        this.FromPopHeader.Text = "";
                        this.ToPopHeader.Text = "";
                        this.SubjectPopHeader.Text = "";
                        this.PopAttachments.Items.Clear();
                        this.PopMessage.DocumentText = "<html></html>";
                    }
                    MessageBox.Show(this, "Message having id " + index + " is deleted.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Email_Client.Pop3ClientException err)
                {
                    MessageBox.Show(this, err.ErrorMessage, "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PopAttachments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MailMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // The delegate used to enable or disable a button control, in another thread
        private delegate void EnableDisableEventHandler(bool enable);

        private void EnableDisableSendButton(bool enable)
        {
            if (this.Connect.InvokeRequired)
            {
                EnableDisableEventHandler obj = new EnableDisableEventHandler(this.EnableDisableSendButton);
                this.Invoke(obj, new object[] { enable });
            }
            else
            {
                this.Send.Enabled = enable;
            }
        }

        private void EnableDisableConnectButton(bool enable)
        {
            if (this.Connect.InvokeRequired)
            {
                EnableDisableEventHandler obj = new EnableDisableEventHandler(this.EnableDisableConnectButton);
                this.Invoke(obj, new object[] { enable });
            }
            else
            {
                this.Connect.Enabled = enable;
            }
        }

        private void EnableDisableDisconnectButton(bool enable)
        {
            if (this.Connect.InvokeRequired)
            {
                EnableDisableEventHandler obj = new EnableDisableEventHandler(this.EnableDisableDisconnectButton);
                this.Invoke(obj, new object[] { enable });
            }
            else
            {
                this.Disconnect.Enabled = enable;
            }
        }

        // The delegate used to insert an item in the Inbox ListView
        private delegate void InboxItemEventHandler(ListViewItem item);

        private void InsertItem(ListViewItem item)
        {
            if (this.MailMessages.InvokeRequired)
            {
                InboxItemEventHandler obj = new InboxItemEventHandler(this.InsertItem);
                this.Invoke(obj, new object[] { item });
            }
            else
            {
                this.MailMessages.Items.Add(item);
            }
        }

        // The delegate used to Add attached file names in Pop Attachments ListView
        private delegate void InsertPopAttachedFileNamesEventHandler(ArrayList attached_file_names);
        private void InsertPopAttachedFileNames(ArrayList attached_file_names)
        {
            if (this.MailMessages.InvokeRequired)
            {
                InsertPopAttachedFileNamesEventHandler obj = new InsertPopAttachedFileNamesEventHandler(this.InsertPopAttachedFileNames);
                this.Invoke(obj, new object[] { attached_file_names });
            }
            else
            {
                this.PopAttachments.Items.Clear();
                for (int i = 0; i < attached_file_names.Count; i++)
                {
                    this.PopAttachments.Items.Add((ListViewItem)attached_file_names[i]);
                }
            }
        }

        // The delegate used to clear the items in Pop Attachments ListView
        private delegate void ClearPopAttachmentsEventHandler();

        private void ClearPopAttachments()
        {
            if (this.PopAttachments.InvokeRequired)
            {
                ClearPopAttachmentsEventHandler obj = new ClearPopAttachmentsEventHandler(this.ClearPopAttachments);
                this.Invoke(obj, new object[] { });
            }
            else
            {
                this.PopAttachments.Items.Clear();
            }
        }

        // The delegate used to write Pop Message in browser
        private delegate void WritePopMessageEventHandler(string content);

        private void WritePopMessage(string content)
        {
            if (this.PopMessage.InvokeRequired)
            {
                WritePopMessageEventHandler obj = new WritePopMessageEventHandler(this.WritePopMessage);
                this.Invoke(obj, new object[] { content });
            }
            else
            {
                this.PopMessage.DocumentText = content.Trim();
            }
        }

        // The delegate used to update Status Bar
        private delegate void UpdateStatusBarEventHandler(string text);

        private void UpdateStatusBar(string text)
        {
            if (this.statusStrip.InvokeRequired)
            {
                UpdateStatusBarEventHandler obj = new UpdateStatusBarEventHandler(this.UpdateStatusBar);
                this.Invoke(obj, new object[] { text });
            }
            else
            {
                this.ProgressLabel.Text = text;
            }
        }

        // The delegate used to update Pop message header
        private delegate void UpdatePopMessageHeaderEventHandler(string from, string to, string subject);

        private void UpdatePopMessageHeader(string from, string to, string subject)
        {
            if (this.FromPopHeader.InvokeRequired || this.ToPopHeader.InvokeRequired || this.SubjectPopHeader.InvokeRequired)
            {
                UpdatePopMessageHeaderEventHandler obj = new UpdatePopMessageHeaderEventHandler(this.UpdatePopMessageHeader);
                this.Invoke(obj, new object[] {from,to,subject });
            }
            else
            {
                this.FromPopHeader.Text = from.Trim();
                this.ToPopHeader.Text = to.Trim();
                this.SubjectPopHeader.Text = subject.Trim();
            }
        }





        // Helping methods for Pop3 Client user Interface

        private void ReceiveEmails()
        {
            try
            {
                Email_Client.Pop3Client pop_client = new Email_Client.Pop3Client();
                pop_client.Pop3Server = this.PopServer.Text;
                pop_client.Pop3Port = Convert.ToInt32(this.PopPort.Text);
                pop_client.UserName = this.PopUserName.Text;
                pop_client.Password = this.PopPassword.Text;
                this.EnableDisableConnectButton(false);

                pop_client.ConnectionEstablishing += new Email_Client.ConnectEventHandler(this.pop_ConnectionEstablishing);
                pop_client.ConnectionEstablished += new Email_Client.ConnectEventHandler(this.pop_ConnectionEstablished);
                pop_client.AuthenticationBegan += new Email_Client.AuthenticateEventHandler(this.pop_AuthenticationBegan);
                pop_client.AuthenticationFinished += new Email_Client.AuthenticateEventHandler(this.pop_AuthenticationFinished);
                pop_client.StartedDataReceiving += new Email_Client.DataReceivingEventHandler(this.pop_StartedDataReceiving);
                pop_client.EndedDataReceiving += new Email_Client.DataReceivingEventHandler(this.pop_EndedDataReceiving);
                pop_client.Disconnected += new Email_Client.DisconnectEventHandler(this.pop_Disconnected);

                this.pop = pop_client;

                pop_client.Connect();
                this.EnableDisableDisconnectButton(true);
                pop_client.GetMailBoxDetails();   //it sets the TotalEmails and TotalEmailSize properties

                if (pop_client.TotalEmails >= 1)
                {
                    this.UpdateStatusBar("Retrieving Emails");
                    this.FillInboxListView(pop_client);
                    this.UpdateStatusBar("Email Client");
                }
                else
                {
                    this.UpdateStatusBar("Email Client");
                    MessageBox.Show(this, "No email message exists in the inbox!.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Email_Client.SmtpClientException err)
            {
                MessageBox.Show(this, err.ErrorMessage, "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.UpdateStatusBar("Email Client");
                this.EnableDisableConnectButton(true);
                this.EnableDisableDisconnectButton(false);
            }
        }

        private void FetchEmailCallBack()
        {
            try
            {
                this.email = this.pop.FetchEmail(this.msg_id);
                this.UpdatePopMessageHeader(this.pop.From, this.pop.To, this.pop.Subject);

                string content = "";
                string content_type = "";
                string attached_file_name = "";
                bool isHtmlIncluded = false;
                int plain_text_message_section = -1;

                for (int i = 1; i <= this.pop.MailSections; i++)
                {
                    this.pop.GetMailSection(i, ref content, ref content_type, ref attached_file_name);

                    if (content_type.ToLower().Equals("text/html"))
                    {
                        this.WritePopMessage(content);
                        isHtmlIncluded = true;
                    }
                    else if (content_type.ToLower().Equals("base64"))
                    {
                        ListViewItem item = new ListViewItem(attached_file_name);
                        item.ImageIndex = 0;
                        attached_file_names.Add(item);
                        this.popAttachmentsIndex.Add(i);
                    }
                    else if (content_type.ToLower().Equals("text/plain"))
                    {
                        plain_text_message_section = i;
                    }
                }

                this.InsertPopAttachedFileNames(attached_file_names);

                if (isHtmlIncluded == false && plain_text_message_section != -1)
                {
                    this.pop.GetMailSection(plain_text_message_section, ref content, ref content_type, ref attached_file_name);
                    this.WritePopMessage(content);
                }

                this.UpdateStatusBar("Email Client");

            }
            catch (Email_Client.Pop3ClientException err)
            {
                MessageBox.Show(this, err.ErrorMessage, "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckInputValidationForPop(string pop_server, string pop_port, string user_name, string password)
        {
            if (pop_server.Equals(""))
            {
                MessageBox.Show(this, "You must provide pop server address.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (pop_port.Equals(""))
            {
                MessageBox.Show(this, "You must provide pop port number.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (user_name.Equals(""))
            {
                MessageBox.Show(this, "You must provide username.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (password.Equals(""))
            {
                MessageBox.Show(this, "You must provide password.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        
            return true;
        }

        private void FillInboxListView(Email_Client.Pop3Client obj)
        {
            ArrayList sender = new ArrayList();
            ArrayList subject = new ArrayList();
            ArrayList date = new ArrayList();
            ArrayList size = new ArrayList();
            DateTime date_time; string temp = "";

            this.MailMessages.Items.Clear();

            for (int i = 1; i <= obj.TotalEmails; i++)
            {
                string emailHeader = obj.FetchEmailTop(i, 0);
                sender.Add(obj.From);
                subject.Add(obj.Subject);
                try
                {
                    date_time = DateTime.Parse(obj.Date);
                    temp = date_time.ToString("D");
                    date.Add(temp);
                }
                catch(Exception)
                {
                    date.Add(obj.Date);
                }
                
                size.Add(obj.GetMailSize(i));
            }

            for (int j = 0; j < sender.Count; j++)
            {
                ListViewItem item = new ListViewItem();

                item.Text = sender[j].ToString();
                item.SubItems.Add(subject[j].ToString());
                item.SubItems.Add(date[j].ToString());
                item.SubItems.Add(size[j].ToString());

                this.InsertItem(item);
            }
        }




        // Helping Methods for Smtp Client user interface

        private void SendEmail(object mail_msg)
        {
            try
            {
                Email_Client.MailMessage mail_message = (Email_Client.MailMessage)mail_msg;


                Email_Client.SmtpClient smtp = new Email_Client.SmtpClient(this.SmtpServer.Text, Convert.ToInt32(this.SmtpPort.Text));
                smtp.UserName = this.UserName.Text;
                smtp.Password = this.Password.Text;
                
                this.EnableDisableSendButton(false);

                smtp.ConnectionEstablishing += new Email_Client.ConnectEventHandler(smtp_ConnectionEstablishing);
                smtp.ConnectionEstablished += new Email_Client.ConnectEventHandler(smtp_ConnectionEstablished);
                smtp.AuthenticationBegan += new Email_Client.AuthenticateEventHandler(smtp_AuthenticationBegan);
                smtp.AuthenticationFinished += new Email_Client.AuthenticateEventHandler(smtp_AuthenticationFinished);
                smtp.StartedDataTransfer += new Email_Client.DataTransferEventHandler(smtp_StartedDataTransfer);
                smtp.EndedDataTransfer += new Email_Client.DataTransferEventHandler(smtp_EndedDataTransfer);
                smtp.Disconnected += new Email_Client.DisconnectEventHandler(smtp_Disconnected);

                smtp.SendMail(mail_message);
                MessageBox.Show(this,"Email message has sent.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Email_Client.SmtpClientException obj)
            {
                MessageBox.Show(this, obj.ErrorMessage, "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.EnableDisableSendButton(true);
                this.ProgressLabel.Text = "Email Client";
            }
        }

        private bool CheckInputValidation(string smtp_server, string smtp_port, string user_name, string password, string from, string to,string cc,string bcc)
        {
            if (smtp_server.Equals(""))
            {
                MessageBox.Show(this, "You must provide smtp server address.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (smtp_port.Equals(""))
            {
                MessageBox.Show(this, "You must provide smtp port number.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (user_name.Equals(""))
            {
                MessageBox.Show(this, "You must provide username.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (password.Equals(""))
            {
                MessageBox.Show(this, "You must provide password.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (from.Equals(""))
            {
                MessageBox.Show(this, "You must provide sender email address.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if ((!(to.Equals(""))) || (!(cc.Equals(""))) || (!(bcc.Equals(""))))
            {
                return true;
            }
            else if (to.Equals("") && cc.Equals("") && bcc.Equals(""))
            {
                MessageBox.Show(this, "You must provide recipient email address.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            return true;
        }

        private bool RecipientsEmailValidation(string recipient)
        {
            string[] splits = recipient.Split(new char[] { ',', ';' });

            for (int i = 0; i < splits.Length; i++)
            {
                if (this.EmailValidation(splits[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private bool EmailValidation(string email)
        {
            Regex regx = new Regex(@"([a-zA-Z_0-9.-]+\@[a-zA-Z_0-9.-]+\.\w+)", RegexOptions.IgnoreCase);
            if (regx.IsMatch(email))
            {
                return true;
            }
            return false;
        }

          
    }
} 
       

     
    