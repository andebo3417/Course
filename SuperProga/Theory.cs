using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperProga
{
    internal class Theory
    {
        private int par_;
        private string theory_;

        [Key]
        public int par
        {
            get { return par_; }
            set { par_ = value; }
        }

        public string theory
        {
            get { return theory_; }
            set { theory_ = value; }
        }
        Theory()
        {
            theory = "";
        }
    }
}
