//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.2032.
// 
namespace Xacc.Diagnostics 
{
  using System.Diagnostics;
  using System.Xml.Serialization;
  using System;
  using System.Web.Services.Protocols;
  using System.ComponentModel;
  using System.Web.Services;
    
    
  /// <remarks/>
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name="reportSoap", Namespace="xacc::error")]
  class ErrorReport : System.Web.Services.Protocols.SoapHttpClientProtocol 
  {
        
    /// <remarks/>
    public ErrorReport() 
    {
      this.Url = "http://xacc.no-ip.info:8888/xaccerror/report.asmx";
    }
        
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("xacc::error/ReportError", RequestNamespace="xacc::error", ResponseNamespace="xacc::error", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public int ReportError(string user, string email, string details, string exception) 
    {
      object[] results = this.Invoke("ReportError", new object[] {
                                                                   user,
                                                                   email,
                                                                   details,
                                                                   exception});
      return ((int)(results[0]));
    }
        
    /// <remarks/>
    public System.IAsyncResult BeginReportError(string user, string email, string details, string exception, System.AsyncCallback callback, object asyncState) 
    {
      return this.BeginInvoke("ReportError", new object[] {
                                                            user,
                                                            email,
                                                            details,
                                                            exception}, callback, asyncState);
    }
        
    /// <remarks/>
    public int EndReportError(System.IAsyncResult asyncResult) 
    {
      object[] results = this.EndInvoke(asyncResult);
      return ((int)(results[0]));
    }
  }
}
