var xData;
var totalData;
var normalData;
var ph1 = [];
var ph2 = [];
var lastData;
var twoData;
var legendData = [];
var year; // 得到年
var myChart;
var chartOption;

$(function () {
    $("#startDate").datepicker({
        language: 'zh-CN',
        format: "yyyy-mm-dd",      //格式化日期
        //weekStart: 1,
        todayBtn: "linked",
        autoclose: true,  // 当选择一个日期之后是否立即关闭此日期时间选择器。
        clearBtn: true,   // 清除按钮
    }).on('click', function () {
        $("#startDate").datepicker("setEndDate", $("#endDate").val())
    });

    $("#endDate").datepicker({
        language: 'zh-CN',
        format: "yyyy-mm-dd",      //格式化日期
        //weekStart: 1,
        todayBtn: "linked",
        autoclose: true,
        clearBtn: true,   // 清除按钮
    }).on('click', function () {
        $("#endDate").datepicker("setStartDate", $("#startDate").val())
    });

    // 绑定监测要素下拉框
    $.ajax({
        type: "POST",
        dataType: "json",
        url: "/Api/System/GetElementsList",
        success: function (result) {
            if (result != null) {
                var html = new Array();
                html.push("<option value=''>请选择</option>");

                $.each(result, function (e, v) {
                    //var selectHtml = "";
                    html.push("<option value=\"" + v.BEIZHU + "\">" + v.CONTENT + "</option>");
                });

                $("#street").html(html.join(''));
            }
        },
        error: function (data) {

        }
    });

    DaBiaoLv(); // 默认展示达标率图表
    $("#flag").val("dabiao");
});

// 绑定达标率图表
function DaBiaoLv() {
    initChart();
    $.getJSON(
        "/Api/System/GetDabiaolv",
        {
            "devicecode": $('#deviceCode').val(),
            "jcys": $("#street").val(),
            "beginDate": $("#startDate").val(),
            "endDate": $("#endDate").val()
        },
        function (rspData) {
            if (rspData != null && rspData[0].DABIAOLV === -100) {
                $("#main").html("<h1>暂无评价标准！</h1>");
                return;
            }
            var sdateArr = [], dblArr = [];
            $.each(rspData, function (index, value) {
                sdateArr.push(value.SDATE);
                dblArr.push(value.DABIAOLV);
            });

            chartOption.xAxis.data = sdateArr;
            chartOption.series[0].data = dblArr;
            myChart.setOption(chartOption);
        });
}
function initChart() {
    myChart = echarts.init(document.getElementById("main"));

    chartOption = {
        title: {
            text: "达标率"
        },
        tooltip: {
            trigger: "axis"
        },
        legend: {
            data: ["达标率"]
        },
        toolbox: {
            feature: {
                restore: { title: "还原", show: true }, // 刷新
                saveAsImage: { title: "保存图片", show: true } // 保存图片（IE8-不支持）
            }
        },
        grid: {
            left: '3%',
            right: '4%',
            //bottom: '3%',
            containLabel: true,
        },
        xAxis: {
            data: [],
            axisTick: {
                alignWithLabel: true
            }
        },
        yAxis: {},
        series: [{
            name: "达标率",
            type: "bar",
            smooth: true,//平滑曲线显示
            legendHoverLink: true,//是否启用图例（legend）hover时的联动响应（高亮显示
            label: {
                normal: {
                    show: true,
                    position: "top"
                }
            },
            itemStyle: {
                normal: { label: { show: true }, color: "#fdd168" },// for legend  
                emphasis: { label: { show: true } }
            },
            data: []
        }]
    };

    myChart.setOption(chartOption);
}

