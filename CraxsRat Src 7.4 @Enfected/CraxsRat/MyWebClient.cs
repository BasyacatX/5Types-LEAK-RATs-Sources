using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Eagle_Spy;

public class MyWebClient : WebClient
{
	protected override WebRequest GetWebRequest(Uri address)
	{
		WebRequest webRequest = base.GetWebRequest(address);
		if (webRequest is HttpWebRequest)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)webRequest;
			httpWebRequest.ClientCertificates.Add(new X509Certificate());
			httpWebRequest = null;
		}
		return webRequest;
	}
}
