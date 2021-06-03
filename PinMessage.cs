using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PindahFrame
{
    public class PinMessage
    {

        public static void Show(string message, string header, Button button)
        {
            // PinMessageForm
            // 
            /*  PinMessageForm. = new System.Drawing.SizeF(7F, 17F);
              AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
              PinMessageForm. AutoSize = true;
              ClientSize = new System.Drawing.Size(391, 209);
              Controls.Add(messagelabel);
              Controls.Add(btnOK);
              Controls.Add(panel1);
              Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
              ForeColor = System.Drawing.Color.Black;
              FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
              Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
              MaximumSize = new System.Drawing.Size(407, 407);
              Name = "PinMessageForm";
              Text = "PinMessageForm";
              panel1.ResumeLayout(false);
              panel2.ResumeLayout(false);
              panel2.PerformLayout();
              ResumeLayout(false);*/

            PinMessageForm form = new PinMessageForm();
            PinMessageForm.lblmessage.Text = message;
            form.Width = PinMessageForm.lblmessage.Width + 50;
            form.ShowDialog();
                                                                    
        }
        
    }
}
