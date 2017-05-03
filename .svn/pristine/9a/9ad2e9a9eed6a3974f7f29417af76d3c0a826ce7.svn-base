// TODO 加载地图插件
/**
 * TODO 加载地图插件
 */
function creatChart() {
    /**
     * 地图配置信息
     * @type {Object}
     */
    setStationData();
    chinaMapOption = {
        tooltip: {
            trigger: 'item',
            backgroundColor: 'rgba(0,0,0,0)',
            borderWidth: 0,
            padding: 0,
            enterable: true,
            position: function(point, params, dom, rect) {
                // console.log(rect);
                return [rect.width < 94 ? rect.x - (94-rect.width)/2-3:rect.x-3, rect.y - 310];
            },
            formatter: function(val, str) {
                var location;
                location = chinaCoordMap[val.name];
                location.length = 2;
                if(val.name == siteOption.center) return null;
                else return tooltips(val);
            },
            textStyle:{
                fontSize:15
            }
        },
        geo: {
            map: 'china',
            center: [120.374519, 36.105802],
            label: {
                emphasis: {
                    show: false
                }
            },
            itemStyle: {
                normal: { //普通样式
                    areaColor: 'rgba(0,0,0,0)',
                    borderWidth: 5,
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
            roam: true,
            zoom: 1
        },
        series: chinaMapSeries
    };

    unti.chinaChart = echarts.init($("#chinaMap")[0]);
    $.get('/js/china.json', function(geoJson) {
        echarts.registerMap('china', geoJson);
        unti.chinaChart.setOption(chinaMapOption);
        hideLoad();
        unti.chinaChart.on('click', function (params) {
            if(params.hasOwnProperty("seriesType") && params.seriesType == "effectScatter"){
                if (params.name != siteOption.center) {
                    showdetailInfo(params.name);
                    var title = params.name;
                    var deviType = siteOption.station[title].deviType;
                    var id = siteOption.station[title].id;
                    if ("fremoni" === deviType || "marimoni" === deviType) {
                        showdetailInfo(params.name);
                    } else if ("3mbuoy" === deviType) {
                        showdetailInfo3(id);
                    } else if ("1mbuoy" === deviType) {
                        showdetailInfo1(id);
                    }
                }
                    
            }
        });
    })
}

// TODO 清空地图数据
/**
 * TODO 清空地图数据
 * @return {[type]} [description]
 */
function disposeChart() {
	if(unti.chinaChart){
		unti.chinaChart.dispose();
	}
    $("#chinaMap").html("");
}

// TODO 地图的tooltip初始化
/**
 * TODO 地图的tooltip初始化
 * @param  {[type]} val [description]
 * @return {[type]}     [description]
 */
var tooltips = function(val) {
    var tooltipStr = "";
    if("marimoni" === siteOption.station[val.name].deviType || "fremoni" === siteOption.station[val.name].deviType){
    	tooltipStr += "<div class='tooltipBox'><a onClick=showdetailInfo(\'" + val.name + "\') class='showinfo'>详细信息</a>" + "<div class='toolTitle'>设备名称：" + val.name + "</div>" ;
    }else if("1mbuoy" === siteOption.station[val.name].deviType){
    	tooltipStr += "<div class='tooltipBox'><a target='_blank'  href='/onebuoy?0&id="+ siteOption.station[val.name].id +"' class='showinfo'>详细信息</a>" + "<div class='toolTitle'>设备名称：" + val.name + "</div>" ;
   	
    }else if("3mbuoy" === siteOption.station[val.name].deviType){
    	tooltipStr += "<div class='tooltipBox'><a target='_blank'  href='/threebuoy?0&id="+ siteOption.station[val.name].id +"' class='showinfo'>详细信息</a>" + "<div class='toolTitle'>设备名称：" + val.name + "</div>" ;
   	
    }
    
    tooltipStr += "<div class='toolContent' style='" + (val.name.length > 10 ? "height:195px;" : "height:215px;") + (isChrome?"overflow-y:scroll":"")+"' data-wheel='wheel'><div><ul data-wheel='continer'>" + (function() {
        if (siteOption.station.hasOwnProperty(val.name)) {
            var listr = "";
            siteOption.station[val.name].info.forEach(function(item, i) { // 水质检测仪
            	if("marimoni" === siteOption.station[val.name].deviType || "fremoni" === siteOption.station[val.name].deviType){
            		if("连续无故障运行时间,型号,温度,湿度".indexOf(item[0]) == -1){
                        if("安装位置"==item[0]){
                            listr += "<li>" + item[0] + ":" + unti.formatDegree(item[1][0]) +"，" + unti.formatDegree(item[1][1]) + "</li>"
                        }else if("最后一次监测时间"==item[0]) {
                            listr += "<li>" + item[0] + ":" + (item[1] == "--" ? "--" : unti.formatDate(item[1],"yyyy-MM-dd HH")) + "</li>";
                        }else{
                            listr += "<li>" + item[0] + ":" + item[1] + "</li>";
                        }
            		}
            	}else{// 浮标
            		if("连续无故障运行时间,型号,温度,湿度".indexOf(item[0]) == -1){
                        if("安装位置"==item[0]){
                            listr += "<li>" + item[0] + ":" + unti.formatDegree(item[1][0]) +"，" + unti.formatDegree(item[1][1]) + "</li>"
                        }else if("最后一次监测时间"==item[0]) {
                            listr += "<li>" + item[0] + ":" + (item[1] == "--" ? "--" : unti.formatDate(item[1],"yyyy-MM-dd HH")) + "</li>";
                        }else{
                            listr += "<li>" + item[0] + ":" + item[1] + "</li>";
                        }
            		}
            	}
                
                
            })
            return listr;
        } else {
            return "<li> 获取数据失败 </li>";
        }
    }()) + "</ul></div></div>" + "<div class='tooltipbottom'></div></div>";
    return tooltipStr;
}
// TODO 加载站点信息并初始化站点详细信息
/**
 * TODO 加载站点信息并初始化站点详细信息
 * @return {[type]} [description]
 */
function showdetailInfo(stationName) {
    //初始化数据后，加载站点信息界面
    showLoad();
    $(".waterBox .title").text(stationName);
    initWaterBox(stationName);
}
function showdetailInfo1(id) {
	window.open("/onebuoy?0&id="+id,'',''); // window.open("/buoy?0&id="+id,'','width=1024,height=768');
}
function showdetailInfo3(id) {
    //window.open("Home/BuoyThree?0&id=" + id, '', ''); // window.open("/buoyThree?0&id="+id,'','width=1024,height=768');
    window.location.href = "Home/BuoyThree?0&id=" + id;
}
// TODO [chinaMapConfig ]
/**
 * TODO [chinaMapConfig ]
 * @type {Object}
 */
var chinaMapConfig = {
    /**
     * [BJData 可以连通的数据]
     * [ { name: '发起城市名' }, { name: '目的地城市名', value: 圆点的大小 } ]
     * @type {Array}
     */
    OKData: [],
    /**
     * [BJData 无法连通的数据]
     * [ { name: '发起城市名' }, { name: '目的地城市名', value: 圆点的大小 } ]
     * @type {Array}
     */
    ERRData: [],
    /**
     * [BJData 可以连通的数据]
     * [ { name: '发起城市名' }, { name: '目的地城市名', value: 圆点的大小 } ]
     * @type {Array}
     */
    OKDataFB3: [],//浮标
    /**
     * [BJData 无法连通的数据]
     * [ { name: '发起城市名' }, { name: '目的地城市名', value: 圆点的大小 } ]
     * @type {Array}
     */
    ERRDataFB3: [],//浮标
    /**
     * [curveness 城市之间线的弧度0~1]
     * @type {number}
     */
    curveness: 0.2,
    /**
     * [lineColor 城市之间线的颜色 0：可以连通 1：无法连通]
     * @type {number}
     */
    lineColor: ['#14f54d', '#f52e23'],
    /**
     * [point 城市之间运动的点的样式 0：可以连通 1：无法连通]
     * @type {number}
     */
    point: ['circle', 'image://' + siteOption.domain + '/img/ok.png', 'image://' + siteOption.domain + '/img/err.png', 'image://' + siteOption.domain + '/img/ok_fb1.png', 'image://' + siteOption.domain + '/img/err_fb1.png', 'image://' + siteOption.domain + '/img/ok_fb3.png', 'image://' + siteOption.domain + '/img/err_fb3.png', 'image://' + siteOption.domain + '/img/center.png'],
    /**
     * [point_size 城市之间运动的点的大小 0：可以连通 1：无法连通]
     * @type {number}
     */
    point_size: [
        [58, 38], 34, [94, 50]
    ],
    /**
     * [effect_size 城市之间运动的点的拖尾点的大小 0：可以连通 1：无法连通]
     * @type {number}
     */
    effect_size: [
        [6, 10], 34
    ],
    /**
     * [effect 城市之间运动的点是否显示 0：可以连通 1：无法连通]
     * @type {number}
     */
    effect: [true, false],
    dataLine: [],
    showEffectOn: ['render', 'emphasis']
}
// TODO 初始化地图数据
/**
 * TODO 初始化地图数据
 */
var setStationData = function() {
    chinaCoordMap = {};
    chinaMapConfig.OKData = [];
    chinaMapConfig.ERRData = [];
    chinaMapConfig.OKDataFB1 = [];// 1m浮标
    chinaMapConfig.ERRDataFB1 = [];// 1m浮标
    chinaMapConfig.OKDataFB3 = [];// 3m浮标
    chinaMapConfig.ERRDataFB3 = [];// 3m浮标
    var newStation = {};
    var className = '';
    $("body > .content > .content_right ul").html("");
    $.each(siteOption.station, function(index, val) {
        newStation[eval("'" + index + "'")] = val.info[0][1];
        $.extend(chinaCoordMap, newStation);
        if (index != siteOption.center) {
            if (val.status) {
                className = '';
                if("marimoni" === val.deviType){
					chinaMapConfig.OKData.push([{ name: siteOption.center }, { name: index, value: 100 }])
				}else if("1mbuoy" === val.deviType) {
					chinaMapConfig.OKDataFB1.push([{ name: siteOption.center }, { name: index, value: 100 }])
                }else if("3mbuoy" === val.deviType) {//3m浮标
					chinaMapConfig.OKDataFB3.push([{ name: siteOption.center }, { name: index, value: 100 }])
                }
            } else {
                className = ' class="err"';
                if("marimoni" === val.deviType){
                	chinaMapConfig.ERRData.push([{ name: siteOption.center }, { name: index, value: 100 }])
                }else if("1mbuoy" === val.deviType){
                chinaMapConfig.ERRDataFB1.push([{ name: siteOption.center }, { name: index, value: 100 }])//浮标
                }else if("3mbuoy" === val.deviType){
                chinaMapConfig.ERRDataFB3.push([{ name: siteOption.center }, { name: index, value: 100 }])//浮标
                }
            }
        } else {
            if (val.status) {
                className = '';
            } else {
                className = ' class="err"';
            }
        }
        if(siteOption.center != index)
        	if("marimoni" === val.deviType){
        		$("body > .content > .content_right ul").append('<li' + className + '><icon></icon><span>' + index + '</span></li>')
        	}else if("1mbuoy" === val.deviType){
        		$("body > .content > .content_right ul").append('<li' + className + '><icon class="fb1"></icon><span>' + index + '</span></li>')
        	}else if("3mbuoy" === val.deviType){
        		$("body > .content > .content_right ul").append('<li' + className + '><icon class="fb3"></icon><span>' + index + '</span></li>')
        	}
    })
    var _time = null;
    $("body > .content > .content_right ul").find("li").off().on("click", function(e) {
            e.preventDefault();
            e.stopPropagation();
            var $this = $(this);
            clearTimeout(_time);
            _time = setTimeout(function() {
                siteOption.nowCenter = $this.find('span').text();
                disposeChart();
                chinaMapOption.geo.center = siteOption.station[$this.find('span').text()].info[0][1];
                creatChart();
            }, 250);
    });
    $("body > .content > .content_right ul").find("li").on("dblclick", function(e) {
    	var title = $(this).find('span').text(); 	
    	var deviType = siteOption.station[title].deviType;
    	var id = siteOption.station[title].id;
    	 if("fremoni" ===deviType || "marimoni" ===deviType){
    		 e.preventDefault();
             e.stopPropagation();
             var $this = $(this);
             clearTimeout(_time);
             showdetailInfo($this.find('span').text()); 
    	 }else if("3mbuoy" ===deviType){
    		 e.preventDefault();
             e.stopPropagation();
             var $this = $(this);
             clearTimeout(_time);
             showdetailInfo3(id); 
    	 }else if("1mbuoy" ===deviType){
    		 e.preventDefault();
             e.stopPropagation();
             var $this = $(this);
             clearTimeout(_time);
             showdetailInfo1(id); 
    	 }
            
    });
    /**
     * [dataLine BJData，可以连通的城市数据；SHData，无法连通的城市数据]
     * @type {Array}
     */
    chinaMapConfig.dataLine = [
        [siteOption.center, chinaMapConfig.OKData],
        [siteOption.center, chinaMapConfig.ERRData],
        [siteOption.center, chinaMapConfig.OKDataFB1],
        [siteOption.center, chinaMapConfig.ERRDataFB1],
        [siteOption.center, chinaMapConfig.OKDataFB3],
        [siteOption.center, chinaMapConfig.ERRDataFB3]
    ];
    setchinaMapSeries();

}
/**
     * echarts 插件调用全国地图配置
     */
function setchinaMapSeries(){
    chinaMapSeries =[];
    chinaMapConfig.dataLine.forEach(function(item, i) {
        chinaMapSeries.push({
            name: item[0],
            type: 'lines',
            zlevel: 1,
            effect: {
                show: chinaMapConfig.effect[i % 2],
                period: 6,
                trailLength: 0.7,
                color: chinaMapConfig.lineColor[i % 2],
                symbolSize: chinaMapConfig.effect_size[0]
            },
            lineStyle: {
                normal: {
                    color: chinaMapConfig.lineColor[i % 2],
                    shadowColor: chinaMapConfig.lineColor[i % 2],
                    shadowBlur: 30,
                    opacity: 0.1,
                    curveness: chinaMapConfig.curveness
                }
            },
            silent:true,
            data: unti.convertData(item[1], chinaCoordMap)
        }, {
            name: item[0],
            type: 'lines',
            zlevel: 2,
            effect: {
                show: chinaMapConfig.effect[i % 2],
                period: 6,
                trailLength: 0,
                symbol: chinaMapConfig.point[i],
                symbolSize: chinaMapConfig.effect_size[0]
            },
            lineStyle: {
                normal: {
                    color: chinaMapConfig.lineColor[i % 2],
                    width: (function(){if(i==0) return 0; else return 1;}()),
                    curveness: chinaMapConfig.curveness
                }
            },
            silent:true,
            data: unti.convertData(item[1], chinaCoordMap)
        }, {//普通的点
            name: item[0],
            type: 'effectScatter',
            coordinateSystem: 'geo',
            zlevel: 3,
            showEffectOn: chinaMapConfig.showEffectOn[1],
            rippleEffect: {
                scale: 1.8,
                brushType: 'stroke'
            },
            label: {
                normal: {
                    show: true,
                    position: 'bottom',
                    textStyle: {
                        color: '#fff',
                        fontSize:15
                    },
                    formatter: function(params){
                        if(params.name.length > 10)
                            return params.name.substring(0,10) + "\n" + params.name.substring(10);
                        else return params.name;
                    }
                }
            },
            symbol: chinaMapConfig.point[i + 1],
            symbolSize: chinaMapConfig.point_size[0],
            symbolOffset: ['0', '-45%'],
            itemStyle: {
                normal: {
                    color: chinaMapConfig.lineColor[i % 2]
                }
            },
            data: (function(){
                 return unti.convertToPoint(item, i, chinaCoordMap, {type:1,point:chinaMapConfig.point[5], size:chinaMapConfig.point_size[2]});
            }())
        }, {//点的放大
            name: item[0],
            type: 'effectScatter',
            coordinateSystem: 'geo',
            zlevel: 4,
            showEffectOn: chinaMapConfig.showEffectOn[0],
            rippleEffect: {
                scale: 1.5,
                brushType: 'stroke'
            },
            label: {
                normal: {
                    show: true,
                    position: 'bottom',
                    textStyle: {
                        color: '#fff',
                        fontSize:15
                    },
                    formatter: '{b}'
                }
            },
            symbol: chinaMapConfig.point[i + 1],
            symbolSize: [chinaMapConfig.point_size[0][0]*1.5,chinaMapConfig.point_size[0][1]*1.5],
            symbolOffset: ['0', '-45%'],
            itemStyle: {
                normal: {
                    color: chinaMapConfig.lineColor[i]
                }
            },
            data: (function(){
                if(item[1].length == 0) {
                    return null;
                }
                if(siteOption.nowCenter != "" ){
                    var arrStr = "";
                    item[1].forEach(function(item1,i1){
                        item1.forEach(function(item2,i2){
                            arrStr += "," + item2.name;
                        })
                    })
                    if( arrStr.indexOf(siteOption.nowCenter) != -1 )
                        return [{
                            name:siteOption.nowCenter,
                            value:chinaCoordMap[siteOption.nowCenter]
                        }]
                    else return null;
                } else
                    return null;
            }())
        }, {
            name: item[0],
            type: 'effectScatter',
            coordinateSystem: 'geo',
            zlevel: 5,
            showEffectOn: chinaMapConfig.showEffectOn[0],
            rippleEffect: {
                scale: 1,
                brushType: 'stroke'
            },
            label: {
                normal: {
                    show: true,
                    position: 'bottom',
                    textStyle: {
                        color: '#fff',
                        fontSize:15
                    },
                    formatter: '{b}'
                }
            },
            symbol: chinaMapConfig.point[i + 1],
            symbolSize: [chinaMapConfig.point_size[0][0]*1.5,chinaMapConfig.point_size[0][1]*1.5],
            symbolOffset: ['0', '-45%'],
            itemStyle: {
                normal: {
                    color: chinaMapConfig.lineColor[i % 2]
                }
            },
            data: (function(){
                if( i == 0 ){
                    return [{
                        name:siteOption.center,
                        value:chinaCoordMap[siteOption.center],
                        symbol:chinaMapConfig.point[7],
                        symbolSize:chinaMapConfig.point_size[2],
                        symbolOffset:[0,0]
                    }]
                } else return null;
            }())
        })
    });
}