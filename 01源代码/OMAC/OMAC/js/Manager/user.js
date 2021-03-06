﻿$(function () {
    initTable();
});

function initTable() {

    $("#table").bootstrapTable({
        striped: true,
        pagination: true,
        height: "500",
        sidePagination: "server",
        url: "/api/system/GetUserList",
        pageSize: 10,
        pageList: "[5, 10, 20, 50, 100, 200]",
        columns: [
            {
                field: "F_ACCOUNT",
                title: "",
                formatter: function(value) {
                    return "<image style=\"width: 32px;height: 32px;\" src=\"GetUserLogo?userAccount=" + value + "\" />";
                }
            },
            {
                field: "F_NAME",
                title: "用户名"
            },
            {
                field: "F_REALNAME",
                title: "真实姓名"
            },
            {
                field: "F_EMAIL",
                title: "邮箱"
            },
            {
                field: "F_TEL",
                title: "手机"
            },
            {
                field: "F_DESCRIPTION",
                title: "说明"
            },
            {
                field: "F_ADDRESS",
                title: "住址"
            },
            {
                field: "F_ACCOUNT",
                formatter: function(value) {
                    var html = [];
                    html.push("<div class=\"btn-group\">");
                    html.push("<a class=\"btn btn-info\" href=\"UserDetail?userId=" + value + "\" role=\"button\">查看</a>");
                    html.push("<a class=\"btn btn-warning\" href=\"UserEdit?userId=" + value + "\" role=\"button\">编辑</a>");
                    html.push("<a class=\"btn btn-danger\" href=\"javascript:deleteUser('" + value + "');\" role=\"button\">删除</a>");
                    html.push("</div>");
                    return html.join("");
                },
                title: "操作",
                align: "center"
            }
        ],
        onLoadSuccess: function() {

            var tableDatas = $("#table").bootstrapTable("getData");

            var href = tableDatas.length > 0
                ? "UserExportExcel?userName=" + $("input[name=\"user-name\"]").val() + "&order=asc&offset=0&limit=65500"
                : "javascript:bootbox.alert(\"无可导出数据,请尝试修改数据查询条件!\");";
            $("#btn-excel").attr("href", href);

            $("#btn-query").on("click", function() {
                GetData();
            });

        }
    });

}

function GetData() {
    $("#table").bootstrapTable("refreshOptions", {
        url: "/api/system/GetUserList?userName=" + $("input[name=\"user-name\"]").val()
    });
}

function deleteUser(userId) {
    bootbox.confirm("<p style=\"color:red;font-weight:bold;\">删除该用户后,<br/>1.此用户所拥有的所有功能将被删除;<br/>2.任何部门中将不会再出现此用户。<br/>您确定吗?</p>",
        function (isOk) {
            if (isOk) {
                $.getJSON("/api/system/DeleteUser",
                    {
                        "id": userId
                    },
                    function (rspData) {
                        if (rspData.status === true) {
                            GetData();
                        } else {
                            bootbox.alert("操作失败!");
                        }
                    });
            }
        });
}