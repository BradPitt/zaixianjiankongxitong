// 查询的表名
var monitorType = "";

$(function () {
    var defaultDevicecode = QueryString.devicecode;
    monitorType = QueryString.monitorType;

    // 绑定浮标号下拉框
    $.getJSON(
        "/api/monitorlog/GetDeviceListByType",
        { "deviceType": 2 },
        function (data) {
            var items = [];
            $.each(data, function (key, val) {
                items.push("<option value='" + val.DEVICECODE + "'>" + val.DEVICENAME + "</option>");
            });

            $("select[name=\"devicecode\"]").html(items.join(""));
            $("select[name=\"devicecode\"]").val(defaultDevicecode);

            InitData();

            $("select[name=\"devicecode\"]").on("change", function () {
                GetData();
            });

        });

    // 初始化 datetime range picker 控件
    $("input[name=\"daterange\"]").daterangepicker(
        {
            "timePicker": true,
            "timePicker24Hour": true,
            "timePickerSeconds": true,
            "locale": {
                "format": "YYYY-MM-DD HH:mm:ss",
                "separator": " - ",
                "applyLabel": "确定",
                "cancelLabel": "取消",
                "fromLabel": "From",
                "toLabel": "To",
                "customRangeLabel": "Custom",
                "weekLabel": "W",
                "daysOfWeek": ["日", "一", "二", "三", "四", "五", "六"],
                "monthNames": ["一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"],
                "firstDay": 1
            },
            startDate: new Date().addDays(-10),
            endDate: new Date()
        },
        function (start, end, label) {
            $("input[name=\"beginTime\"]").val(start.format("YYYY-MM-DD HH:mm:ss"));
            $("input[name=\"endTime\"]").val(end.format("YYYY-MM-DD HH:mm:ss"));
        }
    );

    $("#btn-query").on("click", function () {
        GetData();
    });

    $("#btn-mtp>button").on("click", function () {
        var mtp = $(this).data("mtp");
        window.location.href = "index?devicecode=" + $("select[name=\"devicecode\"]").val() + "&monitorType=" + mtp;
    });

});

function InitData() {
    var beginTime = $("input[name=\"daterange\"]").data('daterangepicker').startDate.format('YYYY-MM-DD HH:mm:ss');
    var endTime = $("input[name=\"daterange\"]").data('daterangepicker').endDate.format('YYYY-MM-DD HH:mm:ss');
    var tableDataUrl = "/api/monitorlog/GetList?tableName=" + monitorType + "&devicecode=" + $("select[name=\"devicecode\"]").val() + "&beginTime=" + beginTime + "&endTime=" + endTime;

    $("#table").bootstrapTable({
        pagination: true,
        height: "600",
        sidePagination: "server",
        url: tableDataUrl,
        pageSize: 2,
        pageList: "[2, 10, 20, 50, 100, 200]",
        columns: DataColumns[monitorType]

    });
}

function GetData() {
    var beginTime = $("input[name=\"daterange\"]").data('daterangepicker').startDate.format('YYYY-MM-DD HH:mm:ss');
    var endTime = $("input[name=\"daterange\"]").data('daterangepicker').endDate.format('YYYY-MM-DD HH:mm:ss');
    var tableDataUrl = "/api/monitorlog/GetList?tableName=" + monitorType + "&devicecode=" + $("select[name=\"devicecode\"]").val() + "&beginTime=" + beginTime + "&endTime=" + endTime;

    $("#table").bootstrapTable("refreshOptions", {
        url: tableDataUrl
    });
}











var DataColumns = function () {
    var rst = {
        "TABBUOYECOLOGY": [
            {
                field: "DATETIME",
                title: "日期时间"
            }, {
                field: "CURRENTTEM",
                title: "海浪水温"
            }, {
                field: "WATERTEM",
                title: "独立水温"
            }
        ]
    };

    return rst;
}();

var QueryString = function () {
    // This function is anonymous, is executed immediately and 
    // the return value is assigned to QueryString!
    var query_string = {};
    var query = window.location.search.substring(1);
    var vars = query.split("&");
    for (var i = 0; i < vars.length; i++) {
        var pair = vars[i].split("=");
        // If first entry with this name
        if (typeof query_string[pair[0]] === "undefined") {
            query_string[pair[0]] = decodeURIComponent(pair[1]);
            // If second entry with this name
        } else if (typeof query_string[pair[0]] === "string") {
            var arr = [query_string[pair[0]], decodeURIComponent(pair[1])];
            query_string[pair[0]] = arr;
            // If third or later entry with this name
        } else {
            query_string[pair[0]].push(decodeURIComponent(pair[1]));
        }
    }
    return query_string;
}();

Date.prototype.addDays = function (days) {
    var dat = new Date(this.valueOf());
    dat.setDate(dat.getDate() + days);
    return dat;
}