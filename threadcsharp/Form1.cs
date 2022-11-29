using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.Remoting.Contexts;
using System.MulticastDelegate;

namespace threadcsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void ExtractExecutingThread()
        {
            // Get the thread currently
            // executing this method.
            Thread currThread = Thread.CurrentThread;
          
        }

        static void ExtractAppDomainHostingThread()
        {
            // Obtain the AppDomain hosting the current thread.
            AppDomain ad = Thread.GetDomain();
        }

        static void ExtractCurrentThreadContext()
        {
            // Obtain the context under which the
            // current thread is operating.
            Context ctx = Thread.CurrentContext;
        }

        


    private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
