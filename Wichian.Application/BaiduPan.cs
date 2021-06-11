using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Furion.RemoteRequest.Extensions;
namespace Wichian.Application
{
    public class BaiduPan : IDynamicApiController
    {
        private string AppID = "23876232";
        private string AppKey = "ONv1ruWzah2lBOSyLb6xCRQUkYyodViz";
        private string SecretKey = "WhAcY5FdoQmOofHV9Tq0q87nzulpD943";
        private string SignKey = "M$07smLZH47^OD4CUSircuo55I2vIP7b";
        /// <summary>
        /// 获取Code
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetAccessCode()
        {
            string clientid = "23876232";
            string uri = $"http://openapi.baidu.com/oauth/2.0/authorize?response_type=code&client_id={clientid}&redirect_uri=oob&scope=basic,netdisk&display=page&qrcode=1&force_login=1";
            return await uri.GetAsStringAsync();
        }
        /// <summary>
        /// 获取Token?
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetAccessToken()
        {
            string AppKey = "ONv1ruWzah2lBOSyLb6xCRQUkYyodViz";
            string uri = $"http://openapi.baidu.com/oauth/2.0/authorize?response_type=token&client_id={AppKey}&redirect_uri=oob&scope=basic,netdisk&display=popup&state=1";
            return await uri.GetAsStringAsync();
        }
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public async Task<string> GetAccessTokenByCode(string code)
        {
            string AppKey = "ONv1ruWzah2lBOSyLb6xCRQUkYyodViz";
            string SecretKey = "WhAcY5FdoQmOofHV9Tq0q87nzulpD943";
            string uri = $"https://openapi.baidu.com/oauth/2.0/token?grant_type=authorization_code&code={code}&client_id={AppKey}&client_secret={SecretKey}&redirect_uri=oob";
            return await uri.GetAsStringAsync();
            //{ "expires_in":2592000,"refresh_token":"122.27d4f8ffe25e5047897c2360a3db201d.YBtEm-y2xND6ISo2QBzKMdLczhI82UVTwzMKDKT.pSUGcA","access_token":"121.5114a95f37d256e52669d602b03ee17e.YnuBehYDNq3-JXcW4yvaXxFb1fAb_rR8JbrUG1T.8P4QkA","session_secret":"","session_key":"","scope":"basic netdisk"}

        }
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="refres_token"></param>
        /// <returns></returns>
        public async Task<string> GetAccessTokenByRefreshToken(string refres_token)
        {
            string AppKey = "ONv1ruWzah2lBOSyLb6xCRQUkYyodViz";
            string SecretKey = "WhAcY5FdoQmOofHV9Tq0q87nzulpD943";
            string uri = $"https://openapi.baidu.com/oauth/2.0/token?grant_type=refresh_token&refresh_token={refres_token}&client_id={AppKey}&client_secret={SecretKey}";
            return await uri.GetAsStringAsync();
            //{ "expires_in":2592000,"refresh_token":"122.eb702ca97038724f89ed127fbbe07e82.Ysx3_nujYL67MuEvpD4Wmudl27e4y5vSmG3f2wL.gnoX7A","access_token":"121.9879664ae08170e3133960a5c0e268bf.YlF4MkWmFmDs6O1qrcQnbssuMXRHhlTvxffjBv8.YWAEUA","session_secret":"","session_key":"","scope":"basic netdisk"}

        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<string> GetUserinfo(string token)
        {
            string uri = $"https://pan.baidu.com/rest/2.0/xpan/nas?method=uinfo&access_token={token}";
            return await uri.GetAsStringAsync();
            //{ "avatar_url":"https://dss0.bdstatic.com/7Ls0a8Sm1A5BphGlnYG/sys/portrait/item/netdisk.1.412b3605.KCI7Y6VY86ccKsT4mhBVkA.jpg","baidu_name":"wichian","errmsg":"succ","errno":0,"netdisk_name":"","request_id":"2824925486995297160","uk":3557122370,"vip_type":2}

        }
        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<System.IO.Stream> GetFilelist(string token)
        {
            string uri = $"https://pan.baidu.com/rest/2.0/xpan/file?method=list&access_token={token}";
            return await uri.GetAsStreamAsync();
            //{"errno":0,"guid_info":"","list":[{"tkbind_id":0,"server_filename":"apps","category":6,"unlist":0,"isdir":1,"oper_id":0,"server_atime":0,"server_ctime":1417734027,"wpfile":0,"local_mtime":1417734027,"size":0,"server_mtime":1417734027,"share":0,"path":"\/apps","local_ctime":1417734027,"pl":0,"fs_id":935036822067500},{"tkbind_id":0,"server_filename":"HLMJ","category":6,"unlist":0,"isdir":1,"oper_id":3557122370,"server_atime":0,"server_ctime":1521296353,"wpfile":0,"local_mtime":1521296353,"size":0,"server_mtime":1609809427,"share":0,"path":"\/HLMJ","local_ctime":1521296353,"pl":0,"fs_id":1045485207737347},{"tkbind_id":0,"server_filename":"\u25a0\u30102021\u5f00\u5b66\u3011\u8d44\u6599\u5927\u793c\u5305","category":6,"unlist":0,"isdir":1,"oper_id":0,"server_atime":0,"server_ctime":1612341386,"wpfile":0,"local_mtime":1612341386,"size":0,"server_mtime":1614841126,"share":0,"path":"\/\u25a0\u30102021\u5f00\u5b66\u3011\u8d44\u6599\u5927\u793c\u5305","local_ctime":1612341386,"pl":0,"fs_id":1077328801038857},{"tkbind_id":0,"server_filename":"\u767e\u5ea6\u4e91\u89e3\u538b","category":6,"unlist":0,"isdir":1,"oper_id":3557122370,"server_atime":0,"server_ctime":1554211026,"wpfile":0,"local_mtime":1554211026,"size":0,"server_mtime":1554211026,"share":0,"path":"\/\u767e\u5ea6\u4e91\u89e3\u538b","local_ctime":1554211026,"pl":0,"fs_id":1115892218636586},{"tkbind_id":0,"server_filename":"\u6765\u81ea\uff1aALP-AL00","category":6,"unlist":0,"isdir":1,"oper_id":3557122370,"server_atime":0,"server_ctime":1604644946,"wpfile":0,"local_mtime":1604644946,"size":0,"server_mtime":1604644946,"share":0,"path":"\/\u6765\u81ea\uff1aALP-AL00","local_ctime":1604644946,"pl":4,"fs_id":533557203500054},{"tkbind_id":0,"server_filename":"\u84dd\u6865\u676f\u8003\u8bd5\u8d44\u6599","category":6,"unlist":0,"isdir":1,"oper_id":0,"server_atime":0,"server_ctime":1611910978,"wpfile":0,"local_mtime":1611910978,"size":0,"server_mtime":1614743798,"share":0,"path":"\/\u84dd\u6865\u676f\u8003\u8bd5\u8d44\u6599","local_ctime":1611910978,"pl":0,"fs_id":416700779941460},{"tkbind_id":0,"server_filename":"\u72f8\u7c73\u8bfe\u5802\u622a\u56fe\u7b14\u8bb0","category":6,"unlist":0,"isdir":1,"oper_id":3557122370,"server_atime":0,"server_ctime":1616661603,"wpfile":0,"local_mtime":1616661603,"size":0,"server_mtime":1616661603,"share":0,"path":"\/\u72f8\u7c73\u8bfe\u5802\u622a\u56fe\u7b14\u8bb0","local_ctime":1616661603,"pl":2,"fs_id":76029567634669},{"tkbind_id":0,"server_filename":"\u6211\u7684\u4ee3\u7801","category":6,"unlist":0,"isdir":1,"oper_id":0,"server_atime":0,"server_ctime":1404557374,"wpfile":0,"local_mtime":1404557374,"size":0,"server_mtime":1404557374,"share":0,"path":"\/\u6211\u7684\u4ee3\u7801","local_ctime":1404557374,"pl":0,"fs_id":1028430179794493},{"tkbind_id":0,"server_filename":"\u6211\u7684\u6d3b\u52a8","category":6,"unlist":0,"isdir":1,"oper_id":3557122370,"server_atime":0,"server_ctime":1573546894,"wpfile":0,"local_mtime":1573546894,"size":0,"server_mtime":1573546894,"share":0,"path":"\/\u6211\u7684\u6d3b\u52a8","local_ctime":1573546894,"pl":0,"fs_id":431747242764991},{"tkbind_id":0,"server_filename":"\u6211\u7684\u8f6f\u4ef6","category":6,"unlist":0,"isdir":1,"oper_id":0,"server_atime":0,"server_ctime":1350705764,"wpfile":0,"local_mtime":1350705764,"size":0,"server_mtime":1404611181,"share":0,"path":"\/\u6211\u7684\u8f6f\u4ef6","local_ctime":1350705764,"pl":0,"fs_id":34711133},{"tkbind_id":0,"server_filename":"\u6211\u7684\u89c6\u9891","category":6,"unlist":0,"isdir":1,"oper_id":0,"server_atime":0,"server_ctime":1350265395,"wpfile":0,"local_mtime":1350265395,"size":0,"server_mtime":1350265395,"share":0,"path":"\/\u6211\u7684\u89c6\u9891","local_ctime":1350265395,"pl":0,"fs_id":4071033304},{"tkbind_id":0,"server_filename":"\u6211\u7684\u6587\u6863","category":6,"unlist":0,"isdir":1,"oper_id":0,"server_atime":0,"server_ctime":1350265395,"wpfile":0,"local_mtime":1350265395,"size":0,"server_mtime":1350265395,"share":0,"path":"\/\u6211\u7684\u6587\u6863","local_ctime":1350265395,"pl":0,"fs_id":2747431424},{"tkbind_id":0,"server_filename":"\u6211\u7684\u97f3\u4e50","category":6,"unlist":0,"isdir":1,"oper_id":0,"server_atime":0,"server_ctime":1350265395,"wpfile":0,"local_mtime":1350265395,"size":0,"server_mtime":1350265395,"share":0,"path":"\/\u6211\u7684\u97f3\u4e50","local_ctime":1350265395,"pl":0,"fs_id":1547725987},{"tkbind_id":0,"server_filename":"\u6211\u7684\u8d44\u6e90","category":6,"unlist":0,"isdir":1,"oper_id":0,"server_atime":0,"server_ctime":1613050595,"wpfile":0,"local_mtime":1613050595,"size":0,"server_mtime":1613050595,"share":0,"path":"\/\u6211\u7684\u8d44\u6e90","local_ctime":1613050595,"pl":0,"fs_id":1044693304840802},{"tkbind_id":0,"server_filename":"\u5b66\u800c\u601d\u8001\u5e08\u62cd\u7684\u7167","category":6,"unlist":0,"isdir":1,"oper_id":3557122370,"server_atime":0,"server_ctime":1616661665,"wpfile":0,"local_mtime":1616661664,"size":0,"server_mtime":1616661665,"share":0,"path":"\/\u5b66\u800c\u601d\u8001\u5e08\u62cd\u7684\u7167","local_ctime":1616661664,"pl":2,"fs_id":671249680949380},{"tkbind_id":0,"server_filename":"\u5b66\u800c\u601d\u7f51\u6821_\u7b14\u8bb0\u62cd\u7167","category":6,"unlist":0,"isdir":1,"oper_id":3557122370,"server_atime":0,"server_ctime":1616661547,"wpfile":0,"local_mtime":1616661547,"size":0,"server_mtime":1616661547,"share":0,"path":"\/\u5b66\u800c\u601d\u7f51\u6821_\u7b14\u8bb0\u62cd\u7167","local_ctime":1616661547,"pl":2,"fs_id":637843594741179},{"tkbind_id":0,"category":2,"unlist":0,"fs_id":777065276343905,"server_filename":"11\u6708 25 \u65e5 \u7eaa\u534e\u5f3a\u8001\u5e08\u5f55\u97f3.mp3","pl":1,"server_atime":0,"server_ctime":1603782275,"wpfile":0,"local_mtime":1543809714,"md5":"6ed6da1a3h5906afbc4f19faadb23758","share":0,"size":28486582,"path":"\/11\u6708 25 \u65e5 \u7eaa\u534e\u5f3a\u8001\u5e08\u5f55\u97f3.mp3","local_ctime":1603423789,"server_mtime":1603782275,"isdir":0,"oper_id":3557122370},{"tkbind_id":0,"category":6,"unlist":0,"fs_id":3452308704614,"server_filename":"2021\u84dd\u6865\u676f\u6559\u5b66\u8d44\u6599.zip","pl":1,"server_atime":0,"server_ctime":1610359329,"wpfile":0,"local_mtime":1610358648,"md5":"b4c47ee77ga89d6bbebe6123068ab6c4","share":0,"size":673144682,"path":"\/2021\u84dd\u6865\u676f\u6559\u5b66\u8d44\u6599.zip","local_ctime":1610358624,"server_mtime":1616917155,"isdir":0,"oper_id":0},{"tkbind_id":0,"category":6,"unlist":0,"fs_id":460134742347936,"server_filename":"\u6d41\u5229\u7ea7.zip","pl":0,"server_atime":0,"server_ctime":1517398197,"wpfile":0,"local_mtime":1517396220,"md5":"9adecc71fb060e3f4c24ee7e490f8541","share":0,"size":749621215,"path":"\/\u6d41\u5229\u7ea7.zip","local_ctime":1517396116,"server_mtime":1604046088,"isdir":0,"oper_id":0},{"tkbind_id":0,"category":4,"unlist":0,"fs_id":233345981142356,"server_filename":"\u5168\u7403\u7f51\u7edc\u5b89\u5168\u653f\u7b56\u6cd5\u5f8b\u52a8\u6001\u4e0e\u7814\u5224\uff082020\uff09.pdf","pl":1,"server_atime":0,"server_ctime":1615343693,"wpfile":0,"local_mtime":1615343103,"md5":"ad6d0ea05n27220f91e7076b6889a71c","share":0,"size":5835979,"path":"\/\u5168\u7403\u7f51\u7edc\u5b89\u5168\u653f\u7b56\u6cd5\u5f8b\u52a8\u6001\u4e0e\u7814\u5224\uff082020\uff09.pdf","local_ctime":1615342943,"server_mtime":1615854182,"isdir":0,"oper_id":0},{"tkbind_id":0,"category":6,"unlist":0,"fs_id":255371713050079,"server_filename":"\u5165\u95e8\u7ea7.zip","pl":0,"server_atime":0,"server_ctime":1517404222,"wpfile":0,"local_mtime":1517396230,"md5":"168c8b867526423e509c75cc8ac9d1c2","share":0,"size":1426500213,"path":"\/\u5165\u95e8\u7ea7.zip","local_ctime":1517396106,"server_mtime":1604046053,"isdir":0,"oper_id":0},{"tkbind_id":0,"category":4,"unlist":0,"fs_id":675484571243840,"server_filename":"\u8f6f\u4ef6\u5b89\u5168\u5f00\u53d1\u751f\u547d\u5468\u671f\u970d\u534e\u5fb7\u7b49.\u626b\u63cf\u7248.pdf","pl":0,"server_atime":0,"server_ctime":1520773868,"wpfile":0,"local_mtime":1520682224,"md5":"94332810cb83778476598b5c4fb7d21e","share":0,"size":236591696,"path":"\/\u8f6f\u4ef6\u5b89\u5168\u5f00\u53d1\u751f\u547d\u5468\u671f\u970d\u534e\u5fb7\u7b49.\u626b\u63cf\u7248.pdf","local_ctime":1520679916,"server_mtime":1620986595,"isdir":0,"oper_id":0},{"tkbind_id":0,"category":6,"unlist":0,"fs_id":1045017646645772,"server_filename":"\u63d0\u9ad8\u7ea7.zip","pl":0,"server_atime":0,"server_ctime":1517403823,"wpfile":0,"local_mtime":1517396210,"md5":"546fdc1a9ecf2972e2776ea78ebbad4a","share":0,"size":1291635955,"path":"\/\u63d0\u9ad8\u7ea7.zip","local_ctime":1517396098,"server_mtime":1604046069,"isdir":0,"oper_id":0}],"request_id":106970032536563359,"guid":0}

        }

        /// <summary>
        /// 获取文件信息
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<System.IO.Stream> GetFileinfo(string token)
        {
            string fids = "[233345981142356]";
            string uri = $"https://pan.baidu.com/rest/2.0/xpan/multimedia?method=filemetas&access_token={token}&fsids={fids}&dlink=1";
            return await uri.GetAsStreamAsync();
            //{ "errmsg":"succ","errno":0,"list":[{ "category":4,"dlink":"https://d.pcs.baidu.com/file/ad6d0ea05n27220f91e7076b6889a71c?fid=3557122370-250528-233345981142356\u0026rt=pr\u0026sign=FDtAERV-DCb740ccc5511e5e8fedcff06b081203-T40LAlORfbWLOhxxihepugcAhLg%3D\u0026expires=8h\u0026chkbd=0\u0026chkv=2\u0026dp-logid=3028964734660690750\u0026dp-callid=0\u0026dstime=1622711880\u0026r=343482765\u0026origin_appid=23876232\u0026file_type=0","filename":"全球网络安全政策法律动态与研判（2020）.pdf","fs_id":233345981142356,"isdir":0,"md5":"ad6d0ea05n27220f91e7076b6889a71c","oper_id":0,"path":"/全球网络安全政策法律动态与研判（2020）.pdf","server_ctime":1615343693,"server_mtime":1615854182,"size":5835979}],"names":{ },"request_id":"3028870447854084217"}

        }
        /// <summary>
        /// 获取网盘容量
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<string> GetQuota(string token)
        {
            string uri = $"https://pan.baidu.com/api/quota?checkfree=1&checkexpire=1&access_token={token}";
            return await uri.GetAsStringAsync();
            //{"errno":0,"total":16612396630016,"free":3418257096704,"request_id":106806504993023675,"expire":false,"used":688411568938}


        }
        /// <summary>
        /// 获取网盘容量
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<string> GetQuota2(string token)
        {
            string uri = $"api/quota?checkfree=1&checkexpire=1&access_token={token}";
            return await uri.SetClient("baidu_pan").GetAsStringAsync();
            //{"errno":0,"total":16612396630016,"free":3418257096704,"request_id":106806504993023675,"expire":false,"used":688411568938}


        }
    }
}
