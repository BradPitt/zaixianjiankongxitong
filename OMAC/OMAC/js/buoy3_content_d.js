
function initWaterBoxData3m(stationName,updata){
    clearInterval(Handler_content);
    formatMoniVal(stationName);
    
    if(!updata){
        $(".waterBox .d.content > ul.sbUL li").width($(".waterBox .d.content > ul.sbUL").width());
        $(".waterBox .d.content > ul.sbUL li").each(function(index, el) {
        	if(index > 0 ){
                $(el).height($(".waterBox .d.content > ul.sbUL").height() - $(".waterBox .d.content > ul.sbUL li").eq(0).height() - 26);
            }
        });
        //console.log($(".waterBox .d.content > ul.middleUL").height()/10*6);
       // $(".waterBox .d.content > ul.middleUL> li:first-child").height($(".waterBox .d.content > ul.middleUL").height()/10*6);
        //$(".waterBox .d.content > ul.middleUL> li:first-child +li").height($(".waterBox .d.content > ul.middleUL").height()/10*5);
        //$(".waterBox .d.content > ul.middleUL> li:first-child +li+li").height($(".waterBox .d.content > ul.middleUL").height()/2);
               
        $(".waterBox .d.content > ul.videoUL > li").height($(".waterBox .d.content > ul.videoUL").height() - 12.1);
        
        $(".waterBox .d.content video").each(function(index, el) {
            $(el).attr("width",$(el).closest('li').width());
            $(el).attr("height",$(el).closest('li').height() - 40);
        });
        $.getScript("/js/video.min.js");
        setSBZT = function(){
                $(deviceStaus).html("");
                siteOption.station[stationName].info.forEach(function(item,i){
                    if("安装位置,设备健康度,通讯线路".indexOf(item[0]) != -1){
                        if(item[0] == "安装位置")
                            $(deviceStaus).append($("<li>").html("经度：" + unti.formatDegree(item[1][0]) + " 纬度：" + unti.formatDegree(item[1][1])));
                        else if(item[0] == "设备健康度"){
                            $(deviceStaus).append($("<li>",{"class":"jiankangdu"}).html('<span>健康度：</span><b style="width:'+ ($(deviceStaus).width() - 130) +'px"><span>0</span><i style="width:'+item[1]+'%"><span>'+item[1]+'</span></i><span>100</span></b>'));
                        } else if(item[0] == "位置偏移报警"){
                            $(deviceStaus).append($("<li>").html("位置偏移报警：</br><span class='fontRed'>经度：" + unti.formatDegree(item[1][0]) + " 纬度：" + unti.formatDegree(item[1][1])+"</span>"));
                        }
                        
                        else
                            $(deviceStaus).append($("<li>").html(item[0] + "：" + item[1]));
                    }
                })
        }

         setBJXS = function(){// 报警显示
        	 var shengyinFlg = false;
                $(alarmStaus).html("");
                var lon_o = 0 ,lat_o = 0;
            	   
                siteOption.station[stationName].info.forEach(function(item,i){
                	if("安装位置" === item[0]){
                		lon_o = item[1][0];
                		lat_o = item[1][1];
                	}
                	var prec = item.dispPrec == undefined ? 2 : item.dispPrec.length-2;   // 格式化
                    if("位置偏移报警,电池,舱内进水,舱门开启".indexOf(item[0]) != -1){
                    	if(item[0] == "电池"){
                    		if("--" ===item[1]){
                    			$(alarmStaus).append($("<li>").html(item[0] + "：" + item[1]));
                    		}else{
                    			$(alarmStaus).append($("<li>").html(item[0] + "：" + parseFloat(item[1]).toFixed(prec)));
                    		}
                    		
                    	}else if(item[0] == "舱门开启"){
                    		if("开启"=== item[1]){
                    			$(alarmStaus).append($("<li>").html(item[0] + "：<span class='fontRed'>" + item[1] + '</span>'));
                    			shengyinFlg = true;
                    		}else{
                    			shengyinFlg = false;
                    			$(alarmStaus).append($("<li>").html(item[0] + "：<span class='fontGreen'>" + item[1] + '</span>'));
                    		}
                    		
                    	}else if(item[0] == "舱内进水"){
                    		if("未进水"=== item[1]){
                    			$(alarmStaus).append($("<li>").html(item[0] + "：<span class='fontGreen'>" + item[1] + '</span>'));
                    			if(shengyinFlg){
                    				shengyinFlg = true;
                    			}
                    		}else{
                    			$(alarmStaus).append($("<li>").html(item[0] + "：<span class='fontRed'>" + item[1] + '</span>'));
                    			shengyinFlg = true;
                    		}
                    		
                    	}else if(item[0] == "位置偏移报警"){
                    		$(alarmStaus).append($("<li>").html(item[0] + "：" + item[1]));
                    		$(alarmStaus).append($("<li>").html("<div id='leidatu' style='height:210px;'></div>"));
                    		var myChart1 = echarts.init(document.getElementById('leidatu')); 
                    		var lon=item[1][0], // 经度
                    		lat=item[1][1]; // 纬度
                    		var dis =  GetDistance(lat_o,lon_o, lat, lon);
                    		option = {
                    		    tooltip : {
                    		        trigger: 'axis'
                    		    },
                    		    polar : [
                    		       {
                    		           indicator : [
                    		               { text: '偏离距离', max: 1000}
                    		            ],
                    		            center : ['50%','50%'],
                    		            radius : 90,
                    		            startAngle: 160,
                    		            splitNumber: 4,
                    		            name : {
                    		            	show:false,
                    		                formatter:'{value}',
                    		                textStyle: {color:'red'},
                    		                
                    		            },
                    		            scale: true,
                    		            type: 'circle',
                    		            axisLine: {            // 坐标轴线
                    		                show: true,        // 默认显示，属性show控制显示与否
                    		                lineStyle: {       // 属性lineStyle控制线条样式
                    		                    color: '#82b3de',
                    		                    width: 2,
                    		                    type: 'solid'
                    		                }
                    		            },
                    		            axisLabel: {           // 坐标轴文本标签，详见axis.axisLabel
                    		                show: true,
                    		                // formatter: null,
                    		                textStyle: {       // 其余属性默认使用全局文本样式，详见TEXTSTYLE
                    		                    color: '#fff'
                    		                }
                    		            },
                    		            splitArea : {
                    		                show : true,
                    		                areaStyle : {
                    		                    color: ['rgba(0,134,255,1)','rgba(0,117,223,0.9)','rgba(1,88,167,0.8)','rgba(3,58,97,0.9)']
                    		                }
                    		            },
                    		            splitLine : {
                    		                show : true,
                    		                lineStyle : {
                    		                    width : 2,
                    		                    color : ['rgba(58,170,255,1)','rgba(58,170,255,1)','rgba(58,170,255,0.9)','rgba(58,170,255,0.5)','rgba(58,170,255,0.3)']
                    		                }
                    		            }
                    		        }
                    		    ],
                    		    calculable : true,
                    		    series : [
                    		        {
                    		            name: '偏离距离',
                    		            type: 'radar',
                    		            data : [
                    		                { 
                    		                	//symbol: 'image://../img/ok_fb3.png', 
                    		                	symbol: 'emptyCircle',
                    		                    symbolSize: 8,     
                    		                    value : [dis],
                    		                    name : '偏离距离'
                    		                }
                    		            ]
                    		        }
                    		    ]
                    		};
                    		myChart1.setOption(option);
                    		                    
                    	}else{
                    		$(alarmStaus).append($("<li>").html(item[0] + "：" + item[1]));
                    	}   
                    }
                })
                if(shengyinFlg){
                	$(play).click();
                }else{
                	$(pause).click();
                }
                addToolTipHander($(alarmStaus).find('li'),0);
        }
         setFMZT = function(){
                $(valveStaus).html("");
                siteOption.station[stationName].valveList.forEach(function(item,i){
                    $(valveStaus).append('<li data-title="'+item.compName+'<br>最后一次运行时间：'+(item.nestRunDt == undefined ? "--" : unti.formatDate(item.nestRunDt,"yyyy-MM-dd HH"))+'"><span class="sta '+(item.heal == undefined ? "err" : (item.heal != 100 ? "err" : "ok"))+'"></span><span class="liname">'+item.compName+'</span></li>');
                })
                addToolTipHander($(valveStaus).find('li'),0);
        }
         /*setBZJ = function(){
            $(pumpStaus).html("");
            siteOption.station[stationName].pumpList.forEach(function(item,i){
                $(pumpStaus).append('<li data-title="'+item.compName+'<br>最后一次运行时间：'+(item.nestRunDt == undefined ? "--" : unti.formatDate(item.nestRunDt,"yyyy-MM-dd HH"))+'"><span class="sta '+(item.heal == undefined ? "err" : (item.heal != 100 ? "err" : "ok"))+'"></span><span class="liname">'+item.compName+'</span></li>');
            })
            addToolTipHander($(pumpStaus).find('li'),1);
        }*/
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
         // 波浪
         setBL = function(){
        	 formatMoniVal(stationName);
             $(bolangStatus).html("");
             $(zhuboxiangStatus).html("");
             if(siteOption.station[stationName].monipamedataList){
            	 
            	 var strData=siteOption.station[stationName].monipamedataList[0];
            	 var tempS="<li class='fir'></li><li class='sec'>波高(m)</li><li class='sec'>波周期(s)</li><li class='las'>时间</li>"
            		 +"<li class='fir'>最大</li><li class='sec'>"+strData.moniVal27+"</li><li class='sec'>"+strData.moniVal28+"</li><li class='las'>"+strData.receTm+"</li>"
            		 +"<li class='fir'>1/10</li><li class='sec'>"+strData.moniVal23+"</li><li class='sec'>"+strData.moniVal24+"</li><li class='las'>"+strData.receTm+"</li>"
	                 +"<li class='fir'>平均</li><li class='sec'>"+strData.moniVal25+"</li><li class='sec'>"+strData.moniVal26+"</li><li class='las'>"+strData.receTm+"</li>"
	                 +"<li class='fir'>有效</li><li class='sec'>"+strData.moniVal29+"</li><li class='sec'>"+strData.moniVal30+"</li><li class='las'>"+strData.receTm+"</li>"
            	 $(bolangStatus).append(tempS);
            	 
            	 tempS= "<li style='height:144px;'><div id='boxiangtu' style='height:100%'></div></li><li style='position:absolute;height:20px;top:120px;width:100%;'>波向："+strData.moniVal31+"°</li>";
            	 $(zhuboxiangStatus).append(tempS);
            	 // 波向图
            	 var myChart = echarts.init(document.getElementById('boxiangtu')); 
            	 option = {
            			    tooltip : {
            			    	show: false,     
            			        formatter: "{a}  : {c}°"
            			    },
            			    series : [
            			        {
            			            name:'波向',
            			            type:'gauge',
            			            center : ['50%', '40%'],    // 默认全局居中
            			            radius: '58%',
            			            startAngle:90,
            			            endAngle:-269.999,
            			            max:360,
            			            detail : {
            			            	show: false,
            			            	formatter:'90'
            			            		}, //仪表盘显示数据
            			            axisLine: { //仪表盘轴线样式
            			            	show: false,  
            			                lineStyle: {
            			                    width: 6,
            			                    show: false
            			                }
            			            },
            			            splitNumber: 4,       // 分割段数，默认为5
            			            splitLine: {           // 分隔线
        						        show: true,        // 默认显示，属性show控制显示与否,这里设为false将隐藏分割线！！
        						        length: 12,         // 属性length控制线长
        						        lineStyle: {       // 属性lineStyle（详见lineStyle）控制线条样式
        						            color: '#ffbd2c',
        						            width: 2,
        						            type: 'solid'
        						        }
        						    },
        						    axisLine: {            // 坐标轴线
        				                lineStyle: {       // 属性lineStyle控制线条样式
        				                    color: [[1, '#ffbd2c']], 
        				                    width: 8
        				                }
        				            },
        				            axisTick: {            // 坐标轴小标记
        				                show: false,        // 属性show控制显示与否，默认不显示
        				                splitNumber: 5,    // 每份split细分多少段
        				                length :8,         // 属性length控制线长
        				                lineStyle: {       // 属性lineStyle控制线条样式
        				                    color: '#ffbd2c',
        				                    width: 1,
        				                    type: 'solid'
        				                }
        				            },
        				            axisLabel: {           // 坐标轴文本标签，详见axis.axisLabel
        				                show: true,
        				                formatter: function(v){
        				                    switch (v+''){
        				                    	case '0': return '北';
        				                        case '90': return '东';
        				                        case '180': return '南';
        				                        case '270': return '西';
        				                        default: return '';
        				                    }
        				                },
        				                distance: -26,
        				                textStyle: {       // 其余属性默认使用全局文本样式，详见TEXTSTYLE
        				                   // color: '#333'
        				                }
        				            },
        				            pointer : {
        				                length : '70%',
        				                width : 4,
        				                color : 'auto'
        				            },
            			            data:[{value: strData.moniVal31, name: ''}]
            			        }
            			    ]
            			};
            			 
            			myChart.setOption(option);
             }
         }
         // 气象
         setQiXiang = function(){
        	 formatMoniVal(stationName);
             $(qixiangStatus).html("");
             if(siteOption.station[stationName].monipamedataList){
            	 var strData=siteOption.station[stationName].monipamedataList[0];
            	 var tempS="<li></li><li>平均</li><li>最大</li><li>最小</li><li class='w20'>最大出现时刻</li><li class='w20'>最小出现时刻</li>"
            		 +"<li>温度</li><li>"+strData.moniVal68+"</li><li>"+strData.moniVal69+"</li><li>"+strData.moniVal70+"</li>"
            		 +"<li class='w20'>" + strData.moniDt1002 + "</li><li class='w20'>" + strData.moniDt1003 + "</li>";
            		
            	 $(qixiangStatus).append(tempS);
            	 var tempS="<li>湿度</li><li>"+strData.moniVal71+"</li><li>"+strData.moniVal72+"</li><li>"+strData.moniVal73+"</li>"
            		 +"<li class='w20'>" + strData.moniDt1004 + "</li><li class='w20'>" + strData.moniDt1005 + "</li>";
            	 $(qixiangStatus).append(tempS);
            	 var tempS="<li>气压</li><li>"+strData.moniVal74+"</li><li>"+strData.moniVal75+"</li><li>"+strData.moniVal76+"</li>"
        		 +"<li class='w20'>" + strData.moniDt1006 + "</li><li class='w20'>" + strData.moniDt1007 + "</li>";
        	 $(qixiangStatus).append(tempS);
             }
         }
         // 海流、温盐
         setHaiLiu = function(){
        	 formatMoniVal(stationName);
             $(hailiuStatus).html("");
             if(siteOption.station[stationName].monipamedataList){
            	 var strData=siteOption.station[stationName].monipamedataList[0];
            	 var tempS="<li class='w24'>平均流速</li><li class='w24'>平均流向</li><li class='w24'>平均水温</li><li class='w24'>平均盐度</li>"
            		 +"<li class='w24'>"+strData.moniVal77+"</li><li class='w24'>"+strData.moniVal78+"</li><li class='w24'>"+strData.moniVal79+"</li>"+"<li class='w24'>" + strData.moniVal80 + "</li>";
        	 $(hailiuStatus).append(tempS);
             }
         }
         // 风
         setFeng = function(){
        	 formatMoniVal(stationName);
        	 $(fengLeft).html("");
             $(fengRight).html("");
             if(siteOption.station[stationName].monipamedataList){
            	 var strData=siteOption.station[stationName].monipamedataList[0];
            	 if(!strData.MoniDt1008){strData.MoniDt1008 ="";}
            	 if(!strData.MoniDt1009){strData.MoniDt1009 ="";}
            	 if(!strData.MoniDt1010){strData.MoniDt1010 ="";}
            	 if(!strData.MoniDt1011){strData.MoniDt1011 ="";}
            	 if(!strData.MoniDt1012){strData.MoniDt1012 ="";}
            	 if(!strData.MoniDt1013){strData.MoniDt1013 ="";}
            	 var tempS="<li>瞬时风速</li><li>瞬时风向</li><li>时间</li>"
            		 +"<li>"+strData.moniVal56+"</li><li>"+strData.moniVal57+"</li><li>"+strData.MoniDt1008+"</li>"
            		 +"<li>"+strData.moniVal58+"</li><li>"+strData.moniVal59+"</li><li>"+strData.MoniDt1009+"</li>"
            		 +"<li>"+strData.moniVal60+"</li><li>"+strData.moniVal61+"</li><li>"+strData.MoniDt1010+"</li>"
            		 +"<li>"+strData.moniVal62+"</li><li>"+strData.moniVal63+"</li><li>"+strData.MoniDt1011+"</li>"
            		 +"<li>"+strData.moniVal64+"</li><li>"+strData.moniVal65+"</li><li>"+strData.MoniDt1012+"</li>"
            		 +"<li>"+strData.moniVal66+"</li><li>"+strData.moniVal67+"</li><li>"+strData.MoniDt1013+"</li>"
            	 $(fengLeft).append(tempS);
            	 var tempS="<li></li><li>最大</li><li>极大</li><li>平时</li><li>瞬时</li>"
            		 +"<li>风速</li><li>"+strData.moniVal56+"</li><li>"+strData.moniVal58+"</li><li>"+strData.moniVal60+"</li><li>"+strData.moniVal62+"</li>"
            		 +"<li>风向</li><li class='fengxiangCanvas1' id='fengxiangCanvas1'></li><li id='fengxiangCanvas2'></li><li id='fengxiangCanvas3'></li><li id='fengxiangCanvas4'></li>"
            		 +"<li></li><li>"+strData.moniVal57+"</li><li>"+strData.moniVal59+"</li><li>"+strData.moniVal61+"</li><li>"+strData.moniVal63+"</li>"
            		 +"<li>最大风速出现时间："+strData.moniDt1000+"</li><li>极大风俗出现时间："+strData.moniDt1001+"</li>"
            	 $(fengRight).append(tempS);
            	 var myChart = echarts.init(document.getElementById('fengxiangCanvas1')); 
            	 myChart.setOption(setOption(strData.moniVal57));
            	 var myChart = echarts.init(document.getElementById('fengxiangCanvas2')); 
            	 myChart.setOption(setOption(strData.moniVal59));
            	 var myChart = echarts.init(document.getElementById('fengxiangCanvas3')); 
            	 myChart.setOption(setOption(strData.moniVal61));
            	 var myChart = echarts.init(document.getElementById('fengxiangCanvas4')); 
            	 myChart.setOption(setOption(strData.moniVal63));
             }
         }
         formatMoniDt(stationName);
        setSBZT();
        setBJXS();
       // setFMZT();
       // setBZJ();
        setDcontent(stationName);
        //setBJZT();
        setBL();
        setQiXiang();
        setHaiLiu();
       // setquxian(nowOpenStation,!true);
        setFeng();
 /*       siteOption.panels = siteOption.station[stationName].monipameinfoList;
        siteOption.panels.forEach(function(item, i) {
        	now = $(radioBox).find('input[name=choosea][checked]').closest('.pay_list_c1 ').index();
            $(radioBox).append('<span class="pay_list_c1 '+(now==undefined ? (i==0?"on":"") :(i==now?"on":""))+'">'+
                '<input type="radio" value="'+item.id+'" '+(now==undefined ? (i==0?'checked="checked"':"") :(i==now?'checked="checked"':""))+' name="choosea"/>'+
                '<span>'+
                    item.cnName+
                '</span>'+
                '</span>')
        })*/
        Handler_content = setInterval(function(){
        	formatMoniDt(stationName);
            setSBZT();
            setBJXS();
           // setFMZT();
            //setBZJ();
            setDcontent(stationName);
            //setBJZT();
            setBL();
            setQiXiang();
            setHaiLiu();
            setFeng();
            //console.log("update content");
        },refesTime);
    } else {
        Handler_content = setInterval(function(){
            setSBZT();
            setBJXS();
           // setFMZT();
            //setBZJ();
            setDcontent(stationName);
            //setBJZT();
            setBL();
            setQiXiang();
            setHaiLiu();
            setFeng();
            //console.log("update content");
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
    var smallChart = echarts.init($(".videoUL div.canvas")[0]);
    $.get('/js/china.json', function(geoJson) {
        echarts.registerMap('china', geoJson);
        smallChart.setOption(stationOption);
    })
}
function formatMoniVal(stationName){
    // 格式化
    if(siteOption.station[stationName].monipamedataList && siteOption.station[stationName].monipamedataList[0]&&siteOption.station[stationName].monipameinfoList){
    		siteOption.station[stationName].monipameinfoList.forEach(function(item, index) {
    		var prec = item.dispPrec == undefined ? 2 : item.dispPrec.length-2;
    		for(var i =0;i<siteOption.station[stationName].monipamedataList.length;i++){
    			siteOption.station[stationName].monipamedataList[i].receTm=unti.formatDate(siteOption.station[stationName].monipamedataList[i].receTm,"yyyy-MM-dd HH:mm:ss");
	    			if(siteOption.station[stationName].monipamedataList[i]["moniVal"+item.id]){
	    				var val=parseFloat(siteOption.station[stationName].monipamedataList[i]["moniVal"+item.id]).toFixed(prec);
	    				// 9998：获取不到数据
	    				if("9998" === parseFloat(siteOption.station[stationName].monipamedataList[i]["moniVal"+item.id]).toFixed(0)){
	    					val = "";
	    				}
	    				siteOption.station[stationName].monipamedataList[i]["moniVal"+item.id] = val;
	    			}else{
	    					var val="";
		    				siteOption.station[stationName].monipamedataList[i]["moniVal"+item.id] = val;
		    				//siteOption.station[stationName].monipamedataList[i]["moniVal"+item.id] = siteOption.station[stationName].monipamedataList[i]["moniVal"+item.id].toFixed(prec);	
	    			}
    			}
		 })
    		
    	}
}
function formatMoniDt(stationName){
    // 格式化
    if(siteOption.station[stationName].monipamedataList && siteOption.station[stationName].monipamedataList[0]&&siteOption.station[stationName].monipameinfoList){
    		siteOption.station[stationName].monipameinfoList.forEach(function(item, index) {
    		var prec = item.dispPrec == undefined ? 2 : item.dispPrec.length-2;
    		for(var i =0;i<siteOption.station[stationName].monipamedataList.length;i++){
    			siteOption.station[stationName].monipamedataList[i].receTm=unti.formatDate(siteOption.station[stationName].monipamedataList[i].receTm,"yyyy-MM-dd HH:mm:ss");
	    			if(siteOption.station[stationName].monipamedataList[i]["moniDt"+item.id]){
	    				var val=unti.formatDate(siteOption.station[stationName].monipamedataList[i]["moniDt"+item.id],item.dispPrec);
	    				siteOption.station[stationName].monipamedataList[i]["moniDt"+item.id] = val;
	    				
	    			}
    			}
		 })
    		
    	}
}
function setOption(strDataVal){
	return option = {
			    tooltip : {
			    	show: false,     
			        formatter: "{a}  : {c}°"
			    },
			    series : [
			        {
			            name:'波向',
			            type:'gauge',
			            center : ['50%', '50%'],    // 默认全局居中
			            radius: '90%',
			            startAngle:90,
			            endAngle:-269.999,
			            max:360,
			            detail : {
			            	show: false,
			            	formatter:'90'
			            		}, //仪表盘显示数据
			            axisLine: { //仪表盘轴线样式
			            	show: false,  
			                lineStyle: {
			                    width: 4,
			                    show: false
			                }
			            },
			            splitNumber: 4,       // 分割段数，默认为5
			            splitLine: {           // 分隔线
					        show: true,        // 默认显示，属性show控制显示与否,这里设为false将隐藏分割线！！
					        length: 12,         // 属性length控制线长
					        lineStyle: {       // 属性lineStyle（详见lineStyle）控制线条样式
					            color: '#b4b4b4',
					            width: 2,
					            type: 'solid'
					        }
					    },
					    axisLine: {            // 坐标轴线
			                lineStyle: {       // 属性lineStyle控制线条样式
			                    color: [[1, '#b4b4b4']], 
			                    width: 4
			                }
			            },
			            axisTick: {            // 坐标轴小标记
			                show: false,        // 属性show控制显示与否，默认不显示
			                splitNumber: 5,    // 每份split细分多少段
			                length :8,         // 属性length控制线长
			                lineStyle: {       // 属性lineStyle控制线条样式
			                    color: '#b4b4b4',
			                    width: 1,
			                    type: 'solid'
			                }
			            },
			            axisLabel: {           // 坐标轴文本标签，详见axis.axisLabel
			                show: false,
			                formatter: function(v){
			                    switch (v+''){
			                    	case '0': return '北';
			                       // case '90': return '东';
			                        //case '180': return '南';
			                       // case '270': return '西';
			                        default: return '';
			                    }
			                },
			                distance: -26,
			                textStyle: {       // 其余属性默认使用全局文本样式，详见TEXTSTYLE
			                   // color: '#333'
			                }
			            },
			            pointer : {
			                length : '70%',
			                width : 4,
			                color : 'auto'
			            },
			            data:[{value: strDataVal, name: ''}]
			        }
			    ]
			};
			 
}