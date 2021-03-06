﻿$(function () {
    $("#haiqu").val(GetQueryString("haiqu") == null ? "全部" : GetQueryString("haiqu"));
    $("#shengfen").val(GetQueryString("shengfen") == null ? "全部" : GetQueryString("shengfen"));
    $("#haiwan").val(GetQueryString("haiwan") == null ? "全部" : GetQueryString("haiwan"));
    $("#jushusheshi").val(GetQueryString("jushusheshi") == null ? "全部" : GetQueryString("jushusheshi"));
    $("#difangsheshi").val(GetQueryString("difangsheshi") == null ? "全部" : GetQueryString("difangsheshi"));
    $("#yewu").val(GetQueryString("yewu") == null ? "全部" : GetQueryString("yewu"));
    setTimeout("$('#search_btn2').click()", 3);
});

function getData() {
    var bianhao, haiqu, shengfen, haiwan, jushusheshi, difangsheshi, yewu;
    if ($("#bianhao").val()) {
        bianhao = $("#bianhao").val();
    } else {
        bianhao = "";
    }
    haiqu = encodeURI($("#haiqu").val(), "UTF-8");
    shengfen = encodeURI($("#shengfen").val(), "UTF-8");
    haiwan = encodeURI($("#haiwan").val(), "UTF-8");
    jushusheshi = encodeURI($("#jushusheshi").val(), "UTF-8");
    difangsheshi = encodeURI($("#difangsheshi").val(), "UTF-8");
    yewu = encodeURI($("#yewu").val(), "UTF-8");
    var dType = GetQueryString("type");
    $.ajax({
        type: "POST",
        dataType: "JSON",
        url: "/Api/System/GetDeviceInfoList?bianhao=" + bianhao + "&haiqu=" + haiqu + "&shengfen=" + shengfen + "&haiwan=" + haiwan + "&jushusheshi=" + jushusheshi + "&difangsheshi=" + difangsheshi + "&yewu=" + yewu + "&dType=" + dType,
        success: function (result) {
            //  var data = JSON.parse(result.aaData);
            var data = result.aaData
            settable(data);
        }
    });
}


function searchBtnClick() {
    var bianhao, haiqu, shengfen, haiwan, jushusheshi, difangsheshi, yewu;
    if ($("#bianhao").val()) {
        bianhao = $("#bianhao").val();
    } else {
        bianhao = "";
    }

    haiqu = encodeURI($("#haiqu").val(), "UTF-8");
    shengfen = encodeURI($("#shengfen").val(), "UTF-8");
    haiwan = encodeURI($("#haiwan").val(), "UTF-8");
    jushusheshi = encodeURI($("#jushusheshi").val(), "UTF-8");
    difangsheshi = encodeURI($("#difangsheshi").val(), "UTF-8");
    yewu = encodeURI($("#yewu").val(), "UTF-8");
    var dType = GetQueryString("type");
    $.ajax({
        type: "POST",
        dataType: "JSON",
        url: "/Api/System/GetDeviceInfoList?bianhao=" + bianhao + "&haiqu=" + haiqu + "&shengfen=" + shengfen + "&haiwan=" + haiwan + "&jushusheshi=" + jushusheshi + "&difangsheshi=" + difangsheshi + "&yewu=" + yewu + "&dType=" + dType,
        success: function (result) {
            var data = result.aaData
            if (!data) {
                data = [];
            }
            $('#mytab').bootstrapTable('load', data);

        }
    });

}


