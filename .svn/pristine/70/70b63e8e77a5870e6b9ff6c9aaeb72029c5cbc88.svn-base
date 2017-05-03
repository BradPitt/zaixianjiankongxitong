var siteOption = {
  domain:window.location.protocol + "//" + window.location.host,
  title:"",
  center:'北海监测中心',
  nowCenter:'',
  station:{}
}


var isChrome = window.navigator.userAgent.indexOf("Chrome") !== -1;
var nowOpenStation = null;
var refesTime = 600000;//600000
var chinaCoordMap = {};
var startFindTooltipTimeHandler;
var wheel = {};
var tooltipHasOn;
wheel.scrollNum = 70.0;
wheel.tY = wheel.tYY = wheel.barY = 0;
wheel.noAnim = null;
var tooltip = false;
var position = { x: 0, y: 0, xx: 0, yy: 0 };
var chinaMapSeries = [];
var contentScal = {};
var titleH = $("body > div.title").height() + 40;
var Ratio = 4 / 3,
        defW = 1440,
        defH = 1280;
var wH = ($(window).height() < 768 ? 768 : $(window).height());
var wW = ($(window).width() < 1024 ? 1024 : $(window).width());
var removeatooltip;
var Handler_acontent,Handler_bcontent,Handler_ccontent,Handler_dcontent,Handler_econtent,Handler_content;
var setYBP,setSBZT,setZYSBQK,setFMZT,setBZJ,setBJZT,setQX,setPICSTU,setLOGLIST;


// 更新数据 监测仪
function setValue(){
        var stations = eval('(' + data.value + ')');
        siteOption.center = stations.center[0].name;
        siteOption.station = {};
        siteOption.station[stations.center[0].name] = {
            status:true,
            info:[['安装位置',[stations.center[0].lon,stations.center[0].lat]]]
        };
        siteOption.panels = stations.panels;
        stations.listInfo.forEach(function(item,i){
        	siteOption.panels = item.monipameinfoList; // by xp
        	var rowData;
        	if(item.monipamedataList &&item.monipamedataList[0]){
        		rowData= item.monipamedataList[0];
        	}
            siteOption.station[item.name] = {
                id:item.id,
                status:(item.commStus == 100 ? true : false),
                deviType:item.deviType,
                info:[['安装位置',[item.lon == undefined ? "--" : item.lon,item.lat == undefined ? "--" : item.lat]],
                  ['型号',item.model == undefined ? "--" : item.model],
                  ['设备健康度',item.heal == undefined ? 0 : item.heal],
                  ['通讯线路', item.commStus == 100 ? '正常 ':'中断'],
                  ['太阳能电池板', rowData == undefined ? "--" : rowData.moniVal85 == undefined ? "--" : rowData.moniVal85],
                  ['电池', rowData == undefined ? "--" : rowData.moniVal86 == undefined ? "--" : rowData.moniVal86],
                  ['舱门开启', rowData == undefined ? "--" : rowData.moniVal83 == 1 ? '<span class="fontRed">开启</span> ':'<span class="fontGreen">未开启</span>'],
                  ['舱内进水', rowData == undefined ? "--" :rowData.moniVal84 == 1 ? '<span class="fontRed">进水 </span>':'<span class="fontGreen">未进水</span>'],
                  ['位置偏移报警', [rowData == undefined ? "--" :rowData.lon == undefined ? "--" : rowData.lon,rowData == undefined ? "--" :rowData.lat == undefined ? "--" : rowData.lat]],
                  ['最后一次监测时间',item.nestRunDt == undefined ? "--" : item.nestRunDt],
                  ['连续无故障运行时间',item.trFrRunTime == undefined ? "--" : item.trFrRunTime],
                  ['温度',item.wendi == undefined ? "--" : item.wendi],
                  ['湿度',item.shidu == undefined ? "--" : item.shidu]
                ].concat((function(){
                    var ybpArr = [];
                    if("marimoni"===item.deviType || "fremoni" === item.deviType){// 检测仪
                    	siteOption.panels.forEach(function(item2, index) {
                            ybpArr.push([item2.cnName,(function(){
                              var prec = item2.dispPrec == undefined ? 2 : item2.dispPrec.length-2;
                              if(item.monipamedataList==undefined || item.monipamedataList[0]==undefined){
                                return "--";
                              }else if(item.monipamedataList[0]["moniVal"+item2.id]==undefined || item.monipamedataList[0]["moniVal"+item2.id].indexOf('99999999999') != -1){
                                var val = "--";
                                for(var i =0;i<item.monipamedataList.length;i++){
                                  if(item.monipamedataList[i]["moniVal"+item2.id] != undefined && item.monipamedataList[i]["moniVal"+item2.id].indexOf('99999999999') == -1){
                                    val = parseFloat(item.monipamedataList[i]["moniVal"+item2.id]).toFixed(prec) +(item2.unit==undefined ? "" :item2.unit);
                                    break;
                                  }
                                }
                                return val;
                              }else {// 浮标
                                return parseFloat(item.monipamedataList[0]["moniVal"+item2.id]).toFixed(prec) +(item2.unit==undefined ? "" :item2.unit)
                              }
                            }())]);
                        });
                    }else{
                    	siteOption.panels.forEach(function(item2, index) {
                            ybpArr.push([item2.cnName,(function(){
                              var prec = item2.dispPrec == undefined ? 2 : item2.dispPrec.length-2;
                              if(item.monipamedataList==undefined || item.monipamedataList[0]==undefined){
                                return "--";
                              }else if(item.monipamedataList[0]["moniVal"+item2.id]==undefined || item.monipamedataList[0]["moniVal"+item2.id].indexOf('99999999999') != -1){
                                var val = "--";
                                for(var i =0;i<item.monipamedataList.length;i++){
                                  if(item.monipamedataList[i]["moniVal"+item2.id] != undefined && item.monipamedataList[i]["moniVal"+item2.id].indexOf('99999999999') == -1){
                                    val = parseFloat(item.monipamedataList[i]["moniVal"+item2.id]).toFixed(prec) +(item2.unit==undefined ? "" :item2.unit);
                                    break;
                                  }
                                }
                                return val;
                              }else {// 浮标
                                return parseFloat(item.monipamedataList[0]["moniVal"+item2.id]).toFixed(prec) +(item2.unit==undefined ? "" :item2.unit)
                              }
                            }())]);
                        });
                    }
                    
                    return ybpArr;
                }())),
                monipamedataList:item.monipamedataList,
                monitordevicerelainfoList:item.monitordevicerelainfoList,
                valveList:item.valveList,
                pumpList:item.pumpList,
                monitorlogList:item.logList,
                monipameinfoList:item.monipameinfoList
            }
        })
    }

