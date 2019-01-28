﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalR.Startup))]

namespace SignalR
{
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      // 如需如何設定應用程式的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkID=316888
      app.MapSignalR();

    }
  }
}
