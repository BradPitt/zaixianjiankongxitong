
function initWaterBoxData(stationName,updata){
    clearInterval(Handler_dcontent);
    if(!updata){
        //$(".waterBox .d.content > ul.sbUL li").width($(".waterBox .d.content > ul.sbUL").width() / 3 - 20);
        
        //$(".waterBox .d.content > ul.sbUL li:nth-child(4)").css("background", "red"); 
        $(".waterBox .d.content > ul.sbUL li:nth-child(1)").width($(".waterBox .d.content > ul.sbUL").width() * 0.22);
        $(".waterBox .d.content > ul.sbUL li:nth-child(2)").width($(".waterBox .d.content > ul.sbUL").width() * 0.5);
        $(".waterBox .d.content > ul.sbUL li:nth-child(3)").width($(".waterBox .d.content > ul.sbUL").width() * 0.22);

        $(".waterBox .d.content > ul.sbUL li:nth-child(4)").width($(".waterBox .d.content > ul.sbUL").width() * 0.22);
        $(".waterBox .d.content > ul.sbUL li:nth-child(5)").width($(".waterBox .d.content > ul.sbUL").width() * 0.5);
        $(".waterBox .d.content > ul.sbUL li:nth-child(6)").width($(".waterBox .d.content > ul.sbUL").width() * 0.22);

        $(".waterBox .d.content > ul.sbUL li").each(function(index, el) {
            if(index >= 3){
                $(el).height($(".waterBox .d.content > ul.sbUL").height() - $(".waterBox .d.content > ul.sbUL li").eq(0).height() - 24);
            }
        });
        $(".waterBox .d.content > ul.videoUL li").height($(".waterBox .d.content > ul.videoUL").height()/2 - 12);
        $(".waterBox .d.content video").each(function(index, el) {
            $(el).attr("width",$(el).closest('li').width());
            $(el).attr("height",$(el).closest('li').height() - 40);
        });
        $.getScript("/js/video.min.js");
        setSBZT = function(){
                $(deviceStaus).html("");
                siteOption.station[stationName].info.forEach(function(item,i){
                    if("安装位置,型号,温度,湿度,设备健康度,连续无故障运行时间,通讯线路".indexOf(item[0]) != -1){
                        if(item[0] == "安装位置")
                            $(deviceStaus).append($("<li>").html("经度：" + unti.formatDegree(item[1][0]) + " 纬度：" + unti.formatDegree(item[1][1])));
                        else if(item[0] == "设备健康度"){
                            $(deviceStaus).append($("<li>",{"class":"jiankangdu"}).html('<span>健康度：</span><b style="width:'+ ($(deviceStaus).width() - 130) +'px"><span>0</span><i style="width:'+item[1]+'%"><span>'+item[1]+'</span></i><span>100</span></b>'));
                        } else if(item[0] == "通讯线路"){
                            $(deviceStaus).append($("<li>").html(item[0] + "情况：" + item[1]));
                        }
                        else
                            $(deviceStaus).append($("<li>").html(item[0] + "：" + item[1]));
                    }
                })
        }

         setZYSBQK = function(){
                $(coreDeviceStaus).html("");
                siteOption.station[stationName].monitordevicerelainfoList.forEach(function(item,i){
                    $(coreDeviceStaus).append('<li class="jiankangdu" data-title="'+item.name+'<br>最后一次运行时间：'+(item.bgnDt == undefined ? "--" : unti.formatDate(item.bgnDt,"yyyy-MM-dd HH"))+'"><span class="liname">'+item.name+'：</span><b style="width:'+($(deviceStaus).width() - 80)+'px"><span>0</span><i style="width:'+item.heal+'%"><span>'+item.heal+'</span></i><span>100</span></b></li>');
                })
                addToolTipHander($(coreDeviceStaus).find('li'),0);
        }
         setQiXiangZT = function(){
             $(QiXiangStaus).html("");
             var tempS = "<li>能见度</li><li>雨量</li><li>总辐射</li><li>红外辐射</li><li>日照时间</li>"
                 + "<li>20m</li><li>100ml</li><li>100</li><li>366</li><li>3h</li>"
                                + "<li>空气二氧化碳</li><li>气温</li><li>湿度</li><li>气压</li><li>风速1</li>"
             + "<li>20</li><li>25°</li><li>236</li><li>52</li><li>30</li>"
             + "<li>风速2</li><li>风速3</li><li>风速4</li><li>风速5</li><li>风速6</li>"
             + "<li>20</li><li>25°</li><li>236</li><li>52</li><li>30</li>"
             + "<li>风速7</li><li>风速8</li><li>风速9</li><li>风速10</li><li>风速6</li>"
             + "<li>20</li><li>25°</li><li>236</li><li>52</li><li>30</li>"
             $(QiXiangStaus).append(tempS);
        }
         setBZJ = function(){
            $(pumpStaus).html("");
            siteOption.station[stationName].pumpList.forEach(function(item,i){
                $(pumpStaus).append('<li data-title="'+item.compName+'<br>最后一次运行时间：'+(item.nestRunDt == undefined ? "--" : unti.formatDate(item.nestRunDt,"yyyy-MM-dd HH"))+'"><span class="sta '+(item.heal == undefined ? "err" : (item.heal != 100 ? "err" : "ok"))+'"></span><span class="liname">'+item.compName+'</span></li>');
            })
            addToolTipHander($(pumpStaus).find('li'),1);
        }
         setBJZT = function(){
            $(alarmStatus).html("");
            $(alarmStatus).closest('li').find('.masbox').addClass('active');
            siteOption.station[stationName].monitorlogList.forEach(function(item,i){
                $(alarmStatus).append('<li class="'+(function(){
                    if(item.logType == "I") return "thao";
                    else if(item.logType == "W") return "gjing";
                    else if(item.logType == "E") return "gzhang";
                    else return "thao";
                }())+'" data-title="'+item.logText+'<br>' + unti.formatDate(item.logDt,"MM-dd HH:mm:ss") + '"><span style="width:'+($(alarmStatus).width()/2)+'px"><icon></icon><span style="width:'+($(alarmStatus).width()/2 - 30)+'px">'+item.logText+'</span></span><span  style="width:'+($(alarmStatus).width()/2 - 10)+'px">'+unti.formatDate(item.logDt,"MM-dd HH:mm:ss")+'</span></li>');
            })
            addToolTipHander($(alarmStatus).find('li'),1);
         }
        // 水文
         setShuiWen = function () {
            // formatMoniVal(stationName);
             $(ShuiWenStaus).html("");

             var tempS = "<li>水深</li><li>5M</li><li>水位</li><li>50</li>"
             +"<li>最大波高</li><li>最大波周期</li><li class='w20'>平均波高</li><li class='w20'>平均波周期</li>"
                                  + "<li>有效波高</li><li>有效波周期</li><li>波向</li><li>22</li>";
             $(ShuiWenStaus).append(tempS);
    
         }
        setQiXiangZT();
        setSBZT();
        setZYSBQK();
        setShuiWen();
       // setBZJ();
        setDcontent(stationName);
        setBJZT();

        Handler_dcontent = setInterval(function(){
            setSBZT();
            setZYSBQK();
            setFMZT();
            setBZJ();
            setDcontent(stationName);
            setBJZT();
            console.log("update dcontent");
        },refesTime);
    } else {
        Handler_dcontent = setInterval(function(){
            setSBZT();
            setZYSBQK();
            setFMZT();
            setBZJ();
            setDcontent(stationName);
            setBJZT();
            console.log("update dcontent");
        },refesTime);
    }
}
function setDcontent(stationName){
    // small map
    /**
     * 地图配置信息
     * @type {Object}
     */
    $(".waterBox .d.content span.station_positon").html("经度：<font color='#fff'>" + unti.formatDegree(siteOption.station[stationName].info[0][1][0]) + "</font>   维度：<font color='#fff'>" + unti.formatDegree(siteOption.station[stationName].info[0][1][1])) + "</font>";
    var stationOption = {
        geo: {
            map: 'china',
            center:[119.505556, 32.915128],
            label: {
                emphasis: {
                    show: false
                }
            },
            itemStyle: {
                normal: { //普通样式
                    areaColor: 'rgba(0,0,0,0)',
                    borderWidth: 3,
                    borderColor: '#76d1fd',
                    shadowColor: '#1a2f86',
                    shadowBlur: 7,
                    shadowOffsetX: -5,
                    shadowOffsetY: 5
                },
                emphasis: { //hover样式
                    areaColor: 'rgba(0,0,0,0.2)'
                }
            },
            left: 'center',
            roam: false,
            silent:true,
            zoom: 1
        },
        series: [{
            name: 'stationmap',
            type: 'effectScatter',
            coordinateSystem: 'geo',
            zlevel: 2,
            showEffectOn:'emphasis',
            silent:true,
            symbol: chinaMapConfig.point[1],
            symbolSize: chinaMapConfig.point_size[0],
            symbolOffset: ['0', '-45%'],
            silent:true,
            data: [{
                name:stationName,
                value:chinaCoordMap[stationName],
            }]
        }]
    };
    var smallChart = echarts.init($(".waterBox .d.content > ul > li div.canvas")[0]);
    $.get('/js/china.json', function(geoJson) {
        echarts.registerMap('china', geoJson);
        smallChart.setOption(stationOption);
    })
}