//更新数据  浮标
function setValueBuoy(nowOpenId){
        var stations = eval('(' + data.value + ')');
        siteOption.center = stations.center[0].name;
        siteOption.station = {};
        siteOption.station[stations.center[0].name] = {
            status:true,
            info:[['安装位置',[stations.center[0].lon,stations.center[0].lat]]]
        };
        siteOption.panels = stations.panels;
        stations.listInfo.forEach(function(item,i){
        	siteOption.panels = item.monipameinfoList; // by xp
        	var rowData;
        	if(item.monipamedataList &&item.monipamedataList[0]){
        		rowData= item.monipamedataList[0];
        	}
        	
            siteOption.station[item.name] = {
                id:item.id,
                status:(item.commStus == 100 ? true : false),
                deviType:item.deviType,
                info:[['安装位置',[item.lon == undefined ? "--" : item.lon,item.lat == undefined ? "--" : item.lat]],
                  ['型号',item.model == undefined ? "--" : item.model],
                  ['设备健康度',item.heal == undefined ? 0 : item.heal],
                  ['通讯线路', item.commStus == 100 ? '正常 ':'中断'],
                  ['太阳能电池板', rowData == undefined ? "--" : rowData.moniVal85 == undefined ? "--" : rowData.moniVal85],
                  ['电池', rowData == undefined ? "--" : rowData.moniVal86 == undefined ? "--" : rowData.moniVal86],

                  ['舱门开启', rowData == undefined ? "--" : rowData.moniVal83 == 1 ? '开启':'未开启'],
                  ['舱内进水', rowData == undefined ? "--" :rowData.moniVal84 == 1 ? '进水':'未进水'],
                  ['位置偏移报警', [rowData == undefined ? "--" :rowData.lon == undefined ? "--" : rowData.lon,rowData == undefined ? "--" :rowData.lat == undefined ? "--" : rowData.lat]],
                  ['最后一次监测时间',item.nestRunDt == undefined ? "--" : item.nestRunDt],
                  ['连续无故障运行时间',item.trFrRunTime == undefined ? "--" : item.trFrRunTime],
                  ['温度',item.wendi == undefined ? "--" : item.wendi],
                  ['湿度',item.shidu == undefined ? "--" : item.shidu]
                ].concat((function(){
                    var ybpArr = [];
                    if("marimoni"===item.deviType || "fremoni" === item.deviType){// 检测仪
                    	siteOption.panels.forEach(function(item2, index) {
                            ybpArr.push([item2.cnName,(function(){
                              var prec = item2.dispPrec == undefined ? 2 : item2.dispPrec.length-2;
                              if(item.monipamedataList==undefined || item.monipamedataList[0]==undefined){
                                return "--";
                              }else if(item.monipamedataList[0]["moniVal"+item2.id]==undefined || item.monipamedataList[0]["moniVal"+item2.id].indexOf('999') != -1){
                                var val = "--";
                                for(var i =0;i<item.monipamedataList.length;i++){
                                  if(item.monipamedataList[i]["moniVal"+item2.id] != undefined && item.monipamedataList[i]["moniVal"+item2.id].indexOf('999') == -1){
                                    val = parseFloat(item.monipamedataList[i]["moniVal"+item2.id]).toFixed(prec) +(item2.unit==undefined ? "" :item2.unit);
                                    break;
                                  }
                                }
                                return val;
                              }else {// 浮标
                                return parseFloat(item.monipamedataList[0]["moniVal"+item2.id]).toFixed(prec) +(item2.unit==undefined ? "" :item2.unit)
                              }
                            }())]);
                        });
                    }else{
                    	siteOption.panels.forEach(function(item2, index) {
                            ybpArr.push([item2.cnName,(function(){
                              var prec = item2.dispPrec == undefined ? 2 : item2.dispPrec.length-2;
                              if(item.monipamedataList==undefined || item.monipamedataList[0]==undefined){
                                return "--";
                              }else if(item.monipamedataList[0]["moniVal"+item2.id]==undefined || item.monipamedataList[0]["moniVal"+item2.id].indexOf('999') != -1){//99999999999
                                var val = "--";
                                for(var i =0;i<item.monipamedataList.length;i++){
                                  if(item.monipamedataList[i]["moniVal"+item2.id] != undefined && item.monipamedataList[i]["moniVal"+item2.id].indexOf('999') == -1){
                                    val = parseFloat(item.monipamedataList[i]["moniVal"+item2.id]).toFixed(prec) +(item2.unit==undefined ? "" :item2.unit);
                                    break;
                                  }
                                }
                                return val;
                              }else {// 浮标
                                return parseFloat(item.monipamedataList[0]["moniVal"+item2.id]).toFixed(prec) +(item2.unit==undefined ? "" :item2.unit)
                              }
                            }())]);
                        });
                    }
                    
                    return ybpArr;
                }())),
                monipamedataList:item.monipamedataList,
                monitordevicerelainfoList:item.monitordevicerelainfoList,
                valveList:item.valveList,
                pumpList:item.pumpList,
                monitorlogList:item.logList,
                monipameinfoList:item.monipameinfoList
            }
        })
    }
// 计算两个经纬度之间的距离
function GetDistance( lat1,  lng1,  lat2,  lng2){
	if( ( Math.abs( lat1 ) > 90  ) ||(  Math.abs( lat2 ) > 90 ) ){
		return "0";
	}
	if( ( Math.abs( lng1 ) > 180  ) ||(  Math.abs( lng2 ) > 180 ) ){
		return "0";
	}
	var radLat1 = rad(lat1);
	var radLat2 = rad(lat2);
	var a = radLat1 - radLat2;
	var  b = rad(lng1) - rad(lng2);
	var s = 2 * Math.asin(Math.sqrt(Math.pow(Math.sin(a/2),2) +
	Math.cos(radLat1)*Math.cos(radLat2)*Math.pow(Math.sin(b/2),2)));
	s = s *6378.137 ;// EARTH_RADIUS;
	s = Math.round(s * 10000) / 10000;
	return s;
}
function rad(d)
{
	return d * Math.PI / 180.0;
}