function settable(data) {
    $('#mytab').bootstrapTable({
        // url: "/Api/System/GetDeviceInfoList?bianhao=" + bianhao + "&haiqu=" + haiqu + "&shengfen=" + shengfen + "&haiwan=" + haiwan + "&jushusheshi=" + jushusheshi + "&difangsheshi=" + difangsheshi + "&yewu=" + yewu,//数据源
        data: data,
        dataField: "rows",//服务端返回数据键值 就是说记录放的键值是rows，分页时使用总记录数的键值为total
        height: $("#index").height(), //tableHeight(),//高度调整
        // search: true,//是否搜索
        pagination: true,//是否分页
        pageSize: 10,//单页记录数
        pageList: [2, 10, 15],//分页步进值
        //sidePagination: "server",//服务端分页
        contentType: "application/x-www-form-urlencoded",//请求数据内容格式 默认是 application/json 自己根据格式自行服务端处理
        dataType: "json",//期待返回数据类型
        method: "post",//请求方式
        //searchAlign: "left",//查询框对齐方式
        queryParamsType: "limit",//查询参数组织方式
        queryParams: function getParams(params) {
            //params obj
            params.other = "otherInfo";
            return params;
        },
        //searchOnEnterKey: false,//回车搜索
        showRefresh: true,//刷新按钮
        showColumns: true,//列选择按钮
        //buttonsAlign: "left",//按钮对齐方式
        //toolbar: "#toolbar",//指定工具栏
        //toolbarAlign: "right",//工具栏对齐方式
        columns: [
        {
            title: "编号",//编号
            field: "DEVICECODE",//键名
            //sortable: true,//是否可排序
            //order: "desc",//默认排序方式
            align: "center"
        },
        {
            title: "设备名",//设备名
            field: "DEVICENAME",//键名
            //sortable: false,//是否可排序
            //order: "desc",//默认排序方式
            align: "center"
        },
        {
            title: "设备类型",//设备类型
            field: "DEVICETYPE",//键名
            //sortable: false,//是否可排序
            //order: "desc",//默认排序方式
            align: "center"
        },
        {
            title: "布放时间",//布放时间
            field: "LAYTIME",//键名
            //sortable: false,//是否可排序
            //order: "desc",//默认排序方式
            align: "center"
        },
        {
            title: "布放经度",//布放经度
            field: "ELON",//键名
            //sortable: false,//是否可排序
            //order: "desc",//默认排序方式
            align: "center"
        },
        {
            title: "布放纬度",//布放纬度
            field: "ELAT",//键名
            //sortable: false,//是否可排序
            //order: "desc",//默认排序方式
            align: "center"
        },
        {
            title: "生产商",//生产商
            field: "PRODUCER",//键名
            //sortable: false,//是否可排序
            //order: "desc",//默认排序方式
            align: "center"
        },
        {
            title: "维护商",//维护商
            field: "MANAGER",//键名
            //sortable: false,//是否可排序
            //order: "desc",//默认排序方式
            align: "center"
        },
        {
            title: "操作",//操作
            field: "DEVICECODE",//键名
            formatter: operateFormatter,
            align: "center"
        }
        ],
        //onClickRow: function (row, $element) {
        //    //$element是当前tr的jquery对象
        //    $element.css("background-color", "green");
        //},//单击row事件
        locale: "zh-CN"//中文支持,
    });
}

function operateFormatter(value, row, index)
    //row 获取这行的值 ，index 获取索引值
{
    var PySheDingID = row.DEVICECODE;
    // 利用 row 获取点击这行的ID
    var dType = row.DEVICETYPE;
    var dClass = GetQueryString("class");
    switch (dClass) {
        case "1":
            return [
                "<button type='button' class='blueBtnSmall'  onclick='btnEntry(" + row.DEVICECODE.toString() + "," + dType + ")'  >实时数据</button><button type='button' class='blueBtnSmall' onclick='btnlssj(" + row.DEVICECODE + ")'  >历史数据</button>"
            ].join('');
        case "2":
            return [
                "<button type='button' class='blueBtnSmall' onclick='btnAddTab(\"" + row.DEVICECODE + "\",\"" + row.DEVICENAME + "\",\"环境评价\"," + dType + ")' >环境评价</button>"
            ].join('');
        case "3":
            return [
                "<button type='button' class='blueBtnSmall' onclick='ParentAlertNotification()' >监控视频</button>"
            ].join('');
        case "4":
            return [
                "<button type='button' class='blueBtnSmall' onclick='ParentAlertNotification()' >三维地图</button>"
            ].join('');
        case "5":
            return [
                "<button type='button' class='blueBtnSmall' onclick='ParentAlertNotification()' >工作流程</button>"
            ].join('');
        default:
            return "";
    }


}
// 实时数据
function btnEntry(id, dtype) {
    id = PrefixInteger(id, 6);
    if (2 == dtype) {
        if ($("#shishiIframe2", window.parent.document).length > 0) {
            parent.setShishiData(id, dtype, false);
        } else {
            parent.setShishiData(id, dtype, true);
        }
    } else {
        if ($("#shishiIframe1", window.parent.document).length > 0) {
            parent.setShishiData(id, dtype, false);
        } else {
            parent.setShishiData(id, dtype, true);
        }
    }

    // window.open("BuoyDetail?id="+id);
}
// 历史数据
function btnlssj(id) {
    id = PrefixInteger(id, 6);
    parent.setHistoryData(id);
    // window.open("../MonitorLog?devicecode=" + id);
}

function btnAddTab(id, name, text, dtype) {
    var href;
    if (dtype == "1") {
        href = "Manager/AnJiZhanAnalysis?deviceCode=" + id + "&deviceName=" + name + "&type=" + dtype;
        if ($("#AnJiZhanAnalysisIframe2", window.parent.document).length > 0) {
            parent.setAnalysisData(id, dtype, false, href);
        } else {
            parent.setAnalysisData(id, dtype, true, href);
        }
       
    } else {
        href = "Manager/FuBiaoAnalysis?deviceCode=" + id + "&deviceName=" + name + "&type=" + dtype;
        if ($("#FuBiaoAnalysisIframe1", window.parent.document).length > 0) {
            parent.setAnalysisData(id, dtype, false, href);
        } else {
            parent.setAnalysisData(id, dtype, true, href);
        }
    }
}

function ParentAlertNotification() {
    parent.bootbox.alert({ buttons: { ok: { label: '关闭', className: 'btn btn-blue button_btn' } }, message: "<h4 style='text-align:center'>此功能正在开发中！</h4>" });
}



