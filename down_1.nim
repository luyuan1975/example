import os, nre, sequtils, httpclient, asyncdispatch

let dir = "22k.im"
let url = "http://m.xxx.yy/"

var num = 0
var url2 = "https://k3.syasn.com/"

proc getFile ( down:seq ) =
    var flag = false
    var name = down[0] & ".mp4"
    var url = url2 & down[1] & '/' & name & "?end=300"

    var ff= newSeq[string](0)

    var album = dir & down[2]
    if existsDir(album) :
        for key, path in walkDir(album) : ff.add(path)
    else :
        createDir(album)

    if ff != @[] :
        if ff.any( proc (x: string): bool = return x.contains( re(name) ) ) : flag = true

    if flag : return
    echo url
    var client = newAsyncHttpClient(userAgent = "Mozilla")
    discard client.downloadFile(url, album & '/' & name)
    inc num

proc getHref( url : string, t = 1 ) =
    var client = newHttpClient(userAgent = "Mozilla")
    client.headers = newHttpHeaders( { "Cookie": "qp=p3" } )
    var output = client.getContent(url)
    client.close()

    if 1 == t :
        var p21 = output.replace( re(r".*<div id=""wr(.*)id=""zj.*id=""jb(.*)id=""xm.*"), "$1~$2" ).split(re"~")
        var down = p21[0].replace( re(r".*rel=""(.*?)"".*?type=""(.*?)"".*href=""(.*?)"".*"), "$1 $2 $3" ).split(re" ")
        getFile(down)

        for v in p21[1].findAll( re(r"<a href=.*?</a>") ) :
            var p22 = v.replace( re(r".*href=""(.*?)"".*"), "$1" )
            if p22.contains(re"/.*/.*") : continue
            p22 = url.replace( re"(.*)/(.*)", "$1") & p22
            getHref( p22, 2 )
    else :
        output = output.replace( re(r".*<div id=""wr(.*)id=""zj.*"), "$1" )
        var down = output.replace( re(r".*rel=""(.*?)"".*?type=""(.*?)"".*href=""(.*?)"".*"), "$1 $2 $3" ).split(re" ")
        getFile(down)

proc main() {.async.} =
    #if commandLineParams() != @[] :
    if paramCount() > 0 :
        url2 = commandLineParams()[0]
        if not url2.contains( re"http.*" ) :
            quit("please input like : getUrl http://ki.syasn.com/ .")

    var client = newHttpClient(userAgent = "Mozilla")
    var content = client.getContent(url)
    client.close()
    content = content.replace( re(r".*div class=""hm2"">(.*)</div><div id=""hf.*"), "$1" )

    for v in content.findAll( re(r"<a id=.*?</a>") ) :
        var info = v.replace( re(r".*href=""(.*?)"".*src=""(.*?)"" .*"), "$1 $2" ).split(re" ")
        getHref( url & info[0] )

    echo("this time download " & $num & " files")

waitFor main()
