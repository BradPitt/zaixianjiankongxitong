
function initBcontent(updata){
    clearInterval(Handler_bcontent);
    if(!updata){
        setLOGLIST = function(){
            $(logList).html("<div></div>");
            siteOption.station[nowOpenStation].monitorlogList.forEach(function(item,i){
                var classname = "thao";
                if(item.logType == "I") classname = "thao";
                if(item.logType == "W") classname =  "gjing";
                if(item.logType == "E") classname =  "gzhang";
                $(logList).children('div').append('<li class="'+classname+'" data-title="'+item.logText+'<br>'+unti.formatDate(item.logDt,"MM-dd HH:mm:ss")+'"><span style="width:'+($(logList).width()-160)+'px"><icon></icon><span style="width:'+($(logList).width()-190)+'px">'+item.logText+'</span></span><span style="width:120px">'+unti.formatDate(item.logDt,"MM-dd HH:mm:ss")+'</span></li>');
            })
            addToolTipHander($(logList).find('li'),0);
        }
        setLOGLIST();
        if($("#planetmap").length > 0) $(planetmap).remove();
        var $map = $("<div>",{"id":"planetmap"});
        $(imgScreen).append($map);
        // <area shape="circle" coords="180,139,14" href ="venus.html" alt="Venus" />
        siteOption.station[nowOpenStation].valveList.forEach(function(item,i){
            if(i >= 16) return;
            var leftTop = {left:0,top:0};
            switch(i) {
                case 0:
                    leftTop.left = '150px';
                    leftTop.top = '107px';
                    break;
                case 1:
                    leftTop.left = '240px';
                    leftTop.top = '108px';
                    break;
                case 2:
                    leftTop.left = '343px';
                    leftTop.top = '108px';
                    break;
                case 3:
                    leftTop.left = '570px';
                    leftTop.top = '115px';
                    break;
                case 4:
                    leftTop.left = '150px';
                    leftTop.top = '297px';
                    break;
                case 5:
                    leftTop.left = '241px';
                    leftTop.top = '296px';
                    break;
                case 6:
                    leftTop.left = '570px';
                    leftTop.top = '301px';
                    break;
                case 7:
                    leftTop.left = '132px';
                    leftTop.top = '45px';
                    break;
                case 8:
                    leftTop.left = '403px';
                    leftTop.top = '44px';
                    break;
                case 9:
                    leftTop.left = '482px';
                    leftTop.top = '44px';
                    break;
                case 10:
                    leftTop.left = '557px';
                    leftTop.top = '44px';
                    break;
                case 11:
                    leftTop.left = '361px';
                    leftTop.top = '187px';
                    break;
                case 12:
                    leftTop.left = '442px';
                    leftTop.top = '188px';
                    break;
                case 13:
                    leftTop.left = '498px';
                    leftTop.top = '207px';
                    break;
                case 14:
                    leftTop.left = '278px';
                    leftTop.top = '52px';
                    break;
                case 15:
                    leftTop.left = '45px';
                    leftTop.top = '302px';
                    break;
            }

            $map.append('<div class="fm '+(i==13?"spicStaus ":" ")+'picStaus '+(item.heal!=100?"err":"ok")+'" style="left:'+leftTop.left+';top:'+leftTop.top+';"><i></i>'+(i==13?"<br>":"")+'<span>'+item.compName+'</span></div>');
        })
        siteOption.station[nowOpenStation].pumpList.forEach(function(item,i){
            var leftTop = {left:0,top:0};
            switch(i) {
                case 0:
                    leftTop.left = '27px';
                    leftTop.top = '98px';
                    break;
                case 1:
                    leftTop.left = '83px';
                    leftTop.top = '21px';
                    break;
                case 2:
                    leftTop.left = '44px';
                    leftTop.top = '356px';
                    break;
                }
            $map.append('<div class="bb picStaus '+(item.heal!=100?"err":"ok")+'" style="left:'+leftTop.left+';top:'+leftTop.top+';"><i></i><span>'+item.compName+'</span></div>');
        })
        siteOption.station[nowOpenStation].monitordevicerelainfoList.forEach(function(item,i){
            var leftTop = {left:0,top:0};
            switch(i) {
                case 0:
                    leftTop.left = '118px';
                    leftTop.top = '158px';
                    break;
                case 1:
                    leftTop = {
                        left: '208px',
                        top: '157px'
                    }
                    break;
                case 2:
                    leftTop = {
                        left: '539px',
                        top: '157px'
                    }
                    break;
                }
            $map.append('<div class="sb picStaus bigpicStaus '+(item.heal!=100?"err":"ok")+'" style="left:'+leftTop.left+';top:'+leftTop.top+';"><i></i><span>'+((i==1?"TP TN COD<br>":(i==2?"WTZ<br>":"")) + item.name)+'</span></div>');
        })
        setPICSTU = function(){
            console.log("updata img");
            siteOption.station[nowOpenStation].valveList.forEach(function(item,i){
                if(i >= 16) return;
                if(item.heal!=100){
                    $map.children('div.fm').eq(i).removeClass('ok').addClass('err');
                } else {
                    $map.children('div.fm').eq(i).removeClass('err').addClass('ok');
                }
            })
            siteOption.station[nowOpenStation].pumpList.forEach(function(item,i){
                if(i >= 16) return;
                if(item.heal!=100){
                    $map.children('div.bb').eq(i).removeClass('ok').addClass('err');
                } else {
                    $map.children('div.bb').eq(i).removeClass('err').addClass('ok');
                }
            })
            siteOption.station[nowOpenStation].monitordevicerelainfoList.forEach(function(item,i){
                if(i >= 16) return;
                if(item.heal!=100){
                    $map.children('div.sb').eq(i).removeClass('ok').addClass('err');
                } else {
                    $map.children('div.sb').eq(i).removeClass('err').addClass('ok');
                }
            })
        }
        Handler_bcontent = setInterval(function(){
            setPICSTU();
            setLOGLIST();
        },refesTime);
    } else {
        Handler_bcontent = setInterval(function(){
            setPICSTU();
            setLOGLIST();
        },refesTime);
    }
}