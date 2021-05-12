using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(WebChatSolution.Startup))]
namespace WebChatSolution
{
    /// <summary>
    /// 웹 응용 프로그램이 시작되는 시점에 웹 응용 프로그램의 각종 환경 설정하는 기능을 제공
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// ASP.NET MVC5 웹 응용프로그램 환경에 ASP.NET SignalR 실시간 통신지원기능을 추가 설정
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            HubConfiguration hubConfiguration = new HubConfiguration()
            {
                EnableJSONP = true
            };
            app.MapSignalR(hubConfiguration);
        }
    }
}