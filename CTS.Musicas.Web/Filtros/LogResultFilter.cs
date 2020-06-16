using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTS.Musicas.Web.Filtros
{
    public class LogResultFilter : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //[data/hora/ Resultado: [controller]/[action] | Resultado
            string mensagem = string.Format("[{0}] Resultado: {1}/{2} | {3}",
                                            DateTime.Now.ToString(),
                                            filterContext.RouteData.Values["Controller"].ToString(),
                                            filterContext.RouteData.Values["Action"].ToString(),
                                            filterContext.Result.ToString());
            //pode ser gravado no banco de dados
            Debug.WriteLine(mensagem);
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //[data/hora/ Processando resultados: [controller]/[action] | Resultado
            string mensagem = string.Format("[{0}] Processando resultados...: {1}/{2} | {3}",
                                            DateTime.Now.ToString(),
                                            filterContext.RouteData.Values["Controller"].ToString(),
                                            filterContext.RouteData.Values["Action"].ToString(),
                                            filterContext.Result.ToString());
            //pode ser gravado no banco de dados
            Debug.WriteLine(mensagem);
        }
    }
}