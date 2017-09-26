using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace lab11_brian.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Welcome to Code Fellows school of Codecraft and Hackery. To register your Hacker please visit the \n \\Register page";
        }

        public string wat()
        {
            return $@"             _            _.,----,
 __  _.-._ / '-.        -  ,._  \) 
|  `-)_   '-.   \       / < _ )/"" }}
/__    '-.   \   '-, ___(c-(6)=(6)
 , `'.    `._ '.  _,'   >\    ""  )
 :;;,,'-._   '---' (  ( ""/`. -='/
;:;;:;;,  '..__    ,`-.`)'- '--'
;';:;;;;;'-._ /'._|   Y/   _/' \
      '''""._ F    |  _/ _.'._   `\
             L    \   \/     '._  \
      .-,-,_ |     `.  `'---,  \_ _|
      //    'L    /  \,   (""--',=`)7
     | `._       : _,  \  /'`-._L,_'-._
     '--' '-.\__/ _L   .`'         './/
                 [ (  /
                  ) `{{
       snd        \__)";
        }
    }
}