// 基于准备好的dom，初始化echarts实例
var myQushiChart = echarts.init(document.getElementById('QuShiFenXi'));
// 趋势分析：根据下拉选择条件更新图表
function QuShi() {
    $.ajax({
        url: "/Api/System/GetQuShiFenXi",
        type: 'get',
        dataType: "json",
        data: { "deviceCode": $('#deviceCode').val(), "strId": $('#street option:selected').val(), "startDate": $('#startDate').val(), "endDate": $('#endDate').val(), "deviceType": $("#deviceType").val() },
        async: false,
        success: function (data) {
            var dtList = eval(data);

            myQushiChart.clear();// 清空表数据 
            xData = [];
            totalData = [];
            normalData = [];
            legendData = [];

            if (dtList != null && dtList.length != 0) {
                xData = dtList.map(function (data) { return data.DATETIME.replace(/T/g, " ") })
                //totalData = dtList.map(function (data) { return data.COUNT ? data.COUNT : 0 })
                totalData = dtList.map(function (data) { return data.KEY ? data.KEY : 0 });
                legendData.push($("#street option:selected").text());
            }

            // 绑定趋势分析数据
            BindQuShiOption();
            var option = myQushiChart.getOption();
            //option.title[0].text = $("#street option:checked").text() + '电梯年增长趋势';
            option.legend[0].data = legendData;
            option.xAxis[0].data = xData;
            option.series[0].data = totalData;

            // PH存在2条标准线
            if (dtList !== null && dtList.length != 0) {
                var dd = [];
                var normalData = dtList.map(function (data) {
                    return data.STD_VALUE;
                });

                // 去掉null元素
                for (var i = 0 ; i < normalData.length; i++) {
                    if (normalData[i] == "" || normalData[i] == null || typeof (normalData[i]) == "undefined") {
                        normalData.splice(i, 1);
                    }
                }

                // 是否显示标准线
                if (normalData.length == dtList.length) {
                    if ($('#street option:selected').val() == "PH") {
                        ph1 = [], ph2 = [];
                        for (var i = 0; i < normalData.length; i++) {
                            ph1.push(normalData[i].split(',')[0]);
                            ph2.push(normalData[i].split(',')[1]);
                        }

                        var item = {
                            name: "标准线",
                            type: 'line',
                            data: ph1,
                            smooth: true,//平滑曲线显示
                            legendHoverLink: true,//是否启用图例（legend）hover时的联动响应（高亮显示
                            label: {
                                normal: {
                                    show: true,
                                    position: 'top'
                                }
                            },
                            itemStyle: {
                                normal: { label: { show: true }, color: '#49d276' },// for legend  
                                emphasis: { label: { show: true } }
                            },
                        }
                        option.series.push(item);
                        //option.series[1].data = ph1;

                        var item2 = {
                            name: "标准线",
                            type: 'line',
                            data: ph2,
                            smooth: true,//平滑曲线显示
                            legendHoverLink: true,//是否启用图例（legend）hover时的联动响应（高亮显示
                            label: {
                                normal: {
                                    show: true,
                                    position: 'top'
                                }
                            },
                            itemStyle: {
                                normal: { label: { show: true }, color: '#49d276' },// for legend  
                                emphasis: { label: { show: true } }
                            },
                        }

                        option.series.push(item2);
                        legendData.push("标准线");
                    }
                    else {
                        // 水温的标准线不显示
                        if ($('#street option:selected').val() != "WATERTEM") {
                            var item = {
                                name: "标准线",
                                type: 'line',
                                data: normalData,
                                smooth: true,//平滑曲线显示
                                legendHoverLink: true,//是否启用图例（legend）hover时的联动响应（高亮显示
                                label: {
                                    normal: {
                                        show: true,
                                        position: 'top'
                                    }
                                },
                                itemStyle: {
                                    normal: { label: { show: true }, color: '#49d276' },// for legend  
                                    emphasis: { label: { show: true } }
                                },
                            }

                            option.series.push(item);
                            legendData.push("标准线");
                        }
                    }
                }

                // 无机氮线（氨氮(铵盐)、硝酸盐-氮、亚硝酸盐-氮总和）
                if ($('#street option:selected').val() == "NH3N" || $('#street option:selected').val() == "NO3" || $('#street option:selected').val() == "NO2") {
                    var nh = dtList.map(function (data) { return data.WUJIDAN ? data.WUJIDAN : 0 });
                    var item = {
                        name: "无机氮",
                        type: 'line',
                        data: nh,
                        smooth: true,//平滑曲线显示
                        legendHoverLink: true,//是否启用图例（legend）hover时的联动响应（高亮显示
                        label: {
                            normal: {
                                show: true,
                                position: 'top'
                            }
                        },
                        itemStyle: {
                            normal: { label: { show: true }, color: '#8fc2f7' },// for legend  
                            emphasis: { label: { show: true } }
                        },
                    }

                    option.series.push(item);
                    legendData.push("无机氮");
                }

            }

            myQushiChart.setOption(option);
        }
    });
}
function BindQuShiOption() {
    // 指定图表的配置项和数据
    option = {
        noDataLoadingOption: {
            effect: 'whirling',
            text: '暂无数据',
            textStyle: {
                fontSize: 20
            }
        },
        title: {
            text: '趋势分析',
            // subtext: '纯属虚构',
            //x: 'left'
        },
        tooltip: {
            trigger: 'axis'
        },
        toolbox: {
            feature: {
                //dataView: { show: true, readOnly: false },  // 数据视图
                //magicType: { show: true, type: ['line', 'bar'] }, // 视图切换（折线图、柱状图）
                restore: { title: '还原', show: true }, // 刷新
                saveAsImage: { title: '保存图片', show: true } // 保存图片（IE8-不支持）
            }
        },
        grid: {
            left: '3%',
            right: '4%',
            //bottom: '3%',
            containLabel: true,
        },
        legend: {
            data: legendData,
            left: "65%"
        },
        xAxis: [
            {
                type: 'category',
                boundaryGap: false,
                data: xData,
                axisTick: {
                    alignWithLabel: true
                },
                //axisLabel: {
                //    interval: 0, // 横轴信息全部显示
                //    rotate: 60, // 60度角倾斜显示
                //    margin: 2,
                //    //formatter: function (val) {
                //    //    return val.split("").join("\n");
                //    //} // 横轴信息文字竖直显示
                //}
            }
        ],
        yAxis: [
            {
                type: 'value',
                name: '要素值',
                //min: 0,
                //max: 10,
                //interval: 1,
                //axisLabel: {
                //    formatter: '{value} %'
                //}
            }
        ],
        series: [
            {
                name: $("#street option:selected").text() != "请选择" ? $("#street option:selected").text() : "-",
                smooth: true, // 折线图的折线平滑显示
                type: 'line',
                label: {
                    normal: {
                        show: true,
                        position: 'top'
                    }
                },
                itemStyle: {
                    normal: { label: { show: true }, color: '#fdd168' },// for legend  
                    emphasis: { label: { show: true } }
                },
                data: totalData
            },
        ]
    };

    // 使用刚指定的配置项和数据显示图表。
    myQushiChart.setOption(option);
}

