
var oTable;

$(function () {
    // 绑定日期
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

    // 初始化Table
    oTable = oTable || new TableInit();
    oTable.Init();
});

//=========================表格================================
var TableInit = function () {
    var oTableInit = new Object();
    //初始化Table
    oTableInit.Init = function () {
        $('#table').bootstrapTable({
            url: '/Api/System/GetSystemLogList',         //请求后台的URL（*）
            method: 'GET',                      //请求方式（*）
            exportDataType: "selected",              //basic', 'all', 'selected'.
            clickToSelect: true,  //是否启用点击选中行
            toolbar: '#toolbar',                //工具按钮用哪个容器
            striped: true,                      //是否显示行间隔色
            cache: false,                       //是否使用缓存，默认为true，所以一般情况下需要设置一下这个属性（*）
            pagination: true,                   //是否显示分页（*）
            sortable: false,                     //是否启用排序
            sortOrder: "asc",                   //排序方式
            queryParams: oTableInit.queryParams,//传递参数（*）
            //singleSelect: true,
            //queryParamsType: "json",
            contentType: "application/x-www-form-urlencoded",
            queryParamsType: "limit",
            sidePagination: "server", //分页方式：client客户端分页，server服务端分页（*）
            pageNumber: 1,                       //初始化加载第一页，默认第一页
            pageSize: 10,
            pageList: [10, 20, 30],        //可供选择的每页的行数（*）
            //search: true,                       //是否显示表格搜索，此搜索是客户端搜索，不会进服务端，所以，个人感觉意义不大
            strictSearch: true,
            showColumns: true,                  //是否显示所有的列
            showRefresh: true,                  //是否显示刷新按钮
            minimumCountColumns: 2,             //最少允许的列数
            height: $("#index").height(),                        //行高，如果没有设置height属性，表格自动根据记录条数觉得表格高度
            uniqueId: "LOG_ID",                     //每一行的唯一标识，一般为主键列
            //showToggle: true,                    //是否显示详细视图和列表视图的切换按钮
            cardView: false,                    //是否显示详细视图
            detailView: false,                   //是否显示父子表
            showFooter: false,
            columns: [
                 {
                     field: 'LOGNAME',
                     title: '日志名称',
                     align: "center",
                     width: "200px",
                     formatter: function (value, rec) {
                         return "<font style='width:200px;display:block;white-space:nowrap; overflow:hidden; text-overflow:ellipsis' title='" + rec.LOGNAME + "'>" + rec.LOGNAME + "</font>"
                     }
                 }, {
                     field: 'TYPE',
                     title: '日志类型',
                     align: "center",
                     width: "200px",
                     formatter: function (value, rec) {
                         return "<font style='width:200px;display:block;white-space:nowrap; overflow:hidden; text-overflow:ellipsis' title='" + rec.TYPE + "'>" + rec.TYPE + "</font>"
                     }
                 },
                 {
                     field: 'CONTENT',
                     title: '日志内容',
                     align: "center",
                     width: "200px",
                     formatter: function (value, rec) {
                         return "<font style='width:200px;display:block;white-space:nowrap; overflow:hidden; text-overflow:ellipsis' title='" + rec.CONTENT + "'>" + rec.CONTENT + "</font>"
                     }
                 },
                 {
                     field: 'REMARK',
                     title: '备注',
                     align: "center",
                     width: "200px",
                     formatter: function (value, rec) {
                         return "<font style='width:200px;display:block;white-space:nowrap; overflow:hidden; text-overflow:ellipsis' title='" + rec.REMARK + "'>" + rec.REMARK + "</font>"
                     }
                 },
                  {
                      field: 'DATETIME',
                      title: '创建时间',
                      align: "center",
                      formatter: function (value, rec) {
                          return rec.DATETIME.replace(/T/g, " ");
                      }
                  },
                //{
                //    field: 'EDIT',
                //    formatter: function (value, rec) {
                //        var HTML = new Array();
                //        HTML.push("<div class=\"\">");
                //        HTML.push("<button style=\"margin-right:10px\" type=\"button\"  class=\"btn btn-blue btn-sm\" onclick=\"verticalTab.addTab('View','查看','/UseUnit/ViewEmergencyPlan?ID=" + rec.ID + "',null,true)\">查看</button>");
                //        HTML.push("<button style=\"margin-right:10px\" type=\"button\"  class=\"btn btn-blue btn-sm\"  onclick=\"verticalTab.addTab('Edit','编辑','/UseUnit/EditEmergencyPlanm?ID=" + rec.ID + "&Url=" + escape(rec.FJLJ) + "',null,true)\">编辑</button>");
                //        HTML.push("<button type=\"button\" class=\"btn btn-blue btn-sm\" onclick=\"del_modal('" + rec.ID + "','" + escape(rec.FJLJ) + "')\">删除</button>");
                //        HTML.push("</div>");
                //        return HTML.join('');

                //    },
                //    title: '操作',
                //    align: "center"
                //}
            ],
            onLoadSuccess: function (data) {

            },
            onEditableSave: function (field, row, oldValue, $el) {

            },
            onCheck: function (row) {;

            },
            onCheckAll: function (rows) {

            },
            onUncheck: function (row) {

            },
            onUncheckAll: function (rows) {
            },
            onClickRow: function (item, $element) {

            }
        });
    };

    //得到查询的参数
    oTableInit.queryParams = function (params) {
        var pageNumber = (params.limit + params.offset) / params.limit;
        var temp = {   //这里的键的名字和控制器的变量名必须一直，这边改动，控制器也需要改成一样的
            pageNumber: pageNumber,  //页码
            pageSize: params.limit,   //页面大小
            logType: $('#logType option:selected').text() == "请选择" ? "" : $('#logType option:selected').text(),
            startDate: $('#startDate').val(),
            endDate: $('#endDate').val()
        };
        return temp;
    };
    return oTableInit;
}

// 查询系统日志列表
function Query() {
    $('#table').bootstrapTable("refreshOptions", { pageNumber: 1 });
}