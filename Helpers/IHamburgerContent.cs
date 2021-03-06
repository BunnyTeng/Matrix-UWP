﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_UWP.Helpers {
  interface IHamburgerContent {
    Task ResetContentAsync();
    event HamburgerContentHandler onError;
  }

  public class HamburgerContentEventArgs : EventArgs {
    public HamburgerContentEventArgs(string msg) { message = msg; }
    public string message;
  }
  public delegate void HamburgerContentHandler(object sender, HamburgerContentEventArgs e);
}
