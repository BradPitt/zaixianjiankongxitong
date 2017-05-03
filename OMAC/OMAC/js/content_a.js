
function initWaterBox(stationName,updata) {
    if(!updata){
        clearInterval(Handler_content);
        nowOpenStation = stationName;
        
        colors = ['#08c31c','#2b94f0','#fefe06','#e82728','#840405','#acf313'];

        $(yibiaopan).html("");
        $(".yibiaopan").before('<div class="danyinzi"><span>单因子：</span><span>Ⅰ类<i style="background:'+colors[0]+'"></i></span>'+
            '<span>Ⅱ类<i style="background:'+colors[1]+'"></i></span><span>Ⅲ类<i style="background:'+colors[2]+'"></i></span>'+
            '<span>Ⅳ类<i style="background:'+colors[3]+'"></i></span></div>');
        var yibiaopanBox = $(".yibiaopan");
        $(yibiaopanBox).children('ul').width($(yibiaopanBox).width())
        $(yibiaopanBox).children('ul').html("");
        var re = /([0-9]+\.[0-9]{2})[0-9]*/;
        var liw = $(yibiaopanBox).width()/4 - 42;
        var yibiaopan = {
            domLI: [],
            left: liw,
            top: 0,
            row: 0,
            col: 0
        };

        $(yibiaopanBox).height($(".a.content").height() - 15);
        yibiaopan.top = ($(yibiaopanBox).height() / 3) - 36;
        $(yibiaopanBox).children('ul').height($(yibiaopanBox).height());

        siteOption.panels = siteOption.station[nowOpenStation].monipameinfoList;  // by xp
        if(siteOption.panels.length > 12){
            $(yibiaopanBox).children('ul').height($(yibiaopanBox).height() + (Math.ceil((siteOption.panels.length - 12) / 4) * (yibiaopan.top + 36)));
        }
        if(siteOption.panels.length / 4 > 3) {
            if(isChrome) $(yibiaopanBox).css({
                "overflow-y":"scroll",
                "overflow-x":"hidden"
            })
            if(wH <= 768 + titleH){
                if(isChrome) $(yibiaopanBox).css({
                    "overflow-y":"scroll",
                    "overflow-x":"hidden"
                });
            }
        }
        var stationInfo = siteOption.station[eval("'" + stationName + "'")];
        var tempInfo = {};
        stationInfo.info.forEach(function(item,i){
            tempInfo[item[0]] = item[1];
        })
        siteOption.panels.forEach(function(item, index) {
            var trueValue = (function(){
                var temp = item.cnName;
                if(parseFloat(tempInfo[temp]) > item.maxVal) return item.maxVal;
                if(parseFloat(tempInfo[temp]) < item.minVal) return item.minVal;
                return parseFloat(tempInfo[temp]);
            }());
            var $li = $("<li>",{"data-title":""+item.cnName,"data-value":trueValue});
            $li.width(liw).height(yibiaopan.top);
            var $canvas = $("<div>",{"class":"canvas"});
            $li.append($canvas);
            $(yibiaopanBox).children('ul').append($li);
            $canvas.css("width",liw*1.3).html("");
            yibiaopan.domLI.push(echarts.init($canvas[0]));
            if (index % 4 == 0 && index != 0) {
                yibiaopan.row++;
                yibiaopan.col = 0;
            };
            $li.css(unti.mTranslate(yibiaopan.left * yibiaopan.col + 35 * (yibiaopan.col + 1) + "px", yibiaopan.top * yibiaopan.row + 30 * (yibiaopan.row + 1) + "px"));
            $li.css("opacity", 1);
            yibiaopan.col++;
        });
        setYBP = function(){
            var tempInfo = {};
            var stationInfo = siteOption.station[eval("'" + stationName + "'")];
            stationInfo.info.forEach(function(item,i){
                tempInfo[item[0]] = item[1];
            })
            siteOption.panels = siteOption.station[eval("'" + stationName + "'")].monipameinfoList;
            siteOption.panels.forEach(function(item, index) {
                var trueValue = (function(){
                    var temp = item.cnName;
                    if(parseFloat(tempInfo[temp]) > item.maxVal) return item.maxVal;
                    if(parseFloat(tempInfo[temp]) < item.minVal) return item.minVal;
                    return parseFloat(tempInfo[temp]);
                }());
                var $li = $(yibiaopanBox).children('ul').find('li').eq(index);
                $li.attr("data-value",trueValue);
                var option = {
                    series: [{
                        name: $li.data("title"),
                        type: 'gauge',
                        radius: '55%',
                        startAngle: '200',
                        endAngle: '-20',
                        min: parseFloat(item.minVal),
                        max: parseFloat(item.maxVal),
                        pointer: {
                            width: 4
                        },
                        detail: {
                            show: false
                        },
                        itemStyle: {
                            normal: {
                                color: "#009cff"
                            }
                        },
                        splitNumber: 1,
                        splitLine: {
                            length: 1,
                            lineStyle: {
                                color: '#000'
                            }
                        },
                        axisLabel: {
                            formatter: function(data) {
                                return data;
                            },
                            distance: -32,
                            textStyle: {
                                color: '#fff',
                                fontSize: 18
                            }
                        },
                        axisLine: {
                            lineStyle: {
                                color: (function(){
                                    if(item.hasOwnProperty("funcareamonieval") && item.funcareamonieval != undefined){
                                        var leftIsOk = parseFloat(item.funcareamonieval.excelUpperLimit) < parseFloat(item.funcareamonieval.poolUpperLimit);
                                        var allS = parseFloat(item.maxVal) - parseFloat(item.minVal);
                                        if(leftIsOk){
                                            // 左绿有红
                                            var lefts = [];
                                            if(item.funcareamonieval.excelUpperLimit  != undefined) lefts.push((parseFloat(item.funcareamonieval.excelUpperLimit) - parseFloat(item.minVal)) / allS);
                                            else {
                                                lefts.push(0);
                                            }
                                            if(item.funcareamonieval.goodUpperLimit  != undefined) lefts.push((parseFloat(item.funcareamonieval.goodUpperLimit) - parseFloat(item.minVal)) / allS);
                                            else {
                                                lefts.push(lefts[lefts.length - 1]);
                                            }
                                            if(item.funcareamonieval.commonUpperLimit  != undefined) lefts.push((parseFloat(item.funcareamonieval.commonUpperLimit) - parseFloat(item.minVal)) / allS);
                                            else {
                                                lefts.push(lefts[lefts.length - 1]);
                                            }
                                            if(item.funcareamonieval.poolUpperLimit  != undefined) lefts.push((parseFloat(item.funcareamonieval.poolUpperLimit) - parseFloat(item.minVal)) / allS);
                                            else {
                                                lefts.push(lefts[lefts.length - 1]);
                                            }
                                            var reArr = [];
                                            var s = 0;
                                            var lastNum = 0;

                                            for(var sj = 0; sj < lefts.length;sj++){
                                                if(lefts[sj] > 1) lefts[sj] = 1;
                                                if(lefts[sj] > 0) {
                                                    reArr.push([lefts[sj],colors[s]]);
                                                }
                                                lastNum = lefts[sj];
                                                s++;
                                            }
                                            if(lastNum < 1) reArr.push([1,colors[4]]);
                                            return reArr;
                                        } else {

                                            // 左红有绿
                                            var lefts = [];
                                            if(item.funcareamonieval.poolUpperLimit  != undefined) lefts.push((parseFloat(item.funcareamonieval.poolUpperLimit) - parseFloat(item.minVal)) / allS);
                                            else {
                                                lefts.push(lefts[lefts.length - 1]);
                                            }

                                            if(item.funcareamonieval.commonUpperLimit  != undefined) lefts.push((parseFloat(item.funcareamonieval.commonUpperLimit) - parseFloat(item.minVal)) / allS);
                                            else {
                                                lefts.push(lefts[lefts.length - 1]);
                                            }

                                            if(item.funcareamonieval.goodUpperLimit  != undefined) lefts.push((parseFloat(item.funcareamonieval.goodUpperLimit) - parseFloat(item.minVal)) / allS);
                                            else {
                                                lefts.push(lefts[lefts.length - 1]);
                                            }

                                            if(item.funcareamonieval.excelUpperLimit  != undefined) lefts.push((parseFloat(item.funcareamonieval.excelUpperLimit) - parseFloat(item.minVal)) / allS);
                                            else {
                                                lefts.push(lefts[lefts.length - 1]);
                                            }
                                            var reArr = [];
                                            var s = 4;
                                            var lastNum = 0;
                                            for(var sj = 0; sj < lefts.length;sj++){
                                                if(lefts[sj] > 1) lefts[sj] = 1;
                                                if(lefts[sj] > 0) {
                                                    reArr.push([lefts[sj],colors[s]]);
                                                }
                                                lastNum = lefts[sj];
                                                s--;
                                            }
                                            if(lastNum < 1) reArr.push([1,colors[0]]);
                                            console.log(reArr);
                                            return reArr;
                                        }
                                    } else {
                                        return [
                                            [1, colors[5]]
                                        ];
                                    }
                                }()),
                                width: 8
                            }
                        },
                        axisTick: {
                            splitNumber: 10,
                            length: 16,
                            lineStyle: {
                                color:'auto',
                            }
                        },
                        detail: {
                            formatter: function (value) {
                                return "当前值："+(isNaN(value)?"":value)+"\n\n"+$li.data("title") + " 单位：" + (item.unit==undefined?"--":item.unit)
                            },
                            textStyle: {
                                color: '#fff',
                                fontSize: 18
                            },
                            offsetCenter: [0, '78%']
                        },
                        // data: [{ value: 22, name: '' }]
                        data: [{ value: (function(){
                            var prec = item.dispPrec == undefined ? 2 : item.dispPrec.length-2;
                            var dd= $li.attr("data-value");//parseFloat($li.attr("data-value")).toFixed(prec);
                            return dd;
                        }()), name: '' }]
                    }]
                };
                yibiaopan.domLI[index].setOption(option, true);
            });
        }
        setYBP();
        setTimeout(function(){
            $(".waterBox").css(unti.mTranslate(0, 0, 1, 1));
            hideLoad();
            $(".waterBox .zhuangtai").css("margin-left",$("div.content").width()/2 - $(".waterBox .zhuangtai").width());
        },700)
        Handler_acontent = setInterval(function(){
            setYBP();
            console.log("update data");
        },refesTime);
    } else {
        Handler_acontent = setInterval(function(){
            setYBP();
            console.log("update data");
        },refesTime);
    }
}