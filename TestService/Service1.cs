using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace TestService
{
    public partial class Service1 : ServiceBase
    {

        System.Threading.Timer timer;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer = new System.Threading.Timer(DoSomething, null, 1000, 5000);
        }

        private void DoSomething(object state)
        {
            Debug.WriteLine("Something");
        }

        protected override void OnStop()
        {
        }
    }
}
