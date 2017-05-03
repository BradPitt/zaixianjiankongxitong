
function setquxian(stationName,updata){
    // 曲线数据
    if(!updata){
        showLoad();
        var quxian = {
            domLI:[],
            option: {},
            trueIndex:[]
        };
        quxian.option = {
            legend: {
                selectedMode: false,
                textStyle: {
                    color: "#fff"
                },
                top:10,
                itemWidth: 25,
                itemHeight: 1,
                data: [{ name: '当前值', icon: 'rect' }, { name: '最大值', icon: 'rect' }]
            },
            tooltip: {
                trigger: 'axis',
                formatter: function(params){
                      var nowIndex = $(event.target).closest('li').index();
                    var tabIndex = $(event.target).closest('li').attr("data-autoId");
                    var len = quxian.trueIndex[nowIndex].length;
                    var unit = $(event.target).closest('li').attr("data-unit");
                    if(unit == undefined) unit = "";
                    var prec = $(event.target).closest('li').attr("data-prec");
                    var nowVar = siteOption.station[nowOpenStation].monipamedataList[quxian.trueIndex[nowIndex][len - 1 - params[0].dataIndex]][eval('"moniVal'+tabIndex+'"')];
                    return  params[0].seriesName + ': ' + parseFloat(nowVar).toFixed(prec) + unit + '<br />'+params[1].seriesName+': ' + params[1].value+unit;
                }
            },
            grid: {
                left: 80,
                right: 80,
                bottom: 40,
                height: $(curveData).height() - $(".tagTag").height() - 140,
                width: $(".waterBox div.center .tagBox ul.tegContent").width() - 80,
                backgroundColor: 'rgba(0, 0, 0, 0.5)'
            },
            xAxis: [{
                type: 'category',
                boundaryGap: false,
                axisLine: {
                    show: true,
                    lineStyle:{
                        color:"#fff"
                    },
                    onZero:false
                },
                axisTick: {
                    show: true
                },
                axisLabel: {
                    show: true
                },
                splitLine: {
                    show: false
                },
                data: (function(){
                    var timeArr = [];
                    var timeNow = parseInt(unti.formatDate(new Date(),"HH"));
                    timeNow = 30 - timeNow;
                    timeNow = 24 - timeNow;
                    var sss = 0;
                    while(sss < 30){
                        sss++;
                        timeArr.push(timeNow + "点");
                        timeNow++;
                        if(timeNow == 24) timeNow=0;
                    }
                    return timeArr;
                }())
            }],
            yAxis: [{
                type: 'value',
                axisLine: {
                    show: true,
                    lineStyle:{
                        color:"#fff"
                    }
                },
                axisLabel: {
                    show: true
                },
                axisTick: {
                    show: true
                },
                splitLine: {
                    show: false
                },
                splitNumber:1
            }],
            color: ['#0096ff', 'red'],
            series: [{
                name: '当前值',
                type: 'line',
                smooth: true,
                zlevel:2,
                areaStyle: {
                    normal: {
                        color: 'rgba(0,0,0,0)'
                    }
                },
                showSymbol: false,
                lineStyle: {
                    normal: {
                        width: 1
                    }
                },
                markPoint: {
                    itemStyle:{
                        normal:{
                            color:"rgba(0,0,0,0.5)",
                            borderColor:"#0096ff"
                        }
                    },
                    silent:true,
                    data: [
                        {type: 'max', name: '最大值'},
                        {type: 'min', name: '最小值'}
                    ]
                },
                data: (function(){
                    var timeArr = [];
                    var sss = 0;
                    while(sss < 30){
                        sss++;
                        timeArr.push(40);
                    }
                    return timeArr;
                }())
            }, {
                name: '最大值',
                type: 'line',
                smooth: true,
                zlevel:1,
                showSymbol: false,
                silent:true,
                areaStyle: {
                    normal: {
                        color: 'rgba(0,0,0,0)'
                    }
                },
                lineStyle: {
                    normal: {
                        width: 1
                    }
                },
                data: (function(){
                    var timeArr = [];
                    var sss = 0;
                    while(sss < 30){
                        sss++;
                        timeArr.push(40);
                    }
                    return timeArr;
                }())
            }]
        };

        $(curveTag).html("");
        $(curveData).html("");
        $(curveData).height($(curveData).height() - $(".tagTag").height())
        siteOption.panels = siteOption.station[nowOpenStation].monipameinfoList;  // by xp
        siteOption.panels.forEach(function(item, index) {
            $(curveTag).append('<li ' +(index == 0?"class='active'":"")+ '>' + item.cnName + '历史值</li> ');
            var $li = $("<li>",{"class":(index == 0?"active":""),"data-autoId":item.id,"data-unit":item.unit,"data-prec":(item.dispPrec == undefined ? 2 : item.dispPrec.length-2)});
            var $canvas = $("<div>",{"class":"canvas"}).appendTo($li);
            $(curveData).append($li);
            $(curveTag).find('li').on("click", function(e) {
                $(curveTag).find('li').removeClass("active");
                $(this).addClass("active");
                $(curveData).find('li').removeClass('active');
                $(curveData).find('li').eq($(this).index()).addClass('active');
            });
            $(curveData).find("div.canvas").width($(curveData).width());
            $(curveData).find("div.canvas").height($(curveData).height() - $(".tagTag").height())
            quxian.domLI.push(echarts.init($canvas[0]));
        });
        setQX = function(){
        	siteOption.panels = siteOption.station[nowOpenStation].monipameinfoList;  // by xp
            siteOption.panels.forEach(function(item, index) {
                var prec = item.dispPrec == undefined ? 2 : item.dispPrec.length-2;
                quxian.option.yAxis[0].min = item.minVal;
                quxian.option.xAxis[0].data = [];
                quxian.option.series[0].data = [];
                quxian.option.series[1].data = [];
                quxian.option.legend.formatter = function (name) {
                    if(name == "最大值"){
                        return name + "       单位：" + (item.unit==undefined?"--":item.unit)
                    }
                    else return name;
                }
                quxian.trueIndex.push([]);
                var tempMax = parseFloat(item.minVal);
                if(isNaN(tempMax)) tempMax = 0;
                if(siteOption.station[stationName].monipamedataList != undefined){
                    siteOption.station[stationName].monipamedataList.forEach(function(item1,i1){
                        if(item1[eval("'" + ("moniVal" + item.id) + "'")] != undefined && item1[eval("'" + ("moniVal" + item.id) + "'")].indexOf('99999999999') == -1){
                            quxian.option.series[0].data.unshift((function(){
                                var tempVal = 0;
                                if(parseFloat(item.maxVal) > parseFloat(item.minVal)){
                                    if(parseFloat(item1[eval("'" + ("moniVal" + item.id) + "'")]) > parseFloat(item.maxVal)) tempVal = parseFloat(item.maxVal).toFixed(prec);
                                    else if(parseFloat(item1[eval("'" + ("moniVal" + item.id) + "'")]) < parseFloat(item.minVal)) tempVal = parseFloat(item.minVal).toFixed(prec);
                                    else tempVal = parseFloat(item1[eval("'" + ("moniVal" + item.id) + "'")]).toFixed(prec);
                                } else {
                                    tempVal = parseFloat(item1[eval("'" + ("moniVal" + item.id) + "'")]).toFixed(prec);
                                }
                                if(parseFloat(tempVal) > parseFloat(tempMax))
                                    tempMax = parseFloat(tempVal);
                                return tempVal;
                            }()));
                            quxian.option.xAxis[0].data.unshift(parseInt(unti.formatDate(item1.receTm,"HH")) + "点");
                            quxian.trueIndex[index].push(i1);
                        }
                    })
                    if(quxian.option.series[0].data.length == 1){
                        quxian.option.series[0].data.push(parseFloat(item.minVal).toFixed(prec));
                    }
                    if(quxian.option.series[0].data.length == 0){
                        quxian.option.series[0].data.push(parseFloat(item.minVal).toFixed(prec));
                        quxian.option.series[0].data.push(parseFloat(item.minVal).toFixed(prec));
                    }
                }
                var beishuz = 2;
                var tempY = tempMax;
                if(item.hasOwnProperty("funcareamonieval") && item.funcareamonieval != null){
                    if(parseFloat(item.funcareamonieval.excelUpperLimit ) > parseFloat(item.funcareamonieval.poolLowLimit ) && parseFloat(item.funcareamonieval.excelUpperLimit ) > tempY){
                        tempY = parseFloat(item.funcareamonieval.excelUpperLimit ) * 1.1;
                    } else if(parseFloat(item.funcareamonieval.excelUpperLimit ) < parseFloat(item.funcareamonieval.poolLowLimit ) && parseFloat(item.funcareamonieval.poolLowLimit ) > tempY){
                        tempY = parseFloat(item.funcareamonieval.poolLowLimit ) * 1.1;
                    } else {
                        tempY = tempMax*beishuz - (item.minVal==undefined?0:(parseFloat(item.minVal) < 0 ? 0 : parseFloat(item.minVal)));
                    }
                } else {
                    tempY = tempMax*beishuz - (item.minVal==undefined?0:(parseFloat(item.minVal) < 0 ? 0 : parseFloat(item.minVal)));
                }
                quxian.option.series[0].data.forEach(function(items,ins){
                    quxian.option.series[1].data.push(Math.ceil(tempY));
                })
                quxian.option.yAxis[0].max = Math.ceil(tempY);
                if(quxian.option.yAxis[0].max <= quxian.option.yAxis[0].min) quxian.option.yAxis[0].max = quxian.option.yAxis[0].min * 2;
                quxian.domLI[index].setOption(quxian.option, true);
            })
        }
        setQX();
        Handler_econtent = setInterval(function(){
            setQX();
            console.log('QUXIANUPDATA');
        },refesTime);
        hideLoad();
    } else {
        Handler_econtent = setInterval(function(){
            setQX();
            console.log('QUXIANUPDATA');
        },refesTime);
    }
}