// 基于准备好的dom，初始化echarts实例
var myTongBiChart = echarts.init(document.getElementById('TongBuFenXi'));
// 同步分析：根据下拉选择条件更新图表
function TongBi() {
    //var startDate = new Date($('#startDate').val());
    //var endDate = new Date($('#endDate').val());
    //var date = endDate.getTime() - startDate.getTime()  //时间差的毫秒数
    ////计算出相差天数
    //var days = Math.floor(date / (24 * 3600 * 1000))

    year = $('#startDate').val().substring(0, 4);

    if ($('#startDate').val().substring(0, 4) != $('#endDate').val().substring(0, 4)) {
        bootbox.confirm("时间段不能跨年，请重新选择！", function (result) {
        });
        return;
    }

    $.ajax({
        url: "/Api/System/GetTongBuFenXi",
        type: 'get',
        dataType: "json",
        data: { "deviceCode": $('#deviceCode').val(), "strId": $('#street option:selected').val(), "startDate": $('#startDate').val(), "endDate": $('#endDate').val(), "deviceType": $("#deviceType").val() },
        async: false,
        success: function (data) {
            var dtList = eval(data);

            myTongBiChart.clear();// 清空表数据
            xData = [];
            totalData = [];
            lastData = [];
            twoData = [];
            legendData = [];

            if (dtList != null && dtList.length != 0) {
                xData = dtList.map(function (data) { return data.DATETIME.replace(/T/g, " ") })
                //totalData = dtList.map(function (data) { return data.COUNT ? data.COUNT : 0 })
                totalData = dtList.map(function (data) { return data.KEY ? data.KEY : 0 })
                lastData = dtList.map(function (data) { return data.KEY2 ? data.KEY2 : 0 })
                twoData = dtList.map(function (data) { return data.KEY3 ? data.KEY3 : 0 })

                // 绑定图例信息
                legendData.push(year + '年');
                legendData.push((year - 1) + '年');
                legendData.push((year - 2) + '年');
            }

            BindTongBuOption();
            var option = myTongBiChart.getOption();
            //option.title[0].text = $("#street option:checked").text() + '电梯年增长趋势';
            option.legend[0].data = legendData;
            option.xAxis[0].data = xData;
            option.series[0].data = totalData;
            option.series[1].data = lastData;
            option.series[2].data = twoData;

            myTongBiChart.setOption(option);

        }
    });
}
function BindTongBuOption() {
    // 指定图表的配置项和数据
    option = {
        title: {
            text: '同步分析',
            // subtext: '纯属虚构',
            //x: 'left'
        },
        tooltip: {
            trigger: 'axis'
        },
        //右上角工具条
        toolbox: {
            feature: {
                //dataView: { show: true, readOnly: false },  // 数据视图
                //magicType: { show: true, type: ['line', 'bar'] }, // 视图切换（折线图、柱状图）
                restore: { title: '还原', show: true }, // 刷新
                saveAsImage: { title: '保存图片', show: true } // 保存图片（IE8-不支持）
            }
        },
        grid: {
            left: '3%',
            right: '4%',
            //bottom: '3%',
            containLabel: true
        },
        legend: {
            //data: ['2017年' + $("#street option:selected").text(), '2016年' + $("#street option:selected").text(), '2015年' + $("#street option:selected").text()],
            data: legendData,
            left: "65%",
            padding: 5,
        },
        xAxis: [
            {
                type: 'category',
                boundaryGap: false,
                data: xData,
                axisTick: {
                    alignWithLabel: true
                }

            }
        ],
        yAxis: [
            {
                type: 'value',
                name: '要素值',
                //min: 0,
                //max: 10,
                //interval: 1,
                //axisLabel: {
                //    formatter: '{value} %'
                //}
            }
        ],
        series: [
            {
                name: year != 0 ? year + '年' : "-",
                smooth: true,
                type: 'line',
                label: {
                    normal: {
                        show: true,
                        position: 'top'
                    }
                },
                itemStyle: {
                    normal: { label: { show: true }, color: '#fdd168' },// for legend  
                    emphasis: { label: { show: true } }
                },
                data: totalData
            },
            {
                name: year != 0 ? (year - 1) + '年' : "-",
                smooth: true, // 折线图的折线平滑显示
                type: 'line',
                label: {
                    normal: {
                        show: true,
                        position: 'top'
                    }
                },
                itemStyle: {
                    normal: { label: { show: true }, color: '#49d276' },// for legend  
                    emphasis: { label: { show: true } }
                },
                data: lastData
            },
            {
                name: year != 0 ? (year - 2) + '年' : "-",
                smooth: true, // 折线图的折线平滑显示
                type: 'line',
                label: {
                    normal: {
                        show: true,
                        position: 'top'
                    }
                },
                itemStyle: {
                    normal: { label: { show: true }, color: '#8fc2f7' },// for legend  
                    emphasis: { label: { show: true } }
                },
                data: twoData
            }
        ]
    };

    // 使用刚指定的配置项和数据显示图表。
    myTongBiChart.setOption(option);
}

// 选择达标率
$('#myTab a[href="#dabiaolv"]').on('shown.bs.tab', function (e) {
    DaBiaoLv();
    $("#flag").val("dabiao");
});
// 选择趋势分析
$('#myTab a[href="#qushi"]').on('shown.bs.tab', function (e) {
    QuShi();
    $("#flag").val("qushi");
});
// 选择同比分析
$('#myTab a[href="#tongbi"]').on('shown.bs.tab', function (e) {
    TongBi();
    $("#flag").val("tongbi");
});

// 查询方法
function query() {
    var flag = $("#flag").val();

    if (flag == "dabiao") {
        DaBiaoLv();
    }
    else if (flag == "qushi") {
        QuShi();
    }
    else if (flag == "tongbi") {
        TongBi();
    }
}