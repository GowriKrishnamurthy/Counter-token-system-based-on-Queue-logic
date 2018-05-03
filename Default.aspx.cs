using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CounterQueueImp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // When application loads, session variable for tokens will be null
            if (Session["TokenQueue"] == null)
            {
                // Create a new Queue of integers for storing tokens and set that to session variable.
                Queue<int> qTokens = new Queue<int>();
                Session["TokenQueue"] = qTokens;
            }

        }
        //Next button on counter 1, 2 or 3 clicked will call same method - Next customer to serve
        public void btnCounter1_Click(object sender, EventArgs args)
        {
            ServeNextCust(txtCounter1, 1);
        }
        public void btnCounter2_Click(object sender, EventArgs args)
        {
            ServeNextCust(txtCounter2, 2);
        }
        public void btnCounter3_Click(object sender, EventArgs args)
        {
            ServeNextCust(txtCounter3, 3);
        }

        // Method to find out who the next customer is from the queue and to which counter
        public void ServeNextCust(TextBox t, int CounterNum)
        {
            // First move the conents of session variable to Queue variable 
            // and check if there is any customer left in the queue
            Queue<int> qToken = (Queue<int>)Session["TokenQueue"];
            if (qToken.Count > 0)
            {
                //If there is any customer waiting in the queue, just pick that customer,
                int whoNext = qToken.Dequeue();
                txtCounterStatus.Text = "Token Number = " + whoNext + " Please go to Counter" + CounterNum;
                t.Text = whoNext.ToString();

                //Populate the listbox with the updated Queue variable and update the session variable as well
                AddTokensToListBox(qToken);
                Session["TokenQueue"] = qToken;
            }
            else
            {
                txtCounterStatus.Text = "No customers in the queue";
                t.Text = "Counter free";
            }
        }

        public void btnPrintToken_Click(object sender, EventArgs args)
        {
            // First move the conents of session variable to Queue variable 
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];

            //Check the number of customers in the queue already.
            lblCurrentStatus.Text = "There are " + tokenQueue.Count.ToString() + " customers before you in the Queue";
            // If there was no token issued so far, then create new token starting from 0
            if (Session["LastTokenIssued"] == null)
            {
                //New tokens
                Session["LastTokenIssued"] = 0;
            }
            int nxtToken = (int)Session["LastTokenIssued"] + 1;
            Session["LastTokenIssued"] = nxtToken;
            //Add new token number to queue
            tokenQueue.Enqueue(nxtToken);
            AddTokensToListBox(tokenQueue);
        }
        // Add token numbers to the list box for display
        private void AddTokensToListBox(Queue<int> tokenQueue)
        {
            listTokens.Items.Clear();
            foreach (int token in tokenQueue)
            {
                listTokens.Items.Add(token.ToString());
            }
        }

    }